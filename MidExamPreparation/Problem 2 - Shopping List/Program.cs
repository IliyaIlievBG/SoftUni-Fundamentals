using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2___Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] currentCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string item = currentCommand[1];
                bool itemIsInList = CheckIfItemIsInList(item, groceries);
                if (currentCommand[0] == "Urgent")
                {
                    if (!itemIsInList)
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (currentCommand[0] == "Unnecessary")
                {
                    if (itemIsInList)
                    {
                        groceries.Remove(item);
                    }
                }
                else if (currentCommand[0] == "Correct")
                {
                    if (itemIsInList)
                    {
                        int index = groceries.IndexOf(item);
                        string newProduct = currentCommand[2];
                        groceries.Insert(index, newProduct);
                        groceries.Remove(item);
                    }
                }
                else //Rearrange
                {
                    if (itemIsInList)
                    {
                        int index = groceries.IndexOf(item);
                        groceries.Add(item);
                        groceries.RemoveAt(index);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", groceries));
        }

        static bool CheckIfItemIsInList(string item, List<string> groceries)
        {
            return groceries.Contains(item);
        }
    }
}
