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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AddVehicle_Click(object sender, EventArgs e)
        {
            new CreateVehicle().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VehicleList_Click(object sender, EventArgs e)
        {
            VehicleList VehicleListrform = new VehicleList();
            new VehicleList().Show();
            this.Hide();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
