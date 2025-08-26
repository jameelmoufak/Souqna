using Souqna.Models;
using System.Collections.Generic;

namespace Souqna.Data.ViewModels
{
    public class MyAccountVM
    {
        public List<ShoppingCartItem> CartItems { get; set; } = new();
        public List<OrderItem> PurchasedProducts { get; set; }
        public List<Product> SoldProducts { get; set; } = new();
        //public List<CheckoutVM> Quantity { get;set; } = new();
    }
}
