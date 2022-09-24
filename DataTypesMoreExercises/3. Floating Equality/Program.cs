using System;

namespace _3._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            double eps = 0.000001;
            bool numsAreEqual = eps >= difference;
            Console.WriteLine(numsAreEqual);
            
        }
    }
}
