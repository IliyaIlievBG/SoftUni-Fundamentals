using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                int currentNum = int.Parse(input);
                bool result = CheckIfInputIsPalindrome(currentNum);
                string output = result.ToString().ToLower();
                Console.WriteLine(output);
                input=Console.ReadLine();
            }
        }

        static bool CheckIfInputIsPalindrome(int currentNum)
        {
            string output = string.Empty;
            int operatingNum = currentNum;
            string currentNumCopy = operatingNum.ToString();

            for (int i = 1; i <= currentNumCopy.Length; i++)
            {
                int currentDigit = operatingNum % 10;
                output += currentDigit.ToString();
                operatingNum /= 10;
            }
            int reversedNum = int.Parse(output);
            bool numIsPalindrome = currentNum == reversedNum ? true : false;
            return numIsPalindrome;
        }
    }
}
