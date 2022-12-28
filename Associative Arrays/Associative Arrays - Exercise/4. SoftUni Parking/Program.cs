using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            int carsToRegister;
            bool inputIsValid = int.TryParse(Console.ReadLine(), out carsToRegister);
            while (!inputIsValid || carsToRegister <= 0)
            {
                Console.WriteLine("Invalid number of cars!");
                Console.Write("Number of cars to register: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out carsToRegister);
            }

            for (int i = 0; i < carsToRegister; i++)
            {
               
                string[] currentCommand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = currentCommand[0];
                //string user = currentCommand[1];
                if (action == "register" || action == "unregister")
                {
                    ValidateParkingPlace(action, currentCommand);

                }
                else
                {
                    Console.WriteLine("Invalid action!");
                }
            }

    
            foreach (KeyValuePair<string, string> user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

            void ValidateParkingPlace(string action, string[] currentCommand)
            {
                string user = currentCommand[1];
                if (action == "register")
                {

                    string licensePlateNumber = currentCommand[2];
                    if (registeredUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        registeredUsers.Add(user, licensePlateNumber);
                        Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                    }
                }
                else //unregister
                {
                    if (!registeredUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

        }
    }
}
