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


/.gitattributes:
--------------------------------------------------------------------------------
 1 | ###############################################################################
 2 | # Set default behavior to automatically normalize line endings.
 3 | ###############################################################################
 4 | * text=auto
 5 | 
 6 | ###############################################################################
 7 | # Set default behavior for command prompt diff.
 8 | #
 9 | # This is need for earlier builds of msysgit that does not have it on by
10 | # default for csharp files.
11 | # Note: This is only used by command line
12 | ###############################################################################
13 | #*.cs     diff=csharp
14 | 
15 | ###############################################################################
16 | # Set the merge driver for project and solution files
17 | #
18 | # Merging from the command prompt will add diff markers to the files if there
19 | # are conflicts (Merging from VS is not affected by the settings below, in VS
20 | # the diff markers are never inserted). Diff markers may cause the following 
21 | # file extensions to fail to load in VS. An alternative would be to treat
22 | # these files as binary and thus will always conflict and require user
23 | # intervention with every merge. To do so, just uncomment the entries below
24 | ###############################################################################
25 | #*.sln       merge=binary
26 | #*.csproj    merge=binary
27 | #*.vbproj    merge=binary
28 | #*.vcxproj   merge=binary
29 | #*.vcproj    merge=binary
30 | #*.dbproj    merge=binary
31 | #*.fsproj    merge=binary
32 | #*.lsproj    merge=binary
33 | #*.wixproj   merge=binary
34 | #*.modelproj merge=binary
35 | #*.sqlproj   merge=binary
36 | #*.wwaproj   merge=binary
37 | 
38 | ###############################################################################
39 | # behavior for image files
40 | #
41 | # image files are treated as binary by default.
42 | ###############################################################################
43 | #*.jpg   binary
44 | #*.png   binary
45 | #*.gif   binary
46 | 
47 | ###############################################################################
48 | # diff behavior for common document formats
49 | # 
50 | # Convert binary document formats to text before diffing them. This feature
51 | # is only available from the command line. Turn it on by uncommenting the 
52 | # entries below.
53 | ###############################################################################
54 | #*.doc   diff=astextplain
55 | #*.DOC   diff=astextplain
56 | #*.docx  diff=astextplain
57 | #*.DOCX  diff=astextplain
58 | #*.dot   diff=astextplain
59 | #*.DOT   diff=astextplain
60 | #*.pdf   diff=astextplain
61 | #*.PDF   diff=astextplain
62 | #*.rtf   diff=astextplain
63 | #*.RTF   diff=astextplain
64 | 


--------------------------------------------------------------------------------
/Souqna.sln:
--------------------------------------------------------------------------------
 1 | ﻿
 2 | Microsoft Visual Studio Solution File, Format Version 12.00
 3 | # Visual Studio Version 17
 4 | VisualStudioVersion = 17.14.36301.6
 5 | MinimumVisualStudioVersion = 10.0.40219.1
 6 | Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Souqna", "Souqna\Souqna.csproj", "{43E3BD4B-52AC-4F54-A142-B426B2FFD081}"
 7 | EndProject
 8 | Global
 9 | 	GlobalSection(SolutionConfigurationPlatforms) = preSolution
10 | 		Debug|Any CPU = Debug|Any CPU
11 | 		Release|Any CPU = Release|Any CPU
12 | 	EndGlobalSection
13 | 	GlobalSection(ProjectConfigurationPlatforms) = postSolution
14 | 		{43E3BD4B-52AC-4F54-A142-B426B2FFD081}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
15 | 		{43E3BD4B-52AC-4F54-A142-B426B2FFD081}.Debug|Any CPU.Build.0 = Debug|Any CPU
16 | 		{43E3BD4B-52AC-4F54-A142-B426B2FFD081}.Release|Any CPU.ActiveCfg = Release|Any CPU
17 | 		{43E3BD4B-52AC-4F54-A142-B426B2FFD081}.Release|Any CPU.Build.0 = Release|Any CPU
18 | 	EndGlobalSection
19 | 	GlobalSection(SolutionProperties) = preSolution
20 | 		HideSolutionNode = FALSE
21 | 	EndGlobalSection
22 | 	GlobalSection(ExtensibilityGlobals) = postSolution
23 | 		SolutionGuid = {D0413D98-B974-4309-93DE-AA039C21739D}
24 | 	EndGlobalSection
25 | EndGlobal
26 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/AccessDenied.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@page
 2 | @model AccessDeniedModel
 3 | @{
 4 |     ViewData["Title"] = "Access denied";
 5 | }
 6 | 
 7 | <header>
 8 |     <h1 class="text-danger">@ViewData["Title"]</h1>
 9 |     <p class="text-danger">You do not have access to this resource.</p>
10 | </header>
11 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/AccessDenied.cshtml.cs:
--------------------------------------------------------------------------------
 1 | ﻿// Licensed to the .NET Foundation under one or more agreements.
 2 | // The .NET Foundation licenses this file to you under the MIT license.
 3 | #nullable disable
 4 | 
 5 | using Microsoft.AspNetCore.Mvc.RazorPages;
 6 | 
 7 | namespace Souqna.Areas.Identity.Pages.Account
 8 | {
 9 |     /// <summary>
10 |     ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
11 |     ///     directly from your code. This API may change or be removed in future releases.
12 |     /// </summary>
13 |     public class AccessDeniedModel : PageModel
14 |     {
15 |         /// <summary>
16 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
17 |         ///     directly from your code. This API may change or be removed in future releases.
18 |         /// </summary>
19 |         public void OnGet()
20 |         {
21 |         }
22 |     }
23 | }
24 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Login.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@page
 2 | @model LoginModel
 3 | @{
 4 |     ViewData["Title"] = "تسجيل الدخول";
 5 | }
 6 | 
 7 | <div class="container mt-5 mb-5">
 8 |     <div class="row justify-content-center">
 9 |         <div class="col-md-5">
10 | 
11 |             <h2 class="text-center mb-4">@ViewData["Title"]</h2>
12 |             <hr />
13 | 
14 |             <form method="post">
15 |                 <div asp-validation-summary="ModelOnly" class="text-danger" role="alert"></div>
16 | 
17 |                 <!-- البريد الإلكتروني -->
18 |                 <div class="form-floating mb-3">
19 |                     <input asp-for="Input.Email" class="form-control" autocomplete="username" placeholder="name@example.com" />
20 |                     <label asp-for="Input.Email">البريد الإلكتروني</label>
21 |                     <span asp-validation-for="Input.Email" class="text-danger"></span>
22 |                 </div>
23 | 
24 |                 <!-- كلمة المرور -->
25 |                 <div class="form-floating mb-3">
26 |                     <input asp-for="Input.Password" class="form-control" type="password" autocomplete="current-password" placeholder="••••••" />
27 |                     <label asp-for="Input.Password">كلمة المرور</label>
28 |                     <span asp-validation-for="Input.Password" class="text-danger"></span>
29 |                 </div>
30 | 
31 |                 <!-- تذكرني -->
32 |                 <div class="form-check mb-3">
33 |                     <input class="form-check-input" asp-for="Input.RememberMe" />
34 |                     <label class="form-check-label" asp-for="Input.RememberMe">
35 |                         تذكرني
36 |                     </label>
37 |                 </div>
38 | 
39 |                 <button type="submit" class="w-100 btn btn-lg btn-primary">تسجيل الدخول</button>
40 |             </form>
41 | 
42 |             <div class="text-center mt-4">
43 |                 <a asp-page="./ForgotPassword">هل نسيت كلمة المرور؟</a><br />
44 |                 <span>ليس لديك حساب؟</span>
45 |                 <a asp-page="./Register">إنشاء حساب</a>
46 |             </div>
47 | 
48 |         </div>
49 | 
50 |         <!-- تسجيل عبر مزود خارجي -->
51 |         <div class="col-md-5 mt-5 mt-md-0">
52 |             <section>
53 |                 <h4 class="mb-3">أو استخدم خدمة خارجية</h4>
54 |                 <hr />
55 |                 @{
56 |                     if ((Model.ExternalLogins?.Count ?? 0) == 0)
57 |                     {
58 |                         <div class="alert alert-info small">
59 |                             لم يتم تفعيل تسجيل الدخول عبر مزودات خارجية (Google، Facebook، إلخ).
60 |                         </div>
61 |                     }
62 |                     else
63 |                     {
64 |                         <form asp-page="./ExternalLogin" asp-route-returnUrl="@Model.ReturnUrl" method="post">
65 |                             @foreach (var provider in Model.ExternalLogins!)
66 |                             {
67 |                                 <button type="submit" class="btn btn-outline-secondary me-2 mb-2"
68 |                                         name="provider" value="@provider.Name"
69 |                                         title="سجّل باستخدام @provider.DisplayName">
70 |                                     @provider.DisplayName
71 |                                 </button>
72 |                             }
73 |                         </form>
74 |                     }
75 |                 }
76 |             </section>
77 |         </div>
78 |     </div>
79 | </div>
80 | 
81 | @section Scripts {
82 |     <partial name="_ValidationScriptsPartial" />
83 | }
84 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Login.cshtml.cs:
--------------------------------------------------------------------------------
  1 | ﻿// Licensed to the .NET Foundation under one or more agreements.
  2 | // The .NET Foundation licenses this file to you under the MIT license.
  3 | #nullable disable
  4 | 
  5 | using System;
  6 | using System.Collections.Generic;
  7 | using System.ComponentModel.DataAnnotations;
  8 | using System.Linq;
  9 | using System.Threading.Tasks;
 10 | using Microsoft.AspNetCore.Authorization;
 11 | using Microsoft.AspNetCore.Authentication;
 12 | using Microsoft.AspNetCore.Identity;
 13 | using Microsoft.AspNetCore.Identity.UI.Services;
 14 | using Microsoft.AspNetCore.Mvc;
 15 | using Microsoft.AspNetCore.Mvc.RazorPages;
 16 | using Microsoft.Extensions.Logging;
 17 | using Souqna.Models;
 18 | 
 19 | namespace Souqna.Areas.Identity.Pages.Account
 20 | {
 21 |     public class LoginModel : PageModel
 22 |     {
 23 |         private readonly SignInManager<ApplicationUser> _signInManager;
 24 |         private readonly ILogger<LoginModel> _logger;
 25 | 
 26 |         public LoginModel(SignInManager<ApplicationUser> signInManager, ILogger<LoginModel> logger)
 27 |         {
 28 |             _signInManager = signInManager;
 29 |             _logger = logger;
 30 |         }
 31 | 
 32 |         /// <summary>
 33 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 34 |         ///     directly from your code. This API may change or be removed in future releases.
 35 |         /// </summary>
 36 |         [BindProperty]
 37 |         public InputModel Input { get; set; }
 38 | 
 39 |         /// <summary>
 40 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 41 |         ///     directly from your code. This API may change or be removed in future releases.
 42 |         /// </summary>
 43 |         public IList<AuthenticationScheme> ExternalLogins { get; set; }
 44 | 
 45 |         /// <summary>
 46 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 47 |         ///     directly from your code. This API may change or be removed in future releases.
 48 |         /// </summary>
 49 |         public string ReturnUrl { get; set; }
 50 | 
 51 |         /// <summary>
 52 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 53 |         ///     directly from your code. This API may change or be removed in future releases.
 54 |         /// </summary>
 55 |         [TempData]
 56 |         public string ErrorMessage { get; set; }
 57 | 
 58 |         /// <summary>
 59 |         ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 60 |         ///     directly from your code. This API may change or be removed in future releases.
 61 |         /// </summary>
 62 |         public class InputModel
 63 |         {
 64 |             /// <summary>
 65 |             ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 66 |             ///     directly from your code. This API may change or be removed in future releases.
 67 |             /// </summary>
 68 |             [Required]
 69 |             [EmailAddress]
 70 |             public string Email { get; set; }
 71 | 
 72 |             /// <summary>
 73 |             ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 74 |             ///     directly from your code. This API may change or be removed in future releases.
 75 |             /// </summary>
 76 |             [Required]
 77 |             [DataType(DataType.Password)]
 78 |             public string Password { get; set; }
 79 | 
 80 |             /// <summary>
 81 |             ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
 82 |             ///     directly from your code. This API may change or be removed in future releases.
 83 |             /// </summary>
 84 |             [Display(Name = "Remember me?")]
 85 |             public bool RememberMe { get; set; }
 86 |         }
 87 | 
 88 |         public async Task OnGetAsync(string returnUrl = null)
 89 |         {
 90 |             if (!string.IsNullOrEmpty(ErrorMessage))
 91 |             {
 92 |                 ModelState.AddModelError(string.Empty, ErrorMessage);
 93 |             }
 94 | 
 95 |             returnUrl ??= Url.Content("~/");
 96 | 
 97 |             // Clear the existing external cookie to ensure a clean login process
 98 |             await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
 99 | 
100 |             ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
101 | 
102 |             ReturnUrl = returnUrl;
103 |         }
104 | 
105 |         public async Task<IActionResult> OnPostAsync(string returnUrl = null)
106 |         {
107 |             returnUrl ??= Url.Content("~/");
108 | 
109 |             ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
110 | 
111 |             if (ModelState.IsValid)
112 |             {
113 |                 // This doesn't count login failures towards account lockout
114 |                 // To enable password failures to trigger account lockout, set lockoutOnFailure: true
115 |                 var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
116 |                 if (result.Succeeded)
117 |                 {
118 |                     _logger.LogInformation("User logged in.");
119 |                     return LocalRedirect(returnUrl);
120 |                 }
121 |                 if (result.RequiresTwoFactor)
122 |                 {
123 |                     return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
124 |                 }
125 |                 if (result.IsLockedOut)
126 |                 {
127 |                     _logger.LogWarning("User account locked out.");
128 |                     return RedirectToPage("./Lockout");
129 |                 }
130 |                 else
131 |                 {
132 |                     ModelState.AddModelError(string.Empty, "Invalid login attempt.");
133 |                     return Page();
134 |                 }
135 |             }
136 | 
137 |             // If we got this far, something failed, redisplay form
138 |             return Page();
139 |         }
140 |     }
141 | }
142 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Logout.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@page
 2 | @model LogoutModel
 3 | @{
 4 |     ViewData["Title"] = "Log out";
 5 | }
 6 | 
 7 | <header>
 8 |     <h1>@ViewData["Title"]</h1>
 9 |     @{
10 |         if (User.Identity?.IsAuthenticated ?? false)
11 |         {
12 |             <form class="form-inline" asp-area="Identity" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Page("/", new { area = "" })" method="post">
13 |                 <button type="submit" class="nav-link btn btn-link text-dark">Click here to Logout</button>
14 |             </form>
15 |         }
16 |         else
17 |         {
18 |             <p>You have successfully logged out of the application.</p>
19 |         }
20 |     }
21 | </header>
22 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Logout.cshtml.cs:
--------------------------------------------------------------------------------
 1 | ﻿// Licensed to the .NET Foundation under one or more agreements.
 2 | // The .NET Foundation licenses this file to you under the MIT license.
 3 | #nullable disable
 4 | 
 5 | using System;
 6 | using System.Threading.Tasks;
 7 | using Microsoft.AspNetCore.Authorization;
 8 | using Microsoft.AspNetCore.Identity;
 9 | using Microsoft.AspNetCore.Mvc;
10 | using Microsoft.AspNetCore.Mvc.RazorPages;
11 | using Microsoft.Extensions.Logging;
12 | using Souqna.Models;
13 | 
14 | namespace Souqna.Areas.Identity.Pages.Account
15 | {
16 |     public class LogoutModel : PageModel
17 |     {
18 |         private readonly SignInManager<ApplicationUser> _signInManager;
19 |         private readonly ILogger<LogoutModel> _logger;
20 | 
21 |         public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
22 |         {
23 |             _signInManager = signInManager;
24 |             _logger = logger;
25 |         }
26 | 
27 |         public async Task<IActionResult> OnPost(string returnUrl = null)
28 |         {
29 |             await _signInManager.SignOutAsync();
30 |             _logger.LogInformation("User logged out.");
31 |             if (returnUrl != null)
32 |             {
33 |                 return LocalRedirect(returnUrl);
34 |             }
35 |             else
36 |             {
37 |                 // This needs to be a redirect so that the browser performs a new
38 |                 // request and the identity for the user gets updated.
39 |                 return RedirectToPage();
40 |             }
41 |         }
42 |     }
43 | }
44 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Register.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@page
 2 | @model UsedMarket.Areas.Identity.Pages.Account.RegisterModel
 3 | @{
 4 |     ViewData["Title"] = "إنشاء حساب جديد";
 5 | }
 6 | 
 7 | <div class="container mt-5 mb-5">
 8 |     <div class="row justify-content-center">
 9 |         <div class="col-md-5">
