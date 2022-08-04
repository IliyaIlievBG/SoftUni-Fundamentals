using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            string result = char.IsUpper(symbol) ? "upper-case" : "lower-case";
            Console.WriteLine(result);
        }
    }
}
