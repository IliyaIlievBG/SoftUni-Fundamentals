using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();   

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                switch (currentCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currentCommand[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currentCommand[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currentCommand[1]));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(currentCommand[1]);
                        int indexToInsertAt = int.Parse(currentCommand[2]);
                        numbers.Insert(indexToInsertAt, numberToInsert);
                        break;

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
