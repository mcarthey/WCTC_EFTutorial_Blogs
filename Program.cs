using System;
using EFTutorial.Models;
using System.Linq;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. List Posts for Blog #1
            using (var db = new BlogContext()) 
            {
                var blog = db.Blogs.Where(x=>x.BlogId == 1).FirstOrDefault();
                // var blogsList = blog.ToList(); // convert to List from IQueryable

                System.Console.WriteLine($"Posts for Blog {blog.Name}");

                foreach (var post in blog.Posts) {
                    System.Console.WriteLine($"\tPost {post.PostId} {post.Title}");
                }
            }
            // 2. Add Post to database
            // System.Console.WriteLine("Enter your Post title");
            // var postTitle = Console.ReadLine();

            // var post = new Post();
            // post.Title = postTitle;
            // post.BlogId = 1;

            // using (var db = new BlogContext())
            // {
            //     db.Posts.Add(post);
            //     db.SaveChanges();
            // }

            // 3. Read Blogs from database
            // using (var db = new BlogContext()) 
            // {
            //     System.Console.WriteLine("Here is the list of blogs");
            //     foreach (var b in db.Blogs) {
            //         System.Console.WriteLine($"Blog: {b.BlogId}: {b.Name}");
            //     }
            // }

            // 4. Add Blog to Database
            // System.Console.WriteLine("Enter your Blog name");
            // var blogName = Console.ReadLine();

            // // Create new Blog
            // var blog = new Blog();
            // blog.Name = blogName;
            
            // // Save blog object to database
            // using (var db = new BlogContext()) 
            // {
            //     db.Add(blog);
            //     db.SaveChanges();
            // }

        }
    }
}
