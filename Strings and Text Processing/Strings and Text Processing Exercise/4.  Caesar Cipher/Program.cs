using System;
using System.Linq;
using System.Text;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string text = Console.ReadLine();
                StringBuilder encryptedText = new StringBuilder();

                foreach (char symbol in text)
                {
                    encryptedText.Append((char)(symbol + 3));
                }

                Console.WriteLine(encryptedText);
            }
        }
    }
}
