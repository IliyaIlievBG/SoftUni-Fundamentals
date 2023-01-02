using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal gabsySavings = decimal.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
            var copyOfDrumset = drumSet.Select(x => x).ToList();

            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if (drumSet[i] <=0)
                    {
                        decimal drumPrice = copyOfDrumset[i] * 3;
                        if (drumPrice<= gabsySavings)
                        {
                            gabsySavings = BuyNewDrum(gabsySavings, drumSet, copyOfDrumset, i, drumPrice);
                        }

                    }
                }
                command = Console.ReadLine();
            }
            drumSet = drumSet.Where(x => x>0).ToList();
            Console.WriteLine(String.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {gabsySavings:F2}lv.");
        }

        private static decimal BuyNewDrum(decimal gabsySavings, List<int> drumSet, List<int> copyOfDrumset, int i, decimal drumPrice)
        {
            gabsySavings -= drumPrice;
            drumSet[i] = copyOfDrumset[i];
            return gabsySavings;
        }

    }
}
