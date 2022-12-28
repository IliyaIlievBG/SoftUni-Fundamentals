using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int wagon = 0; wagon < lift.Length; wagon++)
            {

                for (int currentWagon = lift[wagon]; currentWagon < 4; currentWagon++)
                {
                    if (peopleWaiting==0 && currentWagon<4)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(String.Join(' ', lift));
                        return;
                    }
                    peopleWaiting--;
                    lift[wagon]++;
                }
            }
            if (peopleWaiting>0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
              
            }
            Console.WriteLine(String.Join(' ', lift));
        }
    }
}
