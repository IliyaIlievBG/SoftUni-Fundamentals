using System;

namespace _2.Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;
            foreach (string word in stringArr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);

        }
    }
}
