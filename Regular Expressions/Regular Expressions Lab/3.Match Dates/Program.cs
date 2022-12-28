using System;
using System.Text.RegularExpressions;

namespace _3.Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find all the valid dates in the input and print each date in the following format:
            //"Day: {day}, Month: {month}, Year: {year}", each on a new line. 
            string datesInput = Console.ReadLine();

            string myPattern =
                @"(?<day>\b\d{2}\b)(?<separator>[-.\/])(?<month>\b[A-Z][a-z]{2}\b)\<separator>(?<year>\b\d{4}\b)";

            Regex myRegex = new Regex(myPattern);
            MatchCollection matches = myRegex.Matches(datesInput);

            foreach (Match match in matches)
            {
                string date = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }



        }
    }
}
