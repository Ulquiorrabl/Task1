using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Cars
{
    class Car
    {
        public string Manufacturer { private set; get; }
        public string Model { private set; get; }
        public int TopSpeed { private set; get; }
        public float FuelConsumption { private set; get; }
        public float Cost { private set; get; }
        public string WIN { private set; get; }

        public Car (string manufacturer, string model, int topspeed, float fuelconsumption, float cost, string win)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.TopSpeed = topspeed;
            this.FuelConsumption = fuelconsumption;
            this.Cost = cost;
            this.WIN = win;
        }
    }
}
