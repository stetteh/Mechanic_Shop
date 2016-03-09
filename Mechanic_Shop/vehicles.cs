using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanic_Shop
{
    public abstract class Vehicles
    {
        public bool IsGasTankEmpty { get; set; }
        public bool IsOilDirty = false;
    }

    public interface IchangeOil
    {
        void ChangeOil(bool IsOilDirty);
    }
}
