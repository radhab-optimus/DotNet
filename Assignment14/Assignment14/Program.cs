using System;
using System.Collections.Generic;

namespace Assignment14
{
    class Program
    {
        public static void Main()
        {
            var bigVehicle = new Vehicle()
            {
                Name = "demoName",
                Model = "a11",
                Speed = 122
            };

            var sedan = new Car()
            {
                Name = "audi",
                Model = "12w",
                Speed = 123,
                Seats = 4
            };


            var miniTruck = new Truck()
            {
                Name = "leyland",
                Model = "qw1",
                Speed = 211,
                Wheels = 6
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                bigVehicle,
                sedan,
                miniTruck
            };

            // Before Sorting
            Console.WriteLine("Before sorting");
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine("Name : {0}, Model : {1}, Speed : {2}", vehicle.Name, vehicle.Model, vehicle.Speed);
            }

            vehicles.Sort();

            // After sortin
            Console.WriteLine("After Sorting");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Name : {0}, Model : {1}, Speed : {2}", vehicle.Name, vehicle.Model, vehicle.Speed);
            }

            // Checking objects for equality
            Console.WriteLine(bigVehicle.Equals(sedan));
        }
    }
}
