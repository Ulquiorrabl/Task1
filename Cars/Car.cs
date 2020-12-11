using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars.CarEngine;

namespace Task1.Cars
{
    class Car
    {
        public string Manufacturer { private set; get; }
        public string Model { private set; get; }
        public float TopSpeed { private set; get; }
        public float FuelConsumption { private set; get; }
        public float Cost { private set; get; }
        public string WIN { private set; get; }

        Engine engine;


        public Car (string manufacturer, string model, float topSpeed, float fuelConsumption, float cost, string win)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.TopSpeed = topSpeed;
            this.FuelConsumption = fuelConsumption;
            this.Cost = cost;
            this.WIN = win;
        }

        public Car(string manufacturer, string model, float topSpeed, float fuelConsumption, float cost, string win, Engine engine)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.TopSpeed = topSpeed;
            this.FuelConsumption = fuelConsumption;
            this.Cost = cost;
            this.WIN = win;
            this.engine = engine;
        }
    }
}
