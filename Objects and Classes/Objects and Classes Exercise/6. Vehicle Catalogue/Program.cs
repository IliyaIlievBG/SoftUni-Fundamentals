using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehiclesCatalogue = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();

            while (command != "End")
            {
                string[] vehicleInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vehicleInfo[0];

                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsePower = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                if (vehicle.Type == "truck")
                {
                    trucks.Add(vehicle);
                }
                else
                {
                    cars.Add(vehicle);
                }
                vehiclesCatalogue.Add(vehicle);
                command = Console.ReadLine();

            }
            string nextCommand = Console.ReadLine();

            //List<Vehicle> trucks = new List<Vehicle>();
            //List<Vehicle> cars = new List<Vehicle>();

            while (nextCommand != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehiclesCatalogue.Where(v => v.Model == nextCommand))
                {
                    //if (vehicle.Model == nextCommand)
                    //{
                        Console.WriteLine($"Type: {vehicle.Type.First().ToString().ToUpper() + vehicle.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    //}
                    //if (vehicle.Type == "truck")
                    //{
                    //    trucks.Add(vehicle);
                    //}
                    //else
                    //{
                    //    cars.Add(vehicle);
                    //}
                }
                nextCommand = Console.ReadLine();
            }
            //List<Vehicle> trucks = vehiclesCatalogue.Where(v => v.Type == "Truck").ToList();
            //List<Vehicle> cars = vehiclesCatalogue.Where(vehicle => vehicle.Type == "Car").ToList();

            double carsAverageHorsePower = cars.Count > 0 ? cars.Average(cars => cars.HorsePower) : 0.00;
            double trucksAverageHorsePower = trucks.Count > 0 ? trucks.Average(trucks => trucks.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:F2}.");

        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
