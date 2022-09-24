using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int operatingNumber = number;
            int currentFactorial;
            int sumOfFactorials = 0;

            while (operatingNumber > 0)
            {
                //get the last digit of the number
                int nextDigit = operatingNumber % 10;
                currentFactorial = nextDigit;

                for (int i = nextDigit - 1; i >= 1; i--)
                {
                    currentFactorial = currentFactorial * i;

                }
                sumOfFactorials += currentFactorial;
                operatingNumber = operatingNumber / 10;

            }
            if (sumOfFactorials == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
