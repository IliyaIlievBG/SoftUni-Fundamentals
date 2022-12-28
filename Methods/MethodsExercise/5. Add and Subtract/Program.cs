using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstPlusSecond = AddFirstAndSecondNumber(firstNumber, secondNumber);
            int finalResult = SubstractFromResult(firstPlusSecond, thirdNumber);//first + second - third
            Console.WriteLine(finalResult);
        }

        static int SubstractFromResult(int firstPlusSecond, int thirdNumber)
        {
            return firstPlusSecond - thirdNumber;
        }

        static int AddFirstAndSecondNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}

