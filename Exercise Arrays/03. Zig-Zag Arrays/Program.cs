using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysSize = int.Parse(Console.ReadLine());

            int[] arrOne = new int[arraysSize];
            int[] arrTwo = new int[arraysSize];
            for (int i = 0; i < arraysSize; i++)
            {
                int[] followingNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (i%2==0)
                {
                    arrOne[i] = followingNums[0];
                    arrTwo[i] = followingNums[1];
                }
                else
                {
                    arrOne[i] = followingNums[1];
                    arrTwo[i] = followingNums[0];
                }
            }
            foreach (int nums in arrOne)
            {
                Console.Write($"{nums} ");

            }
            Console.WriteLine();
            foreach (int nums in arrTwo)
            {
                Console.Write($"{nums} ");
            }
        }
    }
}
