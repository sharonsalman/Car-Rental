
namespace Project_OOP
{
    partial class Vehicle
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
            this.VehicleType = new System.Windows.Forms.Label();
            this.CarType = new System.Windows.Forms.Label();
            this.VehicleName = new System.Windows.Forms.Label();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicleName = new System.Windows.Forms.ComboBox();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VehicleType
            // 
            this.VehicleType.AutoSize = true;
            this.VehicleType.Location = new System.Drawing.Point(710, 70);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(55, 13);
            this.VehicleType.TabIndex = 0;
            this.VehicleType.Text = "סוג הרכב";
            // 
            // CarType
            // 
            this.CarType.AutoSize = true;
            this.CarType.Location = new System.Drawing.Point(701, 123);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(64, 13);
            this.CarType.TabIndex = 1;
            this.CarType.Text = "סוג מכונית";
            this.CarType.Click += new System.EventHandler(this.CarType_Click);
            // 
            // VehicleName
            // 
            this.VehicleName.AutoSize = true;
            this.VehicleName.Location = new System.Drawing.Point(712, 181);
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.Size = new System.Drawing.Size(53, 13);
            this.VehicleName.TabIndex = 2;
            this.VehicleName.Text = "שם הרכב";
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Items.AddRange(new object[] {
            "Motorcycle",
            "Car"});
            this.comboBoxVehicleType.Location = new System.Drawing.Point(543, 67);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleType.TabIndex = 3;
            this.comboBoxVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicleType_SelectedIndexChanged);
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.Enabled = false;
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "Family Car",
            "Sport Car"});
            this.comboBoxCarType.Location = new System.Drawing.Point(543, 123);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarType.TabIndex = 4;
            this.comboBoxCarType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarType_SelectedIndexChanged);
            // 
            // comboBoxVehicleName
            // 
            this.comboBoxVehicleName.Enabled = false;
            this.comboBoxVehicleName.FormattingEnabled = true;
            this.comboBoxVehicleName.Location = new System.Drawing.Point(543, 173);
            this.comboBoxVehicleName.Name = "comboBoxVehicleName";
            this.comboBoxVehicleName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleName.TabIndex = 5;
            // 
            // AddVehicle
            // 
            this.AddVehicle.Location = new System.Drawing.Point(665, 383);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(123, 55);
            this.AddVehicle.TabIndex = 6;
            this.AddVehicle.Text = "הוספת רכב";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.comboBoxVehicleName);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.comboBoxVehicleType);
            this.Controls.Add(this.VehicleName);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.VehicleType);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VehicleType;
        private System.Windows.Forms.Label CarType;
        private System.Windows.Forms.Label VehicleName;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.ComboBox comboBoxVehicleName;
        private System.Windows.Forms.Button AddVehicle;
    }
}