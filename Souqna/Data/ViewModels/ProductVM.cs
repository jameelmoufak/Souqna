using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Souqna.Data.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Data.ViewModels
{
    public class ProductVM
    {
        public List<string> ExistingImages { get; set; } = new List<string>();

        public Guid ProductId { get; set; }

        [Display(Name = "اسم المنتج")]
        [Required(ErrorMessage = "ادخل اسم المنتج")]
        public string Name { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Display(Name = "سعر الواحدة")]
        [Required(ErrorMessage = "ادخل السعر")]
        [Range(1, 1000000, ErrorMessage = "السعر المدخل غير صالح")]
        public double PriceOfUnit { get; set; }

        // خليه Nullable + Required عشان خيار "-- اختر --" ما يسبب خطأ ربط
        [Display(Name = "الفئة (التصنيف)")]
        [Required(ErrorMessage = "يرجى اختيار الفئة")]
        public ProductCategory? Category { get; set; }

        [Display(Name = "وحدة القياس")]
        [Required(ErrorMessage = "يرجى تحديد وحدة القياس")]
        public UnitOfMeasurement? Unit { get; set; } = UnitOfMeasurement.Piece;

        [Display(Name = "هل المنتج جديد؟")]
        public bool IsNew { get; set; } = false;

        [Display(Name = "الكمية المتاحة")]
        [Required(ErrorMessage = "الكمية المتاحة مطلوبة")]
        [Range(1, 1000000, ErrorMessage = "ادخل كمية صحيحة")]
        public int StockQuantity { get; set; } = 1;

        // هذي تُملأ بعد الحفظ – لا نتحقق منها في ModelState
        [ValidateNever]
        public List<string> ProductImages { get; set; } = new();

        // التحقق يكون على الملفات المرفوعة
        [Display(Name = "صور للمنتج")]
        [Required(ErrorMessage = "يجب رفع صورة واحدة على الأقل")]
        public List<IFormFile> UploadedImages { get; set; } = new();
    }
}
