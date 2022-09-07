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
    public partial class RentalDisplay : Form
    {
        int price = 0;
        Object vehicle;
        String type;
        public RentalDisplay(Object vehicle, String type)
        {
            this.vehicle = vehicle;
            this.type = type;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // price = databasepriceof car + price; 
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
            Console.WriteLine(this.vehicle.ToString());
            LoadDefaultDataToTextBox();
            LoadTypeSpecificData();
        }

        private void LoadTypeSpecificData()
        {
            switch (this.type.Trim())
            {
                case "Family":
                    MaxSpeedTB.Visible = !MaxSpeedTB.Visible;
                    MaxSpeedLabel.Visible = !MaxSpeedLabel.Visible;
                    LoadCarDataToTextBox();
                    break;
                case "Sport":
                    LoadCarDataToTextBox();
                    SportsCarsClass vehicle = (SportsCarsClass)this.vehicle;
                    MaxSpeedTB.Text = vehicle.MaxSpeed.ToString();

                    break;
                case "Motorbike":
                    LoadMotorBikeDataToTextBox();
                    DoorsTB.Visible = !DoorsTB.Visible;
                    DoorsLabel.Visible = !DoorsLabel.Visible;
                    StorageTB.Visible = !StorageTB.Visible;
                    StorageLabel.Visible = !StorageLabel.Visible;
                    SeatsTB.Visible = !SeatsTB.Visible;
                    SeatsLabel.Visible = !SeatsLabel.Visible;
                    break;
                default:
                    break;
            }

        }

        private void LoadMotorBikeDataToTextBox()
        {
            BikesClass vehicle = (BikesClass)this.vehicle;
            MaxSpeedTB.Text = vehicle.MaxSpeed.ToString();
        }

        private void LoadCarDataToTextBox()
        {
            CarsClass vehicle = (CarsClass)this.vehicle;

            DoorsTB.Text = vehicle.Doors.ToString();
            SeatsTB.Text = vehicle.Seats.ToString();
            DistanceTB.Text = vehicle.Distance.ToString();
            StorageTB.Text = vehicle.Storage.ToString();
        }

        private void LoadDefaultDataToTextBox()
        {
            VehicleClass vehicle = (VehicleClass)this.vehicle;

            licensePlateTextBox.Text = vehicle.LicensePlate.ToString();
            CompanyTB.Text = vehicle.CompanyName.ToString();
            ModelTB.Text = vehicle.VehicleName.ToString();
            YearTB.Text = vehicle.Year.ToString();
            ColorTB.Text = vehicle.Color.ToString();
            SafetyTB.Text = vehicle.Safety.ToString();
            PriceTB.Text = vehicle.Price.ToString();
            DistanceTB.Text = vehicle.Distance.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new VehicleList().Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddtoInvoice_Click(object sender, EventArgs e)
        {
            new Invoice(int.Parse(PriceTB.Text), int.Parse(licensePlateTextBox.Text)).Show();
            this.Hide();
        }
    }
}
