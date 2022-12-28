using System;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstWord = words[0];
            string secondWord = words[1];

            int lonerLength = Math.Max(firstWord.Length, secondWord.Length);
            int multipliedChars = 0;

            string longerString = firstWord.Length == lonerLength ? firstWord : secondWord;
            string shorterString = firstWord.Length < lonerLength ? firstWord : secondWord;

            for (int i = 0; i < longerString.Length; i++)
            {
                int currentCharLongerString = longerString[i];

                if (i < shorterString.Length)
                {
                    int currentCharShorterString = shorterString[i];
                    multipliedChars += currentCharShorterString * currentCharLongerString;
                }
                else
                {
                    multipliedChars += currentCharLongerString;
                }
            }

            Console.WriteLine(multipliedChars);
        }
    }
}
