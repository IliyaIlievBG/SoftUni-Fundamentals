using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x=> int.Parse(x)).ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToList();

            List<int> resultList = new List<int>();
            int iterationsCount = Math.Min(firstList.Count, secondList.Count);
           
            for (int i = 0; i <= iterationsCount-1; i++)
            {
                resultList.Add(firstList[0]);
                firstList.Remove(firstList[0]);
                resultList.Add(secondList[^1]);
                secondList.Remove(secondList[^1]);
            }
         
            List<int> range = firstList.Count > secondList.Count ? firstList : secondList;
            range=range.OrderBy(x => x).ToList();

            resultList = resultList.Where(x => x > range[0] && x < range[1]).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(' ', resultList));
        }
    }
}
