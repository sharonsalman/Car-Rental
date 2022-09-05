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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCarRental);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCarRental.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.databaseCarRental.Customer);

        }

        private void BackMenu_Click_1(object sender, EventArgs e)
        {
            Menu menuform = new Menu();
            new Menu().Show();
            this.Hide();
        }
    }
}
