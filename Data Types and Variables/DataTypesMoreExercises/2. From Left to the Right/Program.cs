using System;

namespace _2._From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                long leftSum = 0;
                long rightSum = 0;

                long lefNumber = long.Parse(input[0]);
                long rightNumber = long.Parse(input[1]);

                if (lefNumber > rightNumber)
                {
                    while (lefNumber != 0)
                    {
                        long currentDigit = lefNumber % 10;
                        leftSum += currentDigit;
                        lefNumber /= 10;
                    }
                    Console.WriteLine(Math.Abs(leftSum));

                }
                else
                {
                    while (rightNumber != 0)
                    {
                        long currentDigit = rightNumber % 10;
                        rightSum += currentDigit;
                        rightNumber /= 10;
                    }
                    Console.WriteLine(Math.Abs(rightSum));
                }



            }
        }
    }
}