10 | 
11 |             <h2 class="text-center mb-4">@ViewData["Title"]</h2>
12 |             <hr />
13 | 
14 |             <form id="registerForm" asp-route-returnUrl="@Model.ReturnUrl" method="post">
15 |                 <div asp-validation-summary="ModelOnly" class="text-danger" role="alert"></div>
16 | 
17 |                 <!-- الاسم الكامل -->
18 |                 <div class="form-floating mb-3">
19 |                     <input asp-for="Input.FullName" class="form-control" placeholder="الاسم الكامل" />
20 |                     <label asp-for="Input.FullName">الاسم الكامل</label>
21 |                     <span asp-validation-for="Input.FullName" class="text-danger"></span>
22 |                 </div>
23 | 
24 |                 <!-- البريد -->
25 |                 <div class="form-floating mb-3">
26 |                     <input asp-for="Input.Email" class="form-control" autocomplete="username" placeholder="name@example.com" />
27 |                     <label asp-for="Input.Email">البريد الإلكتروني</label>
28 |                     <span asp-validation-for="Input.Email" class="text-danger"></span>
29 |                 </div>
30 | 
31 |                 <!-- كلمة المرور -->
32 |                 <div class="form-floating mb-3">
33 |                     <input asp-for="Input.Password" class="form-control" type="password" autocomplete="new-password" placeholder="••••••" />
34 |                     <label asp-for="Input.Password">كلمة المرور</label>
35 |                     <span asp-validation-for="Input.Password" class="text-danger"></span>
36 |                 </div>
37 | 
38 |                 <!-- تأكيد كلمة المرور -->
39 |                 <div class="form-floating mb-3">
40 |                     <input asp-for="Input.ConfirmPassword" class="form-control" type="password" autocomplete="new-password" placeholder="••••••" />
41 |                     <label asp-for="Input.ConfirmPassword">تأكيد كلمة المرور</label>
42 |                     <span asp-validation-for="Input.ConfirmPassword" class="text-danger"></span>
43 |                 </div>
44 | 
45 |                 <button id="registerSubmit" type="submit" class="w-100 btn btn-lg btn-warning">إنشاء حساب</button>
46 |             </form>
47 | 
48 |             <div class="text-center mt-3">
49 |                 <span>لديك حساب؟</span>
50 |                 <a asp-area="Identity" asp-page="/Account/Login">تسجيل الدخول</a>
51 |             </div>
52 | 
53 |         </div>
54 | 
55 |         <!-- التسجيل عبر خدمات خارجية -->
56 |         <div class="col-md-5 mt-5 mt-md-0">
57 |             <section>
58 |                 <h4 class="mb-3">أو استخدم خدمة خارجية</h4>
59 |                 <hr />
60 |                 @{
61 |                     if ((Model.ExternalLogins?.Count ?? 0) == 0)
62 |                     {
63 |                         <div class="alert alert-info small">
64 |                             لم يتم تكوين أي مزوّد تسجيل خارجي (Google، Facebook، ...).
65 |                         </div>
66 |                     }
67 |                     else
68 |                     {
69 |                         <form id="external-account" asp-page="./ExternalLogin" asp-route-returnUrl="@Model.ReturnUrl" method="post">
70 |                             @foreach (var provider in Model.ExternalLogins!)
71 |                             {
72 |                                 <button type="submit" class="btn btn-outline-secondary me-2 mb-2"
73 |                                         name="provider" value="@provider.Name"
74 |                                         title="سجّل عبر @provider.DisplayName">
75 |                                     @provider.DisplayName
76 |                                 </button>
77 |                             }
78 |                         </form>
79 |                     }
80 |                 }
81 |             </section>
82 |         </div>
83 |     </div>
84 | </div>
85 | 
86 | @section Scripts {
87 |     <partial name="_ValidationScriptsPartial" />
88 | }
89 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/Register.cshtml.cs:
--------------------------------------------------------------------------------
  1 | ﻿// Licensed to the .NET Foundation under one or more agreements.
  2 | // The .NET Foundation licenses this file to you under the MIT license.
  3 | #nullable disable
  4 | 
  5 | using System.ComponentModel.DataAnnotations;
  6 | using System.Text;
  7 | using System.Text.Encodings.Web;
  8 | using System.Threading;
  9 | using System.Threading.Tasks;
 10 | using Microsoft.AspNetCore.Authentication;
 11 | using Microsoft.AspNetCore.Authorization;
 12 | using Microsoft.AspNetCore.Identity;
 13 | using Microsoft.AspNetCore.Identity.UI.Services;
 14 | using Microsoft.AspNetCore.Mvc;
 15 | using Microsoft.AspNetCore.Mvc.RazorPages;
 16 | using Microsoft.AspNetCore.WebUtilities;
 17 | using Microsoft.Extensions.Logging;
 18 | using Souqna.Models;
 19 | 
 20 | namespace UsedMarket.Areas.Identity.Pages.Account   // 👈 غيّرنا الـ namespace ليتطابق مع مشروعك
 21 | {
 22 |     [AllowAnonymous]
 23 |     public class RegisterModel : PageModel
 24 |     {
 25 |         private readonly SignInManager<ApplicationUser> _signInManager;
 26 |         private readonly UserManager<ApplicationUser> _userManager;
 27 |         private readonly IUserStore<ApplicationUser> _userStore;
 28 |         private readonly IUserEmailStore<ApplicationUser> _emailStore;
 29 |         private readonly ILogger<RegisterModel> _logger;
 30 |         private readonly IEmailSender _emailSender;
 31 |         private readonly RoleManager<IdentityRole> _roleManager;
 32 | 
 33 |         public RegisterModel(
 34 |             UserManager<ApplicationUser> userManager,
 35 |             IUserStore<ApplicationUser> userStore,
 36 |             SignInManager<ApplicationUser> signInManager,
 37 |             ILogger<RegisterModel> logger,
 38 |             IEmailSender emailSender,
 39 |             RoleManager<IdentityRole> roleManager)
 40 |         {
 41 |             _userManager = userManager;
 42 |             _userStore = userStore;
 43 |             _emailStore = GetEmailStore();
 44 |             _signInManager = signInManager;
 45 |             _logger = logger;
 46 |             _emailSender = emailSender;
 47 |             _roleManager = roleManager;
 48 |         }
 49 | 
 50 |         [BindProperty]
 51 |         public InputModel Input { get; set; }
 52 | 
 53 |         public string ReturnUrl { get; set; }
 54 | 
 55 |         public IList<AuthenticationScheme> ExternalLogins { get; set; }
 56 | 
 57 |         // === النموذج المعروض في صفحة التسجيل ===
 58 |         public class InputModel
 59 |         {
 60 |             [Required]
 61 |             [Display(Name = "الاسم الكامل")]
 62 |             public string FullName { get; set; }
 63 | 
 64 |             [Required]
 65 |             [EmailAddress]
 66 |             [Display(Name = "البريد الإلكتروني")]
 67 |             public string Email { get; set; }
 68 | 
 69 |             [Required]
 70 |             [StringLength(100, ErrorMessage = "{0} يجب أن يكون بين {2} و {1} حرف.", MinimumLength = 6)]
 71 |             [DataType(DataType.Password)]
 72 |             [Display(Name = "كلمة المرور")]
 73 |             public string Password { get; set; }
 74 | 
 75 |             [DataType(DataType.Password)]
 76 |             [Display(Name = "تأكيد كلمة المرور")]
 77 |             [Compare("Password", ErrorMessage = "كلمة المرور وتأكيدها غير متطابقين.")]
 78 |             public string ConfirmPassword { get; set; }
 79 |         }
 80 | 
 81 |         // GET
 82 |         public async Task OnGetAsync(string returnUrl = null)
 83 |         {
 84 |             ReturnUrl = returnUrl;
 85 |             ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
 86 |         }
 87 | 
 88 |         // POST
 89 |         public async Task<IActionResult> OnPostAsync(string returnUrl = null)
 90 |         {
 91 |             returnUrl ??= Url.Content("~/");
 92 |             ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
 93 | 
 94 |             if (ModelState.IsValid)
 95 |             {
 96 |                 var user = CreateUser();
 97 | 
 98 |                 // تعبئة البيانات
 99 |                 user.FullName = Input.FullName;
100 |                 user.Role = "User"; // 👈 تعيين الدور تلقائيًا
101 |                 await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
102 |                 await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
103 | 
104 |                 var result = await _userManager.CreateAsync(user, Input.Password);
105 | 
106 |                 if (result.Succeeded)
107 |                 {
108 |                     _logger.LogInformation("تم إنشاء حساب مستخدم جديد.");
109 | 
110 |                     // تأكد أن دور User موجود
111 |                     if (!await _roleManager.RoleExistsAsync("User"))
112 |                     {
113 |                         await _roleManager.CreateAsync(new IdentityRole("User"));
114 |                     }
115 | 
116 |                     // ربط المستخدم بالدور
117 |                     await _userManager.AddToRoleAsync(user, "User");
118 | 
119 |                     // تأكيد البريد الإلكتروني (إذا مفعل)
120 |                     var userId = await _userManager.GetUserIdAsync(user);
121 |                     var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
122 |                     code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
123 |                     var callbackUrl = Url.Page(
124 |                         "/Account/ConfirmEmail",
125 |                         pageHandler: null,
126 |                         values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
127 |                         protocol: Request.Scheme);
128 | 
129 |                     await _emailSender.SendEmailAsync(Input.Email, "تأكيد الحساب",
130 |                         
quot;يرجى تأكيد حسابك من خلال <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>هذا الرابط</a>.");
131 | 
132 |                     if (_userManager.Options.SignIn.RequireConfirmedAccount)
133 |                     {
134 |                         return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
135 |                     }
136 |                     else
137 |                     {
138 |                         await _signInManager.SignInAsync(user, isPersistent: false);
139 |                         return LocalRedirect(returnUrl);
140 |                     }
141 |                 }
142 | 
143 |                 // عند وجود أخطاء من Identity
144 |                 foreach (var error in result.Errors)
145 |                 {
146 |                     ModelState.AddModelError(string.Empty, error.Description);
147 |                 }
148 |             }
149 | 
150 |             // إعادة عرض الصفحة بالأخطاء
151 |             return Page();
152 |         }
153 | 
154 |         private ApplicationUser CreateUser()
155 |         {
156 |             try
157 |             {
158 |                 return Activator.CreateInstance<ApplicationUser>();
159 |             }
160 |             catch
161 |             {
162 |                 throw new InvalidOperationException(
quot;تعذر إنشاء نسخة من '{nameof(ApplicationUser)}'. تأكد أنه ليس abstract وله مُنشئ عام بدون وسيطات.");
163 |             }
164 |         }
165 | 
166 |         private IUserEmailStore<ApplicationUser> GetEmailStore()
167 |         {
168 |             if (!_userManager.SupportsUserEmail)
169 |             {
170 |                 throw new NotSupportedException("واجهة المستخدم الافتراضية تتطلب متجر مستخدم يدعم البريد الإلكتروني.");
171 |             }
172 |             return (IUserEmailStore<ApplicationUser>)_userStore;
173 |         }
174 |     }
175 | }
176 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/Account/_ViewImports.cshtml:
--------------------------------------------------------------------------------
1 | ﻿@using Souqna.Areas.Identity.Pages.Account


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/_ValidationScriptsPartial.cshtml:
--------------------------------------------------------------------------------
1 | ﻿<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
2 | <script src="~/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>
3 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/_ViewImports.cshtml:
--------------------------------------------------------------------------------
1 | ﻿@using Microsoft.AspNetCore.Identity
2 | @using Souqna.Areas.Identity
3 | @using Souqna.Areas.Identity.Pages
4 | @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
5 | @using Souqna.Models
6 | 


--------------------------------------------------------------------------------
/Souqna/Areas/Identity/Pages/_ViewStart.cshtml:
--------------------------------------------------------------------------------
1 | ﻿
2 | @{
3 |     Layout = "/Views/Shared/_Layout.cshtml";
4 | }
5 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/AdminOrdersController .cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Authorization;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Souqna.Data;
 4 | using Souqna.Data.Repositories;
 5 | 
 6 | namespace Souqna.Controllers
 7 | {
 8 |     [Authorize(Roles = "Admin")]
 9 |     public class AdminOrdersController : Controller
10 |     {
11 |         private readonly UnitOfWork _unitOfWork;
12 | 
13 |         public AdminOrdersController(UnitOfWork unitOfWork)
14 |         {
15 |             _unitOfWork = unitOfWork;
16 |         }
17 | 
18 |         public async Task<IActionResult> Index()
19 |         {
20 |             // جلب جميع الطلبات (لأن الدور Admin)
21 |             var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
22 |             return View(orders);
23 |         }
24 |         // 📌 تفاصيل طلب
25 |         public async Task<IActionResult> Details(Guid id)//يجلب تفاصيل طلب معين
26 |         {
27 |             var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
28 |             var order = orders.FirstOrDefault(o => o.OrderId == id);
29 | 
30 |             if (order == null)
31 |                 return NotFound();
32 | 
33 |             return View(order);
34 |         }
35 | 
36 |         // 📌 حذف طلب (عرض تأكيد الحذف)
37 |         public async Task<IActionResult> Delete(Guid id)//يجلب طلب معين للحذف
38 |         {
39 |             var orders = await _unitOfWork.Orders.GetOrdersByUserIdAndRoleAsync("", "Admin");
40 |             var order = orders.FirstOrDefault(o => o.OrderId == id);
41 | 
42 |             if (order == null)
43 |                 return NotFound();
44 | 
45 |             return View(order);
46 |         }
47 | 
48 |         // 📌 تنفيذ الحذف
49 |         [HttpPost, ActionName("Delete")]
50 |         [ValidateAntiForgeryToken]
51 |         public async Task<IActionResult> DeleteConfirmed(Guid id)// تنفيذ حذف الطلب
52 |         {
53 |             await _unitOfWork.Orders.DeleteAsync(id);
54 |             return RedirectToAction(nameof(Index));
55 |         }
56 | 
57 |     }
58 | 
59 | 
60 | }
61 | 
62 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/AdminProductsController.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Authorization;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Souqna.Data.Repositories;
 4 | using Souqna.Services.Notifications; // عشان نستخدم الإشعارات
 5 | 
 6 | namespace Souqna.Controllers
 7 | {
 8 |     [Authorize(Roles = "Admin")]
 9 |     public class AdminProductsController : Controller
10 |     {
11 |         private readonly UnitOfWork _unitOfWork;
12 |         private readonly INotificationService _notificationService;
13 | 
14 |         public AdminProductsController(UnitOfWork unitOfWork, INotificationService notificationService)
15 |         {
16 |             _unitOfWork = unitOfWork;
17 |             _notificationService = notificationService;
18 |         }
19 | 
20 |         // 📌 المنتجات التي بانتظار الموافقة
21 |         public async Task<IActionResult> PendingProducts()
22 |         {
23 |             var products = await _unitOfWork.Products.GetAllAsync();
24 |             var pending = products.Where(p => !p.IsApproved).ToList();
25 |             return View(pending);
26 |         }
27 | 
28 |         // 📌 الموافقة على منتج
29 |         public async Task<IActionResult> Approve(Guid id)
30 |         {
31 |             var product = await _unitOfWork.Products.GetByIdAsync(id);
32 |             if (product == null) return NotFound();
33 | 
34 |             product.IsApproved = true;
35 |             _unitOfWork.Products.Update(product);
36 |             await _unitOfWork.SaveAsync();
37 | 
38 |             // إشعار للمستخدم
39 |             await _notificationService.NotifyUserAsync(
40 |                 product.UserId,
41 |                 
quot;✅ تمت الموافقة على منتجك: {product.Name}",
42 |                 Url.Action("Details", "Product", new { id = product.ProductId })
43 |             );
44 | 
45 |             TempData["Success"] = "تمت الموافقة على المنتج بنجاح ✅";
46 |             return RedirectToAction(nameof(PendingProducts));
47 |         }
48 | 
49 |         // 📌 رفض منتج (حذفه مثلاً)
50 |         public async Task<IActionResult> Reject(Guid id)
51 |         {
52 |             var product = await _unitOfWork.Products.GetByIdAsync(id);
53 |             if (product == null) return NotFound();
54 | 
55 |             await _unitOfWork.Products.DeleteAsync(id);
56 | 
57 |             // إشعار للمستخدم
58 |             await _notificationService.NotifyUserAsync(product.UserId, 
quot;❌ تم رفض منتجك: {product.Name}");
59 | 
60 |             TempData["Error"] = "تم رفض المنتج ❌";
61 |             return RedirectToAction(nameof(PendingProducts));
62 |         }
63 |     }
64 | }
65 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/AdminReviewsController.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Authorization;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Souqna.Data.Repositories;
 4 | using Souqna.Models;
 5 | 
 6 | namespace Souqna.Controllers
 7 | {
 8 |     [Authorize(Roles = "Admin")]
 9 |     public class AdminReviewsController : Controller
10 |     {
11 |         private readonly UnitOfWork _unitOfWork;
12 | 
13 |         public AdminReviewsController(UnitOfWork unitOfWork)
14 |         {
15 |             _unitOfWork = unitOfWork;
16 |         }
17 | 
18 |         // 📌 عرض جميع الآراء
19 |         public async Task<IActionResult> Index()
20 |         {
21 |             var reviews = await _unitOfWork.Reviews.GetAllAsync();
22 |             return View(reviews);
23 |         }
24 | 
25 |         // 📌 الموافقة على رأي
26 |         public async Task<IActionResult> Approve(int id)
27 |         {
28 |             var review = await _unitOfWork.Reviews.GetByIdAsync(id);
29 |             if (review == null) return NotFound();
30 | 
31 |             review.IsApproved = true;
32 |             await _unitOfWork.Reviews.UpdateAsync(review);
33 | 
34 |             return RedirectToAction(nameof(Index));
35 |         }
36 | 
37 |         // 📌 حذف رأي
38 |         public async Task<IActionResult> Delete(int id)
39 |         {
40 |             var review = await _unitOfWork.Reviews.GetByIdAsync(id);
41 |             if (review == null) return NotFound();
42 | 
43 |             return View(review); // صفحة تأكيد الحذف
44 |         }
45 | 
46 |         [HttpPost, ActionName("Delete")]
47 |         [ValidateAntiForgeryToken]
48 |         public async Task<IActionResult> DeleteConfirmed(int id)
49 |         {
50 |             await _unitOfWork.Reviews.DeleteAsync(id);
51 |             return RedirectToAction(nameof(Index));
52 |         }
53 |       
54 | 
55 |     }
56 | }
57 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/CartController.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Identity;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Microsoft.EntityFrameworkCore;
 4 | using Souqna.Data;
 5 | using Souqna.Data.Cart;
 6 | using Souqna.Data.ViewModels;
 7 | using Souqna.Models;
 8 | using System.Security.Claims;
 9 | 
10 | namespace Souqna.Controllers
11 | {
12 |     public class CartController : Controller
13 |     {
14 |         private readonly UserManager<ApplicationUser> userManager;
15 | 
16 |         private readonly ShoppingCart _shoppingCart;
17 |         private readonly ApplicationDbContext context;
18 | 
19 |         public CartController(UserManager<ApplicationUser> userManager ,ShoppingCart shoppingCart, ApplicationDbContext context)
20 |         {
21 |             this.userManager = userManager;
22 | 
23 |             _shoppingCart = shoppingCart;
24 |             this.context = context;
25 | 
26 |         }
27 | 
28 |         // يرجع العدد في Json (عشان نستخدمه في الـ badge)
29 |         public IActionResult CartCount()
30 |         {
31 |             var count = _shoppingCart.GetShoppingCartCount();
32 |             return Json(count);
33 |         }
34 | 
35 |         // صفحة السلة نفسها
36 |         public IActionResult Index()
37 |         {
38 |             var items = _shoppingCart.GetShoppingCartItems();
39 |             return View(items);
40 |         }
41 |         public async Task<IActionResult> MyAccount()
42 |         {
43 |             var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
44 | 
45 |             var vm = new MyAccountVM
46 |             {
47 |                 // 🛒 المنتجات في السلة
48 |                 CartItems = await context.ShoppingCartItems
49 |                     .Include(c => c.Product)
50 |                     .Where(c => c.ShoppingCartId == _shoppingCart.ShoppingCartId)
51 |                     .ToListAsync(),
52 | 
53 |                 // ✅ المنتجات التي اشتراها المستخدم
54 |                 PurchasedProducts = await context.OrderItems
55 |                     .Include(oi => oi.product)
56 |                     .Where(oi => oi.order.UserId == userId)
57 |                     .ToListAsync(),
58 | 
59 | 
60 |                 // 🏷️ المنتجات المعروضة للبيع
61 |                 SoldProducts = await context.Products
62 |                     .Where(p => p.UserId == userId)
63 |                     .OrderBy(p => p.Name) // ✅ OrderBy
64 |                     .ToListAsync()
65 |             };
66 | 
67 |             return View(vm);
68 |         }
69 | 
70 |         public async Task<IActionResult> CartInfo()
71 |         {
72 |             var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
73 | 
74 |             var purchasedCount = await context.OrderItems
75 |                 .Include(oi => oi.order)
76 |                 .Where(oi => oi.order.UserId == userId)
77 |                 .CountAsync();
78 | 
79 |             var soldCount = await context.Products
80 |                 .Where(p => p.UserId == userId)
81 |                 .CountAsync();
82 | 
83 |             // إذا أردت جلب المنتجات المباعة مع ترتيب
84 |             var soldProducts = await context.Products
85 |                 .Where(p => p.UserId == userId)
86 |                 .OrderBy(p => p.Name) // ترتيب بالاسم كمثال
87 |                 .ToListAsync();
88 | 
89 |             return Json(new { purchased = purchasedCount, sold = soldCount, soldProducts });
90 |         }
91 | 
92 | 
93 | 
94 | 
95 | 
96 |     }
97 | }
98 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/HomeController.cs:
--------------------------------------------------------------------------------
  1 | ﻿using Microsoft.AspNetCore.Mvc;
  2 | using Microsoft.EntityFrameworkCore;
  3 | using Souqna.Data;
  4 | using Souqna.Data.Enums;
  5 | using Souqna.Data.Repositories;
  6 | using Souqna.Data.ViewModels;
  7 | using Souqna.Models;
  8 | using System.Diagnostics;
  9 | 
 10 | namespace Souqna.Controllers
 11 | {
 12 |     public class HomeController : Controller
 13 |     {
 14 |         private readonly ILogger<HomeController> _logger;
 15 |         private readonly IProductRepository _productRepository;
 16 |         private readonly ApplicationDbContext _context;
 17 | 
 18 |         public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, ApplicationDbContext context)
 19 |         {
 20 |             _logger = logger;
 21 |             _productRepository = productRepository;
 22 |             _context = context;
 23 |         }
 24 | 
 25 |         public async Task<IActionResult> Index()
 26 |         {
 27 |             var products = await _productRepository.GetAllApprovedAsync();//المنتجات الموافق عليها
 28 | 
 29 |             var categories = Enum.GetValues(typeof(ProductEnums.ProductCategory))
 30 |                 .Cast<ProductEnums.ProductCategory>()
 31 |                 .Select(c => new CategoryVM
 32 |                 {
 33 |                     Name = c.ToString(),
 34 |                     Icon = GetCategoryIcon(c),
 35 |                     Products = products.Where(p => p.Category == c)
 36 |                 }).ToList();
 37 | 
 38 | 
 39 | 
 40 | 
 41 |             //   ********************************** جلب اخر 6 اراء  **********************************
 42 |             //   
 43 |             //
 44 |             var reviews = await _context.Reviews
 45 |                 .Include(r => r.User) // جلب بيانات المستخدم
 46 |                 .Where(r => r.IsApproved)
 47 |                 .OrderByDescending(r => r.CreatedAt)
 48 |                 .Take(6)
 49 |                 .ToListAsync();
 50 | 
 51 | 
 52 |             var viewModel = new HomeVM
 53 |             {
 54 |                 Categories = categories,
 55 |                 LatestProducts = products.OrderByDescending(p => p.CreatedAt).Take(6),
 56 |                 Reviews = reviews
 57 |             };
 58 | 
 59 |             return View(viewModel);
 60 |         }
 61 | 
 62 |         [HttpPost]
 63 |         public async Task<IActionResult> SendReview(Review review)
 64 |         {
 65 |             if (!ModelState.IsValid) return View(review);
 66 | 
 67 |             // 🔹 ربط المراجعة بالمستخدم الحالي
 68 |             var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
 69 |             if (userId != null)
 70 |             {
 71 |                 review.UserId = userId;
 72 |             }
 73 | 
 74 |             review.CreatedAt = DateTime.Now;
 75 |             review.IsApproved = false;
 76 | 
 77 |             _context.Reviews.Add(review);
 78 |             await _context.SaveChangesAsync();
 79 | 
 80 |             TempData["Success"] = "تم إرسال رأيك بنجاح";
 81 |             return RedirectToAction("Index");
 82 |         }
 83 | 
 84 | 
 85 |         [Route("details/{ProductId:guid}")]
 86 |         public async Task<IActionResult> Details(Guid ProductId)
 87 |         {
 88 |             if (!ModelState.IsValid) return BadRequest(ModelState);
 89 | 
 90 |             var product = await _productRepository.GetByIdAsync(ProductId);
 91 |             if (product == null) return NotFound();
 92 | 
 93 |             return View(product);
 94 |         }
 95 | 
 96 |         public IActionResult Privacy() => View();
 97 | 
 98 |         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
 99 |         public IActionResult Error()
100 |         {
101 |             return View(new ErrorViewModel
102 |             {
103 |                 RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
104 |             });
105 |         }
106 | 
107 |         private string GetCategoryIcon(ProductEnums.ProductCategory category)
108 |         {
109 |             return category switch
110 |             {
111 |                 ProductEnums.ProductCategory.Electronics => "bi-laptop",
112 |                 ProductEnums.ProductCategory.Clothing => "bi-shop",
113 |                 ProductEnums.ProductCategory.Vihicles => "bi-car-front",
114 |                 ProductEnums.ProductCategory.Jewelry => "bi-gem",
115 |                 ProductEnums.ProductCategory.HealthAndPersonalCare => "bi-heart-pulse",
116 |                 ProductEnums.ProductCategory.technology => "bi-cpu",
117 |                 ProductEnums.ProductCategory.Books => "bi-book",
118 |                 ProductEnums.ProductCategory.BeautyProducts => "bi-brush",
119 |                 ProductEnums.ProductCategory.SportsEquipment => "bi-basket",
120 |                 ProductEnums.ProductCategory.Toys => "bi-joystick",
121 |                 ProductEnums.ProductCategory.Furniture => "bi-house",
122 |                 _ => "bi-box"
123 |             };
124 |         }
125 | 
126 |         [HttpGet]
127 |         public async Task<IActionResult> ProductSearch(string Sname)
128 |         {
129 |             var products = string.IsNullOrWhiteSpace(Sname)
130 |                 ? await _productRepository.GetAllAsync()
131 |                 : await _productRepository.SearchAsync(Sname);
132 | 
133 |             if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
134 |                 return PartialView("_ProductsPartial", products);
135 | 
136 |             var categories = Enum.GetValues(typeof(ProductEnums.ProductCategory))
137 |                 .Cast<ProductEnums.ProductCategory>()
138 |                 .Select(c => new CategoryVM
139 |                 {
140 |                     Name = c.ToString(),
141 |                     Icon = GetCategoryIcon(c),
142 |                     Products = products.Where(p => p.Category == c)
143 |                 }).ToList();
144 | 
145 |             var vm = new HomeVM { LatestProducts = products, Categories = categories };
146 |             return View("Index", vm);
147 |         }
148 |     }
149 | }
150 | 


--------------------------------------------------------------------------------
/Souqna/Controllers/NotificationsController .cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Identity;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Souqna.Data;
 4 | using Souqna.Models;
 5 | 
 6 | namespace Souqna.Controllers
 7 | {
 8 |     public class NotificationsController : Controller
 9 |     {
10 |         private readonly ApplicationDbContext _context;
11 |         private readonly UserManager<ApplicationUser> _userManager;
12 | 
13 |         public NotificationsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
14 |         {
15 |             _context = context;
16 |             _userManager = userManager;
17 |         }
18 | 
19 |         public async Task<IActionResult> MyNotifications()//
20 |         {
21 |             var user = await _userManager.GetUserAsync(User);
22 |             var notifications = _context.Notifications
23 |                 .Where(n => n.UserId == user.Id)
24 |                 .OrderByDescending(n => n.CreatedAt)
25 |                 .ToList();
26 | 
27 |             return View(notifications);
28 |         }
29 |         public async Task<IActionResult> ReadNotification(int id)
30 |         {
31 |             var user = await _userManager.GetUserAsync(User);
32 |             var notification = await _context.Notifications.FindAsync(id);
33 | 
34 |             if (notification == null || notification.UserId != user.Id)
35 |                 return NotFound();
36 | 
37 |             // تغيير الحالة إلى مقروء
38 |             notification.IsRead = true;
39 |             await _context.SaveChangesAsync();
40 | 
41 |             // إعادة التوجيه إلى الرابط الخاص بالإشعار
42 |             if (!string.IsNullOrEmpty(notification.Url))
43 |                 return Redirect(notification.Url);
44 | 
45 |             return RedirectToAction("MyNotifications");
46 |         }
47 |         [HttpGet]
48 |         public async Task<IActionResult> UnreadCount()
49 |         {
50 |             var user = await _userManager.GetUserAsync(User);
51 |             if (user == null)
52 |                 return Json(new { count = 0 });
53 | 
54 |             var count = _context.Notifications.Count(n => n.UserId == user.Id && !n.IsRead);
55 |             return Json(new { count });
56 |         }
57 |         public async Task<IActionResult> OpenNotification(int id)
58 |         {
59 |             var user = await _userManager.GetUserAsync(User);
60 |             var notification = await _context.Notifications.FindAsync(id);
61 | 
62 |             if (notification == null || notification.UserId != user.Id)
63 |                 return NotFound();
64 | 
65 |             notification.IsRead = true;
66 |             _context.Update(notification);
67 |             await _context.SaveChangesAsync();
68 | 
69 |             // التوجيه للرابط المخزن في Url
70 |             return Redirect(notification.Url ?? "/");
71 |         }
72 | 
73 | 
74 |     }
75 | 
76 | }
77 | 


--------------------------------------------------------------------------------
/Souqna/Data/Attributes/CollectionLengthAttribute.cs:
--------------------------------------------------------------------------------
 1 | using System;
 2 | using System.Collections;
 3 | using System.ComponentModel.DataAnnotations;
 4 | 
 5 | namespace Souqna.Data.Attributes
 6 | {
 7 |     [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
 8 |     public class CollectionLengthAttribute : ValidationAttribute
 9 |     {
10 |         private readonly int _maxLength;
11 |         private readonly int _minLength;
12 | 
13 |         public CollectionLengthAttribute(int minLength, int maxLength)
14 |         {
15 |             _maxLength = maxLength;
16 |             _minLength = minLength;
17 |             ErrorMessage = 
quot;The maximum allowed number of items is {_maxLength}.";
18 |         }
19 | 
20 |         public override bool IsValid(object value)
21 |         {
22 |             if (value is ICollection collection)
23 |             {
24 |                 if (collection.Count < _minLength)
25 |                 {
26 |                     ErrorMessage = 
quot;The minimum required number of images is {_minLength}.";
27 |                     return false; // Not enough items
28 |                 }
29 |                 return collection.Count <= _maxLength;
30 |             }
31 |             return true; // Not a collection, so ignore
32 |         }
33 |     }
34 | }


--------------------------------------------------------------------------------
/Souqna/Data/Attributes/Min18YearsOldAttribute.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System.ComponentModel.DataAnnotations;
 2 | 
 3 | namespace Souqna.Data.Attributes
 4 | {
 5 |     public class Min18YearsOldAttribute : ValidationAttribute
 6 |     {
 7 |         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
 8 |         {
 9 |             if (value is DateOnly birthday)
10 |             {
11 |                 var today = DateOnly.FromDateTime(DateTime.Today);
12 |                 var age = today.Year - birthday.Year;
13 |                 if (birthday > today.AddYears(-age)) age--;
14 |                 if (age < 18)
15 |                 {
16 |                     return new ValidationResult(ErrorMessage ?? "You must be at least 18 years old");
17 |                 }
18 |             }
19 |             return ValidationResult.Success;
20 |         }
21 |     }
22 | }
23 | 


--------------------------------------------------------------------------------
/Souqna/Data/Cart/ShoppingCart.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore;
 2 | using Souqna.Models;
 3 | 
 4 | namespace Souqna.Data.Cart
 5 | {
 6 |     public class ShoppingCart
 7 |     {
 8 |         public ApplicationDbContext _context { get; set; }
 9 | 
10 |         public string ShoppingCartId { get; set; }
11 |         public List<ShoppingCartItem> ShoppingCartItems { get; set; }
12 | 
13 |         public ShoppingCart(ApplicationDbContext context)
14 |         {
15 |             _context = context;
16 |         }
17 | 
18 |         public static ShoppingCart GetShoppingCart(IServiceProvider services)
19 |         {
20 |             ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
21 |             var context = services.GetService<ApplicationDbContext>();
22 | 
23 |             string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
24 |             session.SetString("CartId", cartId);
25 | 
26 |             return new ShoppingCart(context) { ShoppingCartId = cartId };
27 |         }
28 | 
29 |         public void AddItemToCart(Product product, int quantity)
30 |         {
31 |             var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Product.ProductId == product.ProductId && n.ShoppingCartId == ShoppingCartId);
32 | 
33 |             if (shoppingCartItem == null)
34 |             {
35 |                 shoppingCartItem = new ShoppingCartItem()
36 |                 {
37 |                     ShoppingCartId = ShoppingCartId,
38 |                     Product = product,
39 |                     Amount = quantity
40 |                 };
41 | 
42 |                 _context.ShoppingCartItems.Add(shoppingCartItem);
43 |             }
44 |             else
45 |             {
46 |                 shoppingCartItem.Amount++;
47 |             }
48 |             _context.SaveChanges();
49 |         }
50 | 
51 |         public void RemoveItemFromCart(Product product, bool removeAll)
52 |         {
53 |             var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Product.ProductId == product.ProductId && n.ShoppingCartId == ShoppingCartId);
54 | 
55 |             if (shoppingCartItem != null)
56 |             {
57 |                 if (removeAll)
58 |                 {
59 |                     _context.ShoppingCartItems.Remove(shoppingCartItem);
60 |                 }
61 |                 else
62 |                 {
63 |                     if (shoppingCartItem.Amount > 1)
64 |                     {
65 |                         shoppingCartItem.Amount--;
66 |                     }
67 |                     else
68 |                     {
69 |                         _context.ShoppingCartItems.Remove(shoppingCartItem);
70 |                     }
71 |                 }
72 |             }
73 |             _context.SaveChanges();
74 |         }
75 | 
76 |         public List<ShoppingCartItem> GetShoppingCartItems()
77 |         {
78 |             return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Include(n => n.Product).ToList());
79 |         }
80 | 
81 |         public double GetShoppingCartTotal() => _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).Select(n => n.Product.PriceOfUnit * n.Amount).Sum();
82 | 
83 |         public async Task ClearShoppingCartAsync()
84 |         {
85 |             var items = await _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
86 |             _context.ShoppingCartItems.RemoveRange(items);
87 |             await _context.SaveChangesAsync();
88 |         }
89 |         public int GetShoppingCartCount()
90 |         {
91 |             return _context.ShoppingCartItems
92 |                 .Where(n => n.ShoppingCartId == ShoppingCartId)
93 |                 .Select(n => n.Amount)
94 |                 .Sum();
95 |         }
96 | 
97 |     }
98 | }
99 | 


