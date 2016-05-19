using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

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

            var rssXmlDoc = new XmlDocument();

            rssXmlDoc.Load("http://main.planbgaming.com/feed/");
            var rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            foreach(XmlNode rssNode in rssNodes)
            {
                var rssSubNode = rssNode.SelectSingleNode("title");
                var title = rssSubNode?.InnerText ?? "";

                rssSubNode = rssNode.SelectSingleNode("description");
                var description = rssSubNode?.InnerText ?? "";

                rssSubNode = rssNode.SelectSingleNode("link");
                var url = rssSubNode?.InnerText ?? "";

                rssSubNode = rssNode.SelectSingleNode("pubDate");
                var date = rssSubNode?.InnerText ?? "";

                var post = new Post
                {
                    Title = WebUtility.HtmlDecode(title),
                    Description = WebUtility.HtmlDecode(description),
                    Url = url,
                    Date = DateTime.Parse(date)
                };

                posts.Add(post);
            }

            return posts.ToList();
        }

        private static void Print(Post post)
        {
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Url);
            Console.WriteLine(post.Date);
            Console.WriteLine("-----------");
        }
    }
}