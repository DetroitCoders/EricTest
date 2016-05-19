using System;
using System.Collections.Generic;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var posts = GetPosts();

            posts.ForEach(Print);

            Console.ReadKey();
        }

        private static List<Post> GetPosts()
        {
            var posts = new List<Post>();

            for(var i = 0; i < 10; i++)
            {
                var nonZeroDigit = i + 1;

                var post = new Post
                {
                    Title = $"The Best Movie {nonZeroDigit}",
                    Description = "This movie will bring you to tears",
                    PostTime = new DateTime(2016, nonZeroDigit, nonZeroDigit)
                };

                posts.Add(post);
            }

            return posts;
        }

        private static void Print(Post post)
        {
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.PostTime);
            Console.WriteLine(" ");
        }
    }
}