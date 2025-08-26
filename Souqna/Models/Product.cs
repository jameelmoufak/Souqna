using Souqna.Data.Attributes;
using static Souqna.Data.Enums.ProductEnums;
using System.Text.Json;


namespace Souqna.Models
{
    
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } //اسم المنتج
        public string Description { get; set; } //وصف المنتج
        public double PriceOfUnit { get; set; } //سعر المنتج
        public ProductCategory Category { get; set; } //فئة المنتج
        public UnitOfMeasurement Unit { get; set; } = UnitOfMeasurement.Piece; //وحدة قياس المنتج
        public bool IsNew { get; set; } = false; //هل المنتج جديد أم لا
        public bool IsAvailable { get; set; } = true; //هل المنتج متاح للبيع أم لا
                        
        //
        public bool IsApproved { get; set; } = false; //  المنتج يحتاج موافقة الأدمن

        public int StockQuantity { get; set; } = 1; //الكمية المتاحة من المنتج في المخزون
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //تاريخ إنشاء المنتج
        [CollectionLength(1, 8)] // أقصى عدد للصور المسموح به هو 8
        public string ProductImagesJson { get; set; }        // Navigation properties
        public string UserId { get; set; } // معرف المستخدم الذي أضاف المنتج
        public ApplicationUser User { get; set; } // المستخدم الذي أضاف المنتج
        public ICollection<Rating> Ratings { get; set; } // تقييمات المنتج من قبل المستخدمين
        public Product()
        {
            ProductId = Guid.NewGuid(); // تعيين معرف فريد للمنتج
            CreatedAt = DateTime.UtcNow;
        }

        public List<string> GetImages() =>
      string.IsNullOrEmpty(ProductImagesJson) ? new List<string>() : JsonSerializer.Deserialize<List<string>>(ProductImagesJson);

        public void SetImages(List<string> images) =>
            ProductImagesJson = JsonSerializer.Serialize(images);
    }
}