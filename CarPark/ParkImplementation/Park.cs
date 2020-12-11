using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Cars;
using Task1.States;

namespace Task1.CarPark.ParkImplementation
{
    class Park : IPark
    {
        private List<Car> carPark;

        public int Length { get { return carPark.Count; } }

        public Park()
        {
            carPark = new List<Car>();
        }

        public ParkState Add(Car car)
        {
            try
            {
                carPark.Add(car);
            }
            catch (Exception)
            {
                return ParkState.Error;
            }
            return ParkState.Success;
        }

        public ParkState Remove(int id)
        {
            try
            {
                carPark.Remove(carPark[id]);
            }
            catch (Exception)
            {
                return ParkState.Error;
            }
            return ParkState.Success;
        }

        public Car FindCarByTopSpeed(int topspeed)
        {
            for(int i = 0; i < carPark.Count; i++)
            {
                if(carPark[i].TopSpeed == topspeed)
                {
                    return carPark[i];
                }
            }
            throw new Exception("Car not found");
        }

        public Car GetCarById(int id)
        {
            try
            {
                return carPark[id];
            }
            catch (Exception)
            {
                throw new Exception("Car not found");
            }
            
        }

        public ParkState SortByConsumption()
        {
            try
            {
                carPark.Sort(new Cars.CarComparers.CarFuelConsumptionComparer());
            }
            catch (Exception)
            {
                return ParkState.Error;
            }
            return ParkState.Success;
            
        }

        public float TotalCost()
        {
            float totalCost = 0;
            for(int i = 0; i < carPark.Count; i++)
            {
                totalCost += carPark[i].Cost;
            }
            return totalCost;
        }
    }
}
