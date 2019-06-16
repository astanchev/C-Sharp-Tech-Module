using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm, double travelDistance = 0.0)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TravelDistance = travelDistance;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelDistance { get; set; }

        public bool CanDistanceBeTravaled(double amountKmToTravel)
        {
            bool canDistanceBeTravaled = false;
            double avilableDistanceToTravel = this.FuelAmount * 1.0 / this.FuelConsumptionPerKm;
            
            if (amountKmToTravel <= avilableDistanceToTravel)
            {
                canDistanceBeTravaled = true;
            }
            return canDistanceBeTravaled;
        }

        public void MoveCar(double amountKmToTravel)
        {
            this.TravelDistance += amountKmToTravel;
            this.FuelAmount -= amountKmToTravel * this.FuelConsumptionPerKm * 1.0;            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int carsToTrack = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            AddCarsToList(carsToTrack, carsList);

            DriveCars(carsList);

            PrintCars(carsList);
        }

        private static void DriveCars(List<Car> carsList)
        {
            while (true)
            {
                string inputDriveCar = Console.ReadLine();
                if (inputDriveCar == "End")
                {
                    break;
                }
                string[] inputDrive = inputDriveCar.Split();
                string model = inputDrive[1];
                double amountOfKm = double.Parse(inputDrive[2]);
                foreach (var car in carsList)
                {
                    if (car.Model == model && car.CanDistanceBeTravaled(amountOfKm))
                    {
                        car.MoveCar(amountOfKm);
                    }
                    else if (car.Model == model && !car.CanDistanceBeTravaled(amountOfKm))
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }

        private static void PrintCars(List<Car> carsList)
        {
            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
            }
        }

        private static void AddCarsToList(int carsToTruck, List<Car> carsList)
        {
            for (int i = 0; i < carsToTruck; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                string model = inputCar[0];
                double fuelAmount = double.Parse(inputCar[1]);
                double fuelConsumptionPerKm = double.Parse(inputCar[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKm);
                carsList.Add(newCar);
            }
        }
    }
}
