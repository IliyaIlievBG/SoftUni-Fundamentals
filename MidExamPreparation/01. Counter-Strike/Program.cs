using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int battlesWonCount = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                if (initialEnergy< distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWonCount} won battles and {initialEnergy} energy");
                    return;
                }
                battlesWonCount++;
                initialEnergy -= distance;
                if (battlesWonCount%3 == 0)
                {
                    initialEnergy += battlesWonCount;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {battlesWonCount}. Energy left: {initialEnergy}");
        }
    }
}
