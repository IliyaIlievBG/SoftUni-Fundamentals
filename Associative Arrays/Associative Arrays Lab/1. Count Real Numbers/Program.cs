using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();

            bool validInput = false;
            while (!validInput)
            {
                double num;
                string[] numbersToString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string number in numbersToString)
                {
                    validInput = double.TryParse(number, out num);
                    if (!validInput)
                    {
                        break;
                    }

                }

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Only numbers, separated by space, please!");
                input = Console.ReadLine();


            }
            double[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();


            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }
                counts[number]++;

            }

            foreach (KeyValuePair<double, int> pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");

            }

        }
    }
}
