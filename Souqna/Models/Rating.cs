namespace Souqna.Models
{
    public class Rating
    {
        public Guid RatingId { get; set; }
        public string UserId { get; set; } // معرف المستخدم الذي قام بتقييم المنتج
        public ApplicationUser User { get; set; } // المستخدم الذي قام بتقييم المنتج
        public Guid ProductId { get; set; } // معرف المنتج الذي تم تقييمه
        public Product Product { get; set; } // المنتج الذي تم تقييمه
        public int Stars { get; set; } // عدد النجوم من 1 إلى 5
        public Rating()
        {
            RatingId = Guid.NewGuid(); // تعيين معرف فريد للتقييم 
        }
    }
}
