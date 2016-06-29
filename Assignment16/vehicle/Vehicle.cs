using System;
using ClassLibrary1;
using System.IO;
namespace ConsoleApplication1
{
    public class Vehicle
    {
        private string _name;
        private string _model;
        private string _type;
        private float _speed;

        public Vehicle(string name, string model, string type, float speed)
        {
            _name = name;
            _model = model;
            _type = type;
            _speed = speed;
        }

        public void Accelerate()
        {
            try
            {
                if (_type.Equals("bicycle") && _speed >= 99)
                {
                    Console.WriteLine("bicycle speed cannot go to 100KM/Hr.");
                }
                else if (_type.Equals("car") && _speed > 100)
                {
                    throw new IsCarDeadException("Car is overheated");
                }
                else
                {
                    _speed = _speed + 20;
                    Console.WriteLine("{0} Accelerated to: {1}", _name, _speed);
                }
            }
            catch (IsCarDeadException e)
            {
                string path = @"C:\Users\radha.bisht\Documents\Visual Studio 2012\Projects\Assignment16\ClassLibrary1\Log.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(e.Message);
                streamWriter.Close();
                Console.WriteLine(e.Message);
            }
        }

        public void Deaccelerate()
        {
            try
            {
                if (_speed < 5)
                {
                    throw new IsCarDeadException("speed cannot be negative");
                }
                else
                {
                    _speed = _speed - 5;
                    Console.WriteLine("{0} Deccelerated to: {1}", _name, _speed);
                }
            }
            catch (IsCarDeadException ex)
            {
                string path = @"C:\Users\radha.bisht\Documents\Visual Studio 2012\Projects\Assignment16\ClassLibrary1\Log.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                StreamWriter streamWriter = File.AppendText(path);
                streamWriter.Write(ex.Message);
                streamWriter.Close();
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main()
        {
            Vehicle bicycle = new Vehicle("yamaha", "ss1", "bicycle", 110);
            Vehicle car1 = new Vehicle("audi", "zx11", "car", 105);
            Vehicle car2 = new Vehicle("zen", "zxss11", "car", 10);
            Vehicle car3 = new Vehicle("maruti", "110", "car", 4);

            bicycle.Accelerate();
            bicycle.Deaccelerate();

            car1.Accelerate();
            car1.Deaccelerate();

            car2.Deaccelerate();
            car2.Accelerate();

            car3.Deaccelerate();
            car3.Accelerate();
        }
    }
}
