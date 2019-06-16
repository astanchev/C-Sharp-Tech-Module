using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.CollectionCars = new List<Car>();
            this.CollectionTrucks = new List<Truck>();
        }

        public List<Truck> CollectionTrucks { get; set; }

        public List<Car> CollectionCars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            List<Truck> truckList = new List<Truck>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine=="end")
                {
                    break;
                }
                string[] vehicles = inputLine.Split('/').ToArray();
                string typeOfVehicle = vehicles[0];
                string brandOfVehicle = vehicles[1];
                string modelOfVehicle = vehicles[2];
                if (typeOfVehicle=="Car")
                {
                    int horsePower = int.Parse(vehicles[3]);
                    Car newCar = new Car()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horsePower
                    };
                    carList.Add(newCar);
                }
                else
                {
                    int weight = int.Parse(vehicles[3]);
                    Truck newTruck = new Truck()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        Weight = weight
                    };
                    truckList.Add(newTruck);
                }                
            }
            List<Car> orderedCarList = carList.OrderBy(c => c.Brand).ToList();
            List<Truck> orderedTruckList = truckList.OrderBy(t => t.Brand).ToList();

            Catalog newCatalog = new Catalog()
            {
                CollectionCars = orderedCarList.ToList(),
                CollectionTrucks = orderedTruckList.ToList()                
            };

            PrintCatalog(newCatalog);
            
        }

        private static void PrintCatalog(Catalog newCatalog)
        {
            if (newCatalog.CollectionCars.Count>0)
            {
                PrintCars(newCatalog.CollectionCars);
            }
            if (newCatalog.CollectionTrucks.Count>0)
            {
                PrintTrucks(newCatalog.CollectionTrucks);
            }
        }

        private static void PrintTrucks(List<Truck> orderedTruckList)
        {
            Console.WriteLine("Trucks:");
            for (int i = 0; i < orderedTruckList.Count; i++)
            {
                Truck element = orderedTruckList[i];
                Console.WriteLine($"{element.Brand}: {element.Model} - {element.Weight}kg");
            }
        }

        private static void PrintCars(List<Car> orderedCarList)
        {
            Console.WriteLine("Cars:");
            for (int i = 0; i < orderedCarList.Count; i++)
            {
                Car element = orderedCarList[i];
                Console.WriteLine($"{element.Brand}: {element.Model} - {element.HorsePower}hp");
            }
        }
    }
}
