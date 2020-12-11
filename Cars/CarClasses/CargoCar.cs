using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars.CarEngine;

namespace Task1.Cars.CarClasses
{
    class CargoCar : Car
    {
        public float CargoCapacity { private set; get; }
        public CargoCar(string manufacturer, string model, float topSpeed, float fuelConsumption, float cost, string win, Engine engine,float capacity) : 
            base(manufacturer, model, topSpeed, fuelConsumption, cost, win, engine)
        {
            this.CargoCapacity = capacity;
        }
    }
}
