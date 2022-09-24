using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double jofhnsMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double robeTotalPrice = robePrice * students;
            double lightSabersTotalPrice = lightSaberPrice * (students + Math.Ceiling(students * 0.10));
            double beltTotalPrice = beltPrice * students - beltPrice * (students / 6);

            double totalPrice = robeTotalPrice + lightSabersTotalPrice + beltTotalPrice;

            if (jofhnsMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - jofhnsMoney:F2}lv more.");
            }
        }
    }
}
