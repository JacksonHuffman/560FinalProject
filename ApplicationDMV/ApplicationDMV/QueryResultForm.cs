using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDMV
{
    public partial class QueryResultForm : Form
    {
        public QueryResultForm()
        {
            InitializeComponent();
        }

        private void uxHomeButton_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Close();
        }
    }
}
