using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List
            List<Post> posts = new List<Post>();

            // Populate List
            for (int i = 0; i < 10; i++)
            {
                Post j = new Post();
                j.Title = "The Best Movie";
                j.Description = "This movie will bring you to tears";
                j.PostTime = DateTime.Now;
                posts.Add(j);
            }

            // Display List
            
        }
    }
}
