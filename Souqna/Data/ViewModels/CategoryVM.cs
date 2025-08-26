using Souqna.Models;

namespace Souqna.Data.ViewModels
{
    public class CategoryVM
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }

    public class HomeVM
    {
        public List<CategoryVM> Categories { get; set; }
        // عرض أحدث المنتجات
        public IEnumerable<Product> LatestProducts { get; set; }
        public IEnumerable<Review> Reviews { get; set; }

    }
}
