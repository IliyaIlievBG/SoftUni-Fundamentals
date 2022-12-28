using System;
using System.Collections.Generic;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            List<Students> studentsList = new List<Students>();
            while (info != "end")
            {
                string[] currentStudentInfo = info.Split(' ');
                Students student = new Students(currentStudentInfo[0], currentStudentInfo[1], int.Parse(currentStudentInfo[2]), currentStudentInfo[3]);
                studentsList.Add(student);

                info = Console.ReadLine();
            }
            string city = Console.ReadLine();

            GetStudentsFromTheGivenCity(studentsList, city);
        }

        private static void GetStudentsFromTheGivenCity(List<Students> studentsList, string city)
        {
            foreach (var student in studentsList)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
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
