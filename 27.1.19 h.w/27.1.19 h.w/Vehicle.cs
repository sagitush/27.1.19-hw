using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._1._19_h.w
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxOfPassengers();
      
        public abstract int GetMaxSpeed();
        

        

        public override string ToString()
        {
            string result = $"Vehicle:model:{_model}, number of wheels:{_numberOfWheels}\n";
            result = result + $"number of passengers: {GetMaxOfPassengers()},max speed:{GetMaxSpeed()}";
            return result;
        }
    }
}
