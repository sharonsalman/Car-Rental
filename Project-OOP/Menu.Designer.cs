
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
            this.Invoice = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 70);
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
            this.AddVehicle.Location = new System.Drawing.Point(162, 465);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(167, 53);
            this.AddVehicle.TabIndex = 1;
            this.AddVehicle.Text = "הוספת רכב";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // Invoice
            // 
            this.Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Invoice.ForeColor = System.Drawing.Color.Tomato;
            this.Invoice.Location = new System.Drawing.Point(406, 465);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(167, 53);
            this.Invoice.TabIndex = 2;
            this.Invoice.Text = "בדיקת הזמנה";
            this.Invoice.UseVisualStyleBackColor = true;
            this.Invoice.Click += new System.EventHandler(this.Invoice_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCustomer.ForeColor = System.Drawing.Color.Tomato;
            this.AddCustomer.Location = new System.Drawing.Point(650, 465);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(167, 53);
            this.AddCustomer.TabIndex = 3;
            this.AddCustomer.Text = "הוספת לקוח חדש";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.Invoice);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.Button Invoice;
        private System.Windows.Forms.Button AddCustomer;
    }
}