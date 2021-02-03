using System;
using System.Runtime.CompilerServices;

namespace _02._Articles
{
    class Program
    {



        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            Article newArticle = new Article(article[0], article[1], article[2]);

            for (int i = 0; i < n; i++)
            {
                Article.ArticleEditor();
            }

            Console.WriteLine(newArticle.ToString());
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

            public static void ArticleEditor()
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string newInput = command[1];

                if (action == "Edit")
                {
                    Content = newInput;
                }
                else if (action == "ChangeAuthor")
                {
                    Author = newInput;
                }
                else if (action == "Rename")
                {
                    Title = newInput;
                }
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
