using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int sumEqualElements = int.Parse(Console.ReadLine());
            //14 20 60 13 7 19 8
            for (int index = 0; index < inputArr.Length-1; index++)
            {
                for (int i = index+1; i < inputArr.Length; i++)
                {
                    if (inputArr[index] + inputArr[i] == sumEqualElements)
                    {
                        Console.WriteLine($"{inputArr[index]} {inputArr[i]}");
                    }
                }
            }
        }
    }
}
