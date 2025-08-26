namespace Souqna.Data.ViewModels
{
    public class CheckoutVM
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        // معلومات المستخدم
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double? EstimatedTotal { get; set; }

        // طرق الدفع
        public string PaymentMethod { get; set; } // "ShamCash", "Points", "PayPal"
    }
}
