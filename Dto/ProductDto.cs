using MyPersonalProject.Models;

namespace MyPersonalProject.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
