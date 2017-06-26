using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class DistanceDialog : Form
    {
        private double _distance;
        public DistanceDialog()
        {
            InitializeComponent();
            _distance = 0.0;
        }

        public double Distance
        {
            get { return _distance; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DistanceDialog_Load(object sender, EventArgs e)
        {
            txtDistance.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDistance.Text) && double.TryParse(txtDistance.Text, out _distance) && _distance > 0.0)
                this.Close();
            else
                MessageBox.Show("Please enter a valid number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
