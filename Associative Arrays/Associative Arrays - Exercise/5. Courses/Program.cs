using System;
using System.Collections.Generic;

namespace _5._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] courseAndUser = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
           
                string course = courseAndUser[0];
                string user = courseAndUser[1];

                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string> { user };
                }
                else
                {
                    courses[course].Add(user);
                }

                command = Console.ReadLine();

            }
            foreach (KeyValuePair<string, List<string>> item in courses) //not suppose to have empty list in values
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (string student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
