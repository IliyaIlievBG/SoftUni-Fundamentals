using System;

namespace ForeignLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            //if country = USA or England ->output = English
            //if countru = Spain, Argentina, Mexico -> output = Spanish
            //else -> output = uknown

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
