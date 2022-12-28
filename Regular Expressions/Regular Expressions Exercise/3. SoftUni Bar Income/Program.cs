using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double totalIncome = 0;
            string orderPattern =
                    @"%{1}(?<name>[A-Z][a-z]+)%{1}[^|&%.]*<{1}(?<prod>\w+)>{1}[^|&%.]*\|{1}(?<count>\d+)\|{1}[^|&%.]*?(?<price>\d+\.?\d+)\${1}";
            while (order != "end of shift")
            {
                string currentOrder = order;
                Match matchedOrder = Regex.Match(currentOrder, orderPattern);
                if (matchedOrder.Success)
                {
                    string currentOrderCount = matchedOrder.Groups["count"].Value;
                    string currentOrderPrice = matchedOrder.Groups["price"].Value;
                    Orders currentCustomer = new Orders()
                    {
                        CustomerName = matchedOrder.Groups["name"].Value,
                        Product = matchedOrder.Groups["prod"].Value,
                        Count = int.Parse(currentOrderCount),
                        Price = double.Parse(currentOrderPrice)
                    };
                    Console.WriteLine($"{currentCustomer.CustomerName}: {currentCustomer.Product} - {(currentCustomer.Count * currentCustomer.Price):F2}");
                    totalIncome += currentCustomer.Price * currentCustomer.Count;

                }
                order = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }

    public class Orders
    {
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
    }
}
