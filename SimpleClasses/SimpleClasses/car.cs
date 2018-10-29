using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClasses
{
    class Car
    {
        protected string Make;
        protected string Model;
        protected int Year;
        protected string Color;

        public Car()
        {
            this.Make = "";
            this.Model = "";
            this.Year = 0;
            this.Color = "";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public string getMake()
        {
            return this.Make;
        }

        public void setMake(string make)
        {
            this.Make = make;
        }

        public string getModel()
        {
            return this.Model;
        }

        public void setModel(string model)
        {
            this.Model = model;
        }

        public int getYear()
        {
            return this.Year;
        }

        public void setYear(int year)
        {
            this.Year = year;
        }

        public string getColor()
        {
            return this.Color;
        }

        public void setColor(string color)
        {
            this.Color = color;
        }
    }
}
