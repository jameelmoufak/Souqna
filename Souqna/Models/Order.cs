namespace Souqna.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public double TotalCost { get; set; } // التكلفة الإجمالية للطلب
        public DateTime OrderedAt { get; set; } // تاريخ الطلب
        public ICollection<OrderItem> OrderItems { get; set; } // قائمة العناصر في الطلب
        public Order()
        {
            OrderId = Guid.NewGuid(); // تعيين معرف فريد للطلب
            OrderedAt = DateTime.UtcNow; // تعيين تاريخ الطلب إلى الوقت الحالي
        }
    }
}