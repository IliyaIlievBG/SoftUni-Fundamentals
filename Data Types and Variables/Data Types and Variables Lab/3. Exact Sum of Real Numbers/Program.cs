using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            decimal sumOfNumbers = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                decimal nextNumber = decimal.Parse(Console.ReadLine());
                sumOfNumbers += nextNumber;

            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
