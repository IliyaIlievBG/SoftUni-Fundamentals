using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingCharIndex = int.Parse(Console.ReadLine());
            int endingCharIndex = int.Parse(Console.ReadLine());

            for (int charCount = startingCharIndex; charCount <= endingCharIndex; charCount++)
            {
                Console.Write($"{(char)charCount} ");
            }

           
        }
    }
}
