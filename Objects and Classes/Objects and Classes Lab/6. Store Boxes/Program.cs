using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] data = command.Split(' ');
                Item item = new Item(data[1], decimal.Parse(data[3]));
                Box box = new Box(data[0], item, int.Parse(data[2]));
                boxes.Add(box);

            }
            List<Box> orderedBoexes = boxes.OrderByDescending(box => box.PriceForABox).ToList();

            foreach (Box box in orderedBoexes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
    class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

    }
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int ItemQuantity { get; set; }
        public decimal PriceForABox
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
