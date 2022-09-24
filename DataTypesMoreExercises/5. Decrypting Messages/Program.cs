using System;
using System.Text;

namespace _5._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfChars = int.Parse(Console.ReadLine());
            StringBuilder encrtyptedMessage = new StringBuilder();

            string output = string.Empty;

            for (int i = 1; i <= numberOfChars; i++)
            {
                char nextChar = char.Parse(Console.ReadLine());
                nextChar += (char)key;
                encrtyptedMessage.Append(nextChar);
                
            }
            output = encrtyptedMessage.ToString();
            Console.WriteLine(output);

        }
    }
}
