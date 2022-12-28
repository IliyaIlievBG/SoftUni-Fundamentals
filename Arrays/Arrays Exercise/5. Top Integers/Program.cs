using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           

            for (int index = 0; index < myArr.Length; index++)
            {
                bool currentIndexIsTop = true;

                for (int i = index+1; i < myArr.Length; i++)
                {
                    if (myArr[index] <= myArr[i])
                    {
                        currentIndexIsTop = false;
                        break;
                    }   
                   
                }
                if (currentIndexIsTop)
                {
                    Console.Write($"{myArr[index]} ");
                }

            }
            
            
        }
    }
}
