using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = SumVowels(input);
            Console.WriteLine(result);
        }
        static int SumVowels(string input)
        {
            int sum = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'e' || input[i] == 'u' || input[i] == 'i' || input[i] == 'y')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
