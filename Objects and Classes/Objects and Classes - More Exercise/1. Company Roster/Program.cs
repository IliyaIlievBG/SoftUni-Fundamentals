using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] currentEmployeeInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string department = GetDepartment(currentEmployeeInfo[2]);

                Employee currentEmployee = new Employee();
                currentEmployee.Name = currentEmployeeInfo[0];
                currentEmployee.Salary = decimal.Parse(currentEmployeeInfo[1]);
                currentEmployee.Department = department;

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<Employee>();
                    departments[department].Add(currentEmployee);
                }
                else
                {
                    departments[department].Add(currentEmployee);
                }
            }
            var orderedDepartments = departments.OrderByDescending(x => x.Value.Average(x => x.Salary)).ToList();
            Console.WriteLine($"Highest Average Salary: {orderedDepartments[0].Key}");
          
            List<Employee> employeesBySalary = orderedDepartments[0].Value.OrderByDescending(e => e.Salary).ToList();
            foreach (Employee employee in employeesBySalary)
            {
                Console.Write($"{employee.Name} ");
                Console.WriteLine($"{employee.Salary:F2}");
            }
        }

        private static string GetDepartment(string departmentName)
        {
            return departmentName;
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
