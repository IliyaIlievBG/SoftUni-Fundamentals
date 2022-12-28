using System;
using System.Text.RegularExpressions;

namespace _1.Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string myRegexPattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(myRegexPattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
