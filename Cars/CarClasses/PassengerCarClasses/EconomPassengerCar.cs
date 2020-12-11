using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars.CarEngine;
using Task1.States.ComfortStates;

namespace Task1.Cars.CarClasses.PassengerCarClasses
{
    class EconomPassengerCar : PassengerCar
    {
        public ComfortState ComfortLevel { private set; get; }
        public EconomPassengerCar(string manufacturer, string model, float topSpeed, float fuelConsumption, float cost, string win, Engine engine, int capacity) :
            base(manufacturer, model, topSpeed, fuelConsumption, cost, win, engine, capacity)
        {
            this.ComfortLevel = ComfortState.Low;
        }
    }
}
