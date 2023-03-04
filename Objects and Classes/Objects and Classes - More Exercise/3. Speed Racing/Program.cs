using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsToTrack = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < carsToTrack; i++)
            {
                string[] currentCarInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = GetModel(currentCarInfo);
                double fuelAmount = GetFuel(currentCarInfo);
                double consumptionPerKm = GetConsumption(currentCarInfo);
                
                if (!cars.ContainsKey(currentCarInfo[0]))
                {
                    //if car is not in the dictionary, creat one and add it. Else don't do nothing
                    Car nextCar = new Car(model, fuelAmount, consumptionPerKm);
                    nextCar.TravelDistance = 0;
                    cars.Add(model, nextCar);
                }    
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                //implement logic
                string[] currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = currentCommand[1];
                double distance = double.Parse(currentCommand[2]);
                if (cars.ContainsKey(model))
                {
                    cars[model].Drive(distance);
                }

                command = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Car> car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TravelDistance}");
            }
        }

        private static double GetConsumption(string[] currentCarInfo)
        {
            return double.Parse(currentCarInfo[2]);
        }

        private static double GetFuel(string[] currentCarInfo)
        {
            return double.Parse(currentCarInfo[1]);
        }

        private static string GetModel(string[] currentCarInfo)
        {
            return currentCarInfo[0];
        }
    }
    public class Car
    {
        public Car(string model, double fuelAmount, double consumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            ConsumptionPerKm = consumptionPerKm;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double ConsumptionPerKm { get; set; }

        public double TravelDistance { get; set; }

        public void Drive(double distance)
        {
            if (distance*ConsumptionPerKm>FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                TravelDistance += distance;
                FuelAmount -= ConsumptionPerKm * distance;
            }
        }
    }
}
