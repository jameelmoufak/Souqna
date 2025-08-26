using Souqna.Data.ViewModels;
using Souqna.Models;
using Souqna.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Souqna.Data.Services
{
    public interface IOrdersRepository
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId);// تقوم بتخزين الطلبية في قاعدة البيانات
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);// تقوم بجلب الطلبات بناءً على معرف المستخدم والدور (Admin أو User) من قاعدة البيانات
        bool CheckAccept(List<ShoppingCartItem> items, string userId);// تقوم بالتحقق من أن الكمية المتوفرة من المنتج تكفي للطلبية وأن المستخدم لديه رصيد كافي



        // تقوم بمعالجة عملية الدفع والتحقق من الطلبية، وتحديث الرصيد والكمية المتوفرة من المنتج في قاعدة البيانات، ثم تخزين الطلبية في قاعدة البيانات

        // تقوم بمعالجة عملية الدفع والتحقق من الطلبية، وتحديث الرصيد والكمية المتوفرة من المنتج في قاعدة البيانات، ثم تخزين الطلبية في قاعدة البيانات
        Task<ServiceResponse<Order>> CheckoutAsync(CheckoutVM model, string userId);



        // 👇 إضافات للإدارة
        Task<Order?> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid orderId);

        void Delete(Order order);
    }
}
