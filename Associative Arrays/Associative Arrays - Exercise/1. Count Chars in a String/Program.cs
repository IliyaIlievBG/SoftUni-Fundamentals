using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();
            char[] charsFromInput = input.Where(x => x != ' ').ToArray();

            Dictionary<char, int> charsOccurances = new Dictionary<char, int>();

            foreach (char symbol in charsFromInput)
            {
                if (!charsOccurances.ContainsKey(symbol))
                {
                    charsOccurances[symbol] = 0;
                }

                charsOccurances[symbol]++;
            }

            foreach (KeyValuePair<char, int> pair in charsOccurances)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
