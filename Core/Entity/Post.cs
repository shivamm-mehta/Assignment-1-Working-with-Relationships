namespace Core.Entity
{
    public class Post : UserEnity
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public int PostTypeId { get; set; }

    }
}
