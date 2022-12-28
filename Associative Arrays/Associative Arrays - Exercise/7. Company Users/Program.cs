using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {

      
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {

                string[] nameAndEmployeeID = command.Split(" -> ");
                if (nameAndEmployeeID.Length < 2)
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Enter company name and employee ID separated with \" -> \": ");
                    command = Console.ReadLine();
                    continue;
                }

                string companyName = nameAndEmployeeID[0];
                string employeeID = nameAndEmployeeID[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string> { employeeID };
                }
                else
                {
                    if (!companies[companyName].Contains(employeeID)) 
                    {
                        companies[companyName].Add(employeeID);
                        
                    }
                   
                }


                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (string id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
