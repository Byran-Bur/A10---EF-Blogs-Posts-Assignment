using System;
using EFTutorial.Models;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your Post title");
            var postTitle = Console.ReadLine();

            var post = new Post();
            post.Title = postTitle;
            post.BlogId = 1;


            using (var db = new BlogContext())
            {
           db.Posts.Add(post);
           db.SaveChanges();

            }

            System.Console.WriteLine("Enter your Blog name");
            var blogName = Console.ReadLine();

            var blog = new Blog();
            blog.Name = blogName;
            
        
        }
    }
}