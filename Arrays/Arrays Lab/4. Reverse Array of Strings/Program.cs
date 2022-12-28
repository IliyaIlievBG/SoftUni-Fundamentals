using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            for (int i = 0; i < stringsArr.Length/2; i++)
            {
                string frontSide = stringsArr[i];
                string backSide = stringsArr[stringsArr.Length - 1 - i];

                stringsArr[i] = backSide;
                stringsArr[stringsArr.Length-1-i] = frontSide;

            }
            Console.WriteLine(string.Join(' ', stringsArr));   

        }
    }
}
