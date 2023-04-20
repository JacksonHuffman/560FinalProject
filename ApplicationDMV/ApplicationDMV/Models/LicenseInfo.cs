using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV
{
    internal class LicenseInfo
    {
        public int LicenseID { get; }

        public int RegisteredDriverStateID { get; }

        public string City { get; }

        public string ZIP { get; }

        public string AddressLine1 { get; }

        public string AddressLine2 { get; }

        public int FeetHeight { get; }

        public int InchesHeight { get; }

        public int Weight { get; }

        public DateTime IssueDate { get; }

        public DateTime ExpDate { get; }

        public char Class { get; }

        public bool IsDonor { get; }

        public LicenseInfo(int lid, int rdsid, string c, string zip, string al1, string al2,
            int fh, int ih, int w, DateTime id, DateTime ed, char cl, bool isDonor)
        {
            LicenseID = lid;
            RegisteredDriverStateID = rdsid;
            City = c;
            ZIP = zip;
            AddressLine1 = al1;
            AddressLine2 = al2;
            FeetHeight = w;
            InchesHeight = ih;
            Weight = fh;
            IssueDate = id;
            ExpDate = ed;
            Class = cl;
            IsDonor = isDonor;
        }

    }
}
