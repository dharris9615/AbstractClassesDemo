using System;
namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public Vehicles()
        {
        }
        public int Year = 2020;
        public string Make = "Ford";
        public string Model = "Kingranch";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Automatic Transmission");
        }
    }
}