--------------------------------------------------------------------------------
/Souqna/Data/Components/ProductListViewComponent.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Mvc;
 2 | using Souqna.Data.Repositories;
 3 | 
 4 | namespace Souqna.Components
 5 | {
 6 |     public class ProductListViewComponent : ViewComponent
 7 |     {
 8 |         private readonly IProductRepository repository;
 9 | 
10 |         public ProductListViewComponent(IProductRepository repository)
11 |         {
12 |             this.repository = repository;
13 |         }
14 |         public async Task<IViewComponentResult> InvokeAsync()
15 |         {
16 |             var Products = await repository.GetAllAsync();
17 |             return await Task.FromResult<IViewComponentResult>(View(Products));
18 |         }
19 |     }
20 | }
21 | 


--------------------------------------------------------------------------------
/Souqna/Data/Enums/ProductEnums.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System.ComponentModel.DataAnnotations;
 2 | 
 3 | namespace Souqna.Data.Enums
 4 | {
 5 |     public class ProductEnums
 6 |     {
 7 |         public enum ProductCategory
 8 |         {
 9 |             Electronics,
10 |             Clothing,
11 |             Vihicles,
12 |             Jewelry,
13 |             HealthAndPersonalCare,
14 |             technology,
15 |             Books,
16 |             BeautyProducts,
17 |             SportsEquipment,
18 |             Toys,
19 |             Furniture
20 |         }
21 |         public enum UnitOfMeasurement
22 |         {
23 |             [Display(Name = "قطعة")]
24 |             Piece,
25 |             [Display(Name = "كيلوجرام")]
26 |             Kilogram,
27 |             [Display(Name = "لتر")]
28 |             Liter,
29 |             [Display(Name = "متر")]
30 |             Meter
31 |         }
32 |     }
33 | }
34 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/GenericRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore;
 2 | 
 3 | namespace Souqna.Data.Repositories
 4 | {
 5 |     public class GenericRepository<T> : IRepository<T> where T : class
 6 |     {
 7 |         public readonly ApplicationDbContext context;
 8 | 
 9 |         public GenericRepository(ApplicationDbContext context)
10 |         {
11 |             this.context = context;
12 |         }
13 |         public async Task<T> AddAsync(T entity)
14 |         {
15 |             var newEntity = await context.AddAsync(entity);
16 |             await context.SaveChangesAsync();
17 |             return newEntity.Entity;
18 |         }
19 | 
20 |         public async Task<T>? GetByIdAsync(Guid id)
21 |         {
22 |             return await context.FindAsync<T>(id);
23 |         }
24 | 
25 |         public async Task<List<T>> GetAllAsync()
26 |         {
27 |             return await context.Set<T>().ToListAsync();
28 |         }
29 |         public T Update(T entity)
30 |         {
31 |             var UpdatedEntity = context.Update(entity).Entity;
32 |             context.SaveChanges();
33 |             return UpdatedEntity;
34 |         }
35 |         public async Task DeleteAsync(Guid id)
36 |         {
37 |             var entity = await context.FindAsync<T>(id);
38 |             if (entity != null)
39 |             {
40 |                 context.Remove(entity);
41 |                 await context.SaveChangesAsync();
42 |             }
43 |         }
44 | 
45 |     }
46 | }
47 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IOrdersRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Data.ViewModels;
 2 | using Souqna.Models;
 3 | using Souqna.Services;
 4 | using System;
 5 | using System.Collections.Generic;
 6 | using System.Linq;
 7 | using System.Threading.Tasks;
 8 | 
 9 | namespace Souqna.Data.Services
10 | {
11 |     public interface IOrdersRepository
12 |     {
13 |         Task StoreOrderAsync(List<ShoppingCartItem> items, string userId);// تقوم بتخزين الطلبية في قاعدة البيانات
14 |         Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);// تقوم بجلب الطلبات بناءً على معرف المستخدم والدور (Admin أو User) من قاعدة البيانات
15 |         bool CheckAccept(List<ShoppingCartItem> items, string userId);// تقوم بالتحقق من أن الكمية المتوفرة من المنتج تكفي للطلبية وأن المستخدم لديه رصيد كافي
16 | 
17 | 
18 | 
19 |         // تقوم بمعالجة عملية الدفع والتحقق من الطلبية، وتحديث الرصيد والكمية المتوفرة من المنتج في قاعدة البيانات، ثم تخزين الطلبية في قاعدة البيانات
20 | 
21 |         // تقوم بمعالجة عملية الدفع والتحقق من الطلبية، وتحديث الرصيد والكمية المتوفرة من المنتج في قاعدة البيانات، ثم تخزين الطلبية في قاعدة البيانات
22 |         Task<ServiceResponse<Order>> CheckoutAsync(CheckoutVM model, string userId);
23 | 
24 | 
25 | 
26 |         // 👇 إضافات للإدارة
27 |         Task<Order?> GetByIdAsync(Guid id);
28 |         Task DeleteAsync(Guid orderId);
29 | 
30 |         void Delete(Order order);
31 |     }
32 | }
33 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IProductRepository.cs:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/Data/Repositories/IProductRepository.cs


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IRatingRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Models;
 2 | 
 3 | namespace Souqna.Data.Repositories
 4 | {
 5 |     public interface IRatingRepository
 6 |     {
 7 |         Task AddOrUpdateAsync(Rating rating);
 8 |         Task<double> GetAverageRatingAsync(Guid productId);
 9 |         Task<int> GetUserRatingAsync(Guid productId, string userId);
10 |     }
11 | }
12 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Data.Repositories
 2 | {
 3 |     public interface IRepository<T>
 4 |     {
 5 |         Task<T> AddAsync(T entity);
 6 |         Task<T>? GetByIdAsync(Guid id);
 7 |         Task<List<T>> GetAllAsync();
 8 |         T Update(T entity);
 9 |         Task DeleteAsync(Guid id);
10 |     }
11 | }
12 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IReviewRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Models;
 2 | 
 3 | namespace Souqna.Data.Repositories
 4 | {
 5 |     public interface IReviewRepository
 6 |     {
 7 |         Task<IEnumerable<Review>> GetAllAsync();                 // جلب كل الآراء
 8 |         Task<Review?> GetByIdAsync(int id);                      // جلب رأي حسب المعرف
 9 |         Task AddAsync(Review review);                            // إضافة رأي جديد
10 |         Task UpdateAsync(Review review);                         // تحديث رأي
11 |         Task DeleteAsync(int id);                                // حذف رأي
12 |         Task<IEnumerable<Review>> GetApprovedReviewsAsync(int count = 6); // جلب الآراء المقبولة
13 |     }
14 | }
15 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/IStateRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Data.Repositories
 2 | {
 3 |     public interface IStateRepository
 4 |     {
 5 |         string GetValue (string key);
 6 |         void SetValue (string key, string value);
 7 |         void Delete (string key);
 8 |     }
 9 | }
10 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/OrdersRepository.cs:
--------------------------------------------------------------------------------
  1 | ﻿using Souqna.Models;
  2 | using Microsoft.EntityFrameworkCore;
  3 | using System;
  4 | using System.Collections.Generic;
  5 | using System.Linq;
  6 | using System.Threading.Tasks;
  7 | using Souqna.Data.ViewModels;
  8 | using Souqna.Services;
  9 | using Souqna.Services.Payments;
 10 | 
 11 | namespace Souqna.Data.Services
 12 | {
 13 |     public class OrdersRepository : IOrdersRepository
 14 |     {
 15 |         private readonly ApplicationDbContext _context;
 16 |         private readonly PaymentFactory _paymentFactory;
 17 |         public OrdersRepository(ApplicationDbContext context, PaymentFactory paymentFactory)
 18 |         {
 19 |             _context = context;
 20 |             _paymentFactory = paymentFactory;
 21 |         }
 22 | 
 23 |         public bool CheckAccept(List<ShoppingCartItem> items, string userId) //للتحقق من ان الكمية المتوفرة من المنتج تكفي للطلبية وأن المستخدم لديه رصيد كافي
 24 |         {
 25 |             var user = _context.Users.FirstOrDefault(n => n.Id == userId);
 26 |             var totalCost = items.Sum(n => n.Product.PriceOfUnit * n.Amount);
 27 |             var products = _context.Products.Where(n => items.Select(i => i.Product.ProductId).Equals(n.ProductId)).ToList();
 28 |             if (user == null || user.Balance < totalCost)
 29 |             {
 30 |                 return false;
 31 |             }
 32 |             for (int i = 0; i < products.Count; i++)
 33 |             {
 34 |                 var product = products[i];
 35 |                 if (product == null || product.StockQuantity < items[i].Amount || product.IsAvailable == false)
 36 |                 {
 37 |                     return false; // If any product is not available or insufficient stock, return false
 38 |                 }
 39 |             }
 40 |             user.Balance -= totalCost; // Deduct the total cost from user's balance
 41 |             _context.Users.Update(user); // Update the user's balance in the database
 42 |             for (int i = 0; i < products.Count; i++)
 43 |             {
 44 |                 var product = products[i];
 45 |                 if (product != null)
 46 |                 {
 47 |                     product.StockQuantity -= items[i].Amount; // Deduct the ordered amount from the product's stock
 48 |                     if(product.StockQuantity == 0)
 49 |                     {
 50 |                         product.IsAvailable = false; // If stock reaches zero, mark the product as unavailable
 51 |                     }
 52 |                     _context.Products.Update(product); // Update the product's stock in the database
 53 |                 }
 54 |             }
 55 |             _context.SaveChanges(); // Save all changes to the database
 56 |             return true; // All products are available and user has sufficient balance
 57 |         }
 58 | 
 59 |         public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
 60 |         {
 61 |             var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.product).Include(n => n.User).ToListAsync();
 62 | 
 63 |             if(userRole != "Admin")
 64 |             {
 65 |                 orders = orders.Where(n => n.UserId == userId).ToList();
 66 |             }
 67 | 
 68 |             return orders;
 69 |         }
 70 | 
 71 |         public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId)
 72 |         {
 73 |             var order = new Order()
 74 |             {
 75 |                 UserId = userId,
 76 |             };
 77 |             await _context.Orders.AddAsync(order);
 78 |             await _context.SaveChangesAsync();
 79 | 
 80 |             foreach (var item in items)
 81 |             {
 82 |                 var orderItem = new OrderItem()
 83 |                 {
 84 |                     Amount = item.Amount,
 85 |                     ProductId = item.Product.ProductId,
 86 |                     OrderId = order.OrderId,
 87 |                     Cost = item.Product.PriceOfUnit * item.Amount
 88 |                 };
 89 |                 // Update the product's stock
 90 |                 var product = await _context.Products.FindAsync(item.Product.ProductId);
 91 |                 if (product != null)
 92 |                 {
 93 |                     product.StockQuantity -= item.Amount;
 94 |                     _context.Products.Update(product);
 95 |                 }
 96 |                 await _context.OrderItems.AddAsync(orderItem);
 97 |             }
 98 |             await _context.SaveChangesAsync();
 99 |         }
100 | 
101 |         public async Task<ServiceResponse<Order>> CheckoutAsync(CheckoutVM model, string userId)
102 |         {
103 |             // التحقق من صحة المدخلات
104 |             var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);// الحصول على المستخدم بناءً على userId
105 |             if (user == null) return ServiceResponse<Order>.Fail("❌ المستخدم غير موجود");
106 | 
107 |             var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == model.ProductId);// الحصول على المنتج بناءً على ProductId من النموذج
108 |             if (product == null) return ServiceResponse<Order>.Fail("❌ المنتج غير موجود");
109 | 
110 |             if (product.StockQuantity < model.Quantity)// التحقق من الكمية المتوفرة في المخزون
111 |                 return ServiceResponse<Order>.Fail("❌ الكمية غير متوفرة");
112 | 
113 |             var totalCost = product.PriceOfUnit * model.Quantity;// حساب التكلفة الإجمالية للطلب
114 | 
115 |             var paymentService = _paymentFactory.GetPaymentService(model.PaymentMethod);
116 |             var paymentResult = await paymentService.ProcessPaymentAsync(userId, totalCost);
117 | 
118 |             if (!paymentResult.IsSuccess)
119 |                 return ServiceResponse<Order>.Fail(paymentResult.Message);
120 | 
121 | 
122 |             product.StockQuantity -= model.Quantity;// تحديث الكمية المتوفرة من المنتج في المخزون
123 |             if (product.StockQuantity == 0)
124 |                 product.IsAvailable = false;
125 | 
126 |             var order = new Order// إنشاء طلب جديد
127 |             {
128 |                 UserId = userId,
129 |                 TotalCost = totalCost,
130 |                 OrderedAt = DateTime.UtcNow,
131 |                 OrderItems = new List<OrderItem>
132 |         {
133 |             new OrderItem// إنشاء عنصر طلب جديد
134 |             {
135 |                 ProductId = product.ProductId,
136 |                 Amount = model.Quantity,
137 |                 Cost = totalCost
138 |             }
139 |         }
140 |             };
141 |             // إضافة الطلب إلى قاعدة البيانات
142 |             _context.Orders.Add(order);
143 |             _context.Users.Update(user);
144 |             _context.Products.Update(product);
145 |             await _context.SaveChangesAsync();
146 | 
147 |             return ServiceResponse<Order>.Success(order, "✅ تم إتمام عملية الشراء بنجاح");
148 |         }
149 | 
150 |         // 👇 إضافات للإدارة
151 |         //ادارة الطلبات
152 |         public async Task<Order?> GetByIdAsync(Guid id)// جلب طلب حسب المعرف
153 |         {
154 |             return await _context.Orders
155 |                 .Include(o => o.OrderItems)
156 |                 .ThenInclude(i => i.product)
157 |                 .Include(o => o.User)
158 |                 .FirstOrDefaultAsync(o => o.OrderId == id);
159 |         }
160 | 
161 |         public async Task DeleteAsync(Guid orderId)
162 |         {
163 |             var order = await _context.Orders
164 |                 .Include(o => o.OrderItems)
165 |                 .FirstOrDefaultAsync(o => o.OrderId == orderId);
166 | 
167 |             if (order != null)
168 |             {
169 |                 // نحذف العناصر التابعة للطلب أولاً
170 |                 _context.OrderItems.RemoveRange(order.OrderItems);
171 | 
172 |                 _context.Orders.Remove(order);
173 |                 await _context.SaveChangesAsync();
174 |             }
175 |         }
176 | 
177 |         public void Delete(Order order)// حذف الطلب من قاعدة البيانات
178 |         {
179 |             _context.Orders.Remove(order);
180 |         }
181 | 
182 | 
183 |     }
184 | }
185 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/ProductRepository.cs:
--------------------------------------------------------------------------------
  1 | ﻿using Microsoft.EntityFrameworkCore;
  2 | using Souqna.Models;
  3 | using System;
  4 | using System.Collections.Generic;
  5 | using System.Threading.Tasks;
  6 | using static Souqna.Data.Enums.ProductEnums;// استيراد الفئات من Enums
  7 | 
  8 | namespace Souqna.Data.Repositories
  9 | {
 10 |     public class ProductRepository : IProductRepository// تنفيذ واجهة IProductRepository
 11 |     {
 12 |         private readonly ApplicationDbContext _context;// متغير لحفظ سياق قاعدة البيانات
 13 | 
 14 |         public ProductRepository(ApplicationDbContext context)// مُنشئ لاستقبال سياق قاعدة البيانات
 15 |         {
 16 |             _context = context;
 17 |         }
 18 | 
 19 |         public async Task<IEnumerable<Product>> GetAllAsync()// دالة لجلب جميع المنتجات
 20 |         {
 21 |             return await _context.Products
 22 |                 .Include(p => p.User)
 23 |                 .Include(p => p.Ratings)
 24 |                 .ToListAsync();
 25 |         }
 26 |         // 👇 المنتجات المقبولة فقط
 27 |         public async Task<IEnumerable<Product>> GetAllApprovedAsync()
 28 |         {
 29 |             return await _context.Products
 30 |                 .Include(p => p.User)
 31 |                 .Include(p => p.Ratings)
 32 |                 .Where(p => p.IsApproved)// فقط المنتجات التي تمت الموافقة عليها
 33 |                 .ToListAsync();
 34 |         }
 35 | 
 36 | 
 37 |         public async Task<Product> GetByIdAsync(Guid productId)// دالة لجلب منتج حسب معرفه
 38 |         {
 39 |             return await _context.Products
 40 |                 .Include(p => p.User)//  جلب بيانات البائع
 41 | 
 42 |                 .Include(p => p.Ratings)
 43 |                 .FirstOrDefaultAsync(p => p.ProductId == productId);
 44 |         }
 45 | 
 46 |         public async Task<IEnumerable<Product>> GetByUserIdAsync(string userId)// دالة لجلب المنتجات الخاصة بمستخدم معين حسب معرفه
 47 |         {
 48 |             return await _context.Products
 49 |                 .Where(p => p.UserId == userId)
 50 |                 .Include(p => p.Ratings)
 51 |                 .ToListAsync();
 52 |         }
 53 | 
 54 |         public async Task<IEnumerable<Product>> FilterAsync(DateTime? releaseDate, ProductCategory? category, bool? isAvailable)// دالة لتصفية المنتجات حسب تاريخ الإصدار، الفئة، والتوافر
 55 |         {
 56 |             var query = _context.Products.AsQueryable();// إنشاء استعلام قابل للتعديل
 57 | 
 58 |             if (releaseDate.HasValue)
 59 |                 query = query.Where(p => p.CreatedAt.Date == releaseDate.Value.Date);// تصفية حسب تاريخ الإصدار
 60 | 
 61 |             if (category.HasValue)
 62 |                 query = query.Where(p => p.Category == category.Value);// تصفية حسب الفئة
 63 | 
 64 |             if (isAvailable.HasValue)
 65 |                 query = query.Where(p => p.IsAvailable == isAvailable.Value);// تصفية حسب التوافر
 66 | 
 67 |             return await query.ToListAsync();
 68 |         }
 69 |         public async Task AddAsync(Product product)//دالة لإضافة منتج جديد
 70 |         {
 71 |             await _context.Products.AddAsync(product);
 72 |             await _context.SaveChangesAsync();
 73 |         }
 74 | 
 75 |         public void Update(Product product)//دالة لتحديث منتج موجود
 76 |         {
 77 |             _context.Products.Update(product);
 78 |             _context.SaveChanges();
 79 |         }
 80 | 
 81 |         public async Task DeleteAsync(Guid id)//دالة حذف منتج حسب المعرف
 82 |         {
 83 |             var product = await _context.Products.FindAsync(id);
 84 |             if (product != null)
 85 |             {
 86 |                 _context.Products.Remove(product);
 87 |                 await _context.SaveChangesAsync();
 88 |             }
 89 |         }
 90 |         public async Task<IEnumerable<Product>> SearchAsync(string name)//دالة بحث عن المنتجات حسب الاسم
 91 |         {
 92 |             if (string.IsNullOrWhiteSpace(name))
 93 |                 return await GetAllAsync();
 94 | 
 95 |             return await _context.Products
 96 |                 .Include(p => p.User)
 97 |                 .Include(p => p.Ratings)
 98 |                 .Where(p => p.Name.Contains(name) || p.Description.Contains(name))// بحث في الاسم والوصف
 99 |                 .ToListAsync();
100 |         }
101 | 
102 |         // دالة لجلب المنتجات حسب الفئة، مع إمكانية استبعاد منتج معين بناءً على معرفه
103 |         public async Task<IEnumerable<Product>> GetByCategoryAsync(ProductCategory category, Guid? excludeId = null)// دالة لجلب المنتجات حسب الفئة، مع إمكانية استبعاد منتج معين بناءً على معرفه
104 |         {
105 |             var query = _context.Products
106 |                 .Where(p => p.Category == category);
107 | 
108 |             if (excludeId.HasValue)
109 |                 query = query.Where(p => p.ProductId != excludeId.Value);
110 | 
111 |             return await query
112 |                 .OrderByDescending(p => p.CreatedAt)
113 |                 .Take(8) // مثلاً نعرض 8 منتجات فقط
114 |                 .ToListAsync();
115 |         }
116 |     }
117 | }


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/RatingRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore;
 2 | using Souqna.Models;
 3 | 
 4 | namespace Souqna.Data.Repositories
 5 | {
 6 |     public class RatingRepository : IRatingRepository
 7 |     {
 8 |         private readonly ApplicationDbContext _context;
 9 | 
10 |         public RatingRepository(ApplicationDbContext context)
11 |         {
12 |             _context = context;
13 |         }
14 | 
15 |         public async Task AddOrUpdateAsync(Rating rating)
16 |         {
17 |             var existing = await _context.Ratings
18 |                 .FirstOrDefaultAsync(r => r.ProductId == rating.ProductId && r.UserId == rating.UserId);
19 | 
20 |             if (existing != null)
21 |             {
22 |                 existing.Stars = rating.Stars; // تحديث التقييم
23 |                 _context.Ratings.Update(existing);
24 |             }
25 |             else
26 |             {
27 |                 await _context.Ratings.AddAsync(rating);
28 |             }
29 | 
30 |             await _context.SaveChangesAsync();
31 |         }
32 | 
33 |         public async Task<double> GetAverageRatingAsync(Guid productId)
34 |         {
35 |             return await _context.Ratings
36 |                 .Where(r => r.ProductId == productId)
37 |                 .AverageAsync(r => (double?)r.Stars) ?? 0;
38 |         }
39 | 
40 |         public async Task<int> GetUserRatingAsync(Guid productId, string userId)
41 |         {
42 |             var rating = await _context.Ratings
43 |                 .FirstOrDefaultAsync(r => r.ProductId == productId && r.UserId == userId);
44 | 
45 |             return rating?.Stars ?? 0;
46 |         }
47 |     }
48 | }
49 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/ReviewRepository .cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore;
 2 | using Souqna.Models;
 3 | 
 4 | namespace Souqna.Data.Repositories
 5 | {
 6 |     public class ReviewRepository : IReviewRepository
 7 |     {
 8 |         private readonly ApplicationDbContext _context;
 9 | 
10 |         public ReviewRepository(ApplicationDbContext context)
11 |         {
12 |             _context = context;
13 |         }
14 | 
15 |         public async Task<IEnumerable<Review>> GetAllAsync()
16 |         {
17 |             return await _context.Reviews
18 |                 .Include(r => r.User)
19 |                 .OrderByDescending(r => r.CreatedAt)
20 |                 .ToListAsync();
21 |         }
22 | 
23 |         public async Task<Review?> GetByIdAsync(int id)
24 |         {
25 |             return await _context.Reviews
26 |                 .Include(r => r.User)
27 |                 .FirstOrDefaultAsync(r => r.Id == id);
28 |         }
29 | 
30 |         public async Task AddAsync(Review review)
31 |         {
32 |             await _context.Reviews.AddAsync(review);
33 |             await _context.SaveChangesAsync();
34 |         }
35 | 
36 |         public async Task UpdateAsync(Review review)
37 |         {
38 |             _context.Reviews.Update(review);
39 |             await _context.SaveChangesAsync();
40 |         }
41 | 
42 |         public async Task DeleteAsync(int id)
43 |         {
44 |             var review = await _context.Reviews.FindAsync(id);
45 |             if (review != null)
46 |             {
47 |                 _context.Reviews.Remove(review);
48 |                 await _context.SaveChangesAsync();
49 |             }
50 |         }
51 | 
52 |         public async Task<IEnumerable<Review>> GetApprovedReviewsAsync(int count = 6)
53 |         {
54 |             return await _context.Reviews
55 |                 .Include(r => r.User)
56 |                 .Where(r => r.IsApproved)
57 |                 .OrderByDescending(r => r.CreatedAt)
58 |                 .Take(count)
59 |                 .ToListAsync();
60 |         }
61 |     }
62 | }
63 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/SessionStateRepository.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Data.Repositories
 2 | {
 3 |     public class SessionStateRepository : IStateRepository
 4 |     {
 5 |         private readonly IHttpContextAccessor httpContextAccessor;
 6 | 
 7 |         public SessionStateRepository(IHttpContextAccessor httpContextAccessor)
 8 |         {
 9 |             this.httpContextAccessor = httpContextAccessor;
10 |         }
11 |         public string GetValue(string key)
12 |         {
13 |             return httpContextAccessor.HttpContext?.Session.GetString(key)?? " ";
14 |         }
15 | 
16 |         public void SetValue(string key, string value)
17 |         {
18 |             httpContextAccessor.HttpContext?.Session.SetString(key, value);
19 |         }
20 |         public void Delete(string key)
21 |         {
22 |             httpContextAccessor.HttpContext?.Session.Remove(key);
23 |         }
24 | 
25 |     }
26 | }
27 | 


