using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic_Shop
{
    class Truck : Vehicles, IchangeOil
    {
        public void ChangeOil(bool IsOilDirty)
        {
            if (IsOilDirty)
            {
                Console.WriteLine("Truck changing oil");
            }
        }

    }
}
