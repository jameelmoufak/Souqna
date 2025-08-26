├── .gitattributes
├── .gitignore
├── Souqna.sln
└── Souqna
    ├── Areas
        └── Identity
        │   └── Pages
        │       ├── Account
        │           ├── AccessDenied.cshtml
        │           ├── AccessDenied.cshtml.cs
        │           ├── Login.cshtml
        │           ├── Login.cshtml.cs
        │           ├── Logout.cshtml
        │           ├── Logout.cshtml.cs
        │           ├── Register.cshtml
        │           ├── Register.cshtml.cs
        │           └── _ViewImports.cshtml
        │       ├── _ValidationScriptsPartial.cshtml
        │       ├── _ViewImports.cshtml
        │       └── _ViewStart.cshtml
    ├── Controllers
        ├── AccountController.cs
        ├── AdminOrdersController .cs
        ├── AdminProductsController.cs
        ├── AdminReviewsController.cs
        ├── CartController.cs
        ├── HomeController.cs
        ├── NotificationsController .cs
        ├── OrdersController.cs
        └── ProductController.cs
    ├── Data
        ├── ApplicationDbContext.cs
        ├── Attributes
        │   ├── CollectionLengthAttribute.cs
        │   └── Min18YearsOldAttribute.cs
        ├── Cart
        │   └── ShoppingCart.cs
        ├── Components
        │   └── ProductListViewComponent.cs
        ├── Enums
        │   └── ProductEnums.cs
        ├── Repositories
        │   ├── GenericRepository.cs
        │   ├── IOrdersRepository.cs
        │   ├── IProductRepository.cs
        │   ├── IRatingRepository.cs
        │   ├── IRepository.cs
        │   ├── IReviewRepository.cs
        │   ├── IStateRepository.cs
        │   ├── OrdersRepository.cs
        │   ├── ProductRepository.cs
        │   ├── RatingRepository.cs
        │   ├── ReviewRepository .cs
        │   ├── SessionStateRepository.cs
        │   └── UnitOfWork.cs
        └── ViewModels
        │   ├── CategoryVM.cs
        │   ├── CheckoutVM.cs
        │   ├── LoginVM.cs
        │   ├── MyAccountVM.cs
        │   ├── PayPalCheckoutVM.cs
        │   ├── ProductVM.cs
        │   ├── RegisterVM.cs
        │   └── ShoppingCartVM.cs
    ├── Helpers
        └── EnumTranslations.cs
    ├── Hubs
        └── NotificationHub.cs
    ├── Migrations
        ├── 20250813174458_MakeUserFieldsNullable.Designer.cs
        ├── 20250813174458_MakeUserFieldsNullable.cs
        ├── 20250813200318_ChangeProductImagesToJson.Designer.cs
        ├── 20250813200318_ChangeProductImagesToJson.cs
        ├── 20250815130746_FixDeleteBehavior.Designer.cs
        ├── 20250815130746_FixDeleteBehavior.cs
        ├── 20250816114515_AddReviewsTable.Designer.cs
        ├── 20250816114515_AddReviewsTable.cs
        ├── 20250816120015_AddUserToReviews.Designer.cs
        ├── 20250816120015_AddUserToReviews.cs
        ├── 20250818130056_AddIsApprovedToProduct.Designer.cs
        ├── 20250818130056_AddIsApprovedToProduct.cs
        ├── 20250818160155_AddNotifications.Designer.cs
        ├── 20250818160155_AddNotifications.cs
        ├── 20250818173804_AddNotificationsTable.Designer.cs
        ├── 20250818173804_AddNotificationsTable.cs
        ├── 20250823205702_AddUrlToNotification.Designer.cs
        ├── 20250823205702_AddUrlToNotification.cs
        └── ApplicationDbContextModelSnapshot.cs
    ├── Models
        ├── ApplicationUser.cs
        ├── CartItem.cs
        ├── ErrorViewModel.cs
        ├── Notification.cs
        ├── Order.cs
        ├── OrderItem.cs
        ├── Product.cs
        ├── Rating.cs
        ├── Review.cs
        └── ShoppingCartItem.cs
    ├── Program.cs
    ├── Properties
        ├── launchSettings.json
        ├── serviceDependencies.json
        └── serviceDependencies.local.json
    ├── Services
        ├── FakeEmailSender.cs
        ├── Notifications
        │   └── INotificationService.cs
        ├── Payments
        │   ├── BalancePaymentService.cs
        │   ├── IPaymentService.cs
        │   ├── PayPalPaymentService.cs
        │   ├── PaymentFactory.cs
        │   └── ShamCashPaymentService .cs
        └── ServiceResponse.cs
    ├── Souqna.csproj
    ├── ViewComponents
        └── NotificationsViewComponent.cs
    ├── Views
        ├── Account
        │   ├── DeleteUser.cshtml
        │   ├── EditUser.cshtml
        │   ├── MyAccount.cshtml
        │   └── Users.cshtml
        ├── AdminOrders
        │   ├── Delete.cshtml
        │   ├── Details.cshtml
        │   └── Index.cshtml
        ├── AdminProducts
        │   └── PendingProducts.cshtml
        ├── AdminReviews
        │   ├── Delete.cshtml
        │   └── Index.cshtml
        ├── Cart
        │   └── MyAccount.cshtml
        ├── Home
        │   ├── Index.cshtml
        │   ├── Privacy.cshtml
        │   └── _ProductsPartial.cshtml
        ├── Orders
        │   └── Checkout.cshtml
        ├── Product
        │   ├── Create.cshtml
        │   ├── Delete.cshtml
        │   ├── Details.cshtml
        │   ├── Edit.cshtml
        │   └── Index.cshtml
        ├── Shared
        │   ├── Error.cshtml
        │   ├── _Layout.cshtml
        │   ├── _Layout.cshtml.css
        │   ├── _LoginPartial.cshtml
        │   ├── _ValidationScriptsPartial.cshtml
        │   └── components
        │   │   └── Notifications
        │   │       └── Default.cshtml
        ├── _ViewImports.cshtml
        └── _ViewStart.cshtml
    ├── appsettings.Development.json
    ├── appsettings.json
    └── wwwroot
        ├── assets
            ├── css
            │   └── main.css
            ├── img
            │   ├── about.jpg
            │   ├── faviconn.png
            │   ├── features.svg
            │   ├── footer-bg.jpg
            │   ├── hero-bg.jpg
            │   ├── hero-img.png
            │   ├── logoo.png.png
            │   ├── market1.png
            │   ├── page-title-bg.jpg
            │   ├── portfolio
            │   │   ├── app-1.jpg
            │   │   ├── app-2.jpg
            │   │   ├── app-3.jpg
            │   │   ├── books-1.jpg
            │   │   ├── books-2.jpg
            │   │   ├── books-3.jpg
            │   │   ├── branding-1.jpg
            │   │   ├── branding-2.jpg
            │   │   ├── branding-3.jpg
            │   │   ├── product-1.jpg
            │   │   ├── product-2.jpg
            │   │   └── product-3.jpg
            │   ├── stats-bg.png
            │   └── team-shape.svg
            ├── js
            │   └── main.js
            ├── scss
            │   └── Readme.txt
            └── vendor
            │   ├── aos
            │       ├── aos.cjs.js
            │       ├── aos.css
            │       ├── aos.esm.js
            │       ├── aos.js
            │       └── aos.js.map
            │   ├── bootstrap-icons
            │       ├── bootstrap-icons.css
            │       ├── bootstrap-icons.json
            │       ├── bootstrap-icons.min.css
            │       ├── bootstrap-icons.scss
            │       └── fonts
            │       │   ├── bootstrap-icons.woff
            │       │   └── bootstrap-icons.woff2
            │   ├── bootstrap
            │       ├── css
            │       │   ├── bootstrap-grid.css
            │       │   ├── bootstrap-grid.css.map
            │       │   ├── bootstrap-grid.min.css
            │       │   ├── bootstrap-grid.min.css.map
            │       │   ├── bootstrap-grid.rtl.css
            │       │   ├── bootstrap-grid.rtl.css.map
            │       │   ├── bootstrap-grid.rtl.min.css
            │       │   ├── bootstrap-grid.rtl.min.css.map
            │       │   ├── bootstrap-reboot.css
            │       │   ├── bootstrap-reboot.css.map
            │       │   ├── bootstrap-reboot.min.css
            │       │   ├── bootstrap-reboot.min.css.map
            │       │   ├── bootstrap-reboot.rtl.css
            │       │   ├── bootstrap-reboot.rtl.css.map
            │       │   ├── bootstrap-reboot.rtl.min.css
            │       │   ├── bootstrap-reboot.rtl.min.css.map
            │       │   ├── bootstrap-utilities.css
            │       │   ├── bootstrap-utilities.css.map
            │       │   ├── bootstrap-utilities.min.css
            │       │   ├── bootstrap-utilities.min.css.map
            │       │   ├── bootstrap-utilities.rtl.css
            │       │   ├── bootstrap-utilities.rtl.css.map
            │       │   ├── bootstrap-utilities.rtl.min.css
            │       │   ├── bootstrap-utilities.rtl.min.css.map
            │       │   ├── bootstrap.css
            │       │   ├── bootstrap.css.map
            │       │   ├── bootstrap.min.css
            │       │   ├── bootstrap.min.css.map
            │       │   ├── bootstrap.rtl.css
            │       │   ├── bootstrap.rtl.css.map
            │       │   ├── bootstrap.rtl.min.css
            │       │   └── bootstrap.rtl.min.css.map
            │       └── js
            │       │   ├── bootstrap.bundle.js
            │       │   ├── bootstrap.bundle.js.map
            │       │   ├── bootstrap.bundle.min.js
            │       │   ├── bootstrap.bundle.min.js.map
            │       │   ├── bootstrap.esm.js
            │       │   ├── bootstrap.esm.js.map
            │       │   ├── bootstrap.esm.min.js
            │       │   ├── bootstrap.esm.min.js.map
            │       │   ├── bootstrap.js
            │       │   ├── bootstrap.js.map
            │       │   ├── bootstrap.min.js
            │       │   └── bootstrap.min.js.map
            │   ├── glightbox
            │       ├── css
            │       │   ├── glightbox.css
            │       │   └── glightbox.min.css
            │       └── js
            │       │   ├── glightbox.js
            │       │   └── glightbox.min.js
            │   ├── imagesloaded
            │       └── imagesloaded.pkgd.min.js
            │   ├── isotope-layout
            │       ├── isotope.pkgd.js
            │       └── isotope.pkgd.min.js
            │   ├── php-email-form
            │       └── validate.js
            │   ├── purecounter
            │       ├── purecounter_vanilla.js
            │       └── purecounter_vanilla.js.map
            │   └── swiper
            │       ├── swiper-bundle.min.css
            │       ├── swiper-bundle.min.js
            │       └── swiper-bundle.min.js.map
        ├── css
            └── site.css
        ├── favicon.ico
        ├── images
            ├── products
            │   ├── 0d310f40-a8df-4186-8561-7310c0e45f68.jpg
            │   ├── 0de662a4-590c-4aee-8321-98ee989157b7.jpg
            │   ├── 12c60645-6a3e-4826-a29e-bc1da0d5f94e.jpg
            │   ├── 1dd2df13-274c-4732-9739-5adc63931999.jpg
            │   ├── 23b91105-4f50-4daa-89ae-a7e2e8ad6760.jpg
            │   ├── 2cbe0f3a-37fe-4bfa-a05f-82dafdd5b524.jpg
            │   ├── 5a8f4310-b78d-4c66-9529-c8345554d312.jpg
            │   ├── 6752e912-f114-4900-90e4-0ede6adcd7b4.jpg
            │   ├── 68210cb1-6e6d-4b8e-b37c-051351a811d8.jpg
            │   ├── 7e9bcd99-6cca-4cf4-a0c0-17106da08d84.jpg
            │   ├── 9f363ee7-f4c5-4715-8dd4-21ef8216dc11.jpg
            │   ├── a5510ee1-b53e-49a0-86ed-b581833dff4b.jpg
            │   ├── ba60585c-129c-4c37-8f70-636c4eb4f3cf.jpg
            │   ├── bd003e78-2559-4fdf-8e2b-8192f2044390.png
            │   ├── c37dc0dc-2167-4698-afc2-abb6a1374899.jpg
            │   ├── c8371f6f-566d-429b-92bc-405221310672.jpg
            │   ├── d3d14bb8-f8c8-47f1-9361-49b5382ded3a.jpg
            │   ├── d5a87954-9775-4507-bd0c-2dda1c48f75b.jpg
            │   ├── dc763004-93bc-42da-811b-a1f41f821986.jpg
            │   ├── dd9cc974-661a-468a-813c-d4b9c4c00417.jpg
            │   ├── e1151b86-3374-4726-9a87-8105f826857f.jpg
            │   ├── e9c01a98-d089-4e31-b243-2c3686a2fcd6.jpg
            │   ├── ee76b6e3-0eec-46f3-b448-26231a64f4c8.jpg
            │   ├── f9c35d2a-d7a5-4611-a1b1-3fe6a0b4bc67.jpg
            │   └── fdfa2725-38ae-4302-90cf-bdf6f93973ec.jpg
            └── profiles
            │   ├── 24c5230a-16d1-44d4-8f12-bcd56ee651d0.jpg
            │   ├── 324b1218-12c6-4b03-bae2-bb9001ffa1c5.jpg
            │   ├── 77ebd815-1c35-401e-80b9-f83f7f789f3c.jpg
            │   └── ba246b88-a775-41f0-9f7f-22d0bd037a9c.jpg
        ├── js
            └── site.js
        └── lib
            ├── bootstrap
                ├── LICENSE
                └── dist
                │   ├── css
                │       ├── bootstrap-grid.css
                │       ├── bootstrap-grid.css.map
                │       ├── bootstrap-grid.min.css
                │       ├── bootstrap-grid.min.css.map
                │       ├── bootstrap-grid.rtl.css
                │       ├── bootstrap-grid.rtl.css.map
                │       ├── bootstrap-grid.rtl.min.css
                │       ├── bootstrap-grid.rtl.min.css.map
                │       ├── bootstrap-reboot.css
                │       ├── bootstrap-reboot.css.map
                │       ├── bootstrap-reboot.min.css
                │       ├── bootstrap-reboot.min.css.map
                │       ├── bootstrap-reboot.rtl.css
                │       ├── bootstrap-reboot.rtl.css.map
                │       ├── bootstrap-reboot.rtl.min.css
                │       ├── bootstrap-reboot.rtl.min.css.map
                │       ├── bootstrap-utilities.css
                │       ├── bootstrap-utilities.css.map
                │       ├── bootstrap-utilities.min.css
                │       ├── bootstrap-utilities.min.css.map
                │       ├── bootstrap-utilities.rtl.css
                │       ├── bootstrap-utilities.rtl.css.map
                │       ├── bootstrap-utilities.rtl.min.css
                │       ├── bootstrap-utilities.rtl.min.css.map
                │       ├── bootstrap.css
                │       ├── bootstrap.css.map
                │       ├── bootstrap.min.css
                │       ├── bootstrap.min.css.map
                │       ├── bootstrap.rtl.css
                │       ├── bootstrap.rtl.css.map
                │       ├── bootstrap.rtl.min.css
                │       └── bootstrap.rtl.min.css.map
                │   └── js
                │       ├── bootstrap.bundle.js
                │       ├── bootstrap.bundle.js.map
                │       ├── bootstrap.bundle.min.js
                │       ├── bootstrap.bundle.min.js.map
                │       ├── bootstrap.esm.js
                │       ├── bootstrap.esm.js.map
                │       ├── bootstrap.esm.min.js
                │       ├── bootstrap.esm.min.js.map
                │       ├── bootstrap.js
                │       ├── bootstrap.js.map
                │       ├── bootstrap.min.js
                │       └── bootstrap.min.js.map
            ├── jquery-validation-unobtrusive
                ├── LICENSE.txt
                └── dist
                │   ├── jquery.validate.unobtrusive.js
                │   └── jquery.validate.unobtrusive.min.js
            ├── jquery-validation
                ├── LICENSE.md
                └── dist
                │   ├── additional-methods.js
                │   ├── additional-methods.min.js
                │   ├── jquery.validate.js
                │   └── jquery.validate.min.js
            └── jquery
                ├── LICENSE.txt
                └── dist
                    ├── jquery.js
                    ├── jquery.min.js
                    ├── jquery.min.map
                    ├── jquery.slim.js
                    ├── jquery.slim.min.js
                    └── jquery.slim.min.map
