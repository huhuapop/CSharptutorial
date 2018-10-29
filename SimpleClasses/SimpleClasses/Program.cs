using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.setMake("Oldsmobile");
            myCar.setModel("Cutlas Supreme");
            myCar.setYear(1986);
            myCar.setColor("Silver");

            Console.WriteLine("{0} {1} {2} {3}",myCar.getMake(),myCar.getModel(),myCar.getYear(),myCar.getColor());

            Console.ReadLine();
        }
    }
}
