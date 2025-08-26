using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Souqna.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        
        public Product Product { get; set; } // المنتج الذي ينتمي إليه هذا العنصر في عربة التسوق
        public int Amount { get; set; } // الكمية المطلوبة من المنتج في عربة التسوق
        public string ShoppingCartId { get; set; } // معرف عربة التسوق التي ينتمي إليها هذا العنصر
    }
}
