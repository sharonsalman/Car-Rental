using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VehicleType.SelectedItem.ToString().Equals("Cars")) 
            {
                CarType.Enabled = true;
            }
            else
            {
                CarType.Enabled = false;
            }
        }

        private void CarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarType.SelectedItem.ToString().Equals("Family"))

        }

        private void VehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
