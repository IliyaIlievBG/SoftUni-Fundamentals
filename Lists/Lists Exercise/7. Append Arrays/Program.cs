using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringNums = Console.ReadLine().Split('|').ToList();
            stringNums.Reverse();

   

            List<int> nums = new List<int>();


            foreach (string array in stringNums)
            {
                nums.AddRange(array.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(String.Join(' ', nums));

            



        }
    }
}
