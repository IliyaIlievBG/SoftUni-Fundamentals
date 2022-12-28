using System;

namespace _5._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbolsCount = int.Parse(Console.ReadLine()); //number of symbols

            string SMS = "";

            for (int nextSymbol = 0; nextSymbol < symbolsCount; nextSymbol++) //the loop asks for the next symbol until it reaches the symbols count
            {
                string input = Console.ReadLine();

                int inputLength = input.Length; //get the length of the input
                int symbol = int.Parse(input); //convert the input into int
                int mainDigit = 0;

                for (int i = 0; i < inputLength; i++) //find the main digit
                {
                    mainDigit = symbol % 10;

                }

                int offsetOfNumber = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offsetOfNumber++;
                }//the begining
                int letterIndex = offsetOfNumber + inputLength - 1 + 97;
                char nextChar = (char)letterIndex;
                if (nextChar == (char)91)
                {
                    nextChar = (char)32;
                }
                SMS += nextChar;

            }

            Console.WriteLine(SMS);
        }
    }
}
