using System;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double price = 0;
            double taxes = 0;


            while (input != "special" && input != "regular")
            {
                double partPrice = double.Parse(input);
                if (partPrice<0) //could be wrong
                {
                    Console.WriteLine("Invalid price!");
              
                }
                else
                {
                    price += partPrice;
                    taxes += partPrice * 0.2;
                }    

                input = Console.ReadLine();
            }
            if (taxes + price <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {price:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            if (input == "special")
            {
                Console.WriteLine($"Total price: {(price+taxes)-((price+taxes)*0.1):F2}$");
            }
            else
            {
                Console.WriteLine($"Total price: {price+taxes:F2}$");
            }
        }
    }
}
