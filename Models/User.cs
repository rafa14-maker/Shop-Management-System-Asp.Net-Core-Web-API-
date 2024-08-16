namespace MyPersonalProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<UserProduct> userProducts { get; set; }
    }
}
