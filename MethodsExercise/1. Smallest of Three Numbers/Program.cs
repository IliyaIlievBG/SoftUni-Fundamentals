using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareNumbers(firstNum, secondNum, thirdNum));
        }
        static int CompareNumbers(int first, int second, int third)
        {
            if (first<second && first<third)
            {
                return first;
            }
            else if (second<first && second<third)
            {
                return second;
            }
            return third;
        }
    }
}
