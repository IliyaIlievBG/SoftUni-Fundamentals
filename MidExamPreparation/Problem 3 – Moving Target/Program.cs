using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //get index method
                int index = GetIndex(currentCommand[1]);
                bool indexExists = CheckIfIndexExists(index, targets);
                if (currentCommand[0] == "Shoot")
                {
                    int power = int.Parse(currentCommand[2]);
                    if (indexExists)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if (currentCommand[0] == "Add")
                {
                    if (indexExists)
                    {
                        targets.Insert(index, int.Parse(currentCommand[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else // = Strike
                {
                    int radius = int.Parse(currentCommand[2]);
                    if (index - radius < 0 || index + radius >= targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }

                }

                command = Console.ReadLine();

            }
            Console.WriteLine(String.Join('|', targets));
        }

        private static bool CheckIfIndexExists(int index, List<int> targets)
        {
            bool indexExists = (index >= 0 && index < targets.Count) ? true : false;
            return indexExists;
        }

        private static int GetIndex(string commandIndex)
        {
            return int.Parse(commandIndex);
        }
    }
}
