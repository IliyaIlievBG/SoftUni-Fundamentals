using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;


            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sum += coins;
                }
                input = Console.ReadLine();


            }
            string product = Console.ReadLine();
            //•	"Nuts" with a price of 2.0
            //•	"Water" with a price of 0.7
            //•	"Crisps" with a price of 1.5
            //•	"Soda" with a price of 0.8
            //•	"Coke" with a price of 1.0

            while (product != "End")
            {
                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {

                    if (product == "Nuts")
                    {
                        if (sum >= 2.0)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            sum -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Water")
                    {
                        if (sum >= 0.7)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            sum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Crisps")
                    {
                        if (sum >= 1.5)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            sum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Soda")
                    {
                        if (sum >= 0.8)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            sum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else
                    {
                        if (sum >= 1.0)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            sum -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
