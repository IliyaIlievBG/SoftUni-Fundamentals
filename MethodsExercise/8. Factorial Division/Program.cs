using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstFactorial = GetFactorial(firstNum);
            double secondFactorial = GetFactorial(secondNum);
            //double result = DivideFactorials(firstFactorial, secondFactorial);
            //Console.WriteLine($"{result:F2}");
            DivideFactorials(firstFactorial, secondFactorial);
        }

        static void DivideFactorials(double firstFactorial, double secondFactorial) =>
            Console.WriteLine($"{firstFactorial / secondFactorial:F2}");
    

        static double GetFactorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }



    }
}
