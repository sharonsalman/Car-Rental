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
            customeridTB.Text = generateCustomerNumber();
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

        private void invoiceNumberTextBox_TextChanged(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sharon\Desktop\Car-Rental\Project-OOP\Database.mdf;Integrated Security=True");
            SqlCommand Comm1 = new SqlCommand("SELECT COUNT(*) FROM Invoice", Conn);
            Conn.Open();
            invoiceNumberTextBox.Text = (string)Comm1.ExecuteScalar();
            Conn.Close();
        }

        private void Pay_Click(object sender, EventArgs e)
        {

        }
    }
}
