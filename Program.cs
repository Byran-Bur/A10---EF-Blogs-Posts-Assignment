using System;
using EFTutorial.Models;
using System.Linq;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext()) 
            {
                var blog = db.Blogs.Where(x=>x.BlogId == 1).FirstOrDefault();

                System.Console.WriteLine($"Posts for Blog {blog.Name}");

                foreach (var post in blog.Posts) {
                    System.Console.WriteLine($"\tPost {post.PostId} {post.Title}");
                }
            }
            
        }
    }
}