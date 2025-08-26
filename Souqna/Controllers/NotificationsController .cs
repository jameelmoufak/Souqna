using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Souqna.Data;
using Souqna.Models;

namespace Souqna.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public NotificationsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyNotifications()//
        {
            var user = await _userManager.GetUserAsync(User);
            var notifications = _context.Notifications
                .Where(n => n.UserId == user.Id)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();

            return View(notifications);
        }
        public async Task<IActionResult> ReadNotification(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var notification = await _context.Notifications.FindAsync(id);

            if (notification == null || notification.UserId != user.Id)
                return NotFound();

            // تغيير الحالة إلى مقروء
            notification.IsRead = true;
            await _context.SaveChangesAsync();

            // إعادة التوجيه إلى الرابط الخاص بالإشعار
            if (!string.IsNullOrEmpty(notification.Url))
                return Redirect(notification.Url);

            return RedirectToAction("MyNotifications");
        }
        [HttpGet]
        public async Task<IActionResult> UnreadCount()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return Json(new { count = 0 });

            var count = _context.Notifications.Count(n => n.UserId == user.Id && !n.IsRead);
            return Json(new { count });
        }
        public async Task<IActionResult> OpenNotification(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var notification = await _context.Notifications.FindAsync(id);

            if (notification == null || notification.UserId != user.Id)
                return NotFound();

            notification.IsRead = true;
            _context.Update(notification);
            await _context.SaveChangesAsync();

            // التوجيه للرابط المخزن في Url
            return Redirect(notification.Url ?? "/");
        }


    }

}
