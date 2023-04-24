using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class VehicleManufacturer
    {
        public int MakeID { get; }

        public string Name { get; }

        public VehicleManufacturer(int makeID, string name)
        {
            MakeID = makeID;
            Name = name;
        }
    }
}
