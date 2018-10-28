using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "Basic";
            myCar.Year = 2012;
            myCar.Color = "black";

            Car myOtherCar = new Car();
            myOtherCar.Make = "Nissan";
            myOtherCar.Model = "Super";
            myOtherCar.Year = 2010;
            myOtherCar.Color = "red";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myCar = null;
            myOtherCar = null;

            GC.Collect(GC.MaxGeneration);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            //load config from a file or database
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            //load config from a file or database
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}
