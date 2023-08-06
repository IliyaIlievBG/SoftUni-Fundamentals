using System;
using System.Linq;
using System.Text;

namespace TreasureFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string treasureInfo = Console.ReadLine();
            while (treasureInfo != "find")
            {
                StringBuilder decryptor = new StringBuilder();

                for (int i = 0; i < treasureInfo.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i == treasureInfo.Length)
                        {
                            break;
                        }
                        int currentLetterToInt = treasureInfo[i] - key[j];
                        i++;
                        char currentDecryptedLetter = (char)currentLetterToInt;

                        decryptor.Append(currentDecryptedLetter);
                    }
                    i--;
                }

                var decryptedMessage = decryptor.ToString();
                string treasureType = GetTreasureDetails(decryptedMessage, '&', '&');
                var coordinates = GetTreasureDetails(decryptedMessage, '<', '>');

                Console.WriteLine($"Found {treasureType} at {coordinates}");
                treasureInfo = Console.ReadLine();
            }
        }

        private static string GetTreasureDetails(string decryptedMessage, char start, char end)
        {
            int startIndex = decryptedMessage.IndexOf(start);
            if (startIndex != -1)
            {
                int endIndex = decryptedMessage.LastIndexOf(end);
                if (endIndex != -1)
                {
                    return decryptedMessage.Substring(startIndex + 1, endIndex - startIndex - 1);
                }
            }
            return String.Empty;
        }
    }
}
