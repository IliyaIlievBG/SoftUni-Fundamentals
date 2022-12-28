using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
           
            bool isSpecial = false;
            for (int nextNum = 1; nextNum <= upperLimit; nextNum++)
            {
                int currentNum = nextNum;
                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine("{0} -> {1}", nextNum, isSpecial);
                sumOfDigits = 0;
                isSpecial = false;
               
            }

        }
    }
}
