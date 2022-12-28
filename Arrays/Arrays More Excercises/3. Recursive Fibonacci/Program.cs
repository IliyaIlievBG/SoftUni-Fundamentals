using System;

namespace _3._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedFibonacciNumber = int.Parse(Console.ReadLine()); //arraySize

            int[] fibonacciSequence = new int[wantedFibonacciNumber];

            for (int i = 0; i < fibonacciSequence.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciSequence[i] = 1;
                }
                else
                {

                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                }
            }
            Console.WriteLine(fibonacciSequence[wantedFibonacciNumber - 1]);


        }
    }
}
