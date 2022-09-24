using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintChars(firstChar, secondChar);
        }
        static void PrintChars(char first, char second)
        {
            char firstChar = first;
            char secondChar = second;   
            if (second<first)
            {
                second = firstChar;
                first = secondChar;
            }
            for (char i = ++first; i < second; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
