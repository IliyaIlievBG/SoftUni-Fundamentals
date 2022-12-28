using System;
using System.Linq;

namespace _3.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pathName = Console.ReadLine().Split('\\');
            foreach (string dir in pathName)
            {
                if (dir.Contains('.'))
                {
                    int substringIndex = dir.IndexOf('.');
                    Console.WriteLine($"File name: {dir.Substring(0, substringIndex)}");
                    Console.WriteLine($"File extension: {dir.Substring(substringIndex+1)}");
                }
            }
        }
    }
}
