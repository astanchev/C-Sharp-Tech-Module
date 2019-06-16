using System;

namespace _02._Articles
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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(", ");

            string title = inputLine[0];
            string content = inputLine[1];
            string author = inputLine[2];
            Article article = new Article(title, content, author);

            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string command = commands[0];
                string fieldToChange = commands[1];
                switch (command)
                {
                    case "Edit": article.Edit(fieldToChange); break;
                    case "ChangeAuthor": article.ChangeAuthor(fieldToChange); break;
                    case "Rename": article.Rename(fieldToChange); break;
                    default: break;
                }
            }

            Console.WriteLine(article.ToString());

           

        }
    }
}
