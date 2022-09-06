using System;
using System.Linq;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
          

            int numberOfRotations = int.Parse(Console.ReadLine());

            //rotate the array with the number of rotations; First element goes last and moves to the front with the number of rotations
            //  32 61 21 51 47 
            for (int currentRotation = 0; currentRotation < numberOfRotations; currentRotation++)
            {
                int tempElement = inputArr[0];
                for (int index = 0; index < inputArr.Length-1; index++)
                {
                    
                    inputArr[index] = inputArr[index + 1];
                }
                inputArr[inputArr.Length-1] = tempElement;
                



            }
            Console.WriteLine(String.Join(" ", inputArr));

        }
    }
}
