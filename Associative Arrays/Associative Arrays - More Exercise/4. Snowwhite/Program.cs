using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] dwarfInfo = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                if (dwarfInfo.Count() != 3)
                {
                    Console.WriteLine("Invalid dwarf info!");
                }
                else
                {
                    string dwarfName = GetDwarfInfo(dwarfInfo, 0);
                    string dwarfHatColour = GetDwarfInfo(dwarfInfo, 1);
                    int dwarfPhysics = int.Parse(GetDwarfInfo(dwarfInfo, 2));

                    string currentDwarf = $"({dwarfHatColour}) {dwarfName}";
                    if (!dwarfs.ContainsKey(currentDwarf))
                    {
                        dwarfs.Add(currentDwarf, dwarfPhysics);
                    }
                    else
                    {
                        dwarfs[currentDwarf] = Math.Max(dwarfs[currentDwarf], dwarfPhysics);
                    }

                }

                input = Console.ReadLine();
            }
            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs
                .Where(y => y.Key.Split(' ')[0] == x.Key.Split(' ')[0]).Count()))
            {
                Console.WriteLine($"{dwarf.Key.Split(' ')[0]} {dwarf.Key.Split(' ')[1]} <-> {dwarf.Value}");
            }

        }

        private static string GetDwarfInfo(string[] dwarfInfo, int index)
        {
            return dwarfInfo[index];
        }
    }
}
