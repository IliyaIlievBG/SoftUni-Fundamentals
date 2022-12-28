using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0).ToArray();

            //if user enters numbers or specialSymbols -> they are treated like strings

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
