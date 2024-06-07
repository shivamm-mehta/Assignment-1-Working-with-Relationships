using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
