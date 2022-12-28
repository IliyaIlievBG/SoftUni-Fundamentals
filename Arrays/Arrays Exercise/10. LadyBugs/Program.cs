using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //size of the array
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugField = new int[fieldSize];//ex 3 [ 0 0 0 ]
            //0 1
            int[] occupiedIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int index = 0; index < occupiedIndexes.Length; index++)
            {
                int currentIndex = occupiedIndexes[index];
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladybugField[currentIndex] = 1;//insert a ladyBug into the current index.
                }

            }
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(command[0]);
                while (currentIndex >= 0 && currentIndex < fieldSize && ladybugField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladybugField[currentIndex] = 0; //ladybug flies away
                        isFirst = false;
                    }
                    string direction = command[1];
                    int flightLength = int.Parse(command[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLength;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladybugField[currentIndex] == 0)
                            {
                                ladybugField[currentIndex] = 1; //moove ladybug to the left
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLength;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladybugField[currentIndex] == 0)
                            {
                                ladybugField[currentIndex] = 1; //moove ladybug to the right
                                break;
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(' ', ladybugField));

        }
    }
}