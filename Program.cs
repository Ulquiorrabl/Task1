using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.CarPark.ParkImplementation;
using Task1.Cars;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car temp;
            Park park = new Park();
            Console.WriteLine(park.Add(new Car("Skoda", "Rapid", 169, 12.3f, 4000, "WIN1F")));
            Console.WriteLine(park.Add(new Car("Ford", "Crown Victoria", 185, 15.4f, 10000, "WIN2F")));
            Console.WriteLine(park.Add(new Car("Volkswagen", "Polo Sedan", 178, 9.1f, 3500, "WIN3F")));
            Console.WriteLine(park.Add(new Car("Renault", "Logan", 173, 10.2f, 2800, "WIN4F")));
            for (int i = 0; i < 4; i++)
            {
                temp = park.GetCarById(i);
                Console.WriteLine("Car {0} {1} with fuel consumption {2}",temp.Manufacturer, temp.Model, temp.FuelConsumption);
            }
            park.SortByConsumption();
            Console.WriteLine("============================================");
            for (int i = 0; i < 4; i++)
            {
                temp = park.GetCarById(i);
                Console.WriteLine("Car {0} {1} with fuel consumption {2}", temp.Manufacturer, temp.Model, temp.FuelConsumption);
            }
            Console.ReadKey();
        }
    }
}
