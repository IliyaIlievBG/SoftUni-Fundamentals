using System;

namespace _3.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string myString = Console.ReadLine();

            while (myString.Contains(stringToRemove))
            {
                int startIndex = myString.IndexOf(stringToRemove);
                myString = myString.Remove(startIndex, stringToRemove.Length);
            }

            Console.WriteLine(myString);
         
        }
    }
}
