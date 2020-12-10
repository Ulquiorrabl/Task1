using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Cars.CarComparers
{
    class CarFuelConsumptionComparer : Comparer<Car>
    {
        public override int Compare(Car x, Car y)
        {
            if(x.FuelConsumption != 0)
            {
                return x.FuelConsumption.CompareTo(y.FuelConsumption);
            }
            else
            {
                return 0;
            }
        }
    }
}