--------------------------------------------------------------------------------
/Souqna/Data/Repositories/UnitOfWork.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Data.Services;
 2 | using Souqna.Models;
 3 | 
 4 | namespace Souqna.Data.Repositories
 5 | {
 6 |     public class UnitOfWork : IDisposable
 7 |     {
 8 |         private readonly ApplicationDbContext _context;
 9 |         public IOrdersRepository Orders { get; }
10 |         public IProductRepository Products { get; }
11 |         public IStateRepository State { get; }
12 |         public IReviewRepository Reviews { get; }
13 |         public IRatingRepository Ratings { get; }
14 | 
15 | 
16 |         public UnitOfWork(
17 |             ApplicationDbContext context,
18 |             IOrdersRepository orders,
19 |             IProductRepository products,
20 |             IStateRepository state,
21 |              IReviewRepository reviews,
22 |              IRatingRepository ratings)    
23 |         {
24 |             _context = context;
25 |             Orders = orders;
26 |             Products = products;
27 |             State = state;
28 |             Reviews = reviews;
29 |             Ratings = ratings;
30 |         }
31 | 
32 |         public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
33 | 
34 |         public void Dispose() => _context.Dispose();
35 |     }
36 | }
37 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/CategoryVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Models;
 2 | 
 3 | namespace Souqna.Data.ViewModels
 4 | {
 5 |     public class CategoryVM
 6 |     {
 7 |         public string Name { get; set; }
 8 |         public string Icon { get; set; }
 9 |         public IEnumerable<Product> Products { get; set; }
10 |     }
11 | 
12 |     public class HomeVM
13 |     {
14 |         public List<CategoryVM> Categories { get; set; }
15 |         // عرض أحدث المنتجات
16 |         public IEnumerable<Product> LatestProducts { get; set; }
17 |         public IEnumerable<Review> Reviews { get; set; }
18 | 
19 |     }
20 | }
21 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/CheckoutVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Data.ViewModels
 2 | {
 3 |     public class CheckoutVM
 4 |     {
 5 |         public Guid ProductId { get; set; }
 6 |         public int Quantity { get; set; } = 1;
 7 | 
 8 |         // معلومات المستخدم
 9 |         public string FullName { get; set; }
10 |         public string Email { get; set; }
11 |         public string Address { get; set; }
12 |         public string PhoneNumber { get; set; }
13 |         public double? EstimatedTotal { get; set; }
14 | 
15 |         // طرق الدفع
16 |         public string PaymentMethod { get; set; } // "ShamCash", "Points", "PayPal"
17 |     }
18 | }
19 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/LoginVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using System.Collections.Generic;
 3 | using System.ComponentModel.DataAnnotations;
 4 | using System.Linq;
 5 | using System.Threading.Tasks;
 6 | 
 7 | namespace Souqna.Data.ViewModels
 8 | {
 9 |     public class LoginVM
10 |     {
11 |         [Display(Name = "Email address")]
12 |         [Required(ErrorMessage = "Email address is required")]
13 |         public string EmailAddress { get; set; }
14 | 
15 |         [Required]
16 |         [DataType(DataType.Password)]
17 |         public string Password { get; set; }
18 |     }
19 | }
20 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/MyAccountVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Models;
 2 | using System.Collections.Generic;
 3 | 
 4 | namespace Souqna.Data.ViewModels
 5 | {
 6 |     public class MyAccountVM
 7 |     {
 8 |         public List<ShoppingCartItem> CartItems { get; set; } = new();
 9 |         public List<OrderItem> PurchasedProducts { get; set; }
10 |         public List<Product> SoldProducts { get; set; } = new();
11 |         //public List<CheckoutVM> Quantity { get;set; } = new();
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/PayPalCheckoutVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Data.ViewModels
 2 | {
 3 |     public class PayPalCheckoutVM
 4 |     {
 5 |         public string OrderId { get; set; }
 6 |         public Guid ProductId { get; set; }
 7 |         public int Quantity { get; set; }
 8 |     }
 9 | }
10 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/ProductVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
 2 | using Souqna.Data.Attributes;
 3 | using System.ComponentModel.DataAnnotations;
 4 | using System.Diagnostics.CodeAnalysis;
 5 | using static Souqna.Data.Enums.ProductEnums;
 6 | 
 7 | namespace Souqna.Data.ViewModels
 8 | {
 9 |     public class ProductVM
10 |     {
11 |         public List<string> ExistingImages { get; set; } = new List<string>();
12 | 
13 |         public Guid ProductId { get; set; }
14 | 
15 |         [Display(Name = "اسم المنتج")]
16 |         [Required(ErrorMessage = "ادخل اسم المنتج")]
17 |         public string Name { get; set; }
18 | 
19 |         [Display(Name = "الوصف")]
20 |         public string Description { get; set; }
21 | 
22 |         [Display(Name = "سعر الواحدة")]
23 |         [Required(ErrorMessage = "ادخل السعر")]
24 |         [Range(1, 1000000, ErrorMessage = "السعر المدخل غير صالح")]
25 |         public double PriceOfUnit { get; set; }
26 | 
27 |         // خليه Nullable + Required عشان خيار "-- اختر --" ما يسبب خطأ ربط
28 |         [Display(Name = "الفئة (التصنيف)")]
29 |         [Required(ErrorMessage = "يرجى اختيار الفئة")]
30 |         public ProductCategory? Category { get; set; }
31 | 
32 |         [Display(Name = "وحدة القياس")]
33 |         [Required(ErrorMessage = "يرجى تحديد وحدة القياس")]
34 |         public UnitOfMeasurement? Unit { get; set; } = UnitOfMeasurement.Piece;
35 | 
36 |         [Display(Name = "هل المنتج جديد؟")]
37 |         public bool IsNew { get; set; } = false;
38 | 
39 |         [Display(Name = "الكمية المتاحة")]
40 |         [Required(ErrorMessage = "الكمية المتاحة مطلوبة")]
41 |         [Range(1, 1000000, ErrorMessage = "ادخل كمية صحيحة")]
42 |         public int StockQuantity { get; set; } = 1;
43 | 
44 |         // هذي تُملأ بعد الحفظ – لا نتحقق منها في ModelState
45 |         [ValidateNever]
46 |         public List<string> ProductImages { get; set; } = new();
47 | 
48 |         // التحقق يكون على الملفات المرفوعة
49 |         [Display(Name = "صور للمنتج")]
50 |         [Required(ErrorMessage = "يجب رفع صورة واحدة على الأقل")]
51 |         public List<IFormFile> UploadedImages { get; set; } = new();
52 |     }
53 | }
54 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/RegisterVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Data.Attributes;
 2 | using System;
 3 | using System.Collections.Generic;
 4 | using System.ComponentModel.DataAnnotations;
 5 | using System.Linq;
 6 | using System.Threading.Tasks;
 7 | 
 8 | namespace Souqna.Data.ViewModels
 9 | {
10 |     public class RegisterVM
11 |     {
12 |         [Display(Name = "Full name")]
13 |         [Required(ErrorMessage = "Full name is required")]
14 |         public string FullName { get; set; }
15 | 
16 |         [Display(Name = "Birth day")]
17 |         [Required(ErrorMessage = "Birth day is required")]
18 |         [Min18YearsOld(ErrorMessage = "You must be at least 18 years old")]
19 |         public DateOnly Birthday { get; set; } //تاريخ ميلاد المستخدم
20 |         [Display(Name = "Address")]
21 |         [Required(ErrorMessage = "Address is required")]
22 |         public string Address { get; set; } //عنوان المستخدم
23 | 
24 |         [Display(Name = "Email address")]
25 |         [Required(ErrorMessage = "Email address is required")]
26 |         public string EmailAddress { get; set; }
27 | 
28 |         [Required]
29 |         [DataType(DataType.Password)]
30 |         public string Password { get; set; }
31 | 
32 |         [Display(Name = "Confirm password")]
33 |         [Required(ErrorMessage = "Confirm password is required")]
34 |         [DataType(DataType.Password)]
35 |         [Compare("Password", ErrorMessage = "Passwords do not match")]
36 |         public string ConfirmPassword { get; set; }
37 |     }
38 | 
39 |     
40 | }
41 | 


--------------------------------------------------------------------------------
/Souqna/Data/ViewModels/ShoppingCartVM.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Data.Cart;
 2 | using System;
 3 | using System.Collections.Generic;
 4 | using System.Linq;
 5 | using System.Threading.Tasks;
 6 | 
 7 | namespace Souqna.Data.ViewModels
 8 | {
 9 |     public class ShoppingCartVM
10 |     {
11 |         public ShoppingCart ShoppingCart { get; set; }
12 |         public double ShoppingCartTotal { get; set; }
13 |     }
14 | }
15 | 


--------------------------------------------------------------------------------
/Souqna/Helpers/EnumTranslations.cs:
--------------------------------------------------------------------------------
 1 | ﻿using static Souqna.Data.Enums.ProductEnums;
 2 | 
 3 | namespace Souqna.Helpers
 4 | {
 5 |     public static class EnumTranslations
 6 |     {
 7 |         public static string GetDisplayName(this ProductCategory category)
 8 |         {
 9 |             return category switch
10 |             {
11 |                 ProductCategory.Electronics => "إلكترونيات",
12 |                 ProductCategory.Clothing => "ملابس",
13 |                 ProductCategory.Vihicles => "مركبات",
14 |                 ProductCategory.Jewelry => "مجوهرات",
15 |                 ProductCategory.HealthAndPersonalCare => "الصحة والعناية الشخصية",
16 |                 ProductCategory.technology => "تكنولوجيا",
17 |                 ProductCategory.Books => "كتب",
18 |                 ProductCategory.BeautyProducts => "منتجات تجميل",
19 |                 ProductCategory.SportsEquipment => "معدات رياضية",
20 |                 ProductCategory.Toys => "ألعاب",
21 |                 ProductCategory.Furniture => "أثاث",
22 |                 _ => category.ToString()
23 |             };
24 |         }
25 | 
26 |         //public static string GetDisplayName(this UnitOfMeasurement unit)
27 |         //{
28 |         //    return unit switch
29 |         //    {
30 |         //        UnitOfMeasurement.Piece => "قطعة",
31 |         //        UnitOfMeasurement.Kilogram => "كيلوغرام",
32 |         //        UnitOfMeasurement.Liter => "لتر",
33 |         //        UnitOfMeasurement.Meter => "متر",
34 |         //        _ => unit.ToString()
35 |         //    };
36 |         //}
37 |     }
38 | }
39 | 


--------------------------------------------------------------------------------
/Souqna/Hubs/NotificationHub.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.SignalR;
 2 | 
 3 | namespace Souqna.Hubs
 4 | {
 5 |     public class NotificationHub : Hub
 6 |     {
 7 |         public override async Task OnConnectedAsync()//استخدام هذه الدالة عند اتصال المستخدم
 8 |         {
 9 |             var user = Context.User;// الحصول على المستخدم من سياق الاتصال
10 |             if (user != null && user.IsInRole("Admin"))//نتحقق مما إذا كان المستخدم هو أدمن
11 |             {
12 |                 // ضم الأدمن إلى المجموعة "Admin"
13 |                 await Groups.AddToGroupAsync(Context.ConnectionId, "Admin");// إضافة المستخدم إلى مجموعة الأدمن
14 |             }
15 | 
16 |             await base.OnConnectedAsync();// استدعاء الدالة الأساسية لإكمال عملية الاتصال
17 |         }
18 | 
19 |         // إرسال إشعار لمستخدم محدد
20 |         public async Task SendToUser(string userId, string message)//استخدام هذه الدالة لإرسال إشعار لمستخدم معين
21 |         {
22 |             await Clients.User(userId).SendAsync("ReceiveNotification", message);// إرسال الإشعار للمستخدم المحدد
23 |         }
24 | 
25 |         // إرسال إشعار لجميع الأدمن
26 |         public async Task SendToAdmins(string message)//استخدام هذه الدالة لإرسال إشعار لجميع الأدمن
27 |         {
28 |             await Clients.Group("Admin").SendAsync("ReceiveNotification", message);// إرسال الإشعار لجميع الأدمن في المجموعة "Admin"
29 |         }
30 |     }
31 | }
32 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250813174458_MakeUserFieldsNullable.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class MakeUserFieldsNullable : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.AlterColumn<string>(
14 |                 name: "ProfileImage",
15 |                 table: "AspNetUsers",
16 |                 type: "nvarchar(max)",
17 |                 nullable: true,
18 |                 oldClrType: typeof(string),
19 |                 oldType: "nvarchar(max)");
20 | 
21 |             migrationBuilder.AlterColumn<string>(
22 |                 name: "Address",
23 |                 table: "AspNetUsers",
24 |                 type: "nvarchar(max)",
25 |                 nullable: true,
26 |                 oldClrType: typeof(string),
27 |                 oldType: "nvarchar(max)");
28 |         }
29 | 
30 |         /// <inheritdoc />
31 |         protected override void Down(MigrationBuilder migrationBuilder)
32 |         {
33 |             migrationBuilder.AlterColumn<string>(
34 |                 name: "ProfileImage",
35 |                 table: "AspNetUsers",
36 |                 type: "nvarchar(max)",
37 |                 nullable: false,
38 |                 defaultValue: "",
39 |                 oldClrType: typeof(string),
40 |                 oldType: "nvarchar(max)",
41 |                 oldNullable: true);
42 | 
43 |             migrationBuilder.AlterColumn<string>(
44 |                 name: "Address",
45 |                 table: "AspNetUsers",
46 |                 type: "nvarchar(max)",
47 |                 nullable: false,
48 |                 defaultValue: "",
49 |                 oldClrType: typeof(string),
50 |                 oldType: "nvarchar(max)",
51 |                 oldNullable: true);
52 |         }
53 |     }
54 | }
55 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250813200318_ChangeProductImagesToJson.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class ChangeProductImagesToJson : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.RenameColumn(
14 |                 name: "ProductImages",
15 |                 table: "Products",
16 |                 newName: "ProductImagesJson");
17 |         }
18 | 
19 |         /// <inheritdoc />
20 |         protected override void Down(MigrationBuilder migrationBuilder)
21 |         {
22 |             migrationBuilder.RenameColumn(
23 |                 name: "ProductImagesJson",
24 |                 table: "Products",
25 |                 newName: "ProductImages");
26 |         }
27 |     }
28 | }
29 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250815130746_FixDeleteBehavior.cs:
--------------------------------------------------------------------------------
  1 | ﻿using System;
  2 | using Microsoft.EntityFrameworkCore.Migrations;
  3 | 
  4 | #nullable disable
  5 | 
  6 | namespace Souqna.Migrations
  7 | {
  8 |     /// <inheritdoc />
  9 |     public partial class FixDeleteBehavior : Migration
 10 |     {
 11 |         /// <inheritdoc />
 12 |         protected override void Up(MigrationBuilder migrationBuilder)
 13 |         {
 14 |             migrationBuilder.DropForeignKey(
 15 |                 name: "FK_Orders_AspNetUsers_UserId",
 16 |                 table: "Orders");
 17 | 
 18 |             migrationBuilder.DropForeignKey(
 19 |                 name: "FK_Products_AspNetUsers_UserId",
 20 |                 table: "Products");
 21 | 
 22 |             migrationBuilder.CreateTable(
 23 |                 name: "CartItems",
 24 |                 columns: table => new
 25 |                 {
 26 |                     Id = table.Column<int>(type: "int", nullable: false)
 27 |                         .Annotation("SqlServer:Identity", "1, 1"),
 28 |                     ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
 29 |                     UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
 30 |                     Quantity = table.Column<int>(type: "int", nullable: false),
 31 |                     AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
 32 |                 },
 33 |                 constraints: table =>
 34 |                 {
 35 |                     table.PrimaryKey("PK_CartItems", x => x.Id);
 36 |                     table.ForeignKey(
 37 |                         name: "FK_CartItems_AspNetUsers_UserId",
 38 |                         column: x => x.UserId,
 39 |                         principalTable: "AspNetUsers",
 40 |                         principalColumn: "Id");
 41 |                     table.ForeignKey(
 42 |                         name: "FK_CartItems_Products_ProductId",
 43 |                         column: x => x.ProductId,
 44 |                         principalTable: "Products",
 45 |                         principalColumn: "ProductId");
 46 |                 });
 47 | 
 48 |             migrationBuilder.CreateIndex(
 49 |                 name: "IX_CartItems_ProductId",
 50 |                 table: "CartItems",
 51 |                 column: "ProductId");
 52 | 
 53 |             migrationBuilder.CreateIndex(
 54 |                 name: "IX_CartItems_UserId",
 55 |                 table: "CartItems",
 56 |                 column: "UserId");
 57 | 
 58 |             migrationBuilder.AddForeignKey(
 59 |                 name: "FK_Orders_AspNetUsers_UserId",
 60 |                 table: "Orders",
 61 |                 column: "UserId",
 62 |                 principalTable: "AspNetUsers",
 63 |                 principalColumn: "Id");
 64 | 
 65 |             migrationBuilder.AddForeignKey(
 66 |                 name: "FK_Products_AspNetUsers_UserId",
 67 |                 table: "Products",
 68 |                 column: "UserId",
 69 |                 principalTable: "AspNetUsers",
 70 |                 principalColumn: "Id");
 71 |         }
 72 | 
 73 |         /// <inheritdoc />
 74 |         protected override void Down(MigrationBuilder migrationBuilder)
 75 |         {
 76 |             migrationBuilder.DropForeignKey(
 77 |                 name: "FK_Orders_AspNetUsers_UserId",
 78 |                 table: "Orders");
 79 | 
 80 |             migrationBuilder.DropForeignKey(
 81 |                 name: "FK_Products_AspNetUsers_UserId",
 82 |                 table: "Products");
 83 | 
 84 |             migrationBuilder.DropTable(
 85 |                 name: "CartItems");
 86 | 
 87 |             migrationBuilder.AddForeignKey(
 88 |                 name: "FK_Orders_AspNetUsers_UserId",
 89 |                 table: "Orders",
 90 |                 column: "UserId",
 91 |                 principalTable: "AspNetUsers",
 92 |                 principalColumn: "Id",
 93 |                 onDelete: ReferentialAction.Cascade);
 94 | 
 95 |             migrationBuilder.AddForeignKey(
 96 |                 name: "FK_Products_AspNetUsers_UserId",
 97 |                 table: "Products",
 98 |                 column: "UserId",
 99 |                 principalTable: "AspNetUsers",
100 |                 principalColumn: "Id",
101 |                 onDelete: ReferentialAction.Cascade);
102 |         }
103 |     }
104 | }
105 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250816114515_AddReviewsTable.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using Microsoft.EntityFrameworkCore.Migrations;
 3 | 
 4 | #nullable disable
 5 | 
 6 | namespace Souqna.Migrations
 7 | {
 8 |     /// <inheritdoc />
 9 |     public partial class AddReviewsTable : Migration
10 |     {
11 |         /// <inheritdoc />
12 |         protected override void Up(MigrationBuilder migrationBuilder)
13 |         {
14 |             migrationBuilder.CreateTable(
15 |                 name: "Reviews",
16 |                 columns: table => new
17 |                 {
18 |                     Id = table.Column<int>(type: "int", nullable: false)
19 |                         .Annotation("SqlServer:Identity", "1, 1"),
20 |                     Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
21 |                     Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
22 |                     Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
23 |                     Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
24 |                     CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
25 |                     IsApproved = table.Column<bool>(type: "bit", nullable: false)
26 |                 },
27 |                 constraints: table =>
28 |                 {
29 |                     table.PrimaryKey("PK_Reviews", x => x.Id);
30 |                 });
31 |         }
32 | 
33 |         /// <inheritdoc />
34 |         protected override void Down(MigrationBuilder migrationBuilder)
35 |         {
36 |             migrationBuilder.DropTable(
37 |                 name: "Reviews");
38 |         }
39 |     }
40 | }
41 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250816120015_AddUserToReviews.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class AddUserToReviews : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.AddColumn<string>(
14 |                 name: "UserId",
15 |                 table: "Reviews",
16 |                 type: "nvarchar(450)",
17 |                 nullable: true);
18 | 
19 |             migrationBuilder.CreateIndex(
20 |                 name: "IX_Reviews_UserId",
21 |                 table: "Reviews",
22 |                 column: "UserId");
23 | 
24 |             migrationBuilder.AddForeignKey(
25 |                 name: "FK_Reviews_AspNetUsers_UserId",
26 |                 table: "Reviews",
27 |                 column: "UserId",
28 |                 principalTable: "AspNetUsers",
29 |                 principalColumn: "Id");
30 |         }
31 | 
32 |         /// <inheritdoc />
33 |         protected override void Down(MigrationBuilder migrationBuilder)
34 |         {
35 |             migrationBuilder.DropForeignKey(
36 |                 name: "FK_Reviews_AspNetUsers_UserId",
37 |                 table: "Reviews");
38 | 
39 |             migrationBuilder.DropIndex(
40 |                 name: "IX_Reviews_UserId",
41 |                 table: "Reviews");
42 | 
43 |             migrationBuilder.DropColumn(
44 |                 name: "UserId",
45 |                 table: "Reviews");
46 |         }
47 |     }
48 | }
49 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250818130056_AddIsApprovedToProduct.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class AddIsApprovedToProduct : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.AddColumn<bool>(
14 |                 name: "IsApproved",
15 |                 table: "Products",
16 |                 type: "bit",
17 |                 nullable: false,
18 |                 defaultValue: false);
19 |         }
20 | 
21 |         /// <inheritdoc />
22 |         protected override void Down(MigrationBuilder migrationBuilder)
23 |         {
24 |             migrationBuilder.DropColumn(
25 |                 name: "IsApproved",
26 |                 table: "Products");
27 |         }
28 |     }
29 | }
30 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250818160155_AddNotifications.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using Microsoft.EntityFrameworkCore.Migrations;
 3 | 
 4 | #nullable disable
 5 | 
 6 | namespace Souqna.Migrations
 7 | {
 8 |     /// <inheritdoc />
 9 |     public partial class AddNotifications : Migration
10 |     {
11 |         /// <inheritdoc />
12 |         protected override void Up(MigrationBuilder migrationBuilder)
13 |         {
14 |             migrationBuilder.CreateTable(
15 |                 name: "Notifications",
16 |                 columns: table => new
17 |                 {
18 |                     Id = table.Column<int>(type: "int", nullable: false)
19 |                         .Annotation("SqlServer:Identity", "1, 1"),
20 |                     Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
21 |                     CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
22 |                 },
23 |                 constraints: table =>
24 |                 {
25 |                     table.PrimaryKey("PK_Notifications", x => x.Id);
26 |                 });
27 |         }
28 | 
29 |         /// <inheritdoc />
30 |         protected override void Down(MigrationBuilder migrationBuilder)
31 |         {
32 |             migrationBuilder.DropTable(
33 |                 name: "Notifications");
34 |         }
35 |     }
36 | }
37 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250818173804_AddNotificationsTable.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class AddNotificationsTable : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.AddColumn<bool>(
14 |                 name: "IsRead",
15 |                 table: "Notifications",
16 |                 type: "bit",
17 |                 nullable: false,
18 |                 defaultValue: false);
19 | 
20 |             migrationBuilder.AddColumn<string>(
21 |                 name: "UserId",
22 |                 table: "Notifications",
23 |                 type: "nvarchar(450)",
24 |                 nullable: false,
25 |                 defaultValue: "");
26 | 
27 |             migrationBuilder.CreateIndex(
28 |                 name: "IX_Notifications_UserId",
29 |                 table: "Notifications",
30 |                 column: "UserId");
31 | 
32 |             migrationBuilder.AddForeignKey(
33 |                 name: "FK_Notifications_AspNetUsers_UserId",
34 |                 table: "Notifications",
35 |                 column: "UserId",
36 |                 principalTable: "AspNetUsers",
37 |                 principalColumn: "Id",
38 |                 onDelete: ReferentialAction.Cascade);
39 |         }
40 | 
41 |         /// <inheritdoc />
42 |         protected override void Down(MigrationBuilder migrationBuilder)
43 |         {
44 |             migrationBuilder.DropForeignKey(
45 |                 name: "FK_Notifications_AspNetUsers_UserId",
46 |                 table: "Notifications");
47 | 
48 |             migrationBuilder.DropIndex(
49 |                 name: "IX_Notifications_UserId",
50 |                 table: "Notifications");
51 | 
52 |             migrationBuilder.DropColumn(
53 |                 name: "IsRead",
54 |                 table: "Notifications");
55 | 
56 |             migrationBuilder.DropColumn(
57 |                 name: "UserId",
58 |                 table: "Notifications");
59 |         }
60 |     }
61 | }
62 | 


--------------------------------------------------------------------------------
/Souqna/Migrations/20250823205702_AddUrlToNotification.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore.Migrations;
 2 | 
 3 | #nullable disable
 4 | 
 5 | namespace Souqna.Migrations
 6 | {
 7 |     /// <inheritdoc />
 8 |     public partial class AddUrlToNotification : Migration
 9 |     {
10 |         /// <inheritdoc />
11 |         protected override void Up(MigrationBuilder migrationBuilder)
12 |         {
13 |             migrationBuilder.AddColumn<string>(
14 |                 name: "Url",
15 |                 table: "Notifications",
16 |                 type: "nvarchar(max)",
17 |                 nullable: true);
18 |         }
19 | 
20 |         /// <inheritdoc />
21 |         protected override void Down(MigrationBuilder migrationBuilder)
22 |         {
23 |             migrationBuilder.DropColumn(
24 |                 name: "Url",
25 |                 table: "Notifications");
26 |         }
27 |     }
28 | }
29 | 


--------------------------------------------------------------------------------
/Souqna/Models/ApplicationUser.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Identity;
 2 | 
 3 | namespace Souqna.Models
 4 | {
 5 |     public class ApplicationUser : IdentityUser
 6 |     {
 7 |         public string FullName { get; set; } //الاسم الكامل للمستخدم
 8 | 
 9 |         public string Role { get; set; } = "User";
10 | 
11 |         public double Balance { get; set; } = 0.0; //رصيد المستخدم
12 |         public string? ProfileImage { get; set; } //مسار صورة الملف الشخصي للمستخدم
13 |         public DateOnly Birthday { get; set; } //تاريخ ميلاد المستخدم
14 |         public string? Address { get; set; } //عنوان المستخدم
15 |         public ICollection<Order> Orders { get; set; } //قائمة الطلبات التي قام بها المستخدم
16 |         public ICollection<Product> Products { get; set; } //قائمة المنتجات التي قام المستخدم بإنشائها
17 |     }
18 | }
19 | 


