using System;
using System.Text;
using System.Linq;

namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] instructions = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string operation = GetOperation(instructions);

                if (operation == "Move") //moves first N letters to the back of the string
                {
                    encryptedMessage = GetDecodedMessage(encryptedMessage, instructions, operation);
                }
                else if (operation == "Insert") //inserts the given value before given index
                {
                    encryptedMessage = GetDecodedMessage(encryptedMessage, instructions, operation);

                }
                else // ChangeAll -> changes all occurances of given string with the replacement text
                {
                    encryptedMessage = GetDecodedMessage(encryptedMessage, instructions, operation);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");

        }

        private static string GetDecodedMessage(string encryptedMessage, string[] instructions, string operation)
        {
            if (operation=="Move")
            {

            int substringLength = int.Parse(instructions[1]);
            string subString = encryptedMessage.Substring(0, substringLength);
            encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, subString);
            encryptedMessage = encryptedMessage.Remove(0, substringLength);
            return encryptedMessage;
            }
            else if (operation == "Insert") //inserts the given value before given index
            {
                int index = int.Parse(instructions[1]);
                string value = instructions[2];
                encryptedMessage = encryptedMessage.Insert(index, value);
                return encryptedMessage;

            }
            else // ChangeAll -> changes all occurances of given string with the replacement text
            {
                string substring = instructions[1];
                string replacement = instructions[2];
                while (encryptedMessage.Contains(substring))
                {
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
                return encryptedMessage;
            }

        }

        private static string GetOperation(string[] instructions)
        {
            return instructions[0];
        }
    }
}
