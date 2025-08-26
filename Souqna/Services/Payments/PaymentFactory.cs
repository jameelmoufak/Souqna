namespace Souqna.Services.Payments
{
    public class PaymentFactory
    {
        private readonly BalancePaymentService _balancePaymentService;
        private readonly ShamCashPaymentService _shamCashPaymentService;
        private readonly PayPalPaymentService _payPalPaymentService;

        public PaymentFactory(
            BalancePaymentService balancePaymentService,
            ShamCashPaymentService shamCashPaymentService,
            PayPalPaymentService payPalPaymentService)
        {
            _balancePaymentService = balancePaymentService;
            _shamCashPaymentService = shamCashPaymentService;
            _payPalPaymentService = payPalPaymentService;
        }

        public IPaymentService GetPaymentService(string method)
        {
            return method switch
            {
                "Balance" => _balancePaymentService,
                "ShamCash" => _shamCashPaymentService,
                "PayPal" => _payPalPaymentService,
                _ => throw new ArgumentException("❌ طريقة الدفع غير معروفة")
            };
        }
    }
}
