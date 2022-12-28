using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int output = GetMax(first, second);
                    Console.WriteLine(output);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
            

        }
        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }
        static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
