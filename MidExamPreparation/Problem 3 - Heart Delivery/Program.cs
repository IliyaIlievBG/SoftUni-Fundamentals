using System;
using System.Linq;

namespace Problem_3___Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhoodd = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int currentCupidIndex = 0;
            


            while (command != "Love!")
            {
                string[] currentJumpCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int currentJumpLength = int.Parse(currentJumpCommand[1]);
                currentCupidIndex += currentJumpLength;
                if (currentCupidIndex > neighbourhoodd.Length - 1)
                {
                    currentCupidIndex = 0;
                }

                if (neighbourhoodd[currentCupidIndex] == 0)
                {
                    Console.WriteLine($"Place {currentCupidIndex} already had Valentine's day.");
                }
                else
                {
                    neighbourhoodd[currentCupidIndex] -= 2;
                    if (neighbourhoodd[currentCupidIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentCupidIndex} has Valentine's day.");
                    }

                }
               


                command = Console.ReadLine();

            }
            Console.WriteLine($"Cupid's last position was {currentCupidIndex}.");
            int missedHousesCount = 0;
            foreach (int house in neighbourhoodd)
            {
                if (house != 0)
                {
                    missedHousesCount++;
                }
            }
            if (missedHousesCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {missedHousesCount} places.");
            }

        }
    }
}
