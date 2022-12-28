using System;

namespace _6._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            bool balancedBrackets = true;
            bool consecutiveBrackets = false;
            
            int openBracketsCount = 0;
            int closeBracketsCount = 0;
            for (int i = 1; i <= linesCount; i++)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "(")
                {
                    openBracketsCount++;
                    if (!consecutiveBrackets)
                    {
                        consecutiveBrackets = true;
                        
                    }
                    else
                    {
                        consecutiveBrackets = false;
                    }
                   
                }
                else if (currentInput == ")")
                {
                    closeBracketsCount++;
                    consecutiveBrackets = false;
                }
            }
            balancedBrackets = openBracketsCount == closeBracketsCount;
            if (balancedBrackets && !consecutiveBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
           
        }
    }
}
