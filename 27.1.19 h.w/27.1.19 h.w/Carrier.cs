using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._1._19_h.w
{
    class Carrier
    {
        public Vehicle[] vehicles;

        public override string ToString()
        {
            string result = "Vehicles:";
            for (int i = 0; i < vehicles.Length; i++)
            {
                result = result + vehicles[i].ToString() + "\n";
            }
            return result;
        }
    }
}
