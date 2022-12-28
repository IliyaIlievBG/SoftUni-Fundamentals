using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string validPhones = @"(?<bg>\+359)(?<separator>[ -])2\<separator>(?<g1>\d{3})\<separator>(?<g2>\d{4})\b";
            
            MatchCollection phoneMatches = Regex.Matches(phones, validPhones);
            // var matchedPhones = phoneMatches.Cast<Match>().Select(m => m.Value).ToList();
            Console.WriteLine(string.Join(", ", phoneMatches));

            //foreach (Match match in phoneMatches)
            //{
            //    Console.WriteLine(String.Join(", ", match).ToArray());
            //}

        }
    }
}
