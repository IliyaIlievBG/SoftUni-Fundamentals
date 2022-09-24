using System;

namespace _1._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double max = (a >= b && a >= c) ? a : (b >= a && b >= c) ? b : c;
            double min = (a <= b && a <= c) ? a : (b <= a && b <= c) ? b : c;


            double middle = a + b + c - max - min;
            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
