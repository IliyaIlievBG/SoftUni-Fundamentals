using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] encryptedMessage = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<char, string> morseCode = DecryptMorseCode();

            foreach (var letter in encryptedMessage)
            {
                char nextLetter = GetLetter(morseCode, letter);
                Console.Write(nextLetter);
            }
            Console.WriteLine();
        }

        private static char GetLetter(Dictionary<char, string> morseCode, string codedLetter)
        {
            char nextLetter = '\0';
            foreach (var letter in morseCode)
            {
                if (letter.Value == codedLetter) 
                {
                    nextLetter = letter.Key;
                }
            }
            return char.ToUpper(nextLetter);
        }

        private static Dictionary<char, string> DecryptMorseCode()
        {
            return new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {' ', "|" }
            };
        }
    }
}
