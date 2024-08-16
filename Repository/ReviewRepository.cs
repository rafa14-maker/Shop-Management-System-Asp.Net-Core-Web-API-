using Microsoft.EntityFrameworkCore;
using MyPersonalProject.Data;
using MyPersonalProject.Interfaces;
using MyPersonalProject.Models;

namespace MyPersonalProject.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private DataContext _context;
        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(review => review.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public bool CreateReview(Review review)
        {
            _context.Add(review);
            return Save();
        }

        public bool UpdateReview(Review review)
        {
           _context.Update(review);
            return Save();
        }

        public bool DeleteReview(Review review)
        {
            _context.Remove(review);
            return Save();
        }

        public ICollection<User> GetUserByReview(int reviewId)
        {
            return _context.Reviews.Where(review => review.Id == reviewId).Select(r => r.User).ToList(); 
        }

        public ICollection<Product> GetProductByReview(int reviewId)
        {
            return _context.Reviews.Where(review=>review.Id == reviewId).Select(r => r.Product).ToList();
        }
        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(review=>reviewId == review.Id);
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
