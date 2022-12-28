using System;

namespace _1._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input = Console.ReadLine();

            GetResult(inputType, input);
        }

        static void GetResult(string inputType, string input)
        {
            if (inputType == "int")
            {
                int result = int.Parse(input) * 2;
                Console.WriteLine(result);
            }
            else if (inputType == "real")
            {
                double result = double.Parse(input) * 1.5;
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}
