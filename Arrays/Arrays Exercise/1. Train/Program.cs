using System;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int totalPassanges = 0;
            int[] peopleInWagons = new int[wagons];

            for (int peopleInEachWagon = 0; peopleInEachWagon < peopleInWagons.Length; peopleInEachWagon++)
            {
                peopleInWagons[peopleInEachWagon] = int.Parse(Console.ReadLine());
                totalPassanges += peopleInWagons[peopleInEachWagon];
               
            }
            foreach (int people in peopleInWagons)
            {
                Console.Write($"{people} ");
                
            }
            Console.Write("\n");

            
            Console.WriteLine(totalPassanges);


            
        }
    }
}
