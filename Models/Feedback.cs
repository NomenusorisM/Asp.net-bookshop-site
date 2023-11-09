namespace BookShop.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
