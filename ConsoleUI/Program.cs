using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            Car car1 = new Car()
            {
                Make = "Nissan",
                Model = "Maxima",
                Year = "2010",
                HasTrunk = true
            };

            Motorcycle moto1 = new Motorcycle()
            {
                Make = "Harley Davidson",
                Model = "Street 750",
                Year = "2018",
                HasSideCart = false
            };

            Vehicle car2 = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = "2022",
                HasTrunk = true
            };

            Vehicle moto2 = new Motorcycle()
            {
                Make = "Ducati",
                Model = "Panigale V4",
                Year = "2023",
                HasSideCart = false
            };

            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(car2);
            vehicles.Add(moto2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} | Make: {vehicle.Make} | Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("----------------------");
            }

            car1.DriveAbstract();
            car1.DriveVirtual();

            moto1.DriveAbstract();
            moto1.DriveVirtual();

            Console.ReadLine();
        }
    }
}