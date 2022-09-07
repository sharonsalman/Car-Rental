﻿using System;
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

        private void VehicleList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCarRental.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.databaseCarRental.Car);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FamilyCar FamilyCarForm = new FamilyCar();
            new FamilyCar().Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //FamilyCar FamilyCarForm = new FamilyCar();
            //new FamilyCar().Show();
            //this.Hide();

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row.Cells["LicensePlate"].Value.ToString() == "")
                return;

            int LicensePlate = (int)row.Cells["LicensePlate"].Value;
            String Type = (String)(row.Cells["Type"].Value.ToString());
            String VehicleName = (String)(row.Cells["VehicleName"].Value.ToString());
            String Color = (String)(row.Cells["Color"].Value.ToString());
            String CompanyName = (String)(row.Cells["CompanyName"].Value.ToString());
            int Price = (int)row.Cells["Price"].Value;
            int Safety = (int)row.Cells["Safety"].Value;
            int Distance = (int)row.Cells["Distance"].Value;
            int Year = (int)row.Cells["Year"].Value;

            Console.WriteLine(LicensePlate);
            Console.WriteLine(Type);
            Console.WriteLine(VehicleName);
            Console.WriteLine(Color);
            Console.WriteLine(CompanyName);
            Console.WriteLine(Price);
            Console.WriteLine(Safety);
            Console.WriteLine(Distance);
            Console.WriteLine(Year);


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}