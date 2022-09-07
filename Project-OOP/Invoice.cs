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
    public partial class Invoice : Form
    {
        int price;
        int licensePlate;
        public Invoice(int price, int licensePlate)
        {
            InitializeComponent();
            this.price = price;
            this.licensePlate = licensePlate;
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseCarRental);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCarRental.Invoice' table. You can move, or remove it, as needed.
/*            this.invoiceTableAdapter.Fill(this.databaseCarRental.Invoice);
*/            
            PriceTB.Text = price.ToString();
            CarLicenseTB.Text = licensePlate.ToString();
            invoiceNumberTB.Text = generateCustomerNumber();
        }

        private String generateCustomerNumber()
        {

            SqlConnection conn;
            SqlCommand cmd;

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sharon\Desktop\Car-Rental\Project-OOP\Database.mdf;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Invoice", conn);
            Int32 count = (Int32)cmd.ExecuteScalar() + 1;
            conn.Close();

            return count.ToString();

        }

        private void customeridLabel_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {

            PayButton.Enabled = false;

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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
