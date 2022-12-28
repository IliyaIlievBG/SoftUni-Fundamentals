using System;
using System.Linq;
using System.Text;

namespace _7.String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //exposion starts with > ,
            //after it we have int (strength of explosion)
            //if we hit another explosion add it's power to the previous 
            //don't remove > ! Only power after it.
            //abv > 1 > 1 > 2 > 2asdasd

            StringBuilder result = new StringBuilder();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == '>')
                {
                    power += int.Parse(input[i+1].ToString());
                    result.Append(currentChar);
                }
                else if (power == 0)
                {
                    result.Append(currentChar);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(result);
        }
    }
}
