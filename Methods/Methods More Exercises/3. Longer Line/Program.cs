using System;
using System.Linq;

namespace _3._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] longestLine = new double[4];
            //4 points (two pairs)
            //1st & 2nd pair form a line. Print the longer line, starting from point closer to zero
            double bestLine = 0;
            for (int i = 0; i < 2; i++)
            {
                var firstPair = GetPair();
                var secondPair = GetPair();
                var currentLine = GetCurrentLine(firstPair, secondPair);
                if (currentLine>bestLine)
                {
                    bestLine = currentLine;
                    GetLongestLine(firstPair, secondPair, longestLine);
                }
            }

            Console.WriteLine($"({longestLine[0]}, {longestLine[1]})({longestLine[2]}, {longestLine[3]})");
        }

        private static void GetLongestLine(double[] firstPair, double[] secondPair, double[] longestLine)
        {
            double firstPairSum = Math.Abs(firstPair[0]) + Math.Abs(firstPair[1]);
            double secondPairSum = Math.Abs(secondPair[0]) + Math.Abs(secondPair[1]);

            if (firstPairSum <= secondPairSum)
            {
                longestLine[0] = firstPair[0];
                longestLine[1] = firstPair[1];
                longestLine[2] = secondPair[0];
                longestLine[3] = secondPair[1];
            }
            else
            {
                longestLine[0] = secondPair[0];
                longestLine[1] = secondPair[1];
                longestLine[2] = firstPair[0];
                longestLine[3] = firstPair[1];
            }
        }

        private static double GetCurrentLine(double[] firstPair, double[] secondPair)
        {
            double currentLine = Math.Abs(firstPair[0]) + Math.Abs(firstPair[1]) + Math.Abs(secondPair[0]) +
                                 Math.Abs(secondPair[1]);
            return currentLine;
        }

        private static double[] GetPair()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double[] firstPair = { x1, y1 };
            return firstPair;
        }
    }
}