--------------------------------------------------------------------------------
/Souqna/Models/CartItem.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using System.ComponentModel.DataAnnotations;
 3 | using System.ComponentModel.DataAnnotations.Schema;
 4 | 
 5 | namespace Souqna.Models
 6 | {
 7 |     public class CartItem
 8 |     {
 9 |         [Key]
10 |         public int Id { get; set; }
11 | 
12 |         // معرف المنتج المرتبط بالسلة
13 |         public Guid ProductId { get; set; }
14 |         [ForeignKey("ProductId")]
15 |         public Product Product { get; set; }
16 | 
17 |         // معرف المستخدم الذي يملك السلة
18 |         public string UserId { get; set; }
19 |         [ForeignKey("UserId")]
20 |         public ApplicationUser User { get; set; }
21 | 
22 |         // عدد الكمية التي أضافها المستخدم من المنتج
23 |         public int Quantity { get; set; } = 1;
24 | 
25 |         // وقت إضافة المنتج للسلة
26 |         public DateTime AddedAt { get; set; } = DateTime.UtcNow;
27 |     }
28 | }
29 | 


--------------------------------------------------------------------------------
/Souqna/Models/ErrorViewModel.cs:
--------------------------------------------------------------------------------
 1 | namespace Souqna.Models
 2 | {
 3 |     public class ErrorViewModel
 4 |     {
 5 |         public string? RequestId { get; set; }
 6 | 
 7 |         public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
 8 |     }
 9 | }
10 | 


--------------------------------------------------------------------------------
/Souqna/Models/Notification.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using System.ComponentModel.DataAnnotations;
 3 | using System.ComponentModel.DataAnnotations.Schema;
 4 | 
 5 | namespace Souqna.Models
 6 | {
 7 |     public class Notification
 8 |     {
 9 |         public int Id { get; set; }
10 | 
11 |         [Required]
12 |         public string UserId { get; set; }   // المستخدم اللي وصله الإشعار
13 | 
14 |         [ForeignKey("UserId")]
15 |         public ApplicationUser User { get; set; }
16 | 
17 |         [Required]
18 |         public string Message { get; set; }  // نص الإشعار
19 | 
20 |         public bool IsRead { get; set; } = false; // هل تمت قراءته؟
21 |         public string? Url { get; set; } // رابط الصفحة المرتبطة بالإشعار
22 | 
23 | 
24 |         public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
25 |     }
26 | }
27 | 


--------------------------------------------------------------------------------
/Souqna/Models/Order.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Models
 2 | {
 3 |     public class Order
 4 |     {
 5 |         public Guid OrderId { get; set; }
 6 |         public string UserId { get; set; }
 7 |         public ApplicationUser User { get; set; }
 8 |         public double TotalCost { get; set; } // التكلفة الإجمالية للطلب
 9 |         public DateTime OrderedAt { get; set; } // تاريخ الطلب
10 |         public ICollection<OrderItem> OrderItems { get; set; } // قائمة العناصر في الطلب
11 |         public Order()
12 |         {
13 |             OrderId = Guid.NewGuid(); // تعيين معرف فريد للطلب
14 |             OrderedAt = DateTime.UtcNow; // تعيين تاريخ الطلب إلى الوقت الحالي
15 |         }
16 |     }
17 | }


--------------------------------------------------------------------------------
/Souqna/Models/OrderItem.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Models
 2 | {
 3 |     public class OrderItem
 4 |     {
 5 |         public Guid OrderItemId { get; set; }
 6 |         public Guid OrderId { get; set; } // معرف الطلب الذي ينتمي إليه العنصر
 7 |         public Order order { get; set; } 
 8 |         public Guid ProductId { get; set; } // معرف المنتج الذي ينتمي إليه العنصر
 9 |         public Product product { get; set; }
10 |         public int Amount { get; set; } // الكمية المطلوبة من المنتج
11 |         public double Cost { get; set; } // التكلفة الإجمالية للعنصر في الطلب
12 |         public OrderItem()
13 |         {
14 |             OrderItemId = Guid.NewGuid(); // تعيين معرف فريد للعنصر في الطلب
15 |         }
16 | 
17 |     }
18 | }


--------------------------------------------------------------------------------
/Souqna/Models/Product.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Souqna.Data.Attributes;
 2 | using static Souqna.Data.Enums.ProductEnums;
 3 | using System.Text.Json;
 4 | 
 5 | 
 6 | namespace Souqna.Models
 7 | {
 8 |     
 9 |     public class Product
10 |     {
11 |         public Guid ProductId { get; set; }
12 |         public string Name { get; set; } //اسم المنتج
13 |         public string Description { get; set; } //وصف المنتج
14 |         public double PriceOfUnit { get; set; } //سعر المنتج
15 |         public ProductCategory Category { get; set; } //فئة المنتج
16 |         public UnitOfMeasurement Unit { get; set; } = UnitOfMeasurement.Piece; //وحدة قياس المنتج
17 |         public bool IsNew { get; set; } = false; //هل المنتج جديد أم لا
18 |         public bool IsAvailable { get; set; } = true; //هل المنتج متاح للبيع أم لا
19 |                         
20 |         //
21 |         public bool IsApproved { get; set; } = false; //  المنتج يحتاج موافقة الأدمن
22 | 
23 |         public int StockQuantity { get; set; } = 1; //الكمية المتاحة من المنتج في المخزون
24 |         public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //تاريخ إنشاء المنتج
25 |         [CollectionLength(1, 8)] // أقصى عدد للصور المسموح به هو 8
26 |         public string ProductImagesJson { get; set; }        // Navigation properties
27 |         public string UserId { get; set; } // معرف المستخدم الذي أضاف المنتج
28 |         public ApplicationUser User { get; set; } // المستخدم الذي أضاف المنتج
29 |         public ICollection<Rating> Ratings { get; set; } // تقييمات المنتج من قبل المستخدمين
30 |         public Product()
31 |         {
32 |             ProductId = Guid.NewGuid(); // تعيين معرف فريد للمنتج
33 |             CreatedAt = DateTime.UtcNow;
34 |         }
35 | 
36 |         public List<string> GetImages() =>
37 |       string.IsNullOrEmpty(ProductImagesJson) ? new List<string>() : JsonSerializer.Deserialize<List<string>>(ProductImagesJson);
38 | 
39 |         public void SetImages(List<string> images) =>
40 |             ProductImagesJson = JsonSerializer.Serialize(images);
41 |     }
42 | }


--------------------------------------------------------------------------------
/Souqna/Models/Rating.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Models
 2 | {
 3 |     public class Rating
 4 |     {
 5 |         public Guid RatingId { get; set; }
 6 |         public string UserId { get; set; } // معرف المستخدم الذي قام بتقييم المنتج
 7 |         public ApplicationUser User { get; set; } // المستخدم الذي قام بتقييم المنتج
 8 |         public Guid ProductId { get; set; } // معرف المنتج الذي تم تقييمه
 9 |         public Product Product { get; set; } // المنتج الذي تم تقييمه
10 |         public int Stars { get; set; } // عدد النجوم من 1 إلى 5
11 |         public Rating()
12 |         {
13 |             RatingId = Guid.NewGuid(); // تعيين معرف فريد للتقييم 
14 |         }
15 |     }
16 | }
17 | 


--------------------------------------------------------------------------------
/Souqna/Models/Review.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using System.ComponentModel.DataAnnotations;
 3 | 
 4 | namespace Souqna.Models
 5 | {
 6 |     public class Review
 7 |     {
 8 |         [Key]
 9 |         public int Id { get; set; }
10 | 
11 |         [Required(ErrorMessage = "الاسم مطلوب")]
12 |         [StringLength(100)]
13 |         public string Name { get; set; }
14 | 
15 |         [Required(ErrorMessage = "الايميل مطلوب")]
16 |         [EmailAddress]
17 |         public string Email { get; set; }
18 | 
19 |         [Required(ErrorMessage = "عنوان الرسالة مطلوب")]
20 |         [StringLength(200)]
21 |         public string Subject { get; set; }
22 | 
23 |         [Required(ErrorMessage = "الرسالة مطلوبة")]
24 |         [StringLength(1000)]
25 |         public string Description { get; set; }
26 | 
27 |         public DateTime CreatedAt { get; set; } = DateTime.Now;
28 | 
29 |        
30 | 
31 | 
32 | 
33 |         // 🔹 ربط بالمستخدم
34 |         public string? UserId { get; set; }
35 |         public ApplicationUser? User { get; set; }
36 | 
37 |         public bool IsApproved { get; set; } = false; // موافقة الأدمن
38 | 
39 | 
40 | 
41 |     }
42 | }
43 | 


--------------------------------------------------------------------------------
/Souqna/Models/ShoppingCartItem.cs:
--------------------------------------------------------------------------------
 1 | ﻿using System;
 2 | using System.Collections.Generic;
 3 | using System.ComponentModel.DataAnnotations;
 4 | using System.Linq;
 5 | using System.Threading.Tasks;
 6 | 
 7 | namespace Souqna.Models
 8 | {
 9 |     public class ShoppingCartItem
10 |     {
11 |         [Key]
12 |         public int Id { get; set; }
13 |         
14 |         public Product Product { get; set; } // المنتج الذي ينتمي إليه هذا العنصر في عربة التسوق
15 |         public int Amount { get; set; } // الكمية المطلوبة من المنتج في عربة التسوق
16 |         public string ShoppingCartId { get; set; } // معرف عربة التسوق التي ينتمي إليها هذا العنصر
17 |     }
18 | }
19 | 


--------------------------------------------------------------------------------
/Souqna/Program.cs:
--------------------------------------------------------------------------------
  1 | ﻿using Microsoft.AspNetCore.Authentication.Cookies;
  2 | using Microsoft.AspNetCore.Identity;
  3 | using Microsoft.EntityFrameworkCore;
  4 | using Souqna.Data;
  5 | using Souqna.Data.Cart;
  6 | using Souqna.Data.Repositories;
  7 | using Souqna.Data.Services;
  8 | using Souqna.Models;
  9 | using System;
 10 | 
 11 | using Microsoft.AspNetCore.Identity.UI.Services;
 12 | using Souqna.Services;
 13 | using Souqna.Services.Payments;
 14 | using Souqna.Services.Notifications;
 15 | using Souqna.Hubs;
 16 | 
 17 | var builder = WebApplication.CreateBuilder(args);
 18 | 
 19 | // Add services to the container.
 20 | 
 21 | 
 22 | builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
 23 | {
 24 |     options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
 25 |     options.LoginPath = "/Identity/Account/Login";
 26 |     options.LogoutPath = "/Identity/Account/Logout";
 27 |     options.SlidingExpiration = true;
 28 | });
 29 | 
 30 | 
 31 | // خدمات SignalR
 32 | builder.Services.AddSignalR();
 33 | 
 34 | // خدمة الإشعارات
 35 | builder.Services.AddScoped<INotificationService, SignalRNotificationService>();
 36 | 
 37 | //Repositories
 38 | //
 39 | builder.Services.AddScoped<UnitOfWork>();
 40 | //
 41 | // 🛒 تسجيل الـ Repository
 42 | builder.Services.AddScoped<IRatingRepository, RatingRepository>();
 43 | 
 44 | builder.Services.AddScoped<IRepository<Product>, GenericRepository<Product>>();
 45 | builder.Services.AddScoped<IProductRepository, ProductRepository>();
 46 | builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
 47 | builder.Services.AddScoped<IStateRepository, SessionStateRepository>();
 48 | builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
 49 | 
 50 | builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
 51 | builder.Services.AddSession();
 52 | 
 53 | builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
 54 | 
 55 | 
 56 | var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
 57 | builder.Services.AddDbContext<ApplicationDbContext>(options =>
 58 |     options.UseSqlServer(connectionString));
 59 | 
 60 | //builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
 61 | //builder.Services.AddDatabaseDeveloperPageExceptionFilter();
 62 | 
 63 | //Authentication and authorization
 64 | builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
 65 | builder.Services.AddAuthentication(options =>
 66 | {
 67 |     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
 68 | });
 69 | builder.Services.AddControllersWithViews();
 70 | 
 71 | builder.Services.AddSession();
 72 | builder.Services.AddHttpContextAccessor();
 73 | builder.Services.AddMvc();
 74 | 
 75 | 
 76 | //
 77 | builder.Services.AddSingleton<IEmailSender, FakeEmailSender>();
 78 | //
 79 | 
 80 | 
 81 | 
 82 | //
 83 | // 💳 تسجيل خدمات الدفع
 84 | builder.Services.AddScoped<BalancePaymentService>();
 85 | builder.Services.AddScoped<ShamCashPaymentService>();
 86 | builder.Services.AddScoped<PayPalPaymentService>();
 87 | builder.Services.AddScoped<PaymentFactory>();
 88 | 
 89 | 
 90 | var app = builder.Build();
 91 | 
 92 | app.UseSession();
 93 | 
 94 | // Configure the HTTP request pipeline.
 95 | if (app.Environment.IsDevelopment())
 96 | {
 97 |     app.UseMigrationsEndPoint();
 98 | }
 99 | else
100 | {
101 |     app.UseExceptionHandler("/Home/Error");
102 |     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
103 |     app.UseHsts();
104 | }
105 | 
106 | app.UseHttpsRedirection();
107 | app.UseRouting();
108 | app.UseStaticFiles();
109 | 
110 | app.UseAuthentication();
111 | app.UseAuthorization();
112 | 
113 | app.MapStaticAssets();
114 | 
115 | app.MapControllerRoute(
116 |     name: "default",
117 |     pattern: "{controller=Home}/{action=Index}/{id?}")
118 |     .WithStaticAssets();
119 | 
120 | app.MapRazorPages()
121 |    .WithStaticAssets();
122 | 
123 | app.MapHub<NotificationHub>("/notificationHub");
124 | 
125 | /*using (var serviceScope = app.Services.CreateScope())
126 | {
127 |     var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
128 |     ApplicationDbContext.CreatingInitialTestingDataBase(context); // Seed initial data
129 |     ApplicationDbContext.SeedUsersAndRolesAsync(serviceScope).Wait(); // Seed roles and users
130 | 
131 | }*/
132 | 
133 | 
134 | 
135 | 
136 | //  ����� ������� �������� ����� admin
137 | using (var scope = app.Services.CreateScope())
138 | {
139 |     var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
140 |     var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
141 | 
142 |     string[] roles = { "Admin", "User" };
143 | 
144 |     // ����� ������� ��� �� ��� ������
145 |     foreach (var role in roles)
146 |     {
147 |         if (!await roleManager.RoleExistsAsync(role))
148 |         {
149 |             await roleManager.CreateAsync(new IdentityRole(role));
150 |         }
151 |     }
152 | 
153 |     // ����� ������ Admin ��������
154 |     string adminEmail = "Admin@1A.com";
155 |     string adminPassword = "Admin@1A";
156 |     var admin = await userManager.FindByEmailAsync(adminEmail);
157 | 
158 |     if (admin == null)
159 |     {
160 |         var newAdmin = new ApplicationUser
161 |         {
162 |             UserName = adminEmail,
163 |             Email = adminEmail,
164 |             FullName = "Administrator",
165 |             Role = "Admin",
166 |             EmailConfirmed = true
167 |         };
168 | 
169 |         var result = await userManager.CreateAsync(newAdmin, adminPassword);
170 |         if (result.Succeeded)
171 |         {
172 |             await userManager.AddToRoleAsync(newAdmin, "Admin");
173 |         }
174 |     }
175 | }
176 | 
177 | app.Run();
178 | 


