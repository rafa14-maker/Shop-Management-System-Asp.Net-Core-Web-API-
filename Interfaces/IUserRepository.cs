using MyPersonalProject.Models;

namespace MyPersonalProject.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();

        User GetUser(int userId);

        bool UserExists(int userId);

        bool CreateUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(User user);

        ICollection<Product> GetProductByUser(int userId);

        ICollection<Review> GetReviewByUser(int userId);
        bool Save();
    }
}
