using System;

namespace _2.Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] pointClosestToZero = new double[2];
            double sum = double.MaxValue;
            for (int i = 0; i < 2; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double currentSum = Math.Abs(x) + Math.Abs(y);
                if (currentSum < sum)
                {
                    sum = currentSum;
                    GetBestPoint(pointClosestToZero, x, y);
                }
            }

            Console.WriteLine($"({string.Join(", ", pointClosestToZero)})");
        }

        private static void GetBestPoint(double[] pointClosestToZero, double x, double y)
        {
            pointClosestToZero[0] = x;
            pointClosestToZero[1] = y;
        }
    }
}
