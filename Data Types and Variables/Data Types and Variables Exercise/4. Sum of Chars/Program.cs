using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());

            int sumOfChars = 0;

            for (int nextCharCount = 0; nextCharCount < numberOfChars; nextCharCount++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sumOfChars += (int)currentChar;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");

        }
    }
}
