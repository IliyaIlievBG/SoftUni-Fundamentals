using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double area = CalculateArea(height, width);
            Console.WriteLine(area);

        }
        static double CalculateArea(double a, double b)
        {
            return a * b;
        }
    }
}
