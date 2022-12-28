using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            string input = Console.ReadLine();
            Dictionary<string, Product> productList = new Dictionary<string, Product>();

            while (input.ToLower() != "buy")
            {
                string[] productInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (productInfo.Length != 3)
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                }
                else
                {

                    string product = productInfo[0];
                    double price;
                    bool validPrice = double.TryParse(productInfo[1], out price);
                    int quantity;
                    bool validQuantity = int.TryParse(productInfo[2], out quantity);
                    if (validQuantity && validPrice)
                    {
                        if (!productList.ContainsKey(product))
                        {
                            productList.Add(product, new Product(0, 0));
                        }

                        productList[product].Quantity += quantity;
                        productList[product].Price = price; //

                    }
                    else
                    {
                        Console.WriteLine("Invalid price or quantity!");

                    }
                }
                
                input = Console.ReadLine();

            }

            foreach (KeyValuePair<string, Product> product in productList)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:F2}");
            }


        }
    }
    public class Product
    {
        public Product(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
