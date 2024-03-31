 namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        // short form to create property  -- prop and doble tab click

       // create a property for the id for guid type
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }
    }
}
