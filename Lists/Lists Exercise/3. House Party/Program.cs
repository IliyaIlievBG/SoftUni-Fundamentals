using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split();
                string name = currentCommand[0];
                bool guestIsInList = guests.Contains(name);
                switch (currentCommand[2])
                {
                    case "going!":
                        if (guestIsInList)
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                        else
                        {
                            guests.Add(name);
                        }
                        break;
                    case "not":
                        if (guestIsInList)
                        {
                            guests.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }
                        break;
                }
               
            }
            foreach (string person in guests)
            {
                Console.WriteLine(person);
            }
        }
    }
}
