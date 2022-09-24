﻿using System;

namespace _1._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int intOutput;
            double floatingPointOutput;
            char charOutput;
            bool boolOutput;

            while (input != "END")
            {
                if (int.TryParse(input, out intOutput))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out floatingPointOutput))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charOutput))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolOutput))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }

    }
}
