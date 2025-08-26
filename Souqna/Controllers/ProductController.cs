using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Souqna.Data.Repositories;
using Souqna.Data.ViewModels;
using Souqna.Models;
using Souqna.Services.Notifications;
using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Controllers
{
    public class ProductController : Controller
    {
        private readonly INotificationService _notificationService; // 🔹 خدمة الإشعارات
        private readonly IProductRepository _productRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRatingRepository _ratingRepository;

        public ProductController(IProductRepository productRepository, UserManager<ApplicationUser> userManager, INotificationService notificationService, IRatingRepository ratingRepository)
        {
            _productRepository = productRepository;
            _userManager = userManager;
            _notificationService = notificationService;
            _ratingRepository = ratingRepository;

        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()// عرض جميع المنتجات
        {
            var approved = await _productRepository.GetAllApprovedAsync();
            return View(approved);// 🔹 عرض المنتجات المقبولة فقط
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var approved = await _productRepository.GetAllApprovedAsync();// 🔹 جلب جميع المنتجات المقبولة

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = approved
                    .Where(p => p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                             || (p.Description != null && p.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                return View("Index", filteredResult);// 🔹 عرض المنتجات التي تحتوي على الكلمة المفتاحية
            }

            return View("Index", approved);// 🔹 إذا لم يكن هناك بحث، عرض جميع المنتجات المقبولة
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            var productDetail = await _productRepository.GetByIdAsync(id);


            if (productDetail == null) return View("NotFound");

            var similarProducts = await _productRepository
                .GetByCategoryAsync(productDetail.Category, excludeId: id);

            ViewBag.SimilarProducts = similarProducts;

            // 🔹 حساب متوسط التقييمات والنجوم
            var averageRating = await _ratingRepository.GetAverageRatingAsync(id);

            string userId = _userManager.GetUserId(User);
            int userRating = 0;
            if (userId != null)
                userRating = await _ratingRepository.GetUserRatingAsync(id, userId);

            ViewBag.AverageRating = averageRating;
            ViewBag.UserRating = userRating;


            return View(productDetail);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(Enum.GetValues(typeof(ProductCategory)));
            ViewBag.Units = new SelectList(Enum.GetValues(typeof(UnitOfMeasurement)));
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ProductVM productVM)
        {
            var currentUserId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(currentUserId))
                return Challenge(); // يوجّه لتسجيل الدخول

            // هذي الخاصية لا نتحقّق منها الآن
            ModelState.Remove(nameof(ProductVM.ProductImages));

            // التحقق اليدوي من الصور (لو حاب)
            if (productVM.UploadedImages == null || !productVM.UploadedImages.Any())
                ModelState.AddModelError(nameof(ProductVM.UploadedImages), "يجب رفع صورة واحدة على الأقل");

            if (!ModelState.IsValid)
            {
                // اطبع الأخطاء للكونسول ليسهّل التشخيص
                foreach (var kv in ModelState)
                    foreach (var err in kv.Value.Errors)
                        Console.WriteLine($"[MODELSTATE] {kv.Key}: {err.ErrorMessage}");

                ViewBag.Categories = new SelectList(Enum.GetValues(typeof(ProductCategory)));
                ViewBag.Units = new SelectList(Enum.GetValues(typeof(UnitOfMeasurement)));
                return View(productVM);
            }

            // حفظ الصور
            var imagePaths = new List<string>();
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
            Directory.CreateDirectory(uploadsFolder);

            foreach (var file in productVM.UploadedImages)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);
                using var stream = new FileStream(filePath, FileMode.Create);
                await file.CopyToAsync(stream);
                imagePaths.Add("/images/products/" + fileName);
            }

            // إنشاء الكيان
            var product = new Product
            {
                Name = productVM.Name,
                Description = productVM.Description,
                PriceOfUnit = productVM.PriceOfUnit,
                Category = productVM.Category!.Value,
                Unit = productVM.Unit!.Value,
                IsNew = productVM.IsNew,
                StockQuantity = productVM.StockQuantity,
                IsAvailable = productVM.StockQuantity > 0,
                UserId = currentUserId,//  ربط المنتج بالمستخدم الحالي
                IsApproved = false // 🔹 المنتج قيد المراجعة بعد الإضافة


                // أو لو عندك ProductImagesJson + SetImages(imagePaths) استخدمها بدلاً من السطر أعلاه
            };
            product.SetImages(imagePaths);

            await _productRepository.AddAsync(product);
            // 🔹 إرسال إشعار للأدمن بوجود منتج جديد
            await _notificationService.NotifyAdminsAsync(
     $"📢 منتج جديد بانتظار الموافقة: {product.Name}",
     Url.Action("PendingProducts", "AdminProducts")
 );



            TempData["Success"] = "تم إرسال المنتج بانتظار موافقة الإدارة ✅";
            return RedirectToAction(nameof(Index));// العودة إلى قائمة المنتجات
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, ProductVM productVM)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(Enum.GetValues(typeof(ProductCategory)));
                ViewBag.Units = new SelectList(Enum.GetValues(typeof(UnitOfMeasurement)));
                return View(productVM);
            }

            var existingProduct = await _productRepository.GetByIdAsync(id);
            if (existingProduct == null) return View("NotFound");

            existingProduct.Name = productVM.Name;
            existingProduct.Description = productVM.Description;
            existingProduct.PriceOfUnit = productVM.PriceOfUnit;
            existingProduct.Category = productVM.Category.Value;
            existingProduct.Unit = productVM.Unit.Value;
            existingProduct.IsNew = productVM.IsNew;
            existingProduct.StockQuantity = productVM.StockQuantity;
            existingProduct.IsAvailable = productVM.StockQuantity > 0;

            existingProduct.IsApproved = false; // 🔹 يرجع للانتظار بعد التعديل


            if (productVM.UploadedImages != null && productVM.UploadedImages.Any())
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
                Directory.CreateDirectory(uploadsFolder);

                var imagePaths = new List<string>();
                foreach (var file in productVM.UploadedImages)
                {
                    var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(uploadsFolder, fileName);

                    using var stream = new FileStream(filePath, FileMode.Create);
                    await file.CopyToAsync(stream);

                    imagePaths.Add("/images/products/" + fileName);
                }
                existingProduct.SetImages(imagePaths);
            }

            _productRepository.Update(existingProduct);

            await _notificationService.NotifyAdminsAsync(
                $"✏️ تعديل منتج بانتظار الموافقة: {existingProduct.Name}",
                Url.Action("PendingProducts", "AdminProducts")
            );


            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return View("NotFound");

            var viewModel = new ProductVM
            {
                Name = product.Name,
                Description = product.Description,
                PriceOfUnit = product.PriceOfUnit,
                Category = product.Category,
                Unit = product.Unit,
                IsNew = product.IsNew,
                StockQuantity = product.StockQuantity,
                ExistingImages = product.GetImages()
            };

            ViewBag.Categories = new SelectList(Enum.GetValues(typeof(ProductCategory)));
            ViewBag.Units = new SelectList(Enum.GetValues(typeof(UnitOfMeasurement)));

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Rate(Guid productId, int stars)
        {
            if (stars < 1 || stars > 5)
                return BadRequest("قيمة التقييم غير صحيحة");

            var userId = _userManager.GetUserId(User);
            if (userId == null) return Challenge();

            var rating = new Rating
            {
                ProductId = productId,
                UserId = userId,
                Stars = stars
            };

            await _ratingRepository.AddOrUpdateAsync(rating);

            return RedirectToAction("Details", new { id = productId });
        }

    }
}
