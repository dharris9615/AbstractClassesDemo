using System;
namespace ConsoleUI
{
    public class Car : Vehicles
    {
        public Car()
        {
            
        }

        public int NumberOfDoors = 4;
        public bool HasFourWheels = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Has ability to drive itself.");
        }
    }
}
