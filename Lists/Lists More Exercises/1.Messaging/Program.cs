using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            string text = Console.ReadLine();

            foreach (var number in numbers)
            {
                int sum = 0; 
                int currentNum = number;
                while (currentNum >0)
                {
                    int lastDigit = currentNum % 10;
                    sum += lastDigit;
                    currentNum /=10;
                }
                if (sum<= text.Length)
                {
                    Console.Write(text[sum]);
                }
                else
                {
                    sum -= text.Length;
                    Console.Write(text[sum]);
                }

                text = text.Remove(sum, 1);
            }
        }
    }
}
