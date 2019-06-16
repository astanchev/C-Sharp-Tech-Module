using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Engine
    {
        public Engine(int speed, int power)
        {
            this.EngineSpeed = speed;
            this.EnginePower = power;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
        
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.CargoWeight = weight;
            this.CargoType = type;
        }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }

    class Car
    {
        public Car(string model, int speed, int power, 
                    int weight, string type)
        {
            this.Model = model;
            this.TypeOfEngine = new Engine(speed, power);
            this.TypeOfCargo = new Cargo(weight, type);
        }

        public string Model { get; set; }

        public Engine TypeOfEngine { get; set; }

        public Cargo TypeOfCargo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            AddCarsToList(numberOfCars, listOfCars);

            PrintCars(listOfCars);
        }

        private static void PrintCars(List<Car> listOfCars)
        {
            string command = Console.ReadLine();
            if (command== "fragile")
            {
                foreach (var car in listOfCars)
                {
                    if (car.TypeOfCargo.CargoType =="fragile" 
                        && car.TypeOfCargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable" )
            {
                foreach (var car in listOfCars)
                {
                    if (car.TypeOfCargo.CargoType == "flamable"
                        && car.TypeOfEngine.EnginePower>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }

        

        private static void AddCarsToList(int numberOfCars, List<Car> listOfCars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                string model = inputCar[0];
                int engineSpeed = int.Parse(inputCar[1]);
                int enginePower = int.Parse(inputCar[2]);
                int cargoWeight = int.Parse(inputCar[3]);
                string typeOfCargo = inputCar[4];

                Car newCar = new Car(model, engineSpeed,
                                    enginePower, cargoWeight, typeOfCargo);
                listOfCars.Add(newCar);
            }
        }
                     
    }
}
