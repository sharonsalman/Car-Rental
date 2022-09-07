
namespace Project_OOP
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.VehicleList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddVehicle
            // 
            this.AddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVehicle.ForeColor = System.Drawing.Color.Tomato;
            this.AddVehicle.Location = new System.Drawing.Point(120, 379);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(211, 105);
            this.AddVehicle.TabIndex = 1;
            this.AddVehicle.Text = "הוספת רכב";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // VehicleList
            // 
            this.VehicleList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VehicleList.ForeColor = System.Drawing.Color.Tomato;
            this.VehicleList.Location = new System.Drawing.Point(472, 379);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Size = new System.Drawing.Size(202, 105);
            this.VehicleList.TabIndex = 4;
            this.VehicleList.Text = "רשימת רכבים";
            this.VehicleList.UseVisualStyleBackColor = true;
            this.VehicleList.Click += new System.EventHandler(this.VehicleList_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 579);
            this.Controls.Add(this.VehicleList);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.Button VehicleList;
    }
}