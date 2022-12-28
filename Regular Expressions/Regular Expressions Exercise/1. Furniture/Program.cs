using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string myPattern = @">{2}(?<furn>[A-Za-z\s?]+)<{2}(?<price>\d+.?\d+)!(?<quant>\d+)";

            double totalMoneySpent = 0;

            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match validPurchase = Regex.Match(input, myPattern);
                if (validPurchase.Success)
                {
                    Console.WriteLine(validPurchase.Groups["furn"].Value);
                    totalMoneySpent += double.Parse(validPurchase.Groups["price"].Value) *
                                       int.Parse(validPurchase.Groups["quant"].Value);

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalMoneySpent:F2}");
        }
    }
}
