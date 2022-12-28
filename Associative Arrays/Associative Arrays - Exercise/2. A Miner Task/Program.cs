using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "stop")
                {
                    break;
                }


                string resource = command;
                int quantity;
                bool validQuantity = int.TryParse(Console.ReadLine(), out quantity);
                if (!validQuantity)
                {
                    Console.WriteLine("Resource quantity must be an integer!");
                }
                else
                {
                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }
                    resources[resource] += quantity;
                }

              

            }

            foreach (KeyValuePair<string, int> pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
