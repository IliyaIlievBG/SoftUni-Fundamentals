using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> race = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToList();

            double leftSpeed = 0;
            double rightSpeed = 0;

            for (int i = 0; i < race.Count/2; i++)
            {
                leftSpeed = GetSpeed(race, i, leftSpeed);
                rightSpeed = GetSpeed(race, race.Count - 1 - i, rightSpeed);
            }

            Console.WriteLine(leftSpeed<rightSpeed ? $"The winner is left with total time: {Math.Round(leftSpeed,1)}" : $"The winner is right with total time: {Math.Round(rightSpeed,1)}");
        }

        private static double GetSpeed(List<int> race, int i, double sum)
        {
            if (race[i] != 0)
            {
                sum += race[i];
            }
            else
            {
                sum *= 0.8;
            }

            return sum;
        }
    }
}
