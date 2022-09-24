using System;

namespace backIn30minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //convert the hours into minutes
            int hoursInMinutes = hours * 60;
            int totalTimeInMinutes = hoursInMinutes + minutes + 30; //add 30 minutes
            //convert again into h/mm format
            int newHours = totalTimeInMinutes / 60;
            int newMinutes = totalTimeInMinutes % 60;
            if (newHours > 23)
            {
                newHours = 0;
            }

            Console.WriteLine($"{newHours}:{newMinutes:D2}");

        }
    }
}
