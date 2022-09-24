using System;

namespace _2._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double inputGrade = double.Parse(Console.ReadLine());
            PrintGrades(inputGrade);
        }
        static void PrintGrades(double grade)
        {
            if (grade>= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");

            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
