using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV
{
    internal class VehicleModel
    {
        public int ModelID { get; }

        public int MakeID { get; }

        public string Name { get; }

        public int Year { get; }

        public VehicleModel(int moid, int maid, string n, int y)
        {
            ModelID = moid;
            MakeID = maid;
            Name = n;
            Year = y;
        }
    }
}
