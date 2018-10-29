using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            Car car1 = new Car("BMW","550i","A1");
            Car car2 = new Car("Toyota", "4Runner", "B2");
            Car car3 = new Car("BMW", "745i", "C3");
            Car car4 = new Car("Ford", "Escape", "D4");
            Car car5 = new Car("BMW", "750i", "E5");

            myCars.Add(car1);
            myCars.Add(car2);
            myCars.Add(car3);
            myCars.Add(car4);
            myCars.Add(car5);
            //LINQ Query
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           select car;

            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Model.Contains("50"));

            var bmws = from car in myCars
                       orderby car.Model descending
                       select car;

            //LINQ Method
            foreach(var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.Make);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model, string vin)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = vin;
        }
    }
}
