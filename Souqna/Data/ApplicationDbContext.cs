using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Souqna.Models;
using System.Reflection.Emit;
using System.Text.Json;
using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);




            // تحويل IList<string> إلى JSON والعكس
            //builder.Entity<Product>()
            //    .Property(p => p.ProductImages)
            //    .HasConversion(
            //        v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            //        v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>()
            //    );
            // Product - User
            // Product - User
            // Product - User
            builder.Entity<Product>()
                .HasOne(p => p.User)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Order - User
            builder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Order - OrderItems
            builder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // هنا ممكن نخليه Cascade لأنه مسار واحد

            // OrderItem - Product
            builder.Entity<OrderItem>()
                .HasOne(oi => oi.product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            // Rating - Product
            builder.Entity<Rating>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Ratings)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            // Rating - User
            builder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Unique constraint: User can rate a product only once
            builder.Entity<Rating>()
                .HasIndex(r => new { r.ProductId, r.UserId })
                .IsUnique();

            // CartItem - Product
            builder.Entity<CartItem>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            // CartItem - User
            builder.Entity<CartItem>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);



        }

        public static async Task SeedUsersAndRolesAsync(IServiceScope serviceScope)
        {
            //Roles
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new IdentityRole("User"));

            //Users
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string adminUserEmail = "admin@etickets.com";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if (adminUser == null)
            {
                var newAdminUser = new ApplicationUser()
                {
                    FullName = "Admin User",
                    UserName = "admin-user",
                    Email = adminUserEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                await userManager.AddToRoleAsync(newAdminUser, "Admin");
            }


            string appUserEmail = "user@etickets.com";

            var appUser = await userManager.FindByEmailAsync(appUserEmail);
            if (appUser == null)
            {
                var newAppUser = new ApplicationUser()
                {
                    FullName = "Application User",
                    UserName = "app-user",
                    Email = appUserEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newAppUser, "Coding@1234?");
                await userManager.AddToRoleAsync(newAppUser, "User");
            }
        }

        public static void CreatingInitialTestingDataBase(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Seed Products
            //if (!context.Products.Any())
            //{
            //    var products = new List<Product>
            //    {
            //        new Product
            //        {
            //            ProductId = Guid.NewGuid(),
            //            Name = "Smartphone",
            //            Description = "Latest model smartphone with advanced features.",
            //            PriceOfUnit = 799.99,
            //            Category = ProductCategory.Electronics,
            //            Unit = UnitOfMeasurement.Piece,
            //            IsNew = true,
            //            IsAvailable = true,
            //            StockQuantity = 50,
            //            CreatedAt = DateTime.UtcNow,
            //            ProductImages = new List<string> { "images/smartphone1.jpg" },
            //            UserId = null // Assign a valid user id if available
            //        },
            //        new Product
            //        {
            //            ProductId = Guid.NewGuid(),
            //            Name = "Running Shoes",
            //            Description = "Comfortable running shoes for all terrains.",
            //            PriceOfUnit = 120.00,
            //            Category = ProductCategory.SportsEquipment,
            //            Unit = UnitOfMeasurement.Piece,
            //            IsNew = true,
            //            IsAvailable = true,
            //            StockQuantity = 100,
            //            CreatedAt = DateTime.UtcNow,
            //            ProductImages = new List<string> { "images/shoes1.jpg" },
            //            UserId = null
            //        }
            //    };
            //    context.Products.AddRange(products);
            //    context.SaveChanges();
            //}

            // Seed Orders
            if (!context.Orders.Any())
            {
                var order = new Order
                {
                    OrderId = Guid.NewGuid(),
                    UserId = null, // Assign a valid user id if available
                    TotalCost = 919.99,
                    OrderedAt = DateTime.UtcNow,
                    OrderItems = new List<OrderItem>()
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }

            // Seed Ratings
            if (!context.Ratings.Any())
            {
                var rating = new Rating
                {
                    RatingId = Guid.NewGuid(),
                    UserId = null, // Assign a valid user id if available
                    ProductId = context.Products.First().ProductId,
                    Stars = 5
                };
                context.Ratings.Add(rating);
                context.SaveChanges();
            }

            // Seed ShoppingCartItems
            if (!context.ShoppingCartItems.Any())
            {
                var cartItem = new ShoppingCartItem
                {
                    Product = context.Products.First(),
                    Amount = 2,
                    ShoppingCartId = "test-cart"
                };
                context.ShoppingCartItems.Add(cartItem);
                context.SaveChanges();
            }
        }
    }
}