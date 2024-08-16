namespace MyPersonalProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        public decimal Price { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<UserProduct> UserProducts { get; set; }
    }
}
