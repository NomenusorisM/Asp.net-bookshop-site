namespace BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public ushort Price { get; set; }
        public int Year { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
