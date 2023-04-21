using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV.Search_Forms
{
    public partial class VehicleSearchForm : Form
    {
        public VehicleSearchForm()
        {
            InitializeComponent();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Close();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            QueryResultForm q = new QueryResultForm();
            q.Show();
            this.Close();
        }
    }
}
