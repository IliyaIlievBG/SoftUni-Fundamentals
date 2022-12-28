using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double total = CalculateOrder(order, quantity);
            Console.WriteLine($"{total:F2}");
        }
        static double CalculateOrder(string order, int quantity)
        {
            double total;

            if (order == "coffee")
            {
                total = (double)quantity * 1.50;   
            }
            else if (order=="water")
            {
                total = (double)quantity * 1.00;
            }
            else if (order == "coke")
            {
                total = (double)quantity * 1.40;
            }
            else
            {
                total = (double)quantity * 2.00;
            }
            return total;
        }
    }
}
