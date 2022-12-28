using System;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
        static void PrintSign(int myNum)
        {
            if (myNum>0)
            {
                Console.WriteLine($"The number {myNum} is positive.");
            }
            else if (myNum<0)
            {
                Console.WriteLine($"The number {myNum} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {myNum} is zero.");
            }
        }
    }
}
