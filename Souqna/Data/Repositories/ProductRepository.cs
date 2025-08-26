using Microsoft.EntityFrameworkCore;
using Souqna.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Souqna.Data.Enums.ProductEnums;// استيراد الفئات من Enums

namespace Souqna.Data.Repositories
{
    public class ProductRepository : IProductRepository// تنفيذ واجهة IProductRepository
    {
        private readonly ApplicationDbContext _context;// متغير لحفظ سياق قاعدة البيانات

        public ProductRepository(ApplicationDbContext context)// مُنشئ لاستقبال سياق قاعدة البيانات
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()// دالة لجلب جميع المنتجات
        {
            return await _context.Products
                .Include(p => p.User)
                .Include(p => p.Ratings)
                .ToListAsync();
        }
        // 👇 المنتجات المقبولة فقط
        public async Task<IEnumerable<Product>> GetAllApprovedAsync()
        {
            return await _context.Products
                .Include(p => p.User)
                .Include(p => p.Ratings)
                .Where(p => p.IsApproved)// فقط المنتجات التي تمت الموافقة عليها
                .ToListAsync();
        }


        public async Task<Product> GetByIdAsync(Guid productId)// دالة لجلب منتج حسب معرفه
        {
            return await _context.Products
                .Include(p => p.User)//  جلب بيانات البائع

                .Include(p => p.Ratings)
                .FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetByUserIdAsync(string userId)// دالة لجلب المنتجات الخاصة بمستخدم معين حسب معرفه
        {
            return await _context.Products
                .Where(p => p.UserId == userId)
                .Include(p => p.Ratings)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> FilterAsync(DateTime? releaseDate, ProductCategory? category, bool? isAvailable)// دالة لتصفية المنتجات حسب تاريخ الإصدار، الفئة، والتوافر
        {
            var query = _context.Products.AsQueryable();// إنشاء استعلام قابل للتعديل

            if (releaseDate.HasValue)
                query = query.Where(p => p.CreatedAt.Date == releaseDate.Value.Date);// تصفية حسب تاريخ الإصدار

            if (category.HasValue)
                query = query.Where(p => p.Category == category.Value);// تصفية حسب الفئة

            if (isAvailable.HasValue)
                query = query.Where(p => p.IsAvailable == isAvailable.Value);// تصفية حسب التوافر

            return await query.ToListAsync();
        }
        public async Task AddAsync(Product product)//دالة لإضافة منتج جديد
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public void Update(Product product)//دالة لتحديث منتج موجود
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)//دالة حذف منتج حسب المعرف
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Product>> SearchAsync(string name)//دالة بحث عن المنتجات حسب الاسم
        {
            if (string.IsNullOrWhiteSpace(name))
                return await GetAllAsync();

            return await _context.Products
                .Include(p => p.User)
                .Include(p => p.Ratings)
                .Where(p => p.Name.Contains(name) || p.Description.Contains(name))// بحث في الاسم والوصف
                .ToListAsync();
        }

        // دالة لجلب المنتجات حسب الفئة، مع إمكانية استبعاد منتج معين بناءً على معرفه
        public async Task<IEnumerable<Product>> GetByCategoryAsync(ProductCategory category, Guid? excludeId = null)// دالة لجلب المنتجات حسب الفئة، مع إمكانية استبعاد منتج معين بناءً على معرفه
        {
            var query = _context.Products
                .Where(p => p.Category == category);

            if (excludeId.HasValue)
                query = query.Where(p => p.ProductId != excludeId.Value);

            return await query
                .OrderByDescending(p => p.CreatedAt)
                .Take(8) // مثلاً نعرض 8 منتجات فقط
                .ToListAsync();
        }
    }
}