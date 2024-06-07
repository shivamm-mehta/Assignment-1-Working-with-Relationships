using Assignment_1;
using Core.Entity;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new DataContext())
        {
            context.Database.EnsureCreated();

            var users = new UserEntity[]
            {
                new UserEntity { Name = "Shivam", EmailAddress = "shivam@gmail.com", PhoneNumber = "825-488-1250" },
                new UserEntity { Name = "Keval", EmailAddress = "keval@gmail.com", PhoneNumber = "696-822-8901" },
                new UserEntity { Name = "Rajdeep", EmailAddress = "rajdeep@gmail.com", PhoneNumber = "345-678-9012" }
            };

            context.AddRange(users);
            context.SaveChanges();

            Console.WriteLine("3 Users saved successfully.");

            var user = context.Users.FirstOrDefault(u => u.Name == "Shivam");

            var blogType = new BlogType { Status = "Active", Name = "Technology", Description = "Tech related blogs" };
            context.Add(blogType);
            context.SaveChanges();

            var blog = new Blog
            {
                Url = "http://techblog.com",
                IsPublic = true,
                BlogTypeId = blogType.BlogTypeId,
                UserId = user.UserId
            };
            context.Add(blog);
            context.SaveChanges();

            var postType = new PostType { Status = "Active", Name = "Article", Description = "Informative articles" };
            context.Add(postType);
            context.SaveChanges();

            var post = new Post
            {
                Title = "Introduction to C#",
                Content = "This is a post about C# basics.",
                BlogId = blog.BlogId,
                PostTypeId = postType.PostTypeId,
                UserId = user.UserId
            };
            context.Add(post);
            context.SaveChanges();

            Console.WriteLine("1 Blog and 1 Post saved successfully.");

            var savedUsers = context.Users.ToList();
            Console.WriteLine("\nSaved Users:");
            foreach (var u in savedUsers)
            {
                Console.WriteLine($"ID: {u.UserId}, Name: {u.Name}, Email: {u.EmailAddress}, Phone: {u.PhoneNumber}");
            }

            var savedBlogs = context.Blogs.ToList();
            Console.WriteLine("\nSaved Blogs:");
            foreach (var b in savedBlogs)
            {
                Console.WriteLine($"ID: {b.BlogId}, URL: {b.Url}, IsPublic: {b.IsPublic}, BlogTypeId: {b.BlogTypeId}, UserId: {b.UserId}");
            }

            var savedPosts = context.Posts.ToList();
            Console.WriteLine("\nSaved Posts:");
            foreach (var p in savedPosts)
            {
                Console.WriteLine($"ID: {p.PostId}, Title: {p.Title}, Content: {p.Content}, BlogId: {p.BlogId}, PostTypeId: {p.PostTypeId}, UserId: {p.UserId}");
            }
        }
    }
}
