using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string secondWord = firstArray[i];
                    if (word == secondWord)
                    {
                        Console.Write($"{word} ");
                        break;
                    }
                }
            }

        }
    }
}
