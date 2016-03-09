using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic_Shop
{
    class Shop<T> where T : Vehicles
    {
        public Shop()
        {
        }

        public void ChangeOil(T Vehicles)
        {
            Vehicles.IsOilDirty = true;
        }

        public void FillUp(T Vehicles)
        {

        }

        public void ChangeTire()
        {


        }
    }

    
}
