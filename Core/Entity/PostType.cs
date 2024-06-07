using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class PostType
    {
        [Key]
        public int PostTypeId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
