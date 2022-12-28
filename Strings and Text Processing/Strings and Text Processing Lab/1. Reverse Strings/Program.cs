using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                string word = command;

                string reversed = string.Join("", word.ToCharArray().Reverse());
                Console.WriteLine($"{word} = {reversed}");

                command = Console.ReadLine();
            }

        }
    }
}
