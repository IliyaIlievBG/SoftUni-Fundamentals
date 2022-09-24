using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculation(firstNum, action, secondNum);
            Console.WriteLine(result);
          
        }
        static double Calculation(int firstNumber, string action, int secondNumber)
        {
            double result = 0;
            switch(action)
            {
                case "*":
                    result = firstNumber * secondNumber;
                
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }
            return result;
        }
    }
}
