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

            StringBuilder newMessage = new StringBuilder();

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

            int indexToSkip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                List<char> tempList = new List<char>(charsList);
                tempList = tempList.Skip(indexToSkip).Take(takeList[i]).ToList();
                newMessage.Append(string.Join("", tempList));
                indexToSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(newMessage);
        }
    }
}
