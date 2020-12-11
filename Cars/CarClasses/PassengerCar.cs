using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars.CarEngine;

namespace Task1.Cars.CarClasses
{
    class PassengerCar : Car
    {
        public int PeopleCapacity { private set; get; }
        public PassengerCar(string manufacturer, string model, float topSpeed, float fuelConsumption, float cost, string win, Engine engine, int capacity) :
            base(manufacturer, model, topSpeed, fuelConsumption, cost, win, engine)
        {
            this.PeopleCapacity = capacity;
        }
    }
}
