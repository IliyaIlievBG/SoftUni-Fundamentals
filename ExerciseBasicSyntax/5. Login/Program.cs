using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";

            for (int value = user.Length - 1; value >= 0; value--)
            {
                password += user[value];
            }


            for (int logginAttempt = 0; logginAttempt < 4; logginAttempt++)
            {
                string tryLogin = Console.ReadLine();
                if (tryLogin == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                if (logginAttempt == 3 && tryLogin != password)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {user} blocked!");
        }
    }
}
