using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Car> cars = new List<Car>();
            //List<Truck> trucks = new List<Truck>();
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split('/');
                string type = tokens[0];
                switch (type)
                {
                    case "Car":
                        Car car = new Car(tokens[1], tokens[2], int.Parse(tokens[3]));
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(tokens[1], tokens[2], int.Parse(tokens[3]));
                        catalogue.Trucks.Add(truck);
                        break;
                }
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogue.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

    }
    class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
