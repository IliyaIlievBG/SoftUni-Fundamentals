using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(num, power);
            Console.WriteLine(result);
        }
        static double MathPower(double number, int pow)
        {
            double result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
           
            return result;
        }
    }
}
