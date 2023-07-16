using System;

namespace _1._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string currentPersonInfo = Console.ReadLine();
                string name = GetPersonName(currentPersonInfo);
                
            }
        }

        private static string GetPersonName(string currentPersonInfo)
        {
            int startIndex = currentPersonInfo.IndexOf('@');
            int endIndex = currentPersonInfo.IndexOf('|');

            string name = currentPersonInfo.Substring(startIndex+1, endIndex-startIndex-1);
            return name;
        }
    }
}
