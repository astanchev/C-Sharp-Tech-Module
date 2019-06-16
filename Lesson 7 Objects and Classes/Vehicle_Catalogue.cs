using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
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


    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            AddToLists(vehicleList);

            PrintVehicleInformation(vehicleList);

            List<Vehicle> carsList = vehicleList.Where(v => v.Type == "Car").ToList();
            List<Vehicle> trucksList = vehicleList.Where(v => v.Type == "Truck").ToList();

            double averageCarsHorsepower = CalculateAverageHorsepower(carsList);
            double averageTrucksHorsepower = CalculateAverageHorsepower(trucksList);

            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");

        }

        private static double CalculateAverageHorsepower(List<Vehicle> listOfVehicles)
        {
            double averageHorsepower = 0.0;
            int sumHorsePower = 0;
            foreach (var vehicle in listOfVehicles)
            {
                sumHorsePower += vehicle.HorsePower;
            }
            if (listOfVehicles.Count > 0)
            {
                averageHorsepower = 1.0 * sumHorsePower / listOfVehicles.Count;
            }
            return averageHorsepower;
        }

        private static void PrintVehicleInformation(List<Vehicle> vehicleList)
        {
            while (true)
            {
                string modelVehicle = Console.ReadLine();
                if (modelVehicle == "Close the Catalogue")
                {
                    return;
                }
                foreach (var vehicle in vehicleList)
                {
                    if (vehicle.Model == modelVehicle)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }
        }

        private static void AddToLists(List<Vehicle> vehicleList)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    return;
                }
                string[] inputVehicles = inputLine.Split();
                string typeOfVehicle = StringToTitleCase(inputVehicles[0]);
                string model = inputVehicles[1];
                string color = inputVehicles[2];
                int horsePower = int.Parse(inputVehicles[3]);

                Vehicle newVehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                vehicleList.Add(newVehicle);
            }
        }

        private static string StringToTitleCase(string inputString)
        {

            char[] inputStringTochars = inputString.ToArray();
            inputStringTochars[0] = char.ToUpper(inputStringTochars[0]);
            string newString = new string(inputStringTochars);
            return newString;
        }
    }
}
