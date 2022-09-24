using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);

            int result = MultiplySums(evenSum, oddSum);
            Console.WriteLine(result);

        }
        static int GetSumOfEvenDigits(int number)
        {
            int inputNumber = number;
            int sum = 0;
            while (inputNumber>0)
            {
                int lastDigit = inputNumber % 10;
                if (lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                inputNumber = inputNumber / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int inputNumber = number;
            int sum = 0;
            while (inputNumber>0)
            {
                int lastDigit = inputNumber % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                inputNumber = inputNumber / 10;
            }
            return sum;
        }
        static int MultiplySums(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
