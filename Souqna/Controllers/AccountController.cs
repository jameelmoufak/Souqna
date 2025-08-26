using Souqna.Data;
using Souqna.Data.ViewModels;
using Souqna.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Souqna.Data.Repositories;

namespace Souqna.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ApplicationDbContext context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Users()//نعرض جميع المستخدمين
        {
            var users = await context.Users.ToListAsync();
            return View(users);
        }


        //public IActionResult Login() => View(new LoginVM());//نعرض صفحة تسجيل الدخول

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginVM loginVM)//دالة تسجيل الدخول
        //{
        //    if (!ModelState.IsValid) return View(loginVM);

        //    var user = await userManager.FindByEmailAsync(loginVM.EmailAddress);
        //    if(user != null)
        //    {
        //        var passwordCheck = await userManager.CheckPasswordAsync(user, loginVM.Password);
        //        if (passwordCheck)
        //        {
        //            var result = await signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Movies");
        //            }
        //        }
        //        TempData["Error"] = "Wrong credentials. Please, try again!";
        //        return View(loginVM);
        //    }

        //    TempData["Error"] = "Wrong credentials. Please, try again!";
        //    return View(loginVM);
        //}


        //public IActionResult Register() => View(new RegisterVM());

        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterVM registerVM)
        //{
        //    if (!ModelState.IsValid) return View(registerVM);

        //    var user = await userManager.FindByEmailAsync(registerVM.EmailAddress);
        //    if(user != null)
        //    {
        //        TempData["Error"] = "This email address is already in use";
        //        return View(registerVM);
        //    }

        //    var newUser = new ApplicationUser()
        //    {
        //        FullName = registerVM.FullName,
        //        Email = registerVM.EmailAddress,
        //        UserName = registerVM.EmailAddress
        //    };
        //    var newUserResponse = await userManager.CreateAsync(newUser, registerVM.Password);

        //    if (newUserResponse.Succeeded)
        //        await userManager.AddToRoleAsync(newUser, "User");

        //    return View("RegisterCompleted");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Movies");
        //}

        //public IActionResult AccessDenied(string ReturnUrl)
        //{
        //    return View();
        //}

        [Authorize]
        public async Task<IActionResult> MyAccount()// عرض صفحة الحساب الشخصي للمستخدم
        {
            var userId = userManager.GetUserId(User);
            var user = await userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null) return NotFound();

            return View(user);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MyAccount(ApplicationUser model, IFormFile? profileImage)//تعديل الملف الشخصي
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null) return NotFound();

            // تحديث البيانات
            user.FullName = model.FullName;
            user.Address = model.Address;
            user.Birthday = model.Birthday;
            //user.Balance = model.Balance;

            // رفع الصورة إذا تم تحديدها
            if (profileImage != null && profileImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/profiles");
                Directory.CreateDirectory(uploadsFolder);

                var fileName = Guid.NewGuid() + Path.GetExtension(profileImage.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await profileImage.CopyToAsync(stream);
                }

                // حذف الصورة القديمة إذا كانت موجودة
                if (!string.IsNullOrEmpty(user.ProfileImage))
                {
                    var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", user.ProfileImage.TrimStart('/'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                // احفظ الرابط في قاعدة البيانات
                user.ProfileImage = "/images/profiles/" + fileName;
            }

            await userManager.UpdateAsync(user);

            TempData["Success"] = "تم تحديث الملف الشخصي بنجاح";
            return RedirectToAction("MyAccount");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditUser(string id)// عرض صفحة تعديل بيانات المستخدم
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }
        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditUser(ApplicationUser model)// تعديل بيانات المستخدم
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null) return NotFound();

            user.FullName = model.FullName;
            user.Email = model.Email;
            user.UserName = model.Email;
            user.Address = model.Address;
            user.Birthday = model.Birthday;
            user.Role = model.Role;
            //user.Balance = model.Balance;

            await userManager.UpdateAsync(user);
            return RedirectToAction("Users");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(string id)// حذف مستخدم
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            return View(user); // عرض صفحة تأكيد الحذف
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(string id)// تنفيذ حذف المستخدم
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["Success"] = "تم حذف المستخدم بنجاح ✅";
            }
            else
            {
                TempData["Error"] = "حدث خطأ أثناء الحذف ❌";
            }

            return RedirectToAction(nameof(Users));
        }


    }
}
