using Souqna.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Souqna.Data.ViewModels;
using Souqna.Services;
using Souqna.Services.Payments;

namespace Souqna.Data.Services
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly PaymentFactory _paymentFactory;
        public OrdersRepository(ApplicationDbContext context, PaymentFactory paymentFactory)
        {
            _context = context;
            _paymentFactory = paymentFactory;
        }

        public bool CheckAccept(List<ShoppingCartItem> items, string userId) //للتحقق من ان الكمية المتوفرة من المنتج تكفي للطلبية وأن المستخدم لديه رصيد كافي
        {
            var user = _context.Users.FirstOrDefault(n => n.Id == userId);
            var totalCost = items.Sum(n => n.Product.PriceOfUnit * n.Amount);
            var products = _context.Products.Where(n => items.Select(i => i.Product.ProductId).Equals(n.ProductId)).ToList();
            if (user == null || user.Balance < totalCost)
            {
                return false;
            }
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i];
                if (product == null || product.StockQuantity < items[i].Amount || product.IsAvailable == false)
                {
                    return false; // If any product is not available or insufficient stock, return false
                }
            }
            user.Balance -= totalCost; // Deduct the total cost from user's balance
            _context.Users.Update(user); // Update the user's balance in the database
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i];
                if (product != null)
                {
                    product.StockQuantity -= items[i].Amount; // Deduct the ordered amount from the product's stock
                    if(product.StockQuantity == 0)
                    {
                        product.IsAvailable = false; // If stock reaches zero, mark the product as unavailable
                    }
                    _context.Products.Update(product); // Update the product's stock in the database
                }
            }
            _context.SaveChanges(); // Save all changes to the database
            return true; // All products are available and user has sufficient balance
        }

        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.product).Include(n => n.User).ToListAsync();

            if(userRole != "Admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }

            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId)
        {
            var order = new Order()
            {
                UserId = userId,
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ProductId = item.Product.ProductId,
                    OrderId = order.OrderId,
                    Cost = item.Product.PriceOfUnit * item.Amount
                };
                // Update the product's stock
                var product = await _context.Products.FindAsync(item.Product.ProductId);
                if (product != null)
                {
                    product.StockQuantity -= item.Amount;
                    _context.Products.Update(product);
                }
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<ServiceResponse<Order>> CheckoutAsync(CheckoutVM model, string userId)
        {
            // التحقق من صحة المدخلات
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);// الحصول على المستخدم بناءً على userId
            if (user == null) return ServiceResponse<Order>.Fail("❌ المستخدم غير موجود");

            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == model.ProductId);// الحصول على المنتج بناءً على ProductId من النموذج
            if (product == null) return ServiceResponse<Order>.Fail("❌ المنتج غير موجود");

            if (product.StockQuantity < model.Quantity)// التحقق من الكمية المتوفرة في المخزون
                return ServiceResponse<Order>.Fail("❌ الكمية غير متوفرة");

            var totalCost = product.PriceOfUnit * model.Quantity;// حساب التكلفة الإجمالية للطلب

            var paymentService = _paymentFactory.GetPaymentService(model.PaymentMethod);
            var paymentResult = await paymentService.ProcessPaymentAsync(userId, totalCost);

            if (!paymentResult.IsSuccess)
                return ServiceResponse<Order>.Fail(paymentResult.Message);


            product.StockQuantity -= model.Quantity;// تحديث الكمية المتوفرة من المنتج في المخزون
            if (product.StockQuantity == 0)
                product.IsAvailable = false;

            var order = new Order// إنشاء طلب جديد
            {
                UserId = userId,
                TotalCost = totalCost,
                OrderedAt = DateTime.UtcNow,
                OrderItems = new List<OrderItem>
        {
            new OrderItem// إنشاء عنصر طلب جديد
            {
                ProductId = product.ProductId,
                Amount = model.Quantity,
                Cost = totalCost
            }
        }
            };
            // إضافة الطلب إلى قاعدة البيانات
            _context.Orders.Add(order);
            _context.Users.Update(user);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return ServiceResponse<Order>.Success(order, "✅ تم إتمام عملية الشراء بنجاح");
        }

        // 👇 إضافات للإدارة
        //ادارة الطلبات
        public async Task<Order?> GetByIdAsync(Guid id)// جلب طلب حسب المعرف
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(o => o.OrderId == id);
        }

        public async Task DeleteAsync(Guid orderId)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            if (order != null)
            {
                // نحذف العناصر التابعة للطلب أولاً
                _context.OrderItems.RemoveRange(order.OrderItems);

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public void Delete(Order order)// حذف الطلب من قاعدة البيانات
        {
            _context.Orders.Remove(order);
        }


    }
}
