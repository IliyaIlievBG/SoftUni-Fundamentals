using System;
using System.Text;

namespace _6.Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int index = 0; index < input.Length - 1; index++)
            {
                result = !(input[index] == input[index + 1]) ? result.Append(input[index]) : result;


            }

            result.Append(input[^1]);

            Console.WriteLine(result);
        }
    }
}
