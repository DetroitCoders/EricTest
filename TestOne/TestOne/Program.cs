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

                var j = new Post
                {
                    Title = $"The Best Movie {nonZeroDigit}",
                    Description = "This movie will bring you to tears",
                    PostTime = new DateTime(2016, nonZeroDigit, nonZeroDigit)
                };

                posts.Add(j);
            }

            return posts;
        }

        private static void Print(Post p)
        {
            Console.WriteLine(p.Title);
            Console.WriteLine(p.Description);
            Console.WriteLine(p.PostTime);
            Console.WriteLine(" ");
        }
    }
}