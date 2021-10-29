namespace EFTutorial.Models
{
    public class Post 
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        
        // entity framework relationship
        // Navigation Properties
        public virtual Blog Blog {get;set;}
    }
}