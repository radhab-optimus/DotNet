using System;
using System.Collections;

namespace Assignment12
{
    public class Vehicle : IComparable
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public float Speed { get; set; }

        public int CompareTo(object obj)
        {
            Vehicle vehicleObj = obj as Vehicle;  
            return this.Name.CompareTo(vehicleObj.Name);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Vehicle))
            {
                return false;
            }
            Vehicle vehicle = obj as Vehicle;
            return Name == vehicle.Name && Speed == vehicle.Speed;
        }

        public static void Main()
        {
            // Creating objects of vehicle class
            var truck = new Vehicle();
            truck.Name = "Leyland";
            truck.Model = "SS2";
            truck.Speed = 34;

            Vehicle car = new Vehicle();
            car.Name = "Audi";
            car.Model = "c2";
            car.Speed = 111;

            Vehicle bike = new Vehicle();
            bike.Name = "TVS";
            bike.Model = "ss3";
            bike.Speed = 55;

            Vehicle bicycle = new Vehicle();
            bicycle.Name = "TVS";
            bicycle.Model = "sss3";
            bicycle.Speed = 55;

            // Adding objects into ArrayList
            ArrayList vehicleList = new ArrayList();
            vehicleList.Add(truck);
            vehicleList.Add(car);
            vehicleList.Add(bike);

            // Comparing two objects
            int result = truck.CompareTo(car);
            if (result == 0)
            {
                Console.WriteLine("Objects are equal");
            }
            else
            {
                Console.WriteLine("Objects are not equal");
            }

            // Before sorting objects
            foreach (Vehicle v1 in vehicleList)
            {
                Console.WriteLine("Name: {0},  Model: {1}, Speed: {2}", v1.Name, v1.Model, v1.Speed);
            }

            // After sorting objects
            vehicleList.Sort();
            Console.WriteLine("after sorting");
            foreach( Vehicle v in vehicleList )
            {
                Console.WriteLine("Name: {0},  Model: {1}, Speed: {2}", v.Name, v.Model, v.Speed);
            }

            // Using overloaded equal function
            Console.WriteLine("Checking car and bike objects of vehical are equal or not");
            Console.WriteLine("Result {0}", car.Equals(bike));
            Console.WriteLine("Checking bike and bicycle objects of vehical are equal or not");
            Console.WriteLine("Result {0}", bike.Equals(bicycle));
        }
    }
}
