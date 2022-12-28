using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] bottomArray = new int[initialArray.Length / 2];

            int numbersToFold = initialArray.Length / 4;
            int[] leftTopArray = new int[numbersToFold];
            int[] rightToparray = new int[numbersToFold];

            for (int i = 0; i < leftTopArray.Length; i++)
            {
                leftTopArray[i] = initialArray[i];
            }
            Array.Reverse(leftTopArray);
            int operatingNum = initialArray.Length - 1;

            for (int j = numbersToFold - 1; j >= 0; j--)
            {
                rightToparray[j] = initialArray[operatingNum];
                operatingNum--;
            }
            Array.Reverse(rightToparray);
            int[] combinedArrays = leftTopArray.Concat(rightToparray).ToArray();
            for (int index = 0; index < combinedArrays.Length; index++)
            {
                bottomArray[index] = combinedArrays[index] + initialArray[index + numbersToFold];
                Console.Write($"{bottomArray[index]} ");
            }

        }
    }
}
