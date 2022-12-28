using System;
using System.Linq;
using System.Text;

namespace _5._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            //check if number is negative
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder product = new StringBuilder();
            bool numberIsValid = IfNumberIsValid(reallyBigNumber);
            if (numberIsValid)
            {
                int helper = 0;
                for (int i = reallyBigNumber.Length-1; i >= 0; i--)
                {
                    //TO DO: check for negative number when reach [0]
                    int currentNum = int.Parse(reallyBigNumber[i].ToString());
                    int currentResult = currentNum * multiplier + helper;
                    int digitToInsert = currentResult % 10;
                    product.Append(digitToInsert);
                    helper = currentResult / 10;
                }

                if (helper != 0)
                {
                    product.Append(helper);
                }
            }
            string result = product.ToString();
            char[] final = result.Reverse().ToArray();
            Console.WriteLine(string.Join("", final));

        }

        private static bool IfNumberIsValid(string reallyBigNumber)
        {
            bool numberIsValid;
            foreach (char symbol in reallyBigNumber)
            {
                numberIsValid = char.IsDigit(symbol);
            }

            numberIsValid = (reallyBigNumber[0].Equals('-') || char.IsDigit(reallyBigNumber[0]));
            return numberIsValid;
        }
    }
}
