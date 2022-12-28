using System;

namespace _5._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] myNumbers = new int[3] { num1, num2, num3 };
            int negativeCount = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                CheckIfNumberIsZero(myNumbers[i]);
                negativeCount = CheckIfNumIsNegative(myNumbers, i, negativeCount);
            }

            Console.WriteLine(negativeCount %2 == 0 ? "positive" : "negative");

            
        }

        private static int CheckIfNumIsNegative(int[] myNumbers, int i, int negativeCount)
        {
            if (myNumbers[i] < 0)
            {
                negativeCount++;
            }

            return negativeCount;
        }

        private static void CheckIfNumberIsZero(int myNumber)
        {
            if (myNumber == 0)
            {
                Console.WriteLine("zero");
                System.Environment.Exit(0);
            }
        }
    }
}
