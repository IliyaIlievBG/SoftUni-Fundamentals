using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (currentCommand[0] == "Add")
                {
                    wagons.Add(int.Parse(currentCommand[1]));
                }
                else
                {
                    int passengers = int.Parse(currentCommand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
