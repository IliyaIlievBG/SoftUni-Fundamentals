using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            int iterations = int.Parse(Console.ReadLine());

            string output = RepeatString(myString, iterations);
            Console.WriteLine(output);

        }
        static string RepeatString(string myInput, int iterationsCount)
        {
            string result = string.Empty;

            for (int i = 1; i <=iterationsCount; i++)
            {
                result += myInput;
            }
            return result;
        }
    }
}
