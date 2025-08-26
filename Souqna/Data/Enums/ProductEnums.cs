using System.ComponentModel.DataAnnotations;

namespace Souqna.Data.Enums
{
    public class ProductEnums
    {
        public enum ProductCategory
        {
            Electronics,
            Clothing,
            Vihicles,
            Jewelry,
            HealthAndPersonalCare,
            technology,
            Books,
            BeautyProducts,
            SportsEquipment,
            Toys,
            Furniture
        }
        public enum UnitOfMeasurement
        {
            [Display(Name = "قطعة")]
            Piece,
            [Display(Name = "كيلوجرام")]
            Kilogram,
            [Display(Name = "لتر")]
            Liter,
            [Display(Name = "متر")]
            Meter
        }
    }
}
