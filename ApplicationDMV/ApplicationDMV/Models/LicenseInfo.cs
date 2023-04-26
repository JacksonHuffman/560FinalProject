using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDMV.Models
{
    public class LicenseInfo
    {
        public int LicenseID { get; }

        public int RegisteredDriverStateID { get; }

        public string City { get; set; }

        public string ZIP { get; set;  }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int FeetHeight { get; set; }

        public int InchesHeight { get; set; }

        public int Weight { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpDate { get; set; }
            
        public char Class { get; set; }

        public bool IsDonor { get; set; }

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
