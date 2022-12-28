using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int index = 0; index < myList.Count; index++)
            {
                if (myList[index] <0)
                {
                    myList.RemoveAt(index);
                    index--;
                }
            }
            PrintResult(myList);

        }

        static void PrintResult(List<int> myList)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                myList.Reverse();
                Console.WriteLine(String.Join(" ", myList));
            }
        }
    }
}
