using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedRageQuitMessage = Console.ReadLine().ToUpper();

            string patternToMatch = @"([\D]+)(\d+)";

            MatchCollection matches = Regex.Matches(encryptedRageQuitMessage, patternToMatch);

            StringBuilder rageQuitMessage = new StringBuilder();

            foreach (Match item in matches)
            {
                string letters = item.Groups[1].Value;
                int numbers = int.Parse(item.Groups[2].Value);
                for (int i = 0; i < numbers; i++)
                {
                    rageQuitMessage.Append(letters);
                }

            }

            Console.WriteLine($"Unique symbols used: {rageQuitMessage.ToString().Distinct().Count()}");
            Console.WriteLine(rageQuitMessage.ToString());

        }
    }
}