--------------------------------------------------------------------------------
/Souqna/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | ﻿{
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": true,
 8 |       "applicationUrl": "http://localhost:5028",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": true,
17 |       "applicationUrl": "https://localhost:7147;http://localhost:5028",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/Souqna/Properties/serviceDependencies.json:
--------------------------------------------------------------------------------
1 | {
2 |   "dependencies": {
3 |     "mssql1": {
4 |       "type": "mssql",
5 |       "connectionId": "ConnectionStrings:DefaultConnection"
6 |     }
7 |   }
8 | }


--------------------------------------------------------------------------------
/Souqna/Properties/serviceDependencies.local.json:
--------------------------------------------------------------------------------
1 | {
2 |   "dependencies": {
3 |     "mssql1": {
4 |       "type": "mssql.local",
5 |       "connectionId": "ConnectionStrings:DefaultConnection"
6 |     }
7 |   }
8 | }


--------------------------------------------------------------------------------
/Souqna/Services/FakeEmailSender.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Identity.UI.Services;
 2 | 
 3 | namespace Souqna.Services
 4 | {
 5 |     public class FakeEmailSender : IEmailSender
 6 |     {
 7 |         public Task SendEmailAsync(string email, string subject, string htmlMessage)
 8 |         {
 9 |             Console.WriteLine(
quot;[FakeEmailSender] Email to: {email}, Subject: {subject}");
10 |             return Task.CompletedTask;
11 |         }
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/Souqna/Services/Notifications/INotificationService.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.SignalR;
 2 | using Souqna.Data;
 3 | using Souqna.Hubs;
 4 | using Souqna.Models;
 5 | 
 6 | namespace Souqna.Services.Notifications
 7 | {
 8 |     public interface INotificationService // واجهة خدمة الإشعارات
 9 |     {
10 |         Task NotifyUserAsync(string userId, string message, string? url = null);
11 |         Task NotifyAdminsAsync(string message, string? url = null);
12 |     }
13 | 
14 |     public class SignalRNotificationService : INotificationService // خدمة الإشعارات باستخدام SignalR
15 |     {
16 |         private readonly IHubContext<NotificationHub> _hub;
17 |         private readonly ApplicationDbContext _context;
18 | 
19 |         public SignalRNotificationService(IHubContext<NotificationHub> hub, ApplicationDbContext context)
20 |         {
21 |             _context = context;
22 |             _hub = hub;
23 |         }
24 | 
25 |         public async Task NotifyUserAsync(string userId, string message, string? url = null)
26 |         {
27 |             // ✅ 1. حفظ في قاعدة البيانات
28 |             var notification = new Notification
29 |             {
30 |                 UserId = userId,
31 |                 Message = message,
32 |                 Url = url,
33 |                 CreatedAt = DateTime.UtcNow
34 |             };
35 |             _context.Notifications.Add(notification);
36 |             await _context.SaveChangesAsync();
37 | 
38 |             // ✅ 2. إرسال عبر SignalR
39 |             await _hub.Clients.User(userId).SendAsync("ReceiveNotification", new
40 |             {
41 |                 message,
42 |                 url
43 |             });
44 |         }
45 | 
46 |         public async Task NotifyAdminsAsync(string message, string? url = null)
47 |         {
48 |             // لو عندك أكثر من أدمن، خزن لكل واحد
49 |             var admins = _context.Users.Where(u => u.Role == "Admin").ToList();
50 | 
51 |             foreach (var admin in admins)
52 |             {
53 |                 var notification = new Notification
54 |                 {
55 |                     UserId = admin.Id,
56 |                     Message = message,
57 |                     Url = url,
58 |                     CreatedAt = DateTime.UtcNow
59 |                 };
60 |                 _context.Notifications.Add(notification);
61 |             }
62 | 
63 |             await _context.SaveChangesAsync();
64 | 
65 |             await _hub.Clients.Group("Admin").SendAsync("ReceiveNotification", new
66 |             {
67 |                 message,
68 |                 url
69 |             });
70 |         }
71 |     }
72 | }
73 | 


--------------------------------------------------------------------------------
/Souqna/Services/Payments/BalancePaymentService.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.EntityFrameworkCore;
 2 | using Souqna.Data;
 3 | using Souqna.Models;
 4 | 
 5 | namespace Souqna.Services.Payments
 6 | {
 7 |     public class BalancePaymentService : IPaymentService
 8 |     {
 9 |         private readonly ApplicationDbContext _context;
10 | 
11 |         public BalancePaymentService(ApplicationDbContext context)
12 |         {
13 |             _context = context;
14 |         }
15 | 
16 |         public async Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount)
17 |         {
18 |             var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
19 |             if (user == null) return ServiceResponse<bool>.Fail("المستخدم غير موجود");
20 | 
21 |             if (user.Balance < amount)
22 |                 return ServiceResponse<bool>.Fail("❌ الرصيد غير كافٍ");
23 | 
24 |             user.Balance -= amount;
25 |             _context.Users.Update(user);
26 |             await _context.SaveChangesAsync();
27 | 
28 |             return ServiceResponse<bool>.Success(true, "✅ تم الدفع من الرصيد");
29 |         }
30 |     }
31 | }
32 | 


--------------------------------------------------------------------------------
/Souqna/Services/Payments/IPaymentService.cs:
--------------------------------------------------------------------------------
1 | ﻿namespace Souqna.Services.Payments
2 | {
3 |     public interface IPaymentService
4 |     {
5 |         Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount);
6 |     }
7 | }
8 | 


--------------------------------------------------------------------------------
/Souqna/Services/Payments/PayPalPaymentService.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Services.Payments
 2 | {
 3 |     public class PayPalPaymentService : IPaymentService
 4 |     {
 5 |         public Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount)
 6 |         {
 7 |             // TODO: إضافة تكامل مع PayPal API
 8 |             return Task.FromResult(ServiceResponse<bool>.Success(true, 
quot;🌍 تم الدفع عبر PayPal: {amount}"));
 9 |         }
10 |     }
11 | }
12 | 


--------------------------------------------------------------------------------
/Souqna/Services/Payments/PaymentFactory.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Services.Payments
 2 | {
 3 |     public class PaymentFactory
 4 |     {
 5 |         private readonly BalancePaymentService _balancePaymentService;
 6 |         private readonly ShamCashPaymentService _shamCashPaymentService;
 7 |         private readonly PayPalPaymentService _payPalPaymentService;
 8 | 
 9 |         public PaymentFactory(
10 |             BalancePaymentService balancePaymentService,
11 |             ShamCashPaymentService shamCashPaymentService,
12 |             PayPalPaymentService payPalPaymentService)
13 |         {
14 |             _balancePaymentService = balancePaymentService;
15 |             _shamCashPaymentService = shamCashPaymentService;
16 |             _payPalPaymentService = payPalPaymentService;
17 |         }
18 | 
19 |         public IPaymentService GetPaymentService(string method)
20 |         {
21 |             return method switch
22 |             {
23 |                 "Balance" => _balancePaymentService,
24 |                 "ShamCash" => _shamCashPaymentService,
25 |                 "PayPal" => _payPalPaymentService,
26 |                 _ => throw new ArgumentException("❌ طريقة الدفع غير معروفة")
27 |             };
28 |         }
29 |     }
30 | }
31 | 


--------------------------------------------------------------------------------
/Souqna/Services/Payments/ShamCashPaymentService .cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Services.Payments
 2 | {
 3 |     public class ShamCashPaymentService : IPaymentService
 4 |     {
 5 |         public Task<ServiceResponse<bool>> ProcessPaymentAsync(string userId, double amount)
 6 |         {
 7 |             // TODO: إضافة تكامل مع ShamCash API
 8 |             return Task.FromResult(ServiceResponse<bool>.Success(true, 
quot;🚀 تم الدفع عبر شام كاش: {amount}"));
 9 |         }
10 |     }
11 | }
12 | 


--------------------------------------------------------------------------------
/Souqna/Services/ServiceResponse.cs:
--------------------------------------------------------------------------------
 1 | ﻿namespace Souqna.Services
 2 | {
 3 |     public class ServiceResponse<T>
 4 |     {
 5 |         public bool IsSuccess { get; set; }
 6 |         public string Message { get; set; }
 7 |         public T? Data { get; set; }
 8 | 
 9 |         public static ServiceResponse<T> Success(T data, string message = "تمت العملية بنجاح")
10 |         {
11 |             return new ServiceResponse<T> { IsSuccess = true, Data = data, Message = message };
12 |         }
13 | 
14 |         public static ServiceResponse<T> Fail(string message)
15 |         {
16 |             return new ServiceResponse<T> { IsSuccess = false, Message = message };
17 |         }
18 |     }
19 | }
20 | 


--------------------------------------------------------------------------------
/Souqna/Souqna.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net9.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |     <UserSecretsId>aspnet-Souqna-b13ace01-d2d4-4652-9d18-c0be6cc9ec38</UserSecretsId>
 8 |   </PropertyGroup>
 9 | 
10 |   <ItemGroup>
11 |     <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="9.0.7" />
12 |     <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="9.0.7" />
13 |     <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="9.0.7" />
14 |     <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="9.0.8">
15 |       <PrivateAssets>all</PrivateAssets>
16 |       <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
17 |     </PackageReference>
18 |     <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="9.0.0" />
19 |     <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.8" />
20 |     <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.8">
21 |       <PrivateAssets>all</PrivateAssets>
22 |       <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
23 |     </PackageReference>
24 |     <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="9.0.0" />
25 |   </ItemGroup>
26 | 
27 |   <ItemGroup>
28 |     <Folder Include="Data\Migrations\" />
29 |     <Folder Include="Views\Shared\components\ProductList\" />
30 |     <Folder Include="wwwroot\images\products\" />
31 |   </ItemGroup>
32 | 
33 | </Project>
34 | 


--------------------------------------------------------------------------------
/Souqna/ViewComponents/NotificationsViewComponent.cs:
--------------------------------------------------------------------------------
 1 | ﻿using Microsoft.AspNetCore.Mvc;
 2 | using Microsoft.AspNetCore.Identity;
 3 | using Souqna.Data;
 4 | using Souqna.Models;
 5 | 
 6 | namespace Souqna.ViewComponents
 7 | {
 8 |     public class NotificationsViewComponent : ViewComponent
 9 |     {
10 |         private readonly ApplicationDbContext _context;
11 |         private readonly UserManager<ApplicationUser> _userManager;
12 | 
13 |         public NotificationsViewComponent(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
14 |         {
15 |             _context = context;
16 |             _userManager = userManager;
17 |         }
18 | 
19 |         public async Task<IViewComponentResult> InvokeAsync()
20 |         {
21 |             var user = await _userManager.GetUserAsync(HttpContext.User);
22 |             if (user == null)
23 |                 return View(new List<Notification>());
24 | 
25 |             var notifications = _context.Notifications
26 |                 .Where(n => n.UserId == user.Id)
27 |                 .OrderByDescending(n => n.CreatedAt)
28 |                 .Take(10) // آخر 10 إشعارات
29 |                 .ToList();
30 | 
31 |             // حساب عدد الإشعارات غير المقروءة
32 |             ViewBag.UnreadCount = _context.Notifications.Count(n => n.UserId == user.Id && !n.IsRead);
33 | 
34 | 
35 |             return View(notifications);
36 | 
37 |             // حساب عدد الإشعارات غير المقروءة
38 |             
39 |         }
40 |     }
41 | }
42 | 


--------------------------------------------------------------------------------
/Souqna/Views/Account/DeleteUser.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.ApplicationUser
 2 | 
 3 | @{
 4 |     ViewData["Title"] = "حذف مستخدم";
 5 | }
 6 | 
 7 | <h2 class="text-danger">⚠️ تأكيد حذف المستخدم</h2>
 8 | 
 9 | <div class="alert alert-warning">
10 |     هل أنت متأكد أنك تريد حذف هذا المستخدم؟ 🚨
11 | </div>
12 | 
13 | <table class="table table-bordered">
14 |     <tr>
15 |         <th>الاسم</th>
16 |         <td>@Model.FullName</td>
17 |     </tr>
18 |     <tr>
19 |         <th>البريد الإلكتروني</th>
20 |         <td>@Model.Email</td>
21 |     </tr>
22 |     <tr>
23 |         <th>الدور</th>
24 |         <td>@Model.Role</td>
25 |     </tr>
26 | </table>
27 | 
28 | <form asp-action="DeleteUser" method="post">
29 |     <input type="hidden" asp-for="Id" />
30 |     <button type="submit" class="btn btn-danger">🗑 حذف</button>
31 |     <a asp-action="Users" class="btn btn-secondary">⬅ إلغاء</a>
32 | </form>
33 | 


--------------------------------------------------------------------------------
/Souqna/Views/Account/EditUser.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.ApplicationUser
 2 | @{
 3 |     ViewData["Title"] = "تعديل مستخدم";
 4 | }
 5 | 
 6 | <h2 class="mb-4">تعديل بيانات المستخدم</h2>
 7 | 
 8 | <form asp-action="EditUser" method="post">
 9 |     @Html.AntiForgeryToken()
10 |     <input type="hidden" asp-for="Id" />
11 | 
12 |     <div class="mb-3">
13 |         <label asp-for="FullName" class="form-label"></label>
14 |         <input asp-for="FullName" class="form-control" />
15 |         <span asp-validation-for="FullName" class="text-danger"></span>
16 |     </div>
17 | 
18 |     <div class="mb-3">
19 |         <label asp-for="Email" class="form-label"></label>
20 |         <input asp-for="Email" class="form-control" />
21 |         <span asp-validation-for="Email" class="text-danger"></span>
22 |     </div>
23 | 
24 |     <div class="mb-3">
25 |         <label asp-for="Address" class="form-label"></label>
26 |         <input asp-for="Address" class="form-control" />
27 |         <span asp-validation-for="Address" class="text-danger"></span>
28 |     </div>
29 | 
30 |     <div class="mb-3">
31 |         <label asp-for="Birthday" class="form-label"></label>
32 |         <input asp-for="Birthday" type="date" class="form-control" />
33 |         <span asp-validation-for="Birthday" class="text-danger"></span>
34 |     </div>
35 | 
36 |     <div class="mb-3">
37 |         <label asp-for="Role" class="form-label"></label>
38 |         <select asp-for="Role" class="form-select">
39 |             <option value="">اختر الدور</option>
40 |             <option value="Admin">مدير</option>
41 |             <option value="User">مستخدم</option>
42 |             <!-- أضف أدوار أخرى إن عندك -->
43 |         </select>
44 |         <span asp-validation-for="Role" class="text-danger"></span>
45 |     </div>
46 | 
47 |     <button type="submit" class="btn btn-primary">حفظ التعديلات</button>
48 |     <a asp-action="Users" class="btn btn-secondary">إلغاء</a>
49 | </form>
50 | 
51 | @section Scripts {
52 |     @{
53 |         await Html.RenderPartialAsync("_ValidationScriptsPartial");
54 |     }
55 | }
56 | 


--------------------------------------------------------------------------------
/Souqna/Views/Account/MyAccount.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.ApplicationUser
 2 | @Html.AntiForgeryToken()
 3 | 
 4 | 
 5 | @{
 6 |     ViewData["Title"] = "الملف الشخصي";
 7 | }
 8 | 
 9 | <div class="container mt-5">
10 |     <h2 class="mb-4">الملف الشخصي</h2>
11 | 
12 |     @if (TempData["Success"] != null)
13 |     {
14 |         <div class="alert alert-success">@TempData["Success"]</div>
15 |     }
16 | 
17 |     <form asp-action="MyAccount" method="post" enctype="multipart/form-data" class="row g-3">
18 | 
19 |         <input type="hidden" asp-for="Id" />
20 | 
21 |         <div class="col-md-4 text-center">
22 |             <img src="@(Model.ProfileImage ?? "/images/default-profile.png")"
23 |                  class="img-thumbnail rounded-circle mb-3"
24 |                  style="width:200px; height:200px; object-fit:cover;" />
25 | 
26 |             <input type="file" name="profileImage" class="form-control" />
27 |         </div>
28 | 
29 |         <div class="col-md-8">
30 |             <div class="mb-3">
31 |                 <label asp-for="FullName" class="form-label">الاسم الكامل</label>
32 |                 <input asp-for="FullName" class="form-control" />
33 |             </div>
34 | 
35 |             <div class="mb-3">
36 |                 <label asp-for="Email" class="form-label">البريد الإلكتروني</label>
37 |                 <input asp-for="Email" class="form-control" readonly />
38 |             </div>
39 | 
40 |             <div class="mb-3">
41 |                 <label asp-for="Birthday" class="form-label">تاريخ الميلاد</label>
42 |                 <input asp-for="Birthday" class="form-control" type="date" />
43 |             </div>
44 | 
45 |             <div class="mb-3">
46 |                 <label asp-for="Address" class="form-label">العنوان</label>
47 |                 <input asp-for="Address" class="form-control" />
48 |             </div>
49 | 
50 |             <div class="mb-3">
51 |                 <div class="mb-3">
52 |                     <label asp-for="Balance" class="form-label fw-bold text-primary">
53 |                         الرصيد
54 |                     </label>
55 |                     <div class="input-group">
56 |                         <span class="input-group-text bg-light text-success fw-bold">💰</span>
57 |                         <input asp-for="Balance" class="form-control text-center fw-bold" readonly />
58 |                         <span class="input-group-text bg-light">ر.س</span>
59 |                     </div>
60 |                 </div>
61 | 
62 |             </div>
63 | 
64 |             <button type="submit" class="btn btn-primary">تحديث</button>
65 |         </div>
66 |     </form>
67 | </div>
68 | 


--------------------------------------------------------------------------------
/Souqna/Views/Account/Users.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model List<Souqna.Models.ApplicationUser>
 2 | 
 3 | <h2>إدارة المستخدمين 👥</h2>
 4 | <table class="table table-bordered">
 5 |     <thead>
 6 |         <tr>
 7 |             <th>الصورة</th>
 8 |             <th>الاسم</th>
 9 |             <th>الإيميل</th>
10 |             <th>الرصيد</th>
11 |             <th>الدور</th>
12 |             <th>التحكم</th>
13 |         </tr>
14 |     </thead>
15 |     <tbody>
16 |         @foreach (var user in Model)
17 |         {
18 |             <tr>
19 |                 <td>
20 |                     <img src="@(string.IsNullOrEmpty(user.ProfileImage) ? "/images/default-user.png" : user.ProfileImage)"
21 |                          style="width:50px;height:50px;border-radius:50%;" />
22 |                 </td>
23 |                 <td>@user.FullName</td>
24 |                 <td>@user.Email</td>
25 |                 <td>@user.Balance.ToString("C")</td>
26 |                 <td>@user.Role</td>
27 |                 <td>
28 |                     <a asp-action="EditUser" asp-route-id="@user.Id" class="btn btn-sm btn-warning">✏ تعديل</a>
29 |                     <a asp-action="DeleteUser" asp-route-id="@user.Id" class="btn btn-sm btn-danger">🗑 حذف</a>
30 |                 </td>
31 |             </tr>
32 |         }
33 |     </tbody>
34 | </table>
35 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminOrders/Delete.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.Order
 2 | 
 3 | <h2>🗑 حذف الطلب</h2>
 4 | 
 5 | <p>هل أنت متأكد أنك تريد حذف الطلب رقم <strong>@Model.OrderId</strong>؟</p>
 6 | 
 7 | <form asp-action="Delete" method="post">
 8 |     <input type="hidden" asp-for="OrderId" />
 9 |     <button type="submit" class="btn btn-danger">نعم، حذف</button>
10 |     <a asp-action="Index" class="btn btn-secondary">إلغاء</a>
11 | </form>
12 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminOrders/Details.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.Order
 2 | 
 3 | <div class="container mt-4">
 4 |     <h2>تفاصيل الطلب</h2>
 5 | 
 6 |     <p><strong>رقم الطلب:</strong> @Model.OrderId</p>
 7 |     <p><strong>المستخدم:</strong> @Model.User?.FullName (@Model.User?.Email)</p>
 8 |     <p><strong>الإجمالي:</strong> @Model.TotalCost.ToString("C")</p>
 9 |     <p><strong>التاريخ:</strong> @Model.OrderedAt.ToLocalTime().ToString("yyyy/MM/dd HH:mm")</p>
10 | 
11 |     <h4>🛒 المنتجات:</h4>
12 |     <ul>
13 |         @foreach (var item in Model.OrderItems)
14 |         {
15 |             <li>@item.product?.Name × @item.Amount = @item.Cost.ToString("C")</li>
16 |         }
17 |     </ul>
18 | 
19 |     <a asp-action="Index" class="btn btn-secondary">⬅ رجوع</a>
20 | </div>
21 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminOrders/Index.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model List<Souqna.Models.Order>
 2 | 
 3 | @{
 4 |     ViewData["Title"] = "إدارة الطلبات";
 5 | }
 6 | 
 7 | <h2 class="mb-4">📦 إدارة الطلبات</h2>
 8 | 
 9 | <table class="table table-bordered table-striped align-middle">
10 |     <thead class="table-dark">
11 |         <tr>
12 |             <th>المستخدم</th>
13 |             <th>الإجمالي</th>
14 |             <th>التاريخ</th>
15 |             <th>المنتجات</th>
16 |             <th>التحكم</th>
17 |         </tr>
18 |     </thead>
19 |     <tbody>
20 |         @foreach (var order in Model)
21 |         {
22 |             <tr>
23 |                 <td>
24 |                     @order.User?.FullName <br />
25 |                     <small class="text-muted">@order.User?.Email</small>
26 |                 </td>
27 |                 <td>@order.TotalCost.ToString("C")</td>
28 |                 <td>@order.OrderedAt.ToString("yyyy/MM/dd HH:mm")</td>
29 |                 <td>
30 |                     <ul class="mb-0">
31 |                         @foreach (var item in order.OrderItems)
32 |                         {
33 |                             <li>
34 |                                 <b>@item.product?.Name</b> × @item.Amount
35 |                                 <span class="text-muted">( @item.Cost.ToString("C") )</span>
36 |                             </li>
37 |                         }
38 |                     </ul>
39 |                 </td>
40 |                 <td>
41 |                     <a asp-controller="AdminOrders" asp-action="Details" asp-route-id="@order.OrderId" class="btn btn-info btn-sm">👁️ عرض</a>
42 |                     <a asp-controller="AdminOrders" asp-action="Delete" asp-route-id="@order.OrderId" class="btn btn-danger btn-sm">🗑 حذف</a>
43 |                 </td>
44 |             </tr>
45 |         }
46 |     </tbody>
47 | </table>
48 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminProducts/PendingProducts.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model IEnumerable<Souqna.Models.Product>
 2 | 
 3 | @{
 4 |     ViewData["Title"] = "المنتجات المعلقة";
 5 | }
 6 | 
 7 | <h2>📦 المنتجات المعلقة بانتظار المراجعة</h2>
 8 | 
 9 | @if (!Model.Any())
10 | {
11 |     <p class="text-muted">🚀 لا توجد منتجات معلقة حالياً</p>
12 | }
13 | else
14 | {
15 |     <table class="table table-bordered">
16 |         <thead>
17 |             <tr>
18 |                 <th>الاسم</th>
19 |                 <th>الوصف</th>
20 |                 <th>المستخدم</th>
21 |                 <th>التاريخ</th>
22 |                 <th>التحكم</th>
23 |             </tr>
24 |         </thead>
25 |         <tbody>
26 |             @foreach (var product in Model)
27 |             {
28 |                 <tr>
29 |                     <td>@product.Name</td>
30 |                     <td>@product.Description</td>
31 |                     <td>@product.User?.FullName (@product.User?.Email)</td>
32 |                     <td>@product.CreatedAt.ToString("yyyy/MM/dd")</td>
33 |                     <td>
34 |                         <a asp-action="Approve" asp-route-id="@product.ProductId" class="btn btn-success btn-sm">✔ موافقة</a>
35 |                         <a asp-action="Reject" asp-route-id="@product.ProductId" class="btn btn-danger btn-sm">❌ رفض</a>
36 |                     </td>
37 |                 </tr>
38 |             }
39 |         </tbody>
40 |     </table>
41 | }
42 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminReviews/Delete.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.Review
 2 | 
 3 | <h2>🗑 تأكيد الحذف</h2>
 4 | 
 5 | <div class="alert alert-danger">
 6 |     <h4>هل أنت متأكد أنك تريد حذف هذا الرأي؟</h4>
 7 |     <p><strong>الاسم:</strong> @Model.Name</p>
 8 |     <p><strong>العنوان:</strong> @Model.Subject</p>
 9 |     <p><strong>الوصف:</strong> @Model.Description</p>
10 | </div>
11 | 
12 | <form asp-action="Delete" method="post">
13 |     <input type="hidden" asp-for="Id" />
14 |     <button type="submit" class="btn btn-danger">🗑 نعم، احذف</button>
15 |     <a asp-action="Index" class="btn btn-secondary">⬅ إلغاء</a>
16 | </form>
17 | 


--------------------------------------------------------------------------------
/Souqna/Views/AdminReviews/Index.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model IEnumerable<Souqna.Models.Review>
 2 | 
 3 | <h2>إدارة الآراء 📝</h2>
 4 | <table class="table table-bordered">
 5 |     <thead>
 6 |         <tr>
 7 |             <th>الاسم</th>
 8 |             <th>العنوان</th>
 9 |             <th>الوصف</th>
10 |             <th>الحالة</th>
11 |             <th>التحكم</th>
12 |         </tr>
13 |     </thead>
14 |     <tbody>
15 |         @foreach (var review in Model)
16 |         {
17 |             <tr>
18 |                 <td>@review.Name</td>
19 |                 <td>@review.Subject</td>
20 |                 <td>@review.Description</td>
21 |                 <td>
22 |                     @if (review.IsApproved)
23 |                     {
24 |                         <span class="badge bg-success">مقبول ✅</span>
25 |                     }
26 |                     else
27 |                     {
28 |                         <span class="badge bg-warning">قيد المراجعة ⏳</span>
29 |                     }
30 |                 </td>
31 |                 <td>
32 |                     @if (!review.IsApproved)
33 |                     {
34 |                         <a asp-action="Approve"
35 |                            asp-route-id="@review.Id"
36 |                            class="btn btn-success btn-sm">✔ موافقة</a>
37 |                     }
38 |                     <a asp-action="Delete" asp-route-id="@review.Id" class="btn btn-danger btn-sm">🗑 حذف</a>
39 |                 </td>
40 |             </tr>
41 |         }
42 |     </tbody>
43 | </table>
44 | 


--------------------------------------------------------------------------------
/Souqna/Views/Cart/MyAccount.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Data.ViewModels.MyAccountVM
 2 | 
 3 | <div class="container my-5" >
 4 | 
 5 |     <h2 class="mb-4">المنتجات في السلة</h2>
 6 |     @if (Model.CartItems != null && Model.CartItems.Any())
 7 |     {
 8 |         <ul class="list-group mb-5">
 9 |             @foreach (var item in Model.CartItems)
10 |             {
11 |                 var image = item.Product.GetImages().FirstOrDefault() ?? "/images/no-image.png";
12 |                 <li class="list-group-item d-flex align-items-center justify-content-between">
13 |                     <div class="d-flex align-items-center gap-3">
14 |                         <img src="@image" alt="@item.Product.Name" width="50" class="rounded" />
15 |                         <span>@item.Product.Name</span>
16 |                     </div>
17 |                     <span class="badge bg-primary">الكمية: @item.Amount</span>
18 |                 </li>
19 |             }
20 |         </ul>
21 |     }
22 |     else
23 |     {
24 |         <p class="text-muted">السلة فارغة.</p>
25 |     }
26 | 
27 |     <hr />
28 | 
29 |     <h2 class="mb-4">المنتجات التي قمت بشرائها</h2>
30 |     <div class="row g-4">
31 |         @if (Model.PurchasedProducts.Any())
32 |         {
33 |             @foreach (var item in Model.PurchasedProducts)
34 |             {
35 |                 var product = item.product;
36 |                 var image = product.GetImages().FirstOrDefault() ?? "/images/no-image.png";
37 |                 <div class="col-lg-3 col-md-4 col-sm-6">
38 |                     <div class="card h-100">
39 |                         <a asp-controller="Product" asp-action="Details" asp-route-id="@product.ProductId">
40 |                             <img src="@image" class="card-img-top" alt="@product.Name" />
41 |                         </a>
42 |                         <div class="card-body">
43 |                             <h5 class="card-title">@product.Name</h5>
44 |                             <p class="card-text text-success">@product.PriceOfUnit.ToString("C")</p>
45 |                             <p class="card-text">الكمية: @item.Amount</p>
46 |                         </div>
47 |                     </div>
48 |                 </div>
49 |             }
50 |         }
51 |         else
52 |         {
53 |             <p class="text-muted">ليس لديك منتجات تم شراؤها.</p>
54 |         }
55 |     </div>
56 | 
57 | 
58 |     <hr />
59 | 
60 |     <h2 class="mb-4">منتجاتك المعروضة للبيع</h2>
61 |     <div class="row g-4">
62 |         @if (Model.SoldProducts.Any())
63 |         {
64 |             @foreach (var product in Model.SoldProducts)
65 |             {
66 |                 var image = product.GetImages().FirstOrDefault() ?? "/images/no-image.png";
67 |                 <div class="col-lg-3 col-md-4 col-sm-6">
68 |                     <div class="card h-100">
69 |                         <a asp-controller="Product" asp-action="Details" asp-route-id="@product.ProductId">
70 |                             <img src="@image" class="card-img-top" alt="@product.Name" />
71 |                         </a>
72 |                         <div class="card-body">
73 |                             <h5 class="card-title">@product.Name</h5>
74 |                             <p class="card-text text-success">@product.PriceOfUnit.ToString("C")</p>
75 |                             <p class="card-text">الكمية: @product.StockQuantity</p>
76 | 
77 |                             <div class="d-flex gap-2">
78 |                                 <a asp-controller="Product" asp-action="Details" asp-route-id="@product.ProductId" class="btn btn-outline-primary btn-sm">عرض التفاصيل</a>
79 |                                 <a asp-controller="Product" asp-action="Edit" asp-route-id="@product.ProductId" class="btn btn-warning btn-sm">تعديل</a>
80 |                                 <form asp-area="User" asp-controller="Product" asp-action="Delete" asp-route-id="@product.ProductId" method="post" onsubmit="return confirm('هل أنت متأكد أنك تريد حذف هذا المنتج؟');" style="display:inline;">
81 |                                     @Html.AntiForgeryToken()
82 |                                     <button type="submit" class="btn btn-danger btn-sm">حذف</button>
83 |                                 </form>
84 |                             </div>
85 |                         </div>
86 |                     </div>
87 |                 </div>
88 |             }
89 |         }
90 |         else
91 |         {
92 |             <p class="text-muted">ليس لديك منتجات معروضة للبيع.</p>
93 |         }
94 |     </div>
95 | </div>
96 | 
97 | 


--------------------------------------------------------------------------------
/Souqna/Views/Home/Privacy.cshtml:
--------------------------------------------------------------------------------
1 | ﻿@{
2 |     ViewData["Title"] = "Privacy Policy";
3 | }
4 | <h1>@ViewData["Title"]</h1>
5 | 
6 | <p>Use this page to detail your site's privacy policy.</p>
7 | 


--------------------------------------------------------------------------------
/Souqna/Views/Home/_ProductsPartial.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model IEnumerable<Souqna.Models.Product>
 2 | 
 3 | <div class="row gy-4 isotope-container" data-aos="fade-up" data-aos-delay="200">
 4 |     @foreach (var product in Model)
 5 |     {
 6 |         // إنشاء كلاس الفلترة بناءً على الفئة
 7 |         var filterClass = "filter-" + product.Category.ToString().Replace(" ", "").ToLower();
 8 | 
 9 |         // اختيار الصور: لو عندك GetImages() استعمله، وإلا استخدم ProductImages
10 |         var images = product.GetImages() ?? new List<string>();
11 |         var firstImage = images.FirstOrDefault() ?? "/images/no-image.png";
12 | 
13 |         <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item isotope-item @filterClass">
14 |             <div class="product-card shadow-sm rounded bg-white h-100 d-flex flex-column">
15 |                 <a href="@Url.Action("Details", "Product", new { id = product.ProductId })" class="image-link">
16 |                     <img src="@firstImage" alt="@product.Name" class="product-image rounded-top" />
17 |                 </a>
18 |                 <div class="product-info p-3 d-flex flex-column flex-grow-1">
19 |                     <h5 class="product-title mb-1">
20 |                         <a href="@Url.Action("Details", "Product", new { id = product.ProductId })"
21 |                            class="text-dark text-decoration-none">
22 |                             @product.Name
23 |                         </a>
24 |                     </h5>
25 |                     <p class="product-description text-muted small mb-2" style="height: 40px; overflow: hidden;">
26 |                         @product.Description
27 |                     </p>
28 |                     <p class="product-description text-muted small mb-2">
29 |                         الكمية المتاحة: @product.StockQuantity
30 |                     </p>
31 |                     <div class="mt-auto d-flex justify-content-between align-items-center">
32 |                         <span class="text-success fw-bold">@product.PriceOfUnit.ToString("C")</span>
33 |                         <a href="@Url.Action("Details", "Product", new { id = product.ProductId })"
34 |                            class="btn btn-sm btn-outline-primary">
35 |                             التفاصيل
36 |                         </a>
37 |                     </div>
38 |                 </div>
39 |             </div>
40 |         </div>
41 |     }
42 | </div>
43 | 


--------------------------------------------------------------------------------
/Souqna/Views/Product/Create.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Data.ViewModels.ProductVM
 2 | @using Souqna.Data.Enums
 3 | 
 4 | 
 5 | @{
 6 |     ViewData["Title"] = "إضافة منتج جديد";
 7 | }
 8 | 
 9 | <h2 class="mb-4">إضافة منتج جديد</h2>
10 | 
11 | <form asp-action="Create" method="post" enctype="multipart/form-data" class="row g-3">
12 |     <div asp-validation-summary="All" class="text-danger mb-2"></div>
13 | 
14 |     <div class="col-md-6">
15 |         <label asp-for="Name" class="form-label">اسم المنتج</label>
16 |         <input asp-for="Name" class="form-control" placeholder="أدخل اسم المنتج" />
17 |         <span asp-validation-for="Name" class="text-danger"></span>
18 |     </div>
19 | 
20 |     <div class="col-md-6">
21 |         <label asp-for="PriceOfUnit" class="form-label">سعر الوحدة</label>
22 |         <input asp-for="PriceOfUnit" type="number" step="0.01" class="form-control" placeholder="0.00" />
23 |         <span asp-validation-for="PriceOfUnit" class="text-danger"></span>
24 |     </div>
25 | 
26 |     <div class="col-12">
27 |         <label asp-for="Description" class="form-label">وصف المنتج</label>
28 |         <textarea asp-for="Description" class="form-control" rows="3" placeholder="أدخل وصف المنتج"></textarea>
29 |         <span asp-validation-for="Description" class="text-danger"></span>
30 |     </div>
31 | 
32 |     <div class="col-md-6">
33 |         <label asp-for="Category" class="form-label">فئة المنتج</label>
34 |         <select asp-for="Category" class="form-select" asp-items="Html.GetEnumSelectList<ProductEnums.ProductCategory>()">
35 |             <option value="">-- اختر فئة --</option>
36 |         </select>
37 |         <span asp-validation-for="Category" class="text-danger"></span>
38 |     </div>
39 | 
40 |     <div class="col-md-6">
41 |         <label asp-for="Unit" class="form-label">وحدة القياس</label>
42 | 
43 |         <select asp-for="Unit" class="form-select" asp-items="Html.GetEnumSelectList<ProductEnums.UnitOfMeasurement>()">
44 |             <option value="">-- اختر وحدة --</option>
45 |         </select>
46 |         <span asp-validation-for="Unit" class="text-danger"></span>
47 |     </div>
48 | 
49 |     <div class="col-md-6">
50 |         <label asp-for="StockQuantity" class="form-label">الكمية المتاحة</label>
51 |         <input asp-for="StockQuantity" class="form-control" min="1" />
52 |         <span asp-validation-for="StockQuantity" class="text-danger"></span>
53 |     </div>
54 | 
55 |     <div class="col-md-6">
56 |         <label asp-for="IsNew" class="form-label">هل المنتج جديد؟</label>
57 |         <input asp-for="IsNew" type="checkbox" class="form-check-input ms-2" />
58 |     </div>
59 | 
60 |     <div class="col-12">
61 |         <label class="form-label">صور المنتج (بحد أقصى 8 صور)</label>
62 |         <input asp-for="UploadedImages" type="file" multiple class="form-control" accept="image/*" />
63 |         <span asp-validation-for="UploadedImages" class="text-danger"></span>
64 |     </div>
65 | 
66 |     <div class="col-12">
67 |         <button type="submit" class="btn btn-primary">حفظ المنتج</button>
68 |         <a asp-action="Index" class="btn btn-secondary">إلغاء</a>
69 |     </div>
70 | </form>
71 | 
72 | @section Scripts {
73 |     <partial name="_ValidationScriptsPartial" />
74 | }
75 | 


--------------------------------------------------------------------------------
/Souqna/Views/Product/Delete.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Models.Product
 2 | 
 3 | @{
 4 |     ViewData["Title"] = "حذف المنتج";
 5 | }
 6 | 
 7 | <h2>حذف المنتج</h2>
 8 | 
 9 | <h4>هل أنت متأكد أنك تريد حذف هذا المنتج؟</h4>
10 | 
11 | <div>
12 |     <h5>@Model.Name</h5>
13 |     <p>@Model.Description</p>
14 |     <p>السعر: @Model.PriceOfUnit.ToString("C")</p>
15 | </div>
16 | 
17 | <form asp-action="Delete" method="post">
18 |     @Html.AntiForgeryToken()
19 |     <input type="hidden" asp-for="ProductId" />
20 |     <button type="submit" class="btn btn-danger">حذف</button>
21 |     <a asp-action="Index" class="btn btn-secondary">إلغاء</a>
22 | </form>
23 | 


--------------------------------------------------------------------------------
/Souqna/Views/Product/Details.cshtml:
--------------------------------------------------------------------------------
  1 | ﻿@model Souqna.Models.Product
  2 | 
  3 | @{
  4 |     ViewData["Title"] = "تفاصيل المنتج";
  5 |     var images = Model.GetImages();
  6 | }
  7 | 
  8 | <div class="container py-5">
  9 |     <div class="row g-4">
 10 |         <!-- عرض صور المنتج -->
 11 |         <div class="col-lg-6">
 12 |             <div class="swiper mySwiper shadow-sm rounded bg-white p-3">
 13 |                 <div class="swiper-wrapper">
 14 |                     @if (images != null && images.Any())
 15 |                     {
 16 |                         foreach (var img in images)
 17 |                         {
 18 |                             <div class="swiper-slide">
 19 |                                 <img src="@img" alt="@Model.Name" class="img-fluid rounded" loading="lazy" />
 20 |                             </div>
 21 |                         }
 22 |                     }
 23 |                     else
 24 |                     {
 25 |                         <div class="swiper-slide">
 26 |                             <img src="/images/no-image.png" alt="لا توجد صور" class="img-fluid rounded" />
 27 |                         </div>
 28 |                     }
 29 |                 </div>
 30 |                 <div class="swiper-pagination"></div>
 31 |                 <div class="swiper-button-next"></div>
 32 |                 <div class="swiper-button-prev"></div>
 33 |             </div>
 34 |         </div>
 35 | 
 36 |         <!-- عرض تفاصيل المنتج -->
 37 |         <div class="col-lg-6">
 38 |             <div class="card shadow-sm border-0 rounded h-100">
 39 |                 <div class="card-body d-flex flex-column h-100">
 40 | 
 41 |                     <!-- العنوان والسعر -->
 42 |                     <div class="mb-3">
 43 |                         <h2 class="card-title fw-bold mb-1">@Model.Name</h2>
 44 |                         <p class="text-muted">التصنيف: @Model.Category</p>
 45 |                         <span class="fw-bold fs-4 text-success">@Model.PriceOfUnit.ToString("C")</span>
 46 |                     </div>
 47 | 
 48 |                     <!-- تفاصيل إضافية -->
 49 |                     <ul class="list-unstyled mb-4 flex-grow-1">
 50 |                         <li><strong>الكمية المتاحة:</strong> @Model.StockQuantity</li>
 51 |                         <li><strong>الوصف:</strong> @Model.Description</li>
 52 |                         <li><strong>البائع:</strong> @Model.User?.FullName</li>
 53 |                         <li><strong>تاريخ الإضافة:</strong> @Model.CreatedAt.ToString("yyyy/MM/dd")</li>
 54 |                     </ul>
 55 | 
 56 |                     <!-- ✅ التقييم دائمًا في الأسفل -->
 57 |                     <div class="p-3 rounded shadow-sm mb-3" style="background:#e9f9ee;">
 58 |                         <div class="rating-box w-100">
 59 |                             <div class="d-flex align-items-center mb-2">
 60 |                                 <span class="me-2 text-warning fs-4">⭐</span>
 61 |                                 <span class="fw-bold">التقييمات</span>
 62 |                             </div>
 63 | 
 64 |                             <p class="mb-2 text-muted">
 65 |                                 معدل التقييم:
 66 |                                 <strong class="text-warning">@ViewBag.AverageRating.ToString("0.0")</strong> / 5
 67 |                             </p>
 68 | 
 69 |                             @if (User.Identity.IsAuthenticated)
 70 |                             {
 71 |                                 <form asp-action="Rate" asp-controller="Product" method="post" class="d-flex gap-2">
 72 |                                     <input type="hidden" name="productId" value="@Model.ProductId" />
 73 |                                     <div class="star-rating">
 74 |                                         @for (int i = 1; i <= 5; i++)
 75 |                                         {
 76 |                                             <button type="submit" name="stars" value="@i"
 77 |                                                     class="star-btn @(ViewBag.UserRating >= i ? "active" : "")">
 78 |                                                 ★
 79 |                                             </button>
 80 |                                         }
 81 |                                     </div>
 82 |                                 </form>
 83 |                             }
 84 |                             else
 85 |                             {
 86 |                                 <p>
 87 |                                     <a asp-area="Identity" asp-page="/Account/Login" class="text-primary fw-bold">
 88 |                                         سجل دخول
 89 |                                     </a> لتتمكن من التقييم
 90 |                                 </p>
 91 |                             }
 92 |                         </div>
 93 | 
 94 |                         <!-- CSS -->
 95 |                       
 96 |                     </div>
 97 | 
 98 |                     <!-- زر الشراء -->
 99 |                     <a asp-controller="Orders" asp-action="Checkout"
100 |                        asp-route-productId="@Model.ProductId"
101 |                        class="btn btn-primary btn-lg w-100">
102 |                         شراء الآن
103 |                     </a>
104 |                 </div>
105 | 
106 |             </div>
107 |         </div>
108 |     </div>
109 | </div>
110 | 
111 |   
112 |     <!-- المنتجات المشابهة -->
113 |     <!-- المنتجات المشابهة -->
114 |     <div class="row mt-5">
115 |         <div class="col-12 mb-4">
116 |             <h3 class="fw-bold">منتجات مشابهة</h3>
117 |         </div>
118 | 
119 |         @if (ViewBag.SimilarProducts != null && ((List<Souqna.Models.Product>)ViewBag.SimilarProducts).Any())
120 |         {
121 |             @foreach (var product in (List<Souqna.Models.Product>)ViewBag.SimilarProducts)
122 |             {
123 |                 var simImage = product.GetImages().FirstOrDefault() ?? "/images/no-image.png";
124 | 
125 |                 <div class="col-lg-3 col-md-4 col-sm-6 mb-4">
126 |                     <div class="product-card">
127 |                         <a asp-controller="Product" asp-action="Details" asp-route-id="@product.ProductId">
128 |                             <img src="@simImage" alt="@product.Name" class="card-img-top" />
129 |                         </a>
130 |                         <div class="card-body">
131 |                             <h5 class="card-title">@product.Name</h5>
132 |                             <p class="card-text text-success">@product.PriceOfUnit.ToString("C")</p>
133 |                             <a asp-controller="Product" asp-action="Details" asp-route-id="@product.ProductId" class="btn btn-outline-primary btn-sm">
134 |                                 عرض التفاصيل
135 |                             </a>
136 |                         </div>
137 |                     </div>
138 |                 </div>
139 |             }
140 |         }
141 |         else
142 |         {
143 |             <div class="col-12">
144 |                 <p class="text-muted">لا توجد منتجات مشابهة حالياً.</p>
145 |             </div>
146 |         }
147 |     </div>
148 | 
149 | 
150 | <!-- سكربت مكتبة Swiper -->
151 | <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/swiper@9/swiper-bundle.min.css" />
152 | <script src="https://cdn.jsdelivr.net/npm/swiper@9/swiper-bundle.min.js"></script>
153 | <script>
154 |     document.addEventListener("DOMContentLoaded", function () {
155 |         new Swiper(".mySwiper", {
156 |             loop: true,
157 |             pagination: { el: ".swiper-pagination", clickable: true },
158 |             navigation: { nextEl: ".swiper-button-next", prevEl: ".swiper-button-prev" },
159 |             lazy: { loadOnTransitionStart: true, loadPrevNext: true },
160 |             slidesPerView: 1,
161 |             spaceBetween: 12,
162 |             centeredSlides: true
163 |         });
164 |     });
165 | </script>
166 | 


--------------------------------------------------------------------------------
/Souqna/Views/Product/Edit.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model Souqna.Data.ViewModels.ProductVM
 2 | @using Souqna.Data.Enums
 3 | 
 4 | @{
 5 |     ViewData["Title"] = "تعديل المنتج";
 6 | }
 7 | 
 8 | <h2>تعديل المنتج</h2>
 9 | 
10 | <form asp-action="Edit" method="post" enctype="multipart/form-data">
11 |     @Html.AntiForgeryToken()
12 |     <input type="hidden" asp-for="ProductId" />
13 | 
14 |     <div class="form-group mb-3">
15 |         <label asp-for="Name"></label>
16 |         <input asp-for="Name" class="form-control" />
17 |         <span asp-validation-for="Name" class="text-danger"></span>
18 |     </div>
19 | 
20 |     <div class="form-group mb-3">
21 |         <label asp-for="Description"></label>
22 |         <textarea asp-for="Description" class="form-control"></textarea>
23 |         <span asp-validation-for="Description" class="text-danger"></span>
24 |     </div>
25 | 
26 |     <div class="form-group mb-3">
27 |         <label asp-for="PriceOfUnit"></label>
28 |         <input asp-for="PriceOfUnit" class="form-control" type="number" step="0.01" />
29 |         <span asp-validation-for="PriceOfUnit" class="text-danger"></span>
30 |     </div>
31 | 
32 |     <div class="form-group mb-3">
33 |         <label asp-for="Category">التصنيف</label>
34 |         <select asp-for="Category" class="form-control" asp-items="ViewBag.Categories"></select>
35 |         <span asp-validation-for="Category" class="text-danger"></span>
36 |     </div>
37 | 
38 |     <div class="form-group mb-3">
39 |         <label asp-for="Unit">الوحدة</label>
40 |         <select asp-for="Unit" class="form-control" asp-items="ViewBag.Units"></select>
41 |         <span asp-validation-for="Unit" class="text-danger"></span>
42 |     </div>
43 | 
44 |     <div class="form-check mb-3">
45 |         <input asp-for="IsNew" class="form-check-input" />
46 |         <label asp-for="IsNew" class="form-check-label">جديد</label>
47 |     </div>
48 | 
49 |     <div class="form-group mb-3">
50 |         <label asp-for="StockQuantity">الكمية المتوفرة</label>
51 |         <input asp-for="StockQuantity" class="form-control" type="number" />
52 |         <span asp-validation-for="StockQuantity" class="text-danger"></span>
53 |     </div>
54 | 
55 |     <div class="form-group mb-3">
56 |         <label>الصور الجديدة</label>
57 |         <input asp-for="UploadedImages" class="form-control" type="file" multiple />
58 |         <span asp-validation-for="UploadedImages" class="text-danger"></span>
59 |     </div>
60 | 
61 |     <button type="submit" class="btn btn-success">حفظ التغييرات</button>
62 |     <a asp-action="Index" class="btn btn-secondary">إلغاء</a>
63 | </form>
64 | 
65 | @section Scripts {
66 |     @{
67 |         await Html.RenderPartialAsync("_ValidationScriptsPartial");
68 |     }
69 | }
70 | 


--------------------------------------------------------------------------------
/Souqna/Views/Product/Index.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model IEnumerable<Souqna.Models.Product>
 2 | 
 3 | <h2>قائمة المنتجات</h2>
 4 | 
 5 | <table class="table">
 6 |     <thead>
 7 |         <tr>
 8 |             <th>الاسم</th>
 9 |             <th>السعر</th>
10 |             <th>الفئة</th>
11 |         </tr>
12 |     </thead>
13 |     <tbody>
14 |         @foreach (var product in Model)
15 |         {
16 |             <tr>
17 |                 <td>@product.Name</td>
18 |                 <td>@product.PriceOfUnit</td>
19 |                 <td>@product.Category</td>
20 |             </tr>
21 |         }
22 |     </tbody>
23 | </table>
24 | 


--------------------------------------------------------------------------------
/Souqna/Views/Shared/Error.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model ErrorViewModel
 2 | @{
 3 |     ViewData["Title"] = "Error";
 4 | }
 5 | 
 6 | <h1 class="text-danger">Error.</h1>
 7 | <h2 class="text-danger">An error occurred while processing your request.</h2>
 8 | 
 9 | @if (Model.ShowRequestId)
10 | {
11 |     <p>
12 |         <strong>Request ID:</strong> <code>@Model.RequestId</code>
13 |     </p>
14 | }
15 | 
16 | <h3>Development Mode</h3>
17 | <p>
18 |     Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
19 | </p>
20 | <p>
21 |     <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
22 |     It can result in displaying sensitive information from exceptions to end users.
23 |     For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
24 |     and restarting the app.
25 | </p>
26 | 


--------------------------------------------------------------------------------
/Souqna/Views/Shared/_Layout.cshtml.css:
--------------------------------------------------------------------------------
 1 | ﻿/* Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
 2 | for details on configuring this project to bundle and minify static web assets. */
 3 | 
 4 | a.navbar-brand {
 5 |   white-space: normal;
 6 |   text-align: center;
 7 |   word-break: break-all;
 8 | }
 9 | 
10 | a {
11 |   color: #0077cc;
12 | }
13 | 
14 | .btn-primary {
15 |   color: #fff;
16 |   background-color: #1b6ec2;
17 |   border-color: #1861ac;
18 | }
19 | 
20 | .nav-pills .nav-link.active, .nav-pills .show > .nav-link {
21 |   color: #fff;
22 |   background-color: #1b6ec2;
23 |   border-color: #1861ac;
24 | }
25 | 
26 | .border-top {
27 |   border-top: 1px solid #e5e5e5;
28 | }
29 | .border-bottom {
30 |   border-bottom: 1px solid #e5e5e5;
31 | }
32 | 
33 | .box-shadow {
34 |   box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
35 | }
36 | 
37 | button.accept-policy {
38 |   font-size: 1rem;
39 |   line-height: inherit;
40 | }
41 | 
42 | .footer {
43 |   position: absolute;
44 |   bottom: 0;
45 |   width: 100%;
46 |   white-space: nowrap;
47 |   line-height: 60px;
48 | }
49 | 


--------------------------------------------------------------------------------
/Souqna/Views/Shared/_LoginPartial.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@using Microsoft.AspNetCore.Identity
 2 | @inject SignInManager<IdentityUser> SignInManager
 3 | @inject UserManager<IdentityUser> UserManager
 4 | 
 5 | <ul class="navbar-nav">
 6 | @if (SignInManager.IsSignedIn(User))
 7 | {
 8 |     <li class="nav-item">
 9 |         <a  class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Manage/Index" title="Manage">Hello @User.Identity?.Name!</a>
10 |     </li>
11 |     <li class="nav-item">
12 |         <form  class="form-inline" asp-area="Identity" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Action("Index", "Home", new { area = "" })">
13 |             <button  type="submit" class="nav-link btn btn-link text-dark">Logout</button>
14 |         </form>
15 |     </li>
16 | }
17 | else
18 | {
19 |     <li class="nav-item">
20 |         <a class="nav-link text-dark" asp-controller="Account" asp-action="Register">Register</a>
21 |     </li>
22 |     <li class="nav-item">
23 |         <a class="nav-link text-dark" asp-controller="Account" asp-action="Login">Login</a>
24 |     </li>
25 | }
26 | </ul>
27 | 


--------------------------------------------------------------------------------
/Souqna/Views/Shared/_ValidationScriptsPartial.cshtml:
--------------------------------------------------------------------------------
1 | ﻿<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
2 | <script src="~/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>
3 | 


--------------------------------------------------------------------------------
/Souqna/Views/Shared/components/Notifications/Default.cshtml:
--------------------------------------------------------------------------------
 1 | ﻿@model List<Souqna.Models.Notification>
 2 | 
 3 | <ul class="list-unstyled" id="notificationsList">
 4 |     @foreach (var n in Model)
 5 |     {
 6 |         <li class="mb-2">
 7 |             <a href="@Url.Action("OpenNotification", "Notifications", new { id = n.Id })"
 8 |                class="alert alert-info p-2 d-block @(n.IsRead ? "" : "fw-bold")">
 9 |                 @n.Message
10 |                 <small class="text-muted">(@n.CreatedAt.ToLocalTime())</small>
11 |             </a>
12 |         </li>
13 |     }
14 |     @if (!Model.Any())
15 |     {
16 |         <li class="text-muted">لا يوجد إشعارات بعد</li>
17 |     }
18 | </ul>
19 | 


--------------------------------------------------------------------------------
/Souqna/Views/_ViewImports.cshtml:
--------------------------------------------------------------------------------
1 | ﻿@using Souqna
2 | @using Souqna.Models
3 | @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
4 | 


--------------------------------------------------------------------------------
/Souqna/Views/_ViewStart.cshtml:
--------------------------------------------------------------------------------
1 | ﻿@{
2 |     Layout = "_Layout";
3 | }
4 | 


--------------------------------------------------------------------------------
/Souqna/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/Souqna/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "ConnectionStrings": {
 3 |     "DefaultConnection": "Server=ANASM;Database=Souqna;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
 4 |   },
 5 |   "Logging": {
 6 |     "LogLevel": {
 7 |       "Default": "Information",
 8 |       "Microsoft.AspNetCore": "Warning"
 9 |     }
10 |   },
11 |   "AllowedHosts": "*"
12 | }
13 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/css/main.css:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/css/main.css


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/about.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/about.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/faviconn.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/faviconn.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/footer-bg.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/footer-bg.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/hero-bg.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/hero-bg.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/hero-img.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/hero-img.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/logoo.png.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/logoo.png.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/market1.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/market1.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/page-title-bg.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/page-title-bg.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/app-1.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/app-1.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/app-2.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/app-2.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/app-3.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/app-3.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/books-1.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/books-1.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/books-2.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/books-2.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/books-3.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/books-3.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/branding-1.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/branding-1.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/branding-2.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/branding-2.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/branding-3.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/branding-3.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/product-1.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/product-1.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/product-2.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/product-2.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/portfolio/product-3.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/portfolio/product-3.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/stats-bg.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/img/stats-bg.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/img/team-shape.svg:
--------------------------------------------------------------------------------
1 | <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1440 320"><path fill="currentColor" fill-opacity="1" d="M0,160L34.3,170.7C68.6,181,137,203,206,202.7C274.3,203,343,181,411,154.7C480,128,549,96,617,112C685.7,128,754,192,823,213.3C891.4,235,960,213,1029,197.3C1097.1,181,1166,171,1234,170.7C1302.9,171,1371,181,1406,186.7L1440,192L1440,320L1405.7,320C1371.4,320,1303,320,1234,320C1165.7,320,1097,320,1029,320C960,320,891,320,823,320C754.3,320,686,320,617,320C548.6,320,480,320,411,320C342.9,320,274,320,206,320C137.1,320,69,320,34,320L0,320Z"></path></svg>
2 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/js/main.js:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/js/main.js


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/scss/Readme.txt:
--------------------------------------------------------------------------------
1 | The .scss (Sass) files are only available in the pro version.
2 | You can buy it from: https://bootstrapmade.com/techie-free-skin-bootstrap-3/


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/vendor/bootstrap-icons/fonts/bootstrap-icons.woff:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/vendor/bootstrap-icons/fonts/bootstrap-icons.woff


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/vendor/bootstrap-icons/fonts/bootstrap-icons.woff2:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/assets/vendor/bootstrap-icons/fonts/bootstrap-icons.woff2


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/vendor/imagesloaded/imagesloaded.pkgd.min.js:
--------------------------------------------------------------------------------
 1 | /*!
 2 |  * imagesLoaded PACKAGED v5.0.0
 3 |  * JavaScript is all like "You images are done yet or what?"
 4 |  * MIT License
 5 |  */
 6 | !function(t,e){"object"==typeof module&&module.exports?module.exports=e():t.EvEmitter=e()}("undefined"!=typeof window?window:this,(function(){function t(){}let e=t.prototype;return e.on=function(t,e){if(!t||!e)return this;let i=this._events=this._events||{},s=i[t]=i[t]||[];return s.includes(e)||s.push(e),this},e.once=function(t,e){if(!t||!e)return this;this.on(t,e);let i=this._onceEvents=this._onceEvents||{};return(i[t]=i[t]||{})[e]=!0,this},e.off=function(t,e){let i=this._events&&this._events[t];if(!i||!i.length)return this;let s=i.indexOf(e);return-1!=s&&i.splice(s,1),this},e.emitEvent=function(t,e){let i=this._events&&this._events[t];if(!i||!i.length)return this;i=i.slice(0),e=e||[];let s=this._onceEvents&&this._onceEvents[t];for(let n of i){s&&s[n]&&(this.off(t,n),delete s[n]),n.apply(this,e)}return this},e.allOff=function(){return delete this._events,delete this._onceEvents,this},t})),
 7 | /*!
 8 |  * imagesLoaded v5.0.0
 9 |  * JavaScript is all like "You images are done yet or what?"
10 |  * MIT License
11 |  */
12 | function(t,e){"object"==typeof module&&module.exports?module.exports=e(t,require("ev-emitter")):t.imagesLoaded=e(t,t.EvEmitter)}("undefined"!=typeof window?window:this,(function(t,e){let i=t.jQuery,s=t.console;function n(t,e,o){if(!(this instanceof n))return new n(t,e,o);let r=t;var h;("string"==typeof t&&(r=document.querySelectorAll(t)),r)?(this.elements=(h=r,Array.isArray(h)?h:"object"==typeof h&&"number"==typeof h.length?[...h]:[h]),this.options={},"function"==typeof e?o=e:Object.assign(this.options,e),o&&this.on("always",o),this.getImages(),i&&(this.jqDeferred=new i.Deferred),setTimeout(this.check.bind(this))):s.error(`Bad element for imagesLoaded ${r||t}`)}n.prototype=Object.create(e.prototype),n.prototype.getImages=function(){this.images=[],this.elements.forEach(this.addElementImages,this)};const o=[1,9,11];n.prototype.addElementImages=function(t){"IMG"===t.nodeName&&this.addImage(t),!0===this.options.background&&this.addElementBackgroundImages(t);let{nodeType:e}=t;if(!e||!o.includes(e))return;let i=t.querySelectorAll("img");for(let t of i)this.addImage(t);if("string"==typeof this.options.background){let e=t.querySelectorAll(this.options.background);for(let t of e)this.addElementBackgroundImages(t)}};const r=/url\((['"])?(.*?)\1\)/gi;function h(t){this.img=t}function d(t,e){this.url=t,this.element=e,this.img=new Image}return n.prototype.addElementBackgroundImages=function(t){let e=getComputedStyle(t);if(!e)return;let i=r.exec(e.backgroundImage);for(;null!==i;){let s=i&&i[2];s&&this.addBackground(s,t),i=r.exec(e.backgroundImage)}},n.prototype.addImage=function(t){let e=new h(t);this.images.push(e)},n.prototype.addBackground=function(t,e){let i=new d(t,e);this.images.push(i)},n.prototype.check=function(){if(this.progressedCount=0,this.hasAnyBroken=!1,!this.images.length)return void this.complete();let t=(t,e,i)=>{setTimeout((()=>{this.progress(t,e,i)}))};this.images.forEach((function(e){e.once("progress",t),e.check()}))},n.prototype.progress=function(t,e,i){this.progressedCount++,this.hasAnyBroken=this.hasAnyBroken||!t.isLoaded,this.emitEvent("progress",[this,t,e]),this.jqDeferred&&this.jqDeferred.notify&&this.jqDeferred.notify(this,t),this.progressedCount===this.images.length&&this.complete(),this.options.debug&&s&&s.log(`progress: ${i}`,t,e)},n.prototype.complete=function(){let t=this.hasAnyBroken?"fail":"done";if(this.isComplete=!0,this.emitEvent(t,[this]),this.emitEvent("always",[this]),this.jqDeferred){let t=this.hasAnyBroken?"reject":"resolve";this.jqDeferred[t](this)}},h.prototype=Object.create(e.prototype),h.prototype.check=function(){this.getIsImageComplete()?this.confirm(0!==this.img.naturalWidth,"naturalWidth"):(this.proxyImage=new Image,this.img.crossOrigin&&(this.proxyImage.crossOrigin=this.img.crossOrigin),this.proxyImage.addEventListener("load",this),this.proxyImage.addEventListener("error",this),this.img.addEventListener("load",this),this.img.addEventListener("error",this),this.proxyImage.src=this.img.currentSrc||this.img.src)},h.prototype.getIsImageComplete=function(){return this.img.complete&&this.img.naturalWidth},h.prototype.confirm=function(t,e){this.isLoaded=t;let{parentNode:i}=this.img,s="PICTURE"===i.nodeName?i:this.img;this.emitEvent("progress",[this,s,e])},h.prototype.handleEvent=function(t){let e="on"+t.type;this[e]&&this[e](t)},h.prototype.onload=function(){this.confirm(!0,"onload"),this.unbindEvents()},h.prototype.onerror=function(){this.confirm(!1,"onerror"),this.unbindEvents()},h.prototype.unbindEvents=function(){this.proxyImage.removeEventListener("load",this),this.proxyImage.removeEventListener("error",this),this.img.removeEventListener("load",this),this.img.removeEventListener("error",this)},d.prototype=Object.create(h.prototype),d.prototype.check=function(){this.img.addEventListener("load",this),this.img.addEventListener("error",this),this.img.src=this.url,this.getIsImageComplete()&&(this.confirm(0!==this.img.naturalWidth,"naturalWidth"),this.unbindEvents())},d.prototype.unbindEvents=function(){this.img.removeEventListener("load",this),this.img.removeEventListener("error",this)},d.prototype.confirm=function(t,e){this.isLoaded=t,this.emitEvent("progress",[this,this.element,e])},n.makeJQueryPlugin=function(e){(e=e||t.jQuery)&&(i=e,i.fn.imagesLoaded=function(t,e){return new n(this,t,e).jqDeferred.promise(i(this))})},n.makeJQueryPlugin(),n}));


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/vendor/php-email-form/validate.js:
--------------------------------------------------------------------------------
 1 | /**
 2 | * PHP Email Form Validation - v3.10
 3 | * URL: https://bootstrapmade.com/php-email-form/
 4 | * Author: BootstrapMade.com
 5 | */
 6 | (function () {
 7 |   "use strict";
 8 | 
 9 |   let forms = document.querySelectorAll('.php-email-form');
10 | 
11 |   forms.forEach( function(e) {
12 |     e.addEventListener('submit', function(event) {
13 |       event.preventDefault();
14 | 
15 |       let thisForm = this;
16 | 
17 |       let action = thisForm.getAttribute('action');
18 |       let recaptcha = thisForm.getAttribute('data-recaptcha-site-key');
19 |       
20 |       if( ! action ) {
21 |         displayError(thisForm, 'The form action property is not set!');
22 |         return;
23 |       }
24 |       thisForm.querySelector('.loading').classList.add('d-block');
25 |       thisForm.querySelector('.error-message').classList.remove('d-block');
26 |       thisForm.querySelector('.sent-message').classList.remove('d-block');
27 | 
28 |       let formData = new FormData( thisForm );
29 | 
30 |       if ( recaptcha ) {
31 |         if(typeof grecaptcha !== "undefined" ) {
32 |           grecaptcha.ready(function() {
33 |             try {
34 |               grecaptcha.execute(recaptcha, {action: 'php_email_form_submit'})
35 |               .then(token => {
36 |                 formData.set('recaptcha-response', token);
37 |                 php_email_form_submit(thisForm, action, formData);
38 |               })
39 |             } catch(error) {
40 |               displayError(thisForm, error);
41 |             }
42 |           });
43 |         } else {
44 |           displayError(thisForm, 'The reCaptcha javascript API url is not loaded!')
45 |         }
46 |       } else {
47 |         php_email_form_submit(thisForm, action, formData);
48 |       }
49 |     });
50 |   });
51 | 
52 |   function php_email_form_submit(thisForm, action, formData) {
53 |     fetch(action, {
54 |       method: 'POST',
55 |       body: formData,
56 |       headers: {'X-Requested-With': 'XMLHttpRequest'}
57 |     })
58 |     .then(response => {
59 |       if( response.ok ) {
60 |         return response.text();
61 |       } else {
62 |         throw new Error(`${response.status} ${response.statusText} ${response.url}`); 
63 |       }
64 |     })
65 |     .then(data => {
66 |       thisForm.querySelector('.loading').classList.remove('d-block');
67 |       if (data.trim() == 'OK') {
68 |         thisForm.querySelector('.sent-message').classList.add('d-block');
69 |         thisForm.reset(); 
70 |       } else {
71 |         throw new Error(data ? data : 'Form submission failed and no error message returned from: ' + action); 
72 |       }
73 |     })
74 |     .catch((error) => {
75 |       displayError(thisForm, error);
76 |     });
77 |   }
78 | 
79 |   function displayError(thisForm, error) {
80 |     thisForm.querySelector('.loading').classList.remove('d-block');
81 |     thisForm.querySelector('.error-message').innerHTML = error;
82 |     thisForm.querySelector('.error-message').classList.add('d-block');
83 |   }
84 | 
85 | })();
86 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/assets/vendor/purecounter/purecounter_vanilla.js:
--------------------------------------------------------------------------------
1 | /*!
2 |  * purecounter.js - A simple yet configurable native javascript counter which you can count on.
3 |  * Author: Stig Rex
4 |  * Version: 1.5.0
5 |  * Url: https://github.com/srexi/purecounterjs
6 |  * License: MIT
7 |  */
8 | !function(e,t){"object"==typeof exports&&"object"==typeof module?module.exports=t():"function"==typeof define&&define.amd?define([],t):"object"==typeof exports?exports.PureCounter=t():e.PureCounter=t()}(self,(function(){return e={638:function(e){function t(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function r(e){return function(e){if(Array.isArray(e))return n(e)}(e)||function(e){if("undefined"!=typeof Symbol&&null!=e[Symbol.iterator]||null!=e["@@iterator"])return Array.from(e)}(e)||function(e,t){if(e){if("string"==typeof e)return n(e,t);var r=Object.prototype.toString.call(e).slice(8,-1);return"Object"===r&&e.constructor&&(r=e.constructor.name),"Map"===r||"Set"===r?Array.from(e):"Arguments"===r||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r)?n(e,t):void 0}}(e)||function(){throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function n(e,t){(null==t||t>e.length)&&(t=e.length);for(var r=0,n=new Array(t);r<t;r++)n[r]=e[r];return n}function o(e){var t=arguments.length>1&&void 0!==arguments[1]?arguments[1]:{},r={};for(var n in e)if(t=={}||t.hasOwnProperty(n)){var o=c(e[n]);r[n]=o,n.match(/duration|pulse/)&&(r[n]="boolean"!=typeof o?1e3*o:o)}return Object.assign({},t,r)}function i(e,t){var r=(t.end-t.start)/(t.duration/t.delay),n="inc";t.start>t.end&&(n="dec",r*=-1);var o=c(t.start);e.innerHTML=u(o,t),!0===t.once&&e.setAttribute("data-purecounter-duration",0);var i=setInterval((function(){var a=function(e,t){var r=arguments.length>2&&void 0!==arguments[2]?arguments[2]:"inc";return e=c(e),t=c(t),parseFloat("inc"===r?e+t:e-t)}(o,r,n);e.innerHTML=u(a,t),((o=a)>=t.end&&"inc"==n||o<=t.end&&"dec"==n)&&(e.innerHTML=u(t.end,t),t.pulse&&(e.setAttribute("data-purecounter-duration",0),setTimeout((function(){e.setAttribute("data-purecounter-duration",t.duration/1e3)}),t.pulse)),clearInterval(i))}),t.delay)}function a(e,t){return Math.pow(e,t)}function u(e,t){var r={minimumFractionDigits:t.decimals,maximumFractionDigits:t.decimals},n="string"==typeof t.formater?t.formater:void 0;return e=function(e,t){if(t.filesizing||t.currency){e=Math.abs(Number(e));var r=1e3,n=t.currency&&"string"==typeof t.currency?t.currency:"",o=t.decimals||1,i=["","K","M","B","T"],u="";t.filesizing&&(r=1024,i=["bytes","KB","MB","GB","TB"]);for(var c=4;c>=0;c--)if(0===c&&(u="".concat(e.toFixed(o)," ").concat(i[c])),e>=a(r,c)){u="".concat((e/a(r,c)).toFixed(o)," ").concat(i[c]);break}return n+u}return parseFloat(e)}(e,t),function(e,t){if(t.formater){var r=t.separator?"string"==typeof t.separator?t.separator:",":"";return"en-US"!==t.formater&&!0===t.separator?e:(n=r,e.replace(/^(?:(\d{1,3},(?:\d{1,3},?)*)|(\d{1,3}\.(?:\d{1,3}\.?)*)|(\d{1,3}(?:\s\d{1,3})*))([\.,]?\d{0,2}?)$/gi,(function(e,t,r,o,i){var a="",u="";if(void 0!==t?(a=t.replace(new RegExp(/,/gi,"gi"),n),u=","):void 0!==r?a=r.replace(new RegExp(/\./gi,"gi"),n):void 0!==o&&(a=o.replace(new RegExp(/ /gi,"gi"),n)),void 0!==i){var c=","!==u&&","!==n?",":".";a+=void 0!==i?i.replace(new RegExp(/\.|,/gi,"gi"),c):""}return a})))}var n;return e}(e=t.formater?e.toLocaleString(n,r):parseInt(e).toString(),t)}function c(e){return/^[0-9]+\.[0-9]+$/.test(e)?parseFloat(e):/^[0-9]+$/.test(e)?parseInt(e):/^true|false/i.test(e)?/^true/i.test(e):e}function f(e){for(var t=e.offsetTop,r=e.offsetLeft,n=e.offsetWidth,o=e.offsetHeight;e.offsetParent;)t+=(e=e.offsetParent).offsetTop,r+=e.offsetLeft;return t>=window.pageYOffset&&r>=window.pageXOffset&&t+o<=window.pageYOffset+window.innerHeight&&r+n<=window.pageXOffset+window.innerWidth}function s(){return"IntersectionObserver"in window&&"IntersectionObserverEntry"in window&&"intersectionRatio"in window.IntersectionObserverEntry.prototype}e.exports=function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:{},n={start:0,end:100,duration:2e3,delay:10,once:!0,pulse:!1,decimals:0,legacy:!0,filesizing:!1,currency:!1,separator:!1,formater:"us-US",selector:".purecounter"},a=o(e,n);function d(){var e=document.querySelectorAll(a.selector);if(0!==e.length)if(s()){var t=new IntersectionObserver(p.bind(this),{root:null,rootMargin:"20px",threshold:.5});e.forEach((function(e){t.observe(e)}))}else window.addEventListener&&(l(e),window.addEventListener("scroll",(function(t){l(e)}),{passive:!0}))}function l(e){e.forEach((function(e){!0===v(e).legacy&&f(e)&&p([e])}))}function p(e,t){e.forEach((function(e){var r=e.target||e,n=v(r);if(n.duration<=0)return r.innerHTML=u(n.end,n);if(!t&&!f(e)||t&&e.intersectionRatio<.5){var o=n.start>n.end?n.end:n.start;return r.innerHTML=u(o,n)}setTimeout((function(){return i(r,n)}),n.delay)}))}function v(e){var n=a,i=[].filter.call(e.attributes,(function(e){return/^data-purecounter-/.test(e.name)}));return o(0!=i.length?Object.assign.apply(Object,[{}].concat(r(i.map((function(e){var r=e.name,n=e.value;return t({},r.replace("data-purecounter-","").toLowerCase(),c(n))}))))):{},n)}d()}}},t={},r=function r(n){var o=t[n];if(void 0!==o)return o.exports;var i=t[n]={exports:{}};return e[n](i,i.exports,r),i.exports}(638),r;var e,t,r}));
9 | //# sourceMappingURL=purecounter_vanilla.js.map


--------------------------------------------------------------------------------
/Souqna/wwwroot/css/site.css:
--------------------------------------------------------------------------------
 1 | html {
 2 |   font-size: 14px;
 3 | }
 4 | 
 5 | @media (min-width: 768px) {
 6 |   html {
 7 |     font-size: 16px;
 8 |   }
 9 | }
10 | 
11 | .btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
12 |   box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
13 | }
14 | 
15 | html {
16 |   position: relative;
17 |   min-height: 100%;
18 | }
19 | 
20 | body {
21 |   margin-bottom: 60px;
22 | }
23 | 
24 | .form-floating > .form-control-plaintext::placeholder, .form-floating > .form-control::placeholder {
25 |   color: var(--bs-secondary-color);
26 |   text-align: end;
27 | }
28 | 
29 | .form-floating > .form-control-plaintext:focus::placeholder, .form-floating > .form-control:focus::placeholder {
30 |   text-align: start;
31 | }


--------------------------------------------------------------------------------
/Souqna/wwwroot/favicon.ico:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/favicon.ico


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/0d310f40-a8df-4186-8561-7310c0e45f68.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/0d310f40-a8df-4186-8561-7310c0e45f68.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/0de662a4-590c-4aee-8321-98ee989157b7.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/0de662a4-590c-4aee-8321-98ee989157b7.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/12c60645-6a3e-4826-a29e-bc1da0d5f94e.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/12c60645-6a3e-4826-a29e-bc1da0d5f94e.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/1dd2df13-274c-4732-9739-5adc63931999.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/1dd2df13-274c-4732-9739-5adc63931999.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/23b91105-4f50-4daa-89ae-a7e2e8ad6760.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/23b91105-4f50-4daa-89ae-a7e2e8ad6760.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/2cbe0f3a-37fe-4bfa-a05f-82dafdd5b524.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/2cbe0f3a-37fe-4bfa-a05f-82dafdd5b524.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/5a8f4310-b78d-4c66-9529-c8345554d312.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/5a8f4310-b78d-4c66-9529-c8345554d312.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/6752e912-f114-4900-90e4-0ede6adcd7b4.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/6752e912-f114-4900-90e4-0ede6adcd7b4.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/68210cb1-6e6d-4b8e-b37c-051351a811d8.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/68210cb1-6e6d-4b8e-b37c-051351a811d8.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/7e9bcd99-6cca-4cf4-a0c0-17106da08d84.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/7e9bcd99-6cca-4cf4-a0c0-17106da08d84.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/9f363ee7-f4c5-4715-8dd4-21ef8216dc11.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/9f363ee7-f4c5-4715-8dd4-21ef8216dc11.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/a5510ee1-b53e-49a0-86ed-b581833dff4b.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/a5510ee1-b53e-49a0-86ed-b581833dff4b.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/ba60585c-129c-4c37-8f70-636c4eb4f3cf.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/ba60585c-129c-4c37-8f70-636c4eb4f3cf.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/bd003e78-2559-4fdf-8e2b-8192f2044390.png:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/bd003e78-2559-4fdf-8e2b-8192f2044390.png


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/c37dc0dc-2167-4698-afc2-abb6a1374899.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/c37dc0dc-2167-4698-afc2-abb6a1374899.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/c8371f6f-566d-429b-92bc-405221310672.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/c8371f6f-566d-429b-92bc-405221310672.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/d3d14bb8-f8c8-47f1-9361-49b5382ded3a.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/d3d14bb8-f8c8-47f1-9361-49b5382ded3a.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/d5a87954-9775-4507-bd0c-2dda1c48f75b.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/d5a87954-9775-4507-bd0c-2dda1c48f75b.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/dc763004-93bc-42da-811b-a1f41f821986.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/dc763004-93bc-42da-811b-a1f41f821986.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/dd9cc974-661a-468a-813c-d4b9c4c00417.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/dd9cc974-661a-468a-813c-d4b9c4c00417.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/e1151b86-3374-4726-9a87-8105f826857f.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/e1151b86-3374-4726-9a87-8105f826857f.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/e9c01a98-d089-4e31-b243-2c3686a2fcd6.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/e9c01a98-d089-4e31-b243-2c3686a2fcd6.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/ee76b6e3-0eec-46f3-b448-26231a64f4c8.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/ee76b6e3-0eec-46f3-b448-26231a64f4c8.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/f9c35d2a-d7a5-4611-a1b1-3fe6a0b4bc67.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/f9c35d2a-d7a5-4611-a1b1-3fe6a0b4bc67.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/products/fdfa2725-38ae-4302-90cf-bdf6f93973ec.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/products/fdfa2725-38ae-4302-90cf-bdf6f93973ec.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/profiles/24c5230a-16d1-44d4-8f12-bcd56ee651d0.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/profiles/24c5230a-16d1-44d4-8f12-bcd56ee651d0.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/profiles/324b1218-12c6-4b03-bae2-bb9001ffa1c5.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/profiles/324b1218-12c6-4b03-bae2-bb9001ffa1c5.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/profiles/77ebd815-1c35-401e-80b9-f83f7f789f3c.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/profiles/77ebd815-1c35-401e-80b9-f83f7f789f3c.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/images/profiles/ba246b88-a775-41f0-9f7f-22d0bd037a9c.jpg:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/jameelmoufak/Souqna/d12bcc22520887c2cabcc9e0f40b610dbadb9d6a/Souqna/wwwroot/images/profiles/ba246b88-a775-41f0-9f7f-22d0bd037a9c.jpg


--------------------------------------------------------------------------------
/Souqna/wwwroot/js/site.js:
--------------------------------------------------------------------------------
1 | ﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
2 | // for details on configuring this project to bundle and minify static web assets.
3 | 
4 | // Write your JavaScript code.
5 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/lib/bootstrap/LICENSE:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | 
 3 | Copyright (c) 2011-2021 Twitter, Inc.
 4 | Copyright (c) 2011-2021 The Bootstrap Authors
 5 | 
 6 | Permission is hereby granted, free of charge, to any person obtaining a copy
 7 | of this software and associated documentation files (the "Software"), to deal
 8 | in the Software without restriction, including without limitation the rights
 9 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
10 | copies of the Software, and to permit persons to whom the Software is
11 | furnished to do so, subject to the following conditions:
12 | 
13 | The above copyright notice and this permission notice shall be included in
14 | all copies or substantial portions of the Software.
15 | 
16 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
17 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
18 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
19 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
20 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
21 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
22 | THE SOFTWARE.
23 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | 
 3 | Copyright (c) .NET Foundation and Contributors
 4 | 
 5 | All rights reserved.
 6 | 
 7 | Permission is hereby granted, free of charge, to any person obtaining a copy
 8 | of this software and associated documentation files (the "Software"), to deal
 9 | in the Software without restriction, including without limitation the rights
10 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
11 | copies of the Software, and to permit persons to whom the Software is
12 | furnished to do so, subject to the following conditions:
13 | 
14 | The above copyright notice and this permission notice shall be included in all
15 | copies or substantial portions of the Software.
16 | 
17 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
18 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
19 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
20 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
21 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
22 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
23 | SOFTWARE.
24 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js:
--------------------------------------------------------------------------------
1 | /**
2 |  * @license
3 |  * Unobtrusive validation support library for jQuery and jQuery Validate
4 |  * Copyright (c) .NET Foundation. All rights reserved.
5 |  * Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
6 |  * @version v4.0.0
7 |  */
8 | !function(a){"function"==typeof define&&define.amd?define("jquery.validate.unobtrusive",["jquery-validation"],a):"object"==typeof module&&module.exports?module.exports=a(require("jquery-validation")):jQuery.validator.unobtrusive=a(jQuery)}(function(s){var a,o=s.validator,d="unobtrusiveValidation";function l(a,e,n){a.rules[e]=n,a.message&&(a.messages[e]=a.message)}function u(a){return a.replace(/([!"#$%&'()*+,./:;<=>?@\[\\\]^`{|}~])/g,"\\$1")}function n(a){return a.substr(0,a.lastIndexOf(".")+1)}function m(a,e){return a=0===a.indexOf("*.")?a.replace("*.",e):a}function f(a){var e=s(this),n="__jquery_unobtrusive_validation_form_reset";if(!e.data(n)){e.data(n,!0);try{e.data("validator").resetForm()}finally{e.removeData(n)}e.find(".validation-summary-errors").addClass("validation-summary-valid").removeClass("validation-summary-errors"),e.find(".field-validation-error").addClass("field-validation-valid").removeClass("field-validation-error").removeData("unobtrusiveContainer").find(">*").removeData("unobtrusiveContainer")}}function p(n){function a(a,e){(a=r[a])&&s.isFunction(a)&&a.apply(n,e)}var e=s(n),t=e.data(d),i=s.proxy(f,n),r=o.unobtrusive.options||{};return t||(t={options:{errorClass:r.errorClass||"input-validation-error",errorElement:r.errorElement||"span",errorPlacement:function(){!function(a,e){var e=s(this).find("[data-valmsg-for='"+u(e[0].name)+"']"),n=(n=e.attr("data-valmsg-replace"))?!1!==s.parseJSON(n):null;e.removeClass("field-validation-valid").addClass("field-validation-error"),a.data("unobtrusiveContainer",e),n?(e.empty(),a.removeClass("input-validation-error").appendTo(e)):a.hide()}.apply(n,arguments),a("errorPlacement",arguments)},invalidHandler:function(){!function(a,e){var n=s(this).find("[data-valmsg-summary=true]"),t=n.find("ul");t&&t.length&&e.errorList.length&&(t.empty(),n.addClass("validation-summary-errors").removeClass("validation-summary-valid"),s.each(e.errorList,function(){s("<li />").html(this.message).appendTo(t)}))}.apply(n,arguments),a("invalidHandler",arguments)},messages:{},rules:{},success:function(){!function(a){var e,n=a.data("unobtrusiveContainer");n&&(e=(e=n.attr("data-valmsg-replace"))?s.parseJSON(e):null,n.addClass("field-validation-valid").removeClass("field-validation-error"),a.removeData("unobtrusiveContainer"),e&&n.empty())}.apply(n,arguments),a("success",arguments)}},attachValidation:function(){e.off("reset."+d,i).on("reset."+d,i).validate(this.options)},validate:function(){return e.validate(),e.valid()}},e.data(d,t)),t}return o.unobtrusive={adapters:[],parseElement:function(t,a){var e,i,r,o=s(t),d=o.parents("form")[0];d&&((e=p(d)).options.rules[t.name]=i={},e.options.messages[t.name]=r={},s.each(this.adapters,function(){var a="data-val-"+this.name,e=o.attr(a),n={};void 0!==e&&(a+="-",s.each(this.params,function(){n[this]=o.attr(a+this)}),this.adapt({element:t,form:d,message:e,params:n,rules:i,messages:r}))}),s.extend(i,{__dummy__:!0}),a||e.attachValidation())},parse:function(a){var a=s(a),e=a.parents().addBack().filter("form").add(a.find("form")).has("[data-val=true]");a.find("[data-val=true]").each(function(){o.unobtrusive.parseElement(this,!0)}),e.each(function(){var a=p(this);a&&a.attachValidation()})}},(a=o.unobtrusive.adapters).add=function(a,e,n){return n||(n=e,e=[]),this.push({name:a,params:e,adapt:n}),this},a.addBool=function(e,n){return this.add(e,function(a){l(a,n||e,!0)})},a.addMinMax=function(a,t,i,r,e,n){return this.add(a,[e||"min",n||"max"],function(a){var e=a.params.min,n=a.params.max;e&&n?l(a,r,[e,n]):e?l(a,t,e):n&&l(a,i,n)})},a.addSingleVal=function(e,n,t){return this.add(e,[n||"val"],function(a){l(a,t||e,a.params[n])})},o.addMethod("__dummy__",function(a,e,n){return!0}),o.addMethod("regex",function(a,e,n){return!!this.optional(e)||(e=new RegExp(n).exec(a))&&0===e.index&&e[0].length===a.length}),o.addMethod("nonalphamin",function(a,e,n){var t;return t=n?(t=a.match(/\W/g))&&t.length>=n:t}),o.methods.extension?(a.addSingleVal("accept","mimtype"),a.addSingleVal("extension","extension")):a.addSingleVal("extension","extension","accept"),a.addSingleVal("regex","pattern"),a.addBool("creditcard").addBool("date").addBool("digits").addBool("email").addBool("number").addBool("url"),a.addMinMax("length","minlength","maxlength","rangelength").addMinMax("range","min","max","range"),a.addMinMax("minlength","minlength").addMinMax("maxlength","minlength","maxlength"),a.add("equalto",["other"],function(a){var e=n(a.element.name),e=m(a.params.other,e);l(a,"equalTo",s(a.form).find(":input").filter("[name='"+u(e)+"']")[0])}),a.add("required",function(a){"INPUT"===a.element.tagName.toUpperCase()&&"CHECKBOX"===a.element.type.toUpperCase()||l(a,"required",!0)}),a.add("remote",["url","type","additionalfields"],function(t){var i={url:t.params.url,type:t.params.type||"GET",data:{}},r=n(t.element.name);s.each((t.params.additionalfields||t.element.name).replace(/^\s+|\s+$/g,"").split(/\s*,\s*/g),function(a,e){var n=m(e,r);i.data[n]=function(){var a=s(t.form).find(":input").filter("[name='"+u(n)+"']");return a.is(":checkbox")?a.filter(":checked").val()||a.filter(":hidden").val()||"":a.is(":radio")?a.filter(":checked").val()||"":a.val()}}),l(t,"remote",i)}),a.add("password",["min","nonalphamin","regex"],function(a){a.params.min&&l(a,"minlength",a.params.min),a.params.nonalphamin&&l(a,"nonalphamin",a.params.nonalphamin),a.params.regex&&l(a,"regex",a.params.regex)}),a.add("fileextensions",["extensions"],function(a){l(a,"extension",a.params.extensions)}),s(function(){o.unobtrusive.parse(document)}),o.unobtrusive});


--------------------------------------------------------------------------------
/Souqna/wwwroot/lib/jquery-validation/LICENSE.md:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | =====================
 3 | 
 4 | Copyright Jörn Zaefferer
 5 | 
 6 | Permission is hereby granted, free of charge, to any person obtaining a copy
 7 | of this software and associated documentation files (the "Software"), to deal
 8 | in the Software without restriction, including without limitation the rights
 9 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
10 | copies of the Software, and to permit persons to whom the Software is
11 | furnished to do so, subject to the following conditions:
12 | 
13 | The above copyright notice and this permission notice shall be included in
14 | all copies or substantial portions of the Software.
15 | 
16 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
17 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
18 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
19 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
20 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
21 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
22 | THE SOFTWARE.
23 | 


--------------------------------------------------------------------------------
/Souqna/wwwroot/lib/jquery/LICENSE.txt:
--------------------------------------------------------------------------------
 1 | 
 2 | Copyright OpenJS Foundation and other contributors, https://openjsf.org/
 3 | 
 4 | Permission is hereby granted, free of charge, to any person obtaining
 5 | a copy of this software and associated documentation files (the
 6 | "Software"), to deal in the Software without restriction, including
 7 | without limitation the rights to use, copy, modify, merge, publish,
 8 | distribute, sublicense, and/or sell copies of the Software, and to
 9 | permit persons to whom the Software is furnished to do so, subject to
10 | the following conditions:
11 | 
12 | The above copyright notice and this permission notice shall be
13 | included in all copies or substantial portions of the Software.
14 | 
15 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
16 | EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
17 | MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
18 | NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
19 | LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
20 | OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
21 | WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


--------------------------------------------------------------------------------
