using System;
using System.Collections.Generic;

namespace HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = Console.ReadLine();

            List<string> comments = new List<string>();

            while (comment != "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }

            Console.WriteLine($"<h1> {Environment.NewLine}"
                              + "  " + $"{title}" + $"{Environment.NewLine}"
                              + "</h2>");
            Console.WriteLine($"<article> {Environment.NewLine}"
                              + "  " + $"{content}" + $"{Environment.NewLine}"
                              + "</article>");

            foreach (var sentence in comments)
            {
                Console.WriteLine($"<div> {Environment.NewLine}"
                                  + "  " + $"{sentence}" + $"{Environment.NewLine}"
                                  + "</div>");
            }
        }
    }
}
