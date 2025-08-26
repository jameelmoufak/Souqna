using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Souqna.Data;
using Souqna.Data.Cart;
using Souqna.Data.Repositories;
using Souqna.Data.Services;
using Souqna.Models;
using System;

using Microsoft.AspNetCore.Identity.UI.Services;
using Souqna.Services;
using Souqna.Services.Payments;
using Souqna.Services.Notifications;
using Souqna.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Identity/Account/Login";
    options.LogoutPath = "/Identity/Account/Logout";
    options.SlidingExpiration = true;
});


// خدمات SignalR
builder.Services.AddSignalR();

// خدمة الإشعارات
builder.Services.AddScoped<INotificationService, SignalRNotificationService>();

//Repositories
//
builder.Services.AddScoped<UnitOfWork>();
//
// 🛒 تسجيل الـ Repository
builder.Services.AddScoped<IRatingRepository, RatingRepository>();

builder.Services.AddScoped<IRepository<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IStateRepository, SessionStateRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession();

builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Authentication and authorization
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});
builder.Services.AddControllersWithViews();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMvc();


//
builder.Services.AddSingleton<IEmailSender, FakeEmailSender>();
//



//
// 💳 تسجيل خدمات الدفع
builder.Services.AddScoped<BalancePaymentService>();
builder.Services.AddScoped<ShamCashPaymentService>();
builder.Services.AddScoped<PayPalPaymentService>();
builder.Services.AddScoped<PaymentFactory>();


var app = builder.Build();

app.UseSession();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.MapHub<NotificationHub>("/notificationHub");

/*using (var serviceScope = app.Services.CreateScope())
{
    var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    ApplicationDbContext.CreatingInitialTestingDataBase(context); // Seed initial data
    ApplicationDbContext.SeedUsersAndRolesAsync(serviceScope).Wait(); // Seed roles and users

}*/




//  ����� ������� �������� ����� admin
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    string[] roles = { "Admin", "User" };

    // ����� ������� ��� �� ��� ������
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // ����� ������ Admin ��������
    string adminEmail = "Admin@1A.com";
    string adminPassword = "Admin@1A";
    var admin = await userManager.FindByEmailAsync(adminEmail);

    if (admin == null)
    {
        var newAdmin = new ApplicationUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            FullName = "Administrator",
            Role = "Admin",
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(newAdmin, adminPassword);
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(newAdmin, "Admin");
        }
    }
}

app.Run();
