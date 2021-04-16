using System;
namespace ConsoleUI
{
    public class MotorCycle : Vehicles
    {
        public MotorCycle()
        {
        }

        public bool HasSideCar = true;
        public bool IsChopper = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Limit 2 riders.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Manual Trnasmission");
        }
    }
}
