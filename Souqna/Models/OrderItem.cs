namespace Souqna.Models
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; } // معرف الطلب الذي ينتمي إليه العنصر
        public Order order { get; set; } 
        public Guid ProductId { get; set; } // معرف المنتج الذي ينتمي إليه العنصر
        public Product product { get; set; }
        public int Amount { get; set; } // الكمية المطلوبة من المنتج
        public double Cost { get; set; } // التكلفة الإجمالية للعنصر في الطلب
        public OrderItem()
        {
            OrderItemId = Guid.NewGuid(); // تعيين معرف فريد للعنصر في الطلب
        }

    }
}