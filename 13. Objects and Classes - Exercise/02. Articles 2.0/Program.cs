using System;
using System.Collections.Generic;

namespace _02._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> articlesList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ");
                Article newArticle = new Article(article[0], article[1], article[2]);
                articlesList.Add(newArticle.ToString());
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articlesList.Sort();
            }
            else if (criteria == "content")
            {
                for (int i = 0; i < articlesList.Count; i++)
                {
                    string[] elements = articlesList[i].Split(", ");
                }
            }
            else if (criteria == "author")
            {

            }





        }

        public class Article
        {
            public static string Title { get; set; }
            public static string Content { get; set; }
            public static string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
