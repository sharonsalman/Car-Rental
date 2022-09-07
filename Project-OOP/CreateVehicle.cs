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
            SqlCommand cmd = new SqlCommand("Insert_Car_Procedure", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LicensePlate", int.Parse(licensePlateTextBox.Text));
            cmd.Parameters.AddWithValue("@VehicleName",vehicleNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Color", colorTextBox.Text);
            cmd.Parameters.AddWithValue("@CompanyName", companyNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(priceTextBox.Text));
            cmd.Parameters.AddWithValue("@Safety", int.Parse(safetyTextBox.Text));
            cmd.Parameters.AddWithValue("@Distance", int.Parse(distanceTextBox.Text));
            cmd.Parameters.AddWithValue("@Year", int.Parse(yearTextBox.Text));
            cmd.Parameters.AddWithValue("@Type", TypeCB.SelectedItem);

            switch (TypeCB.SelectedItem.ToString().Trim())
            {
                case "Family":
                    cmd.Parameters.AddWithValue("@Doors", int.Parse(doorsTextBox.Text));
                    cmd.Parameters.AddWithValue("@Seats", int.Parse(seatsTextBox.Text));
                    cmd.Parameters.AddWithValue("@Storage", int.Parse(storageTextBox.Text));
                    break;
                case "Sport":
                    cmd.Parameters.AddWithValue("@Doors", int.Parse(doorsTextBox.Text));
                    cmd.Parameters.AddWithValue("@Seats", int.Parse(seatsTextBox.Text));
                    cmd.Parameters.AddWithValue("@Storage", int.Parse(storageTextBox.Text));
                    cmd.Parameters.AddWithValue("@MaxSpeed", int.Parse(maxSpeedTextBox.Text));
                    break;
                case "Motorbike":
                    cmd.Parameters.AddWithValue("@MaxSpeed", int.Parse(maxSpeedTextBox.Text));
                    break;
                default:
                   
                    break;
            }
            int i = (int) cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
