﻿
namespace Project_OOP
{
    partial class Vehicles
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleType = new System.Windows.Forms.ComboBox();
            this.CarType = new System.Windows.Forms.ComboBox();
            this.VehicleName = new System.Windows.Forms.ComboBox();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "סוג הרכב אותו תרצו להשכיר";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "סוג המכונית שתרצו להשכיר";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "שם הרכב להשכרה";
            // 
            // VehicleType
            // 
            this.VehicleType.FormattingEnabled = true;
            this.VehicleType.Items.AddRange(new object[] {
            "Cars",
            "Motorcycle"});
            this.VehicleType.Location = new System.Drawing.Point(540, 245);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(170, 21);
            this.VehicleType.TabIndex = 8;
            this.VehicleType.SelectedIndexChanged += new System.EventHandler(this.VehicleType_SelectedIndexChanged);
            // 
            // CarType
            // 
            this.CarType.Enabled = false;
            this.CarType.FormattingEnabled = true;
            this.CarType.Items.AddRange(new object[] {
            "Family",
            "Sports"});
            this.CarType.Location = new System.Drawing.Point(308, 245);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(170, 21);
            this.CarType.TabIndex = 9;
            this.CarType.SelectedIndexChanged += new System.EventHandler(this.CarType_SelectedIndexChanged);
            // 
            // VehicleName
            // 
            this.VehicleName.Enabled = false;
            this.VehicleName.FormattingEnabled = true;
            this.VehicleName.Items.AddRange(new object[] {
            "Family",
            "Sports"});
            this.VehicleName.Location = new System.Drawing.Point(57, 245);
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.Size = new System.Drawing.Size(170, 21);
            this.VehicleName.TabIndex = 10;
            this.VehicleName.SelectedIndexChanged += new System.EventHandler(this.VehicleName_SelectedIndexChanged);
            // 
            // AddVehicle
            // 
            this.AddVehicle.Location = new System.Drawing.Point(672, 390);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(116, 48);
            this.AddVehicle.TabIndex = 11;
            this.AddVehicle.Text = "הוספת רכב";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.VehicleName);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vehicles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VehicleType;
        private System.Windows.Forms.ComboBox CarType;
        private System.Windows.Forms.ComboBox VehicleName;
        private System.Windows.Forms.Button AddVehicle;
    }
}

