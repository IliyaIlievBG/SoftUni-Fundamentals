using System;

namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ");
            Article article = new Article(articleData[0], articleData[1], articleData[2]);

            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(": ");
                switch (currentCommand[0])
                {
                    case "Edit":
                        article.Edit(currentCommand[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(currentCommand[1]);
                        break;
                    case "Rename":
                        article.Rename(currentCommand[1]);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    public class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
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
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }


}
