using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int sumOfDigits = 0;
            for (int i = 1; i <= n; i++)  //print the next number
            {
                int currentNum = i;
                while (currentNum != 0) //get the sum of the digits of the next number
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                }
               
                Console.WriteLine($"{i} -> {isSpecial}");
                sumOfDigits = 0;
                isSpecial = false;
            }
        }
    }
}
