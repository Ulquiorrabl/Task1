using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars;
using Task1.States;

namespace Task1.CarPark
{
    interface IPark
    {
        ParkState SortByConsumption();
        ParkState Add(Car car);
        ParkState Remove(int win);
        Car FindCarByTopSpeed(int topspeed);
        float TotalCost();
    }
}
