using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_OOP.FamilyCarsClass;
using static Project_OOP.SportsCarsClass;
using static Project_OOP.CarsClass;
using static Project_OOP.VehicleClass;
using static Project_OOP.BikesClass;

// איפה שמים פונקציה בונה? צריך פונקציה שבונה כל דבר
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
            // TODO: This line of code loads data into the 'databaseDataOOP.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseDataOOP.Table);
            VehicleClass [] vehicle = new VehicleClass [10] ;

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
            // נבנה מערך של כל הרכבים ולפי הלחיצה הקודמת נעלה את כל השמות
            if (CarType.SelectedItem.ToString().Equals("Family")) ;
     
        }

        private void VehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (CarType.SelectedItem.ToString().Equals("Family"))
                {
                VehicleName.ValueMember = "Type";
            }

        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddVehicle_Click(object sender, EventArgs e)
        {
            new CreateVehicles().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
