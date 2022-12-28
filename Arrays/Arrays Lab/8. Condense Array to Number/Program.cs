using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the first array from the console
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] condensedArray = new int[nums.Length - 1];

            while (nums.Length > 1)
            {

                for (int index = 0; index < nums.Length - 1; index++)
                {
                    condensedArray[index] = nums[index] + nums[index + 1];
                    if (index == nums.Length - 2)
                    {
                        nums = condensedArray;
                        condensedArray = new int[nums.Length - 1];
                    }
                }

            }
            Console.WriteLine($"{nums[0]}");


        }
    }
}
