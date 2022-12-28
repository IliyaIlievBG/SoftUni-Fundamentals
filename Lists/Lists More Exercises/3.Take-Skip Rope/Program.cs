using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encryptedMessage = Console.ReadLine();
            List<int> numbersList = encryptedMessage.Where(x => char.IsDigit(x))
                .Select(x => (int)char.GetNumericValue(x))
                .ToList();
            List<char> charsList = encryptedMessage.Where(x => !char.IsDigit(x)).ToList();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i%2==0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

        }
    }
}
