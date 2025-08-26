using Microsoft.AspNetCore.Identity.UI.Services;

namespace Souqna.Services
{
    public class FakeEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Console.WriteLine($"[FakeEmailSender] Email to: {email}, Subject: {subject}");
            return Task.CompletedTask;
        }
    }
}
