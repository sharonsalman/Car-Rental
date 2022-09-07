using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class CreateVehicle : Form
    {
        public CreateVehicle()
        {
            InitializeComponent();
        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCarRental);

        }

        private void CreateVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCarRental.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.databaseCarRental.Car);

        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Menu menuform = new Menu();
            new Menu().Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save.Enabled = false;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sharon\Desktop\Car-Rental\Project-OOP\Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert_Invoice_Procedure", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@InvoiceNumber", int.Parse(invoiceNumberTB.Text));
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Car_License", licensePlate);
            cmd.Parameters.AddWithValue("@Price", price);
            int i = cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
