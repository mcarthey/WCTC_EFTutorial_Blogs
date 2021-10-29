using System;
using EFTutorial.Models;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your Blog name");
            var blogName = Console.ReadLine();

            // Create new Blog
            var blog = new Blog();
            blog.Name = blogName;
            
            // Save blog object to database
            // var db = new BlogContext();
            // db.Add(blog);
            // db.Commit();
        }
    }
}
