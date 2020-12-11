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
        static Park taxiPark = new Park();
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Taxi Park:");
            Console.WriteLine("1) Add car");
            Console.WriteLine("2) Remove car");
            Console.WriteLine("3) Sort cars by fuel consumption");
            Console.WriteLine("4) Show total park cost");
            Console.WriteLine("5) Show cars");
            Console.WriteLine("6) Find car by top speed interval");
            Console.WriteLine("7) Exit");
            Console.WriteLine("Select option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddCar();
                    return true;
                case "2":
                    RemoveCarById();
                    return true;
                case "3":
                    SortCarsByConsumption();
                    return true;
                case "4":
                    ShowParkTotalCost();
                    return true;
                case "5":
                    ShowCars();
                    return true;
                case "6":
                    FindCarByTopSpeedInterval();
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }
        private static void AddCar()
        {
            Console.Clear();
            Console.WriteLine("Add Car:");
            Console.WriteLine("Input Manufacturer:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Input Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Input Top Speed:");
            float topSpeed;
            float.TryParse(Console.ReadLine(), out topSpeed);
            Console.WriteLine("Input Fuel Consumption:");
            float fuelConsumption;
            float.TryParse(Console.ReadLine(), out fuelConsumption);
            Console.WriteLine("Input Cost:");
            float cost;
            float.TryParse(Console.ReadLine(), out cost);
            Console.WriteLine("Input WIN:");
            string WIN = Console.ReadLine();
            Console.WriteLine("Status: {0}",taxiPark.Add(new Car(manufacturer, model, topSpeed, fuelConsumption, cost, WIN)));
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }
        private static void ShowCars()
        {
            Console.Clear();
            Console.WriteLine("All cars:");
            Console.WriteLine("Car - id - Manufacturer - Model - Top Speed - Fuel Consumption - WIN");
            Car car;
            for(int i=0; i < taxiPark.Length; i++)
            {
                car = taxiPark.GetCarById(i);
                Console.WriteLine("Car {0}: \t{1} \t{2} \t{3} \t{4} \t{5}", i, car.Manufacturer, car.Model, car.TopSpeed, car.FuelConsumption, car.WIN);
            }
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void SortCarsByConsumption()
        {
            Console.Clear();
            Console.WriteLine("Sorting array...");
            Console.WriteLine("Status: {0}",taxiPark.SortByConsumption());
            Console.WriteLine("Array sorted");
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void RemoveCarById()
        {
            Console.Clear();
            Console.WriteLine("Remove car by id:");
            Console.WriteLine("Enter id for removing car:");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Status: {0}", taxiPark.Remove(id));
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void ShowParkTotalCost()
        {
            Console.Clear();
            Console.WriteLine("Total park cost: {0}", taxiPark.TotalCost());
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void FindCarByTopSpeedInterval()
        {
            Console.Clear();
            Console.WriteLine("Find car by top speed interval:");
            Console.WriteLine("Input minimum top speed:");
            float minSpeed;
            float.TryParse(Console.ReadLine(), out minSpeed);
            Console.WriteLine("Input maximum top speed:");
            float maxSpeed;
            float.TryParse(Console.ReadLine(), out maxSpeed);
            if(minSpeed < maxSpeed)
            {
                Car car;
                Console.WriteLine("Searching for car");
                try
                {
                    car = taxiPark.FindCarByTopSpeed(minSpeed, maxSpeed);
                    Console.WriteLine("Car - Manufacturer - Model - Top Speed - Fuel Consumption - WIN");
                    Console.WriteLine("Car founded: {0} \t{1} \t{2} \t{3} \t{4}", car.Manufacturer, car.Model, car.TopSpeed, car.FuelConsumption, car.WIN);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error occured: {0}", e.Message);
                }
            }
            else
            {
                Console.WriteLine("Minimum speed is greater than maximum");
            }
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }
    }
}
