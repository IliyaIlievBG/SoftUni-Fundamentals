using System;
using System.Collections.Generic;

namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(',');
                Article article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                articles.Add(article);

            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
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
        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }
   
}
