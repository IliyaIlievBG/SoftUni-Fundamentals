using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] currentCarInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = GetCarInfo(currentCarInfo, 0);
                int engineSpeed = GetNumericCarInfo(currentCarInfo, 1);
                int enginePower = GetNumericCarInfo(currentCarInfo, 2);
                int cargoWeight = GetNumericCarInfo(currentCarInfo, 3);
                string cargoType = GetCarInfo(currentCarInfo, 4);

                Engine currentEngine = new Engine();
                currentEngine.Speed = engineSpeed;
                currentEngine.Power = enginePower;

                Cargo currentCargo = new Cargo();
                currentCargo.Weight = cargoWeight;
                currentCargo.Type = cargoType;

                Car currentCar = new Car(model, currentEngine, currentCargo);
                allCars.Add(currentCar);
            }
            var carsWithFlamableCargo = allCars.Where(x => x.Cargo.Type == "flamable").ToList();
            var carsWithFragileCargo = allCars.Where(x => x.Cargo.Type == "fragile").ToList();

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var item in carsWithFragileCargo.Where(x => x.Cargo.Weight < 1000))
                    {
                        Console.WriteLine(item.Model);
                    }
                    break;
                case "flamable":
                    foreach (var item in carsWithFlamableCargo.Where(x => x.Engine.Power > 250))
                    {
                        Console.WriteLine(item.Model);
                    }
                    break;
            }

        }

        private static string GetCarInfo(string[] currentCarInfo, int index)
        {
            return currentCarInfo[index];
        }
        private static int GetNumericCarInfo(string[] currentCarInfo, int index)
        {
            return int.Parse(currentCarInfo[index]);
        }
    }
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
