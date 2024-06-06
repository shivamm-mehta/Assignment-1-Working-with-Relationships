namespace Core.Entity
{
    public class Blog : UserEnity
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public int BlogTypeId { get; set; }
    }
}
