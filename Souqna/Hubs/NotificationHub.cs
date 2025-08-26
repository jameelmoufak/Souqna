using Microsoft.AspNetCore.SignalR;

namespace Souqna.Hubs
{
    public class NotificationHub : Hub
    {
        public override async Task OnConnectedAsync()//استخدام هذه الدالة عند اتصال المستخدم
        {
            var user = Context.User;// الحصول على المستخدم من سياق الاتصال
            if (user != null && user.IsInRole("Admin"))//نتحقق مما إذا كان المستخدم هو أدمن
            {
                // ضم الأدمن إلى المجموعة "Admin"
                await Groups.AddToGroupAsync(Context.ConnectionId, "Admin");// إضافة المستخدم إلى مجموعة الأدمن
            }

            await base.OnConnectedAsync();// استدعاء الدالة الأساسية لإكمال عملية الاتصال
        }

        // إرسال إشعار لمستخدم محدد
        public async Task SendToUser(string userId, string message)//استخدام هذه الدالة لإرسال إشعار لمستخدم معين
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", message);// إرسال الإشعار للمستخدم المحدد
        }

        // إرسال إشعار لجميع الأدمن
        public async Task SendToAdmins(string message)//استخدام هذه الدالة لإرسال إشعار لجميع الأدمن
        {
            await Clients.Group("Admin").SendAsync("ReceiveNotification", message);// إرسال الإشعار لجميع الأدمن في المجموعة "Admin"
        }
    }
}
