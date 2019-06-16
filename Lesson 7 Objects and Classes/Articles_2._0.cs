using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Content = content;
            this.Title = title;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] inputLine = Console.ReadLine().Split(", ");
                string title = inputLine[0];
                string content = inputLine[1];
                string author = inputLine[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string fieldToOrderBy = Console.ReadLine();
            List<Article> orderedArticles = ListOrderBy(fieldToOrderBy, articles);


            for (int i = 0; i < numberOfArticles; i++)
            {
                Article element = orderedArticles[i];
                Console.WriteLine(element.ToString());
            }
        }

        private static List<Article> ListOrderBy(string fieldToOrderBy, 
                                                List<Article> articles)
        {
            if (fieldToOrderBy == "title")
            {
                return articles.OrderBy(a => a.Title).ToList();
            }
            else if (fieldToOrderBy == "content")
            {
                return articles.OrderBy(a => a.Content).ToList();
            }
            else
            {
                return articles.OrderBy(a => a.Author).ToList();
            }                      
        }
    }
}
