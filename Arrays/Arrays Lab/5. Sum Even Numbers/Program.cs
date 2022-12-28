using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int evenNumsSum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2==0)
                {
                    evenNumsSum += intArray[i];
                }   
            }
            Console.WriteLine(evenNumsSum);

        }
    }
}
