
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.AddVehicle = new System.Windows.Forms.Button();
            this.databaseDataSet = new Project_OOP.DatabaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Project_OOP.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.CarSearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddVehicle
            // 
            this.AddVehicle.BackColor = System.Drawing.SystemColors.Menu;
            this.AddVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVehicle.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddVehicle.Location = new System.Drawing.Point(32, 299);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(186, 55);
            this.AddVehicle.TabIndex = 6;
            this.AddVehicle.Text = "הוספת רכב";
            this.AddVehicle.UseVisualStyleBackColor = false;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // CarSearchButton
            // 
            this.CarSearchButton.BackColor = System.Drawing.SystemColors.Menu;
            this.CarSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarSearchButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CarSearchButton.Location = new System.Drawing.Point(276, 299);
            this.CarSearchButton.Name = "CarSearchButton";
            this.CarSearchButton.Size = new System.Drawing.Size(186, 55);
            this.CarSearchButton.TabIndex = 7;
            this.CarSearchButton.Text = "רשימת רכבים";
            this.CarSearchButton.UseVisualStyleBackColor = false;
            this.CarSearchButton.Click += new System.EventHandler(this.CarSearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(530, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "הוספת לקוח חדש";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarSearchButton);
            this.Controls.Add(this.AddVehicle);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddVehicle;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button CarSearchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}