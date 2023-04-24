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
    public partial class AggregatedQueriesForm : Form
    {
        public AggregatedQueriesForm()
        {
            InitializeComponent();
        }

        private void uxQuery1Button_Click(object sender, EventArgs e)
        {
            QueryResultForm q = new QueryResultForm();
            this.Hide();
            q.Show();
        }

        private void uxQuery2Button_Click(object sender, EventArgs e)
        {
            QueryResultForm q = new QueryResultForm();
            this.Hide();
            q.Show();
        }

        private void uxQuery3Button_Click(object sender, EventArgs e)
        {
            QueryResultForm q = new QueryResultForm();
            this.Hide();
            q.Show();
        }

        private void uxQuery4Button_Click(object sender, EventArgs e)
        {
            QueryResultForm q = new QueryResultForm();
            this.Hide();
            q.Show();
        }
    }
}
