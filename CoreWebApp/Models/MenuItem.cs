namespace CoreWebApp.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
