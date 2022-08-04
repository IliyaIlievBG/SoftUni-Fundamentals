using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            // 1 British Pound = 1.31 Dollars
            decimal dollars = pounds * 1.31m;
            Console.WriteLine($"{dollars:F3}");

        }
    }
}
