    using System;

    namespace _3._Elevator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                int elevatorCapacity = int.Parse(Console.ReadLine());

                int coursesCount = (int)Math.Ceiling((double)peopleCount / elevatorCapacity);
                Console.WriteLine(coursesCount);
            }
        }
    }
