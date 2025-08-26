namespace Souqna.Services.Payments
{
    public interface IPaymentService
    {
        Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount);
    }
}
