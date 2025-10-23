using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This vehicle is driving (from base class).");
        }
    }
}