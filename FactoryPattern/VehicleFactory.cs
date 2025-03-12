using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            if(wheelCount == 4)
            {
                return new Car();
            }

            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                 default:
                    return new Car();

            }

            
        }
    }
}
