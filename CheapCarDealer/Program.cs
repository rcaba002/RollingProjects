using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapCarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanDrive drivableThing = null;
            string response = Console.ReadLine();
            if (response == "c")
            {
                drivableThing = new Car();
            }
            else if (response == "t")
            {
                drivableThing = new Truck();
            }
            else if (response == "m")
            {
                drivableThing = new Motorcycle();
            }

            if (drivableThing != null)
            {
                drivableThing.Drive();
            }
            else
            {
                Console.WriteLine("Can't drive nothin'");
            }

            Console.ReadLine();
        }
    }

    class Vehicle : ICanDrive
    {
        public DoorCount Doors { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public int Wheels { get; set; }
    }

    interface ICanDrive
    {
        void Drive();
        int Wheels { get; set; }
    }

    class Motorcycle : ICanDrive
    {
        public void Drive()
        {
            Console.WriteLine("The motorcycle says 'moooo'");
        }

        public int Wheels { get; set; }
    }

    class Car : Vehicle
    {
        public bool HasBucketSeats { get; set; }
    }

    class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Rumble!!");
        }
    }

    enum DoorCount
    {
        TwoDoor,
        FourDoor,
        CrewCab,
        QuadCab,
        FiveDoor
    }
}
