using Microsoft.EntityFrameworkCore;
using Souqna.Data;
using Souqna.Models;

namespace Souqna.Services.Payments
{
    public class BalancePaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _context;

        public BalancePaymentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null) return ServiceResponse<bool>.Fail("المستخدم غير موجود");

            if (user.Balance < amount)
                return ServiceResponse<bool>.Fail("❌ الرصيد غير كافٍ");

            user.Balance -= amount;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return ServiceResponse<bool>.Success(true, "✅ تم الدفع من الرصيد");
        }
    }
}
