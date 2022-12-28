using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                string action = currentCommand[0];

                if (action == "Delete")
                {
                    int element = int.Parse(currentCommand[1]);
                    for (int index = 0; index < numbers.Count; index++)
                    {
                        if (numbers[index] == element)
                        {
                            numbers.RemoveAll(x => x == element);
                        }
                    }
                }
                else //Insert
                {
                    int element = int.Parse(currentCommand[1]);
                    int position = int.Parse(currentCommand[2]);
                    numbers.Insert(position, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
