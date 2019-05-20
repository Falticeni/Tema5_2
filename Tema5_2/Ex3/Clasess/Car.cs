using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Interfaces;

namespace Ex3.Clasess
{
    public class Car : IVehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Car(string manufacturer, string model, int year, double price)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
        public Car(string manufacturer, string model, int year) // asta stie prima data clientul
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }

    }
}
