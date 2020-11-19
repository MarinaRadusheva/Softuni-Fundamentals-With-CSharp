using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> Cars = new List<Car>();
            List<Truck> Trucks = new List<Truck>();
            while (input!="end")
            {
                string[] newVehicle = input.Split("/");
                if (newVehicle[0]=="Car")
                {
                    Cars.Add(Car.CreateNewCar(newVehicle));
                        
                }
                else if (newVehicle[0]=="Truck")
                {
                    Trucks.Add(Truck.CreateNewTruck(newVehicle));
                }

                input = Console.ReadLine();
            }
            List<Car> sortedCars = Cars.OrderBy(x => x.Brand).ToList();
            List<Truck> sortedTrucks = Trucks.OrderBy(x => x.Brand).ToList();
            VehicleCatalogue carsAndTrucks = new VehicleCatalogue { Cars = sortedCars, Trucks = sortedTrucks };
            
            if (carsAndTrucks.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in carsAndTrucks.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (carsAndTrucks.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in carsAndTrucks.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
            
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public static Car CreateNewCar(string[] newVehicle)
        {
           Car newCar = new Car { Brand = newVehicle[1], Model = newVehicle[2], HorsePower = int.Parse(newVehicle[3]) };
            return newCar;
        }
            


    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public static Truck CreateNewTruck(string[] newVehicle)
        {
            Truck newTruck = new Truck { Brand = newVehicle[1], Model = newVehicle[2], Weight = int.Parse(newVehicle[3]) };
            return newTruck;
        }
    }
    public class VehicleCatalogue
    {
        public VehicleCatalogue()
        {
            List<Car> Cars = new List<Car>();
            List<Truck> Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
