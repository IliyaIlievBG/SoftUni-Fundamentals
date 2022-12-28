using System;

namespace _4.Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] tribonacciSequence = new int[length];
            if (length <=3)
            {
                for (int i = 0; i < length; i++)
                {
                    int nextNum = GetNextNum(i);
                    tribonacciSequence[i] = nextNum;
                }
            }
            else
            {
                tribonacciSequence[0] = 1;
                tribonacciSequence[1] = tribonacciSequence[0];
                tribonacciSequence[2] = 2;
                int nextNum = NextNumberAfterThirdIndex(tribonacciSequence);
            }

            Console.WriteLine(string.Join(' ', tribonacciSequence));
        }

        private static int NextNumberAfterThirdIndex(int[] tribonacciSequence)
        {
            int i;
            for (i = 3; i < tribonacciSequence.Length; i++)
            {
                tribonacciSequence[i] = tribonacciSequence[i - 3] + tribonacciSequence[i - 2] +
                                        tribonacciSequence[i - 1];
            }

            return i;
        }

        private static int GetNextNum(int i)
        {
            if (i == 0 || i == 1)
            {
                return 1;
            }

            return 2;
        }
    }
}
