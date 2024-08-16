using MyPersonalProject.Models;

namespace MyPersonalProject.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts();

        Product GetProduct(int productId);

        bool ProductExists(int productId);

        bool CreateProduct(Product product);

        bool UpdateProduct(Product product);

        bool DeleteProduct(Product product);
        ICollection<User> GetUserByProduct(int productId);

        ICollection<Review> GetReviewByProduct(int productId);
    }
}
