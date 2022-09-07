using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_OOP
{
    public partial class VehicleList : Form
    {
        public VehicleList()
        {
            InitializeComponent();

        }

        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        List<VehicleClass> vehicleList;
        private void VehicleList_Load(object sender, EventArgs e)
        {

            set_up_grid();
        }

        private void set_up_grid()
        {
            LoadData();
        }

        private void LoadData()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sharon\Desktop\Car-Rental\Project-OOP\Database.mdf;Integrated Security=True");
            cmd = new SqlCommand("select * from Car", con);
            string selectquery = "select * from Car";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            DataTable table = new DataTable();
            adpt.Fill(table);
            dataGridView1.DataSource = table;

            this.vehicleList = LoadList(table);
        }

        private List<VehicleClass> LoadList(DataTable data)
        {
            return data.AsEnumerable().Select(r => createVehicleFromObject(r)).ToList();
        }

        private VehicleClass createVehicleFromObject(DataRow row)
        {

            int LicensePlate = (int)row["LicensePlate"];
            String Type = (String)(row["Type"].ToString());
            String VehicleName = (String)(row["VehicleName"].ToString());
            String Color = (String)(row["Color"].ToString());
            String CompanyName = (String)(row["CompanyName"].ToString());
            int Price = (int)row["Price"];
            int Safety = (int)row["Safety"];
            int Distance = (int)row["Distance"];
            int Year = (int)row["Year"];

            int Doors, Seats, Storage, MaxSpeed, FuelPerKM;
            VehicleClass vehicle = null;

            switch (Type.Trim())
            {
                case "Family":
                    Doors = (int)row["Doors"];
                    Seats = (int)row["Seats"];
                    Storage = (int)row["Storage"];
                    FuelPerKM = (int)row["FuelPerKM"];
                    vehicle = new FamilyCarsClass(FuelPerKM, Year, Distance, Safety, Price,
                        CompanyName, Color, VehicleName, LicensePlate, Doors, Seats, Storage);

                    break;
                case "Sport":
                    Doors = (int)row["Doors"];
                    Seats = (int)row["Seats"];
                    Storage = (int)row["Storage"];
                    MaxSpeed = (int)row["MaxSpeed"];
                    vehicle = new SportsCarsClass(MaxSpeed, Year, Distance, Safety, Price,
                        CompanyName, Color, VehicleName, LicensePlate, Doors, Seats, Storage);
                    break;
                case "Motorbike":
                    MaxSpeed = (int)row["MaxSpeed"];
                    vehicle = new BikesClass(MaxSpeed, Year, Distance, Safety, Price,
                    CompanyName, Color, VehicleName, LicensePlate);
                    break;
                default:
                    vehicle = new FamilyCarsClass(0, Year, Distance, Safety, Price,
                        CompanyName, Color, VehicleName, LicensePlate, 0, 0, 0);
                    break;
            }

            return vehicle;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row.Cells["LicensePlate"].Value.ToString() == "")
                return;

            String type = (String)(row.Cells["Type"].Value.ToString());
            VehicleClass vehicle = this.vehicleList[e.RowIndex];

            RentalDisplay FamilyCarForm = new RentalDisplay(vehicle, type);
            FamilyCarForm.Show();
            this.Hide();

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                vehicleList.RemoveAt(e.RowIndex);
            }
        }
    }
}
