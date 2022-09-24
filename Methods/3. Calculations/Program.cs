using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            //"add", "multiply", "subtract", "divide".
            switch (action)
            {
                case "add":
                    Add(firstNum, secondNum);
                        break;
                case "multiply":
                    Multiply(firstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(firstNum, secondNum);
                    break;
                case "divide":
                    Divide(firstNum, secondNum);
                    break;
            }
        }

        static void Add(double myFirstNum, double mySecondNum)
        {
            Console.WriteLine(myFirstNum+mySecondNum);
        }
        static void Multiply(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum*secondNum);
        }
        static void Subtract(double firstNum, double secoundNum)
        {
            Console.WriteLine(firstNum-secoundNum);
        }
        static void Divide(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum/secondNum);
        }
    }
}
