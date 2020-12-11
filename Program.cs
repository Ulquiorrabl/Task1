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
        static Park carPark = new Park();
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
            Console.WriteLine("6) Exit");
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
            int topSpeed;
            int.TryParse(Console.ReadLine(), out topSpeed);
            Console.WriteLine("Input Fuel Consumption:");
            float fuelConsumption;
            float.TryParse(Console.ReadLine(), out fuelConsumption);
            Console.WriteLine("Input Cost:");
            int cost;
            int.TryParse(Console.ReadLine(), out cost);
            Console.WriteLine("Input WIN:");
            string WIN = Console.ReadLine();
            Console.WriteLine("Status: {0}",carPark.Add(new Car(manufacturer, model, topSpeed, fuelConsumption, cost, WIN)));
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }
        private static void ShowCars()
        {
            Console.Clear();
            Console.WriteLine("All cars:");
            Console.WriteLine("Car - id - Manufacturer - Model - Top Speed - Fuel Consumption - WIN");
            Car car;
            for(int i=0; i < carPark.Length; i++)
            {
                car = carPark.GetCarById(i);
                Console.WriteLine("Car {0}: \t{1} \t{2} \t{3} \t{4} \t{5}", i, car.Manufacturer, car.Model, car.TopSpeed, car.FuelConsumption, car.WIN);
            }
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void SortCarsByConsumption()
        {
            Console.Clear();
            Console.WriteLine("Sorting array...");
            Console.WriteLine("Status: {0}",carPark.SortByConsumption());
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
            Console.WriteLine("Status: {0}", carPark.Remove(id));
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }

        private static void ShowParkTotalCost()
        {
            Console.Clear();
            Console.WriteLine("Total park cost: {0}", carPark.TotalCost());
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
        }
    }
}
