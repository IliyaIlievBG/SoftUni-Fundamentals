using System;
using System.Linq;
using System.Text;


namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] filteredUsers = userNames.Where(x => x.Length >= 3).Where(x => x.Length <= 16).ToArray();

            for (int i = 0; i < filteredUsers.Length; i++)
            {
                string currentUser = filteredUsers[i];
                bool userIsValid = true;
                for (int index = 0; index < currentUser.Length; index++)
                {

                    userIsValid = char.IsLetterOrDigit(currentUser[index]) || currentUser.Contains('_') || currentUser.Contains('-') ? true: false;
                    if (userIsValid == false)
                    {
                        break;
                    }
                }

                if (userIsValid)
                {
                    Console.WriteLine(currentUser);
                }
            }

        }
    }
}
