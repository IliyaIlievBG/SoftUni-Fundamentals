using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondtList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            int biggerCount = Math.Max(firstList.Count, secondtList.Count);
            for (int index = 0; index < biggerCount; index++)
            {
                if (firstList.Count > index)
                {
                    resultList.Add(firstList[index]);

                }
                if (secondtList.Count > index)            
                {
                    resultList.Add(secondtList[index]);

                }
            }
            Console.WriteLine(String.Join(" ", resultList));

        }
    }
}
