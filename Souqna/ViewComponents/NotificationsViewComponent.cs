using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Souqna.Data;
using Souqna.Models;

namespace Souqna.ViewComponents
{
    public class NotificationsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public NotificationsViewComponent(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
                return View(new List<Notification>());

            var notifications = _context.Notifications
                .Where(n => n.UserId == user.Id)
                .OrderByDescending(n => n.CreatedAt)
                .Take(10) // آخر 10 إشعارات
                .ToList();

            // حساب عدد الإشعارات غير المقروءة
            ViewBag.UnreadCount = _context.Notifications.Count(n => n.UserId == user.Id && !n.IsRead);


            return View(notifications);

            // حساب عدد الإشعارات غير المقروءة
            
        }
    }
}
