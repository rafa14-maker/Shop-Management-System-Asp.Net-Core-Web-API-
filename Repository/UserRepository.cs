using Microsoft.EntityFrameworkCore;
using MyPersonalProject.Data;
using MyPersonalProject.Interfaces;
using MyPersonalProject.Models;

namespace MyPersonalProject.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context; 
        }

        public User GetUser(int userId)
        {
            return _context.Users.Where(c => c.Id == userId).FirstOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public bool CreateUser(User user)
        {
            _context.Add(user);
            return Save();
        }

        public bool DeleteUser(User user)
        {
            _context.Remove(user);
            return Save();
        }

        public bool UpdateUser(User user)
        {
            _context.Update(user);
            return Save();
        }

        public bool UserExists(int userId)
        {
           return _context.Users.Any(c=>c.Id == userId);
        }

        public ICollection<Product> GetProductByUser(int userId)
        {
            return _context.UserProducts.Where(p=>p.UserId == userId).Select(p=>p.Product).ToList();
        }

        public ICollection<Review> GetReviewByUser(int userId)
        {
            return _context.Reviews.Where(p => p.User.Id == userId).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
