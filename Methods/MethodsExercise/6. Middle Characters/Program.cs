using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = GetMiddleCharacters(input);
            Console.WriteLine(result);
        }

        static string GetMiddleCharacters(string input)
        {
            string receivedChars = string.Empty;
            int desiredLength;
            if (input.Length%2 == 0)
            {
                desiredLength = input.Length / 2 + 1;
                for (int  i = 0;  i <desiredLength;  i++)
                {
                    if (i == desiredLength-2 || i == desiredLength -1)
                    {
                        receivedChars += input[i];
                    }
                }
            }
            else
            {
                desiredLength = input.Length / 2;
                for (int i = 0; i < desiredLength; i++)
                {
                    if (i==desiredLength-1)
                    {
                        receivedChars += input[i+1];
                    }
                }
            }
            return receivedChars;
          
        }
    }
}
