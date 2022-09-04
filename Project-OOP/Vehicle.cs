﻿using System;
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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void CarType_Click(object sender, EventArgs e)
        {

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            List<VehicleClass> vehicle = new List<VehicleClass>(); 
        }

        private void comboBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVehicleName.Enabled = true;
            if (comboBoxCarType.SelectedItem.ToString().Equals("Family Car"))
            {
                comboBoxVehicleName.ValueMember = "Type";
            }
        }
        private void comboBoxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVehicleType.SelectedItem.ToString().Equals("Car"))
            {
                comboBoxCarType.Enabled = true;
                comboBoxVehicleName.Enabled = false;
            }
            else
            if (comboBoxVehicleType.SelectedItem.ToString().Equals("Motorcycle"))
            {
                comboBoxVehicleName.Enabled = true;
                comboBoxCarType.Enabled = false;
            }
            }
        private void AddVehicle_Click(object sender, EventArgs e)
        {
            new CreateVehicle().Show();
        }

        private void CarSearchButton_Click(object sender, EventArgs e)
        {
           // if (comboBoxVehicleName.GetType = "Family Car") new FamilyCar().Show();
        }
    }
}