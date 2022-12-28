using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            bool countIsValid = int.TryParse(Console.ReadLine(), out count);
            while (!countIsValid)
            {
                Console.WriteLine("Invalid count! Only integers, please!");
                Console.WriteLine("Enter count of students: ");
                countIsValid = int.TryParse(Console.ReadLine(), out count);
            }

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string studentName = Console.ReadLine();
                double grade;
                bool gradeIsValid = double.TryParse(Console.ReadLine(), out grade);
                while (!gradeIsValid || grade <= 0)
                {
                    Console.WriteLine("Invalid grade! Only numbers, please!");
                    gradeIsValid = double.TryParse(Console.ReadLine(), out grade);
                }

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double> { grade };
                }
                else
                {
                    studentGrades[studentName].Add(grade);
                }
            }

            foreach (KeyValuePair<string, List<double>> student in studentGrades
                         .Where(averageGrade => averageGrade.Value.Average() >= 4.5))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }

        }
    }
}
