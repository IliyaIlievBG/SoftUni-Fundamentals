using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int sum = GetSumOfDigits(i);
                bool holdsOdddigit = CheckForOddDigit(i);
                if (sum%8 == 0 && holdsOdddigit)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool CheckForOddDigit(int currentNum)
        {
            bool oddDigit = false;
            while (currentNum>0)
            {
                int lastDigit = currentNum % 10;

                if (lastDigit%2!=0)
                {
                    oddDigit = true;
                    break;
                }
               
                currentNum /= 10;
                
            }
            return oddDigit;
            
        }

        static int GetSumOfDigits(int i)
        {
            int sumOfDigits = 0;
            while (i>0)
            {
                int lastDigit = i % 10;
                sumOfDigits += lastDigit;
                i /= 10;
            }
            return sumOfDigits;
        }
    }
}
