using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudens = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudens; i++)
            {
                string[] currentStudentInfo = Console.ReadLine().Split(' ');
                Student student = new Student(currentStudentInfo[0], currentStudentInfo[1], double.Parse(currentStudentInfo[2]));
                students.Add(student);
            }
            List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();
            foreach (Student student1 in orderedStudents)
            {
                Console.WriteLine(student1);
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
