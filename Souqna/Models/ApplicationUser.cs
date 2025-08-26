using Microsoft.AspNetCore.Identity;

namespace Souqna.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } //الاسم الكامل للمستخدم

        public string Role { get; set; } = "User";

        public double Balance { get; set; } = 0.0; //رصيد المستخدم
        public string? ProfileImage { get; set; } //مسار صورة الملف الشخصي للمستخدم
        public DateOnly Birthday { get; set; } //تاريخ ميلاد المستخدم
        public string? Address { get; set; } //عنوان المستخدم
        public ICollection<Order> Orders { get; set; } //قائمة الطلبات التي قام بها المستخدم
        public ICollection<Product> Products { get; set; } //قائمة المنتجات التي قام المستخدم بإنشائها
    }
}
