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
    public partial class FamilyCar : Form
    {
        int price = 0;
        public FamilyCar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // price = databasepriceof car + price; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kidseat.Checked == true) kidseatsnum.Enabled = true;
            kidseatsnum.Enabled = false;
        }

        private void kidseatsnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCarRental);

        }

        private void FamilyCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCarRental.Car' table. You can move, or remove it, as needed.


        }

    }
}
