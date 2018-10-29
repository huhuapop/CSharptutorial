using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            Car car1 = new Car("Nisson","SUV","123");
            Car car2 = new Car("Nisson", "Crossovers","456");
            myArrayList.Add(car1);
            myArrayList.Add(car2);

            //List<T> 泛型数组
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);


            foreach(Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            //Dictionary<TKey, Value>
            Dictionary<string, Car> myDictornary = new Dictionary<string, Car>();
            myDictornary.Add(car1.VIN, car1);
            myDictornary.Add(car2.VIN, car2);
            Console.WriteLine(myDictornary["123"].Model);

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model,string vin)
        {
            this.Make =make;
            this.Model = model;
            this.VIN = vin;
        }
    }
}
