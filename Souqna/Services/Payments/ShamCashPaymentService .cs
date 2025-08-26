namespace Souqna.Services.Payments
{
    public class ShamCashPaymentService : IPaymentService
    {
        public Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount)
        {
            // TODO: إضافة تكامل مع ShamCash API
            return Task.FromResult(ServiceResponse<bool>.Success(true, $"🚀 تم الدفع عبر شام كاش: {amount}"));
        }
    }
}
