using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int index = 0; index < input.Length; index++)
            {
                int randomIndex = random.Next(0, input.Length);

                string currentWord = input[index];
                input[index] = input[randomIndex];
                input[randomIndex] = currentWord;

            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
           
        }
    }

}
