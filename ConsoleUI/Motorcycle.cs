using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is driving abstractly.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is driving virtually — VROOM VROOM!!!");
        }
    }
}