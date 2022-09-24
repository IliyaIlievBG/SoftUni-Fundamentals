using System;

namespace _2._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] topArray = new int[1] { 1 };
            int[] operatingArray = topArray;
            Console.WriteLine(String.Join(' ', topArray));

            for (int i = 1; i <rows; i++)
            {
                int[] currentRow = new int[operatingArray.Length + 1];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;

                for (int index = 1; index < currentRow.Length-1; index++)
                {
                    currentRow[index] = operatingArray[index - 1] + operatingArray[index];
                   
                }
                Console.WriteLine(String.Join(' ', currentRow));
                operatingArray=currentRow; 
            }
         
        }
    }
}
