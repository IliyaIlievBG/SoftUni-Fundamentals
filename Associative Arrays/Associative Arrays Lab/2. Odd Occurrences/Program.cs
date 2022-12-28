using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLower()).ToArray();
            //numbers and special symbols are treated like strings

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word] = 0;
                }

                wordsDictionary[word]++;
            }

            foreach (KeyValuePair<string, int> pair in wordsDictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }





        }
    }
}
