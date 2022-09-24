using System;

namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int length = input.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
