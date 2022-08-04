using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = number;
            int sum = 0;
            while (currentNumber>0)
            {
                int currentDigit = currentNumber % 10;
                sum += currentDigit;
                currentNumber /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
