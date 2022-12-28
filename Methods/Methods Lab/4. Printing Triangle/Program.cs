using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleHeight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleHeight; i++)
            {
                PrintLines(1, i);
            }
            for (int i = triangleHeight-1; i >=1; i--)
            {
                PrintLines(1, i);
            }
            
        }
        static void PrintLines(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
