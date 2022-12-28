using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
           

            int originalCount = numbers.Count;
            for (int i = 0; i < originalCount/2; i++)
            {
                numbers[i] += numbers[originalCount - 1 - i];
                numbers.RemoveAt(numbers.Count - 1);

            }
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
