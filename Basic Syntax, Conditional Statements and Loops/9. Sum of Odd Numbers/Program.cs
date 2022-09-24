using System;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nextNum = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(nextNum);
                sum += nextNum;
                nextNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
