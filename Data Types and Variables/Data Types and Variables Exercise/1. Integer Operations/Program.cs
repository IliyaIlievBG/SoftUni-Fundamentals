using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sumFirstAndSecond = firstNumber + secondNumber;

            int thirdNumber = int.Parse(Console.ReadLine());

            int divisionResult = sumFirstAndSecond / thirdNumber;

            int fourthNumber = int.Parse(Console.ReadLine());

            int finalResult = divisionResult * fourthNumber;
            Console.WriteLine(finalResult);
        }
    }
}
