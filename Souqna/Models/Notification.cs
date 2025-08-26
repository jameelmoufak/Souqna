using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Souqna.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }   // المستخدم اللي وصله الإشعار

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public string Message { get; set; }  // نص الإشعار

        public bool IsRead { get; set; } = false; // هل تمت قراءته؟
        public string? Url { get; set; } // رابط الصفحة المرتبطة بالإشعار


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
