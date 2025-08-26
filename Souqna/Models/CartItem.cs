using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Souqna.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        // معرف المنتج المرتبط بالسلة
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        // معرف المستخدم الذي يملك السلة
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        // عدد الكمية التي أضافها المستخدم من المنتج
        public int Quantity { get; set; } = 1;

        // وقت إضافة المنتج للسلة
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
