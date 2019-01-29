using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._1._19_h.w
{
    class Car: Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _numberOfDoors;

        public override int GetMaxOfPassengers()
        {
            Console.WriteLine("How many passengers?");
            int numberOfPassengers = Convert.ToInt32(Console.ReadLine());
            return numberOfPassengers;
        }

        public override int GetMaxSpeed()
        {
            Console.WriteLine("What is the max speed?");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());
            return maxSpeed;
        }

        public override string ToString()
        {
            return base.ToString() + $"number of doors:{_numberOfDoors}";
        }
    }
}
