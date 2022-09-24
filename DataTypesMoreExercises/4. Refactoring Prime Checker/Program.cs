using System;

namespace _4._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= limit; currentNum++)
            {
                bool currentNumIsPrime = true;
                
                for (int divisor = 2; divisor < currentNum; divisor++)
                {
                    if (currentNum % divisor == 0)
                    {
                        currentNumIsPrime = false;
                        break;
                    }
                }
                string output = currentNumIsPrime.ToString().ToLower();
                Console.WriteLine($"{currentNum} -> {output}");
            }


        }
    }
}
