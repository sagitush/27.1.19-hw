using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._1._19_h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car()
            {
                _numberOfWheels = 4,
                _model = "mercedes",
                _numberOfDoors = 4
            };
            Car subaro = new Car()
            {
                _numberOfWheels = 4,
                _model = "subaro",
                _numberOfDoors = 2
            };
            Motorcycle kawasaki = new Motorcycle()
            {
                _numberOfWheels = 2,
                _model = "kawasaki",
                _numberOfHandBreakes = 1
            };
            Motorcycle yamaha = new Motorcycle()
            {
                _numberOfWheels = 2,
                _model = "yamaha",
                _numberOfHandBreakes = 2
            };
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car { _numberOfWheels = 4,_model = "subaro", _numberOfDoors = 2},
                new Car {_numberOfWheels = 4,_model = "mercedes",  _numberOfDoors = 4 },
                new Motorcycle{ _numberOfWheels = 2,_model = "yamaha",_numberOfHandBreakes = 2 }
            };
            Carrier oto = new Carrier()
            {
                vehicles = new Vehicle[]
                {
                    new Car{_numberOfWheels = 4,_model = "subaro", _numberOfDoors = 2 },
                    new Car {_numberOfWheels = 4,_model = "mercedes",  _numberOfDoors = 4 },
                    new Motorcycle{ _numberOfWheels = 2,_model = "yamaha",_numberOfHandBreakes = 2 }
                }
            };
            Console.WriteLine(oto.ToString());
        }
        public void PrintVehicle(Vehicle r)
        {
            Console.WriteLine(r._model);
            Console.WriteLine(r.ToString());
        }
        public void PrintVehicles(Vehicle[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i].ToString());
            }
        }
    }
}
