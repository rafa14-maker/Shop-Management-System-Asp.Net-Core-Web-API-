namespace MyPersonalProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string Title { get; set; }

        public decimal Rating { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }

    }
}
