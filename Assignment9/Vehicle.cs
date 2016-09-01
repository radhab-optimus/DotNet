using System;
namespace Induction
{
    class Vehicle
    {
        private string _make;
        private int _yearOfManufacture;
        private string _model;
        private float _speed;

        public Vehicle(string make, int yearOfMaufacture, string model, float speed)
        {
            _make = make;
            _yearOfManufacture = yearOfMaufacture;
            _model = model;
            _speed = speed;
        }

        public void Display()
        {
            Console.WriteLine("Make is {0}, YearOfMaufacture is {1}, Model is {2}, Speed is {3}", _make, _yearOfManufacture, _model, _speed);
        }


        public void Accelerate()
        {
            _speed += 5;
            Console.WriteLine("Accerleration is {0}", _speed);
        }

        public void Deaccelarate()
        {
            _speed -= 5;
            Console.WriteLine("Deaccerleration is {0}", _speed);
        }

        public void Stop()
        {
            _speed = 0;
            Console.WriteLine("Vehical is Stopped");
        }

        public Boolean IsMoving()
        {
            if (_speed != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle(string make, int yearOfMaufacture, string model, float speed)
            : base(make, yearOfMaufacture, model, speed)
        {
        }

        public void Print()
        {
            bool state = IsMoving();
            if (state)
            {
                Console.WriteLine("Bicycle is moving");
            }
            else
            {
                Console.WriteLine("Bicycle is not moving");
            }

        }

    }

    class Bike : Vehicle
    {
        public Bike(string make, int yearOfMaufacture, string model, float speed)
            : base(make, yearOfMaufacture, model, speed)
        {
        }

        public void Print()
        {
            bool state = IsMoving();

            if (state)
            {
                Console.WriteLine("Bike is moving");
            }
            else
            {
                Console.WriteLine("Bike is not moving");
            }
        }

    }

    class Car : Vehicle
    {
        public Car(string make, int yearOfMaufacture, string model, float speed)
            : base(make, yearOfMaufacture, model, speed)
        {
        }
        public void Print()
        {
            bool state = IsMoving();

            if (state)
            {
                Console.WriteLine("Car is moving");
            }
            else
            {
                Console.WriteLine("Car is not moving");
            }
        }
    }

    class Truck : Vehicle
    {
        public Truck(string make, int yearOfMaufacture, string model, float speed)
            : base(make, yearOfMaufacture, model, speed)
        {
        }

        public void Print()
        {
            bool state = IsMoving();

            if (state)
            {
                Console.WriteLine("Truck is moving");
            }
            else
            {
                Console.WriteLine("Truck is not moving");
            }
        }
    }

    public class VehicleDetail
    {
        static void Main()
        {
            Bicycle BicycleObj = new Bicycle("Yamaha", 2018, "ss1", 23);
            BicycleObj.Display();
            BicycleObj.Accelerate();
            BicycleObj.Deaccelarate();
            BicycleObj.Print();
            BicycleObj.Stop();

            Car CarObj = new Car("Maruti", 2012, "ss1", 23);
            CarObj.Display();
            CarObj.Accelerate();
            CarObj.Deaccelarate();
            CarObj.Print();
            CarObj.Stop();

            Truck TruckObj = new Truck("Ashok Leyland", 2011, "2s1", 232);
            TruckObj.Display();
            TruckObj.Stop();
            TruckObj.Print();
            TruckObj.Accelerate();
            TruckObj.Deaccelarate();

            Bike BikeObj = new Bike("TVS", 2011, "2s1", 232);
            BikeObj.Display();
            BikeObj.Stop();
            BikeObj.Print();
            BikeObj.Accelerate();
            BikeObj.Deaccelarate();
        }
    }
}
