using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int index = 0; index < inputArr.Length; index++)
            {
                if (inputArr.Length==1)
                {
                    Console.WriteLine("0");
                    return;
                }
                leftSum = 0;
                for (int leftSide = index; leftSide >0; leftSide--)
                {
                    int nextLeftElement = leftSide - 1;
                    if (leftSide>0)
                    {
                        leftSum += inputArr[nextLeftElement];
                    }
                }
                rightSum = 0;
                for (int rightSide = index; rightSide < inputArr.Length; rightSide++)
                {
                    int nextRightElement = rightSide + 1;
                    if (rightSide < inputArr.Length-1)
                    {
                        rightSum += inputArr[nextRightElement];
                    }
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine($"{index}");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
