using MyPersonalProject.Models;

namespace MyPersonalProject.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);

        bool ReviewExists(int reviewId);

        bool CreateReview(Review review);

        bool UpdateReview(Review review);

        bool DeleteReview(Review review);

        ICollection<Product> GetProductByReview(int reviewId);

        ICollection<User> GetUserByReview(int reviewId);
    }
}
