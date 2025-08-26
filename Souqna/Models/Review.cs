using System;
using System.ComponentModel.DataAnnotations;

namespace Souqna.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "الايميل مطلوب")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "عنوان الرسالة مطلوب")]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "الرسالة مطلوبة")]
        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

       



        // 🔹 ربط بالمستخدم
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public bool IsApproved { get; set; } = false; // موافقة الأدمن



    }
}
