using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopleAndTheirMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsAndTheirPrices = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleAndTheirMoney.Length; i++)
            {
                string[] currentPersonInfo = peopleAndTheirMoney[i].Split("=");
                Person currentPerson = new Person();
                currentPerson.Name = currentPersonInfo[0];
                currentPerson.Money = decimal.Parse(currentPersonInfo[1]);
                people.Add(currentPerson);
            }
            for (int i = 0; i < productsAndTheirPrices.Length; i++)
            {
                string[] currentProductInfo = productsAndTheirPrices[i].Split("=");
                Product product = new Product();
                product.ProductName = currentProductInfo[0];
                product.Cost = decimal.Parse(currentProductInfo[1]);
                products.Add(product);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentPurchase = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string person = currentPurchase[0];
                string product = currentPurchase[1];

                int personIndex = people.FindIndex(x => x.Name == person);
                int productIndex = products.FindIndex(x => x.ProductName == product);

                if (people[personIndex].Money >= products[productIndex].Cost)
                {
                    people[personIndex].Money -= products[productIndex].Cost;
                    people[personIndex].BagOfProducts.Add(products[productIndex]);

                    Console.WriteLine($"{people[personIndex].Name} bought {products[productIndex].ProductName}");
                }
                else
                {
                    Console.WriteLine($"{people[personIndex].Name} can't afford {products[productIndex].ProductName}");
                }

                command = Console.ReadLine();
            }
            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.BagOfProducts.Count==0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{String.Join(", ", person.BagOfProducts.Select(x => x.ProductName))}");
                }
            }

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; } = new List<Product>();
    }
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
    }
}
