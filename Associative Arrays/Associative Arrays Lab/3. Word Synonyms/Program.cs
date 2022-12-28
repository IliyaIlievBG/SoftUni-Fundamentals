using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int countOfWords = -1;
            bool validInput = int.TryParse(input, out countOfWords);

            while (!validInput || countOfWords < 0) //check for invalid count
            {
                Console.WriteLine("Invalid count: Enter only positive integers");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out countOfWords);

            }

            Dictionary<string, List<string>> synonymsDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
        
                string keyWord = Console.ReadLine();
                string value = Console.ReadLine();
                if (!synonymsDictionary.ContainsKey(keyWord))
                {
                    synonymsDictionary[keyWord] = new List<string>(); //if you get the keyword again, add it's synonym to it's list.
                }
                synonymsDictionary[keyWord].Add(value);
                Console.WriteLine();
            }

            foreach (KeyValuePair<string, List<string>> pair in synonymsDictionary)
            {
                Console.WriteLine($"{pair.Key} - {String.Join(", ", pair.Value)}");
            }

        }
    }
}
