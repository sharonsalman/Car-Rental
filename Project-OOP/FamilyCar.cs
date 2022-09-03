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
    //פונקציה שמקשרת את הCLASS לפה
    public partial class FamilyCar : Form
    {
        public FamilyCar()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (RadioButton1.Checked == true){ 
                this.Price = this.Price + 50;
            }
          */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CompanyText_TextChanged(object sender, EventArgs e)
        {
            //f.Company;
        }

        private void FamilyCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataOOP.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseDataOOP.Table);

        }

        private void RentalPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataOOP);

        }

        private void licensePlateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void licensePlateLabel_Click(object sender, EventArgs e)
        {

        }

        private void kidSeatHowMuchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                   
        }

        private void kidSeatHowMuchLabel_Click(object sender, EventArgs e)
        {

        }

        private void kidSeatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kidSeatRadioButton.Checked == true) {
                    kidSeatHowMuchComboBox.Enabled = true;
                }
        }
    }
}
