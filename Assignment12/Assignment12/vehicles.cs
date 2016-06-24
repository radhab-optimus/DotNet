using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment12
{
    class VehicleCollections : IEnumerable
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        private List<VehicleCollections> vehicleList;

        public static void Main()
        {
            VehicleCollections vehicle1 = new VehicleCollections()
            {
                Name = "vehicle1",
                Model = "model1",
                Speed = 21
            };

            VehicleCollections vehicle2 = new VehicleCollections()
            {
                Name = "vehicle2",
                Model = "model2",
                Speed = 212
            };

            VehicleCollections vehicle3 = new VehicleCollections()
            {
                Name = "vehicle3",
                Model = "model3",
                Speed = 211
            };

            List<VehicleCollections> vehicleList = new List<VehicleCollections>(3)
            {
                vehicle1,
                vehicle2,
                vehicle3
            };

            foreach (VehicleCollections v in vehicleList)
            {
                Console.WriteLine("Name: {0}, Model: {1}, Speed: {2}", v.Name, v.Model, v.Speed);
            }

        }

        public IEnumerator GetEnumerator()
        {
            return vehicleList.GetEnumerator();
        }
    }
}
