using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souqna.Data;
using Souqna.Data.Enums;
using Souqna.Data.Repositories;
using Souqna.Data.ViewModels;
using Souqna.Models;
using System.Diagnostics;

namespace Souqna.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, ApplicationDbContext context)
        {
            _logger = logger;
            _productRepository = productRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllApprovedAsync();//المنتجات الموافق عليها

            var categories = Enum.GetValues(typeof(ProductEnums.ProductCategory))
                .Cast<ProductEnums.ProductCategory>()
                .Select(c => new CategoryVM
                {
                    Name = c.ToString(),
                    Icon = GetCategoryIcon(c),
                    Products = products.Where(p => p.Category == c)
                }).ToList();




            //   ********************************** جلب اخر 6 اراء  **********************************
            //   
            //
            var reviews = await _context.Reviews
                .Include(r => r.User) // جلب بيانات المستخدم
                .Where(r => r.IsApproved)
                .OrderByDescending(r => r.CreatedAt)
                .Take(6)
                .ToListAsync();


            var viewModel = new HomeVM
            {
                Categories = categories,
                LatestProducts = products.OrderByDescending(p => p.CreatedAt).Take(6),
                Reviews = reviews
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SendReview(Review review)
        {
            if (!ModelState.IsValid) return View(review);

            // 🔹 ربط المراجعة بالمستخدم الحالي
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                review.UserId = userId;
            }

            review.CreatedAt = DateTime.Now;
            review.IsApproved = false;

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            TempData["Success"] = "تم إرسال رأيك بنجاح";
            return RedirectToAction("Index");
        }


        [Route("details/{ProductId:guid}")]
        public async Task<IActionResult> Details(Guid ProductId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var product = await _productRepository.GetByIdAsync(ProductId);
            if (product == null) return NotFound();

            return View(product);
        }

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

        private string GetCategoryIcon(ProductEnums.ProductCategory category)
        {
            return category switch
            {
                ProductEnums.ProductCategory.Electronics => "bi-laptop",
                ProductEnums.ProductCategory.Clothing => "bi-shop",
                ProductEnums.ProductCategory.Vihicles => "bi-car-front",
                ProductEnums.ProductCategory.Jewelry => "bi-gem",
                ProductEnums.ProductCategory.HealthAndPersonalCare => "bi-heart-pulse",
                ProductEnums.ProductCategory.technology => "bi-cpu",
                ProductEnums.ProductCategory.Books => "bi-book",
                ProductEnums.ProductCategory.BeautyProducts => "bi-brush",
                ProductEnums.ProductCategory.SportsEquipment => "bi-basket",
                ProductEnums.ProductCategory.Toys => "bi-joystick",
                ProductEnums.ProductCategory.Furniture => "bi-house",
                _ => "bi-box"
            };
        }

        [HttpGet]
        public async Task<IActionResult> ProductSearch(string Sname)
        {
            var products = string.IsNullOrWhiteSpace(Sname)
                ? await _productRepository.GetAllAsync()
                : await _productRepository.SearchAsync(Sname);

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_ProductsPartial", products);

            var categories = Enum.GetValues(typeof(ProductEnums.ProductCategory))
                .Cast<ProductEnums.ProductCategory>()
                .Select(c => new CategoryVM
                {
                    Name = c.ToString(),
                    Icon = GetCategoryIcon(c),
                    Products = products.Where(p => p.Category == c)
                }).ToList();

            var vm = new HomeVM { LatestProducts = products, Categories = categories };
            return View("Index", vm);
        }
    }
}
