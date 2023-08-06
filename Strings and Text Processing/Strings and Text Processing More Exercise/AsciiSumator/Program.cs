using System;

namespace AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string charsToSum = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < charsToSum.Length ; i++)
            {
                if (charsToSum[i] >= firstChar && charsToSum[i] <= secondChar)
                {
                    sum += charsToSum[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
