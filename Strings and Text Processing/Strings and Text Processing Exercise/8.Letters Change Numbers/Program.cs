using System;
using System.Runtime.InteropServices;

namespace _8.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequences = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < sequences.Length; i++)
            {
                string currentString = sequences[i];
                bool currentStringIsValid;
               //to do check if there is Digit
                for (int j = 0; j < currentString.Length; j++)
                {
                    
                    char firstChar = GetChar(currentString, j);
                    char lastChar = GetChar(currentString, currentString.Length - 1);
                   // int lastIndex = currentString[^1];
                    //int length = currentString.Length - 1 - (j + 1);
                    string numberToString = currentString.Substring(j + 1, currentString.Length - (j+1)-1);
                    int number = int.Parse(numberToString);
                    int firstCharPosition = GetCharPosition(firstChar);
                    int lastCharPosition = GetCharPosition(lastChar);
                    double currentResult = Operations(firstChar, number, firstCharPosition, lastChar, lastCharPosition);
                    sum += currentResult;
                    break;

                }
            }

            Console.WriteLine($"{sum:F2}");
        }

        private static double Operations(char firstChar, int number, int firstCharPosition, char lastChar, int lastCharPosition)
        {
            double currentResult;
            if (char.IsUpper(firstChar))
            {
                currentResult = (double)number / firstCharPosition;
            }
            else
            {
                currentResult = (double)number * firstCharPosition;
            }

            if (char.IsUpper(lastChar))
            {
                currentResult -= lastCharPosition;
            }
            else
            {
                currentResult += lastCharPosition;
            }

            return currentResult;
        }

        private static int GetCharPosition(char currentChar)
        {
            if (!char.IsUpper(currentChar))
            {
                currentChar = char.ToUpper(currentChar);
            }
            int currentCharPoistion = currentChar - 64;
            return currentCharPoistion;
        }

        private static char GetChar(string currentString, int j)
        {
            return currentString[j];
        }
    }
}
