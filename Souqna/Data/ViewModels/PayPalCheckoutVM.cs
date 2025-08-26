namespace Souqna.Data.ViewModels
{
    public class PayPalCheckoutVM
    {
        public string OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
