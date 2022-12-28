using System;
using System.Collections.Generic;

namespace _5._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            while (true)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand == "end")
                {
                    break;
                }
                string[] studentInfo = currentCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                bool studentExists = CheckIfStudentExists(studentsList, studentInfo[0], studentInfo[1]);
                if (studentExists)
                {
                    //find existingStudent
                    Student student = GetStudent(studentsList, studentInfo[0], studentInfo[1]);
                    student.FirstName = studentInfo[0];
                    student.LastName = studentInfo[1];
                    student.Age = int.Parse(studentInfo[2]);
                    student.HomeTown = studentInfo[3];
                }
                else
                {
                    Student student = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]);
                    studentsList.Add(student);
                }
            }
            string city = Console.ReadLine();
            foreach (Student student in studentsList)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static Student GetStudent(List<Student> studentsList, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            
            return existingStudent;
        }

        private static bool CheckIfStudentExists(List<Student> studentsList, string firstName, string lastName)
        {

            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
