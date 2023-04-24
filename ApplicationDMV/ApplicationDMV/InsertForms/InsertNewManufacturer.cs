using ApplicationDMV.SqlRepos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV.InsertForms
{
    public partial class InsertNewManufacturer : Form
    {
        private SqlVehicleManufacturerRepository _makeRepo;

        private string _name;

        public InsertNewManufacturer(SqlVehicleManufacturerRepository makeRepo, string name)
        {
            InitializeComponent();
            _makeRepo = makeRepo;
            _name = name;
        }

        private void uxAddBT_Click(object sender, EventArgs e)
        {
            _makeRepo.AddManufacturer(_name);
            this.Close();
        }

        private void uxBackBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
