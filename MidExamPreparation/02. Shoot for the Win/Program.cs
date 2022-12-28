using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToList();
            int shotTargets = 0;
            string command = Console.ReadLine();

            while (command!="End")
            {
                int currentIndex = int.Parse(command);
                if (currentIndex>=0 && currentIndex < targets.Count)
                {
                    int currentIndexValue = targets[currentIndex];
                    if (currentIndexValue == -1)
                    {
                        continue;
                    }
                    targets[currentIndex] = -1;
                    shotTargets++;

                    processTargets(targets, currentIndexValue);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {String.Join(' ', targets)}");

        }

        static void processTargets(List<int> targets, int currentIndexValue)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }
                if (targets[i] > currentIndexValue)
                {
                    targets[i] -= currentIndexValue;
                }
                else
                {
                    targets[i] += currentIndexValue;
                }
            }
        }
           
    }
}
