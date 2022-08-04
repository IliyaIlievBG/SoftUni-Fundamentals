using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterPourCount = int.Parse(Console.ReadLine());
            double tankCapacity = 255;
            double littersInTank = 0;
            for (int i = 0; i < waterPourCount; i++)
            {
                double waterToBePoured = double.Parse(Console.ReadLine());
                if (waterToBePoured>tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                tankCapacity -= waterToBePoured;
                littersInTank += waterToBePoured;

            }
            Console.WriteLine(littersInTank);
        }
    }
}
