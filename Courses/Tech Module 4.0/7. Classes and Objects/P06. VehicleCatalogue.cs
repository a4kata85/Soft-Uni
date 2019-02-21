using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._VehicleCatalogue
{
    class StartUp
    {
        static void Main()
        {
                List<Car> carCatalog = new List<Car>();
                List<Truck> truckCatalog = new List<Truck>();

                double carsTotalPower = 0;
                double trucksTotalPower = 0;

                while (true)
                {

                    string input = Console.ReadLine();

                    if (input == "End")
                    {
                        break;
                    }

                    string[] split = input.Split();

                    string type = split[0];
                    string model = split[1];
                    string color = split[2];
                    int power = int.Parse(split[3]);


                    if (type == "car")
                    {
                        Car newCar = new Car(model, color, power);
                        carCatalog.Add(newCar);
                        carsTotalPower += newCar.HorsePower;
                    }
                    else
                    {
                        Truck newTruck = new Truck(model, color, power);
                        truckCatalog.Add(newTruck);
                        trucksTotalPower += newTruck.HorsePower;
                    }
                }

                while (true)
                {

                    string vehicleModel = Console.ReadLine();

                    if (vehicleModel == "Close the Catalogue")
                    {
                        break;
                    }


                    if (carCatalog.Any(x => x.Model == vehicleModel))
                    {

                        foreach (Car item in carCatalog.Where(x => x.Model == vehicleModel))
                        {
                            Console.WriteLine("Type: Car");
                            Console.WriteLine($"Model: {item.Model}");
                            Console.WriteLine($"Color: {item.Color}");
                            Console.WriteLine($"Horsepower: {item.HorsePower}");
                        }
                    }
                    else if (truckCatalog.Any(x => x.Model == vehicleModel))
                    {

                        foreach (Truck item in truckCatalog.Where(x => x.Model == vehicleModel))
                        {
                            Console.WriteLine("Type: Truck");
                            Console.WriteLine($"Model: {item.Model}");
                            Console.WriteLine($"Color: {item.Color}");
                            Console.WriteLine($"Horsepower: {item.HorsePower}");
                        }

                    }

                }


                if (carCatalog.Count <= 0 && truckCatalog.Count > 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {trucksTotalPower / truckCatalog.Count:F2}.");
                }
                else if (carCatalog.Count > 0 && truckCatalog.Count <= 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {carsTotalPower / carCatalog.Count:F2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");

                }
                else if (carCatalog.Count <= 0 && truckCatalog.Count <= 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                }
                else
                {
                    Console.WriteLine($"Cars have average horsepower of: {carsTotalPower / carCatalog.Count:F2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {trucksTotalPower / truckCatalog.Count:F2}.");
                }
            }
        }
    }

    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower; 
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

