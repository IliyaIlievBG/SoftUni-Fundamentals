using System;
using System.Text;

namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder chars = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    chars.Append(symbol);
                }
                else 
                {
                    other.Append(symbol);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(other);
        }
    }
}
