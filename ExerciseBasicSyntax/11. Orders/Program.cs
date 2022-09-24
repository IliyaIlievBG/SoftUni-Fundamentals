using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double total = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                total += price;
            }
            Console.WriteLine($"Total: ${total:F2}");

        }
    }
}
