using System;
using System.Collections;

namespace CollectionsNLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Vehicle()
            {
               Name = "Maruti",
               Model = "22a",
               Speed = 123
            };

            var truck = new Vehicle()
            {
               Name = "Leyland",
               Model = "dd2s",
               Speed = 234
            };

            var bike = new TwoWheeler()
            {
               Name ="tvs",
               Model = "HHb11",
               Speed = 23
            };

            ArrayList vehicles = new ArrayList
            {
                car,
                truck,
                bike
            };

            // Enumerating through the list contents and using tostring method for printing.
            foreach( var vehicle in vehicles )
            {
                Console.WriteLine(vehicle);
            }

            // Gettting the list element using indexes
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine("Name : {0}, Model : {1}, Speed {2}", ((Vehicle)vehicles[i]).Name, ((Vehicle)vehicles[i]).Model, ((Vehicle)vehicles[i]).Speed);

                Console.WriteLine("Name : {0}", ((Vehicle)vehicles[1]).Name = "Modified");
            }

            // Calling ToString from object 
            Console.WriteLine(Convert.ToString(bike));
            Console.WriteLine(Convert.ToString(car));
        }
    }
}
