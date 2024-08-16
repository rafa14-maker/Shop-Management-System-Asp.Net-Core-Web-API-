using MyPersonalProject.Data;
using MyPersonalProject.Interfaces;
using MyPersonalProject.Models;

namespace MyPersonalProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public Product GetProduct(int productId)
        {
            return _context.Products.Where(product => product.Id == productId).FirstOrDefault();
        }

        public ICollection<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool CreateProduct(Product product)
        {
            _context.Add(product);
            return Save();
        }

        public bool UpdateProduct(Product product)
        {
           _context.Update(product);
            return Save();
        }

        public bool DeleteProduct(Product product)
        {
            _context.Remove(product);
            return Save();
        }

        public ICollection<Review> GetReviewByProduct(int productId)
        {
            return _context.Products.Where(product=>product.Id == productId).Select(r=>r.Reviews).FirstOrDefault();
        }

        public ICollection<User> GetUserByProduct(int productId)
        {
            return _context.UserProducts.Where(p => p.ProductId == productId).Select(p => p.User).ToList();
        }

        public bool ProductExists(int productId)
        {
            return _context.Products.Any((product) => product.Id == productId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
