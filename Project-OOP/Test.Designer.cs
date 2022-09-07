
namespace Project_OOP
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label licensePlateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.DoorsTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.MaxSpeedTB = new System.Windows.Forms.TextBox();
            this.DistanceTB = new System.Windows.Forms.TextBox();
            this.SafetyTB = new System.Windows.Forms.TextBox();
            this.ColorTB = new System.Windows.Forms.TextBox();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.CompanyTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kidseatsnum = new System.Windows.Forms.ComboBox();
            this.kidseat = new System.Windows.Forms.CheckBox();
            this.databaseCarRental = new Project_OOP.DatabaseCarRental();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Project_OOP.DatabaseCarRentalTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.AddtoInvoice = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SeatsTB = new System.Windows.Forms.TextBox();
            this.SeatsLabel = new System.Windows.Forms.Label();
            this.StorageTB = new System.Windows.Forms.TextBox();
            this.StorageLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(27, 30);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(74, 13);
            licensePlateLabel.TabIndex = 60;
            licensePlateLabel.Text = "License Plate:";
            // 
            // DoorsTB
            // 
            this.DoorsTB.Location = new System.Drawing.Point(106, 289);
            this.DoorsTB.Name = "DoorsTB";
            this.DoorsTB.ReadOnly = true;
            this.DoorsTB.Size = new System.Drawing.Size(100, 20);
            this.DoorsTB.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Location = new System.Drawing.Point(27, 289);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(38, 13);
            this.DoorsLabel.TabIndex = 54;
            this.DoorsLabel.Text = "Doors:";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(620, 352);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 53;
            this.PriceTB.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // MaxSpeedTB
            // 
            this.MaxSpeedTB.Location = new System.Drawing.Point(106, 250);
            this.MaxSpeedTB.Name = "MaxSpeedTB";
            this.MaxSpeedTB.ReadOnly = true;
            this.MaxSpeedTB.Size = new System.Drawing.Size(100, 20);
            this.MaxSpeedTB.TabIndex = 52;
            // 
            // DistanceTB
            // 
            this.DistanceTB.Location = new System.Drawing.Point(106, 219);
            this.DistanceTB.Name = "DistanceTB";
            this.DistanceTB.ReadOnly = true;
            this.DistanceTB.Size = new System.Drawing.Size(100, 20);
            this.DistanceTB.TabIndex = 51;
            // 
            // SafetyTB
            // 
            this.SafetyTB.Location = new System.Drawing.Point(106, 189);
            this.SafetyTB.Name = "SafetyTB";
            this.SafetyTB.ReadOnly = true;
            this.SafetyTB.Size = new System.Drawing.Size(100, 20);
            this.SafetyTB.TabIndex = 50;
            // 
            // ColorTB
            // 
            this.ColorTB.Location = new System.Drawing.Point(106, 157);
            this.ColorTB.Name = "ColorTB";
            this.ColorTB.ReadOnly = true;
            this.ColorTB.Size = new System.Drawing.Size(100, 20);
            this.ColorTB.TabIndex = 49;
            // 
            // YearTB
            // 
            this.YearTB.Location = new System.Drawing.Point(106, 122);
            this.YearTB.Name = "YearTB";
            this.YearTB.ReadOnly = true;
            this.YearTB.Size = new System.Drawing.Size(100, 20);
            this.YearTB.TabIndex = 48;
            // 
            // ModelTB
            // 
            this.ModelTB.Location = new System.Drawing.Point(106, 91);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.ReadOnly = true;
            this.ModelTB.Size = new System.Drawing.Size(100, 20);
            this.ModelTB.TabIndex = 47;
            // 
            // CompanyTB
            // 
            this.CompanyTB.Location = new System.Drawing.Point(106, 58);
            this.CompanyTB.Name = "CompanyTB";
            this.CompanyTB.ReadOnly = true;
            this.CompanyTB.Size = new System.Drawing.Size(100, 20);
            this.CompanyTB.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Rental Price:";
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(27, 253);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(64, 13);
            this.MaxSpeedLabel.TabIndex = 44;
            this.MaxSpeedLabel.Text = "Max Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Distance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Company:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Safety:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Model:";
            // 
            // kidseatsnum
            // 
            this.kidseatsnum.Enabled = false;
            this.kidseatsnum.FormattingEnabled = true;
            this.kidseatsnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.kidseatsnum.Location = new System.Drawing.Point(339, 28);
            this.kidseatsnum.Name = "kidseatsnum";
            this.kidseatsnum.Size = new System.Drawing.Size(68, 21);
            this.kidseatsnum.TabIndex = 58;
            this.kidseatsnum.SelectedIndexChanged += new System.EventHandler(this.kidseatsnum_SelectedIndexChanged);
            // 
            // kidseat
            // 
            this.kidseat.AutoSize = true;
            this.kidseat.Location = new System.Drawing.Point(258, 30);
            this.kidseat.Name = "kidseat";
            this.kidseat.Size = new System.Drawing.Size(66, 17);
            this.kidseat.TabIndex = 59;
            this.kidseat.Text = "Kid Seat";
            this.kidseat.UseVisualStyleBackColor = true;
            this.kidseat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // databaseCarRental
            // 
            this.databaseCarRental.DataSetName = "DatabaseCarRental";
            this.databaseCarRental.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.databaseCarRental;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(107, 27);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.ReadOnly = true;
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateTextBox.TabIndex = 61;
            // 
            // AddtoInvoice
            // 
            this.AddtoInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddtoInvoice.ForeColor = System.Drawing.Color.Tomato;
            this.AddtoInvoice.Location = new System.Drawing.Point(477, 384);
            this.AddtoInvoice.Name = "AddtoInvoice";
            this.AddtoInvoice.Size = new System.Drawing.Size(124, 43);
            this.AddtoInvoice.TabIndex = 62;
            this.AddtoInvoice.Text = "הוסף להזמנה";
            this.AddtoInvoice.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.ForeColor = System.Drawing.Color.Tomato;
            this.backButton.Location = new System.Drawing.Point(643, 384);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 43);
            this.backButton.TabIndex = 63;
            this.backButton.Text = "חזור";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SeatsTB
            // 
            this.SeatsTB.Location = new System.Drawing.Point(107, 327);
            this.SeatsTB.Name = "SeatsTB";
            this.SeatsTB.ReadOnly = true;
            this.SeatsTB.Size = new System.Drawing.Size(100, 20);
            this.SeatsTB.TabIndex = 65;
            this.SeatsTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SeatsLabel
            // 
            this.SeatsLabel.AutoSize = true;
            this.SeatsLabel.BackColor = System.Drawing.Color.White;
            this.SeatsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeatsLabel.Location = new System.Drawing.Point(28, 327);
            this.SeatsLabel.Name = "SeatsLabel";
            this.SeatsLabel.Size = new System.Drawing.Size(37, 13);
            this.SeatsLabel.TabIndex = 64;
            this.SeatsLabel.Text = "Seats:";
            this.SeatsLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // StorageTB
            // 
            this.StorageTB.Location = new System.Drawing.Point(107, 359);
            this.StorageTB.Name = "StorageTB";
            this.StorageTB.ReadOnly = true;
            this.StorageTB.Size = new System.Drawing.Size(100, 20);
            this.StorageTB.TabIndex = 67;
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.BackColor = System.Drawing.Color.White;
            this.StorageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StorageLabel.Location = new System.Drawing.Point(28, 359);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(47, 13);
            this.StorageLabel.TabIndex = 66;
            this.StorageLabel.Text = "Storage:";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StorageTB);
            this.Controls.Add(this.StorageLabel);
            this.Controls.Add(this.SeatsTB);
            this.Controls.Add(this.SeatsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AddtoInvoice);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(this.kidseat);
            this.Controls.Add(this.kidseatsnum);
            this.Controls.Add(this.DoorsTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoorsLabel);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.MaxSpeedTB);
            this.Controls.Add(this.DistanceTB);
            this.Controls.Add(this.SafetyTB);
            this.Controls.Add(this.ColorTB);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.CompanyTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MaxSpeedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "FamilyCar";
            this.Load += new System.EventHandler(this.FamilyCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DoorsTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DoorsLabel;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox MaxSpeedTB;
        private System.Windows.Forms.TextBox DistanceTB;
        private System.Windows.Forms.TextBox SafetyTB;
        private System.Windows.Forms.TextBox ColorTB;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox CompanyTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kidseatsnum;
        private System.Windows.Forms.CheckBox kidseat;
        private DatabaseCarRental databaseCarRental;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DatabaseCarRentalTableAdapters.CarTableAdapter carTableAdapter;
        private DatabaseCarRentalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.Button AddtoInvoice;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox SeatsTB;
        private System.Windows.Forms.Label SeatsLabel;
        private System.Windows.Forms.TextBox StorageTB;
        private System.Windows.Forms.Label StorageLabel;
    }
}