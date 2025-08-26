using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Helpers
{
    public static class EnumTranslations
    {
        public static string GetDisplayName(this ProductCategory category)
        {
            return category switch
            {
                ProductCategory.Electronics => "إلكترونيات",
                ProductCategory.Clothing => "ملابس",
                ProductCategory.Vihicles => "مركبات",
                ProductCategory.Jewelry => "مجوهرات",
                ProductCategory.HealthAndPersonalCare => "الصحة والعناية الشخصية",
                ProductCategory.technology => "تكنولوجيا",
                ProductCategory.Books => "كتب",
                ProductCategory.BeautyProducts => "منتجات تجميل",
                ProductCategory.SportsEquipment => "معدات رياضية",
                ProductCategory.Toys => "ألعاب",
                ProductCategory.Furniture => "أثاث",
                _ => category.ToString()
            };
        }

        //public static string GetDisplayName(this UnitOfMeasurement unit)
        //{
        //    return unit switch
        //    {
        //        UnitOfMeasurement.Piece => "قطعة",
        //        UnitOfMeasurement.Kilogram => "كيلوغرام",
        //        UnitOfMeasurement.Liter => "لتر",
        //        UnitOfMeasurement.Meter => "متر",
        //        _ => unit.ToString()
        //    };
        //}
    }
}
