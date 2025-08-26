using Microsoft.AspNetCore.SignalR;
using Souqna.Data;
using Souqna.Hubs;
using Souqna.Models;

namespace Souqna.Services.Notifications
{
    public interface INotificationService // واجهة خدمة الإشعارات
    {
        Task NotifyUserAsync(string userId, string message, string? url = null);
        Task NotifyAdminsAsync(string message, string? url = null);
    }

    public class SignalRNotificationService : INotificationService // خدمة الإشعارات باستخدام SignalR
    {
        private readonly IHubContext<NotificationHub> _hub;
        private readonly ApplicationDbContext _context;

        public SignalRNotificationService(IHubContext<NotificationHub> hub, ApplicationDbContext context)
        {
            _context = context;
            _hub = hub;
        }

        public async Task NotifyUserAsync(string userId, string message, string? url = null)
        {
            // ✅ 1. حفظ في قاعدة البيانات
            var notification = new Notification
            {
                UserId = userId,
                Message = message,
                Url = url,
                CreatedAt = DateTime.UtcNow
            };
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();

            // ✅ 2. إرسال عبر SignalR
            await _hub.Clients.User(userId).SendAsync("ReceiveNotification", new
            {
                message,
                url
            });
        }

        public async Task NotifyAdminsAsync(string message, string? url = null)
        {
            // لو عندك أكثر من أدمن، خزن لكل واحد
            var admins = _context.Users.Where(u => u.Role == "Admin").ToList();

            foreach (var admin in admins)
            {
                var notification = new Notification
                {
                    UserId = admin.Id,
                    Message = message,
                    Url = url,
                    CreatedAt = DateTime.UtcNow
                };
                _context.Notifications.Add(notification);
            }

            await _context.SaveChangesAsync();

            await _hub.Clients.Group("Admin").SendAsync("ReceiveNotification", new
            {
                message,
                url
            });
        }
    }
}
