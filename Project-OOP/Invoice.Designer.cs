
namespace Project_OOP
{
    partial class Invoice
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label CarLicenseLabel;
            System.Windows.Forms.Label PriceLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CarLicenseTB = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.invoiceNumberTB = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCarRental = new Project_OOP.DatabaseCarRental();
            this.invoiceTableAdapter = new Project_OOP.DatabaseCarRentalTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager();
            dateLabel = new System.Windows.Forms.Label();
            CarLicenseLabel = new System.Windows.Forms.Label();
            PriceLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(260, 299);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 74;
            dateLabel.Text = "Date:";
            // 
            // CarLicenseLabel
            // 
            CarLicenseLabel.AutoSize = true;
            CarLicenseLabel.Location = new System.Drawing.Point(260, 324);
            CarLicenseLabel.Name = "CarLicenseLabel";
            CarLicenseLabel.Size = new System.Drawing.Size(66, 13);
            CarLicenseLabel.TabIndex = 76;
            CarLicenseLabel.Text = "Car License:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new System.Drawing.Point(260, 350);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new System.Drawing.Size(34, 13);
            PriceLabel.TabIndex = 81;
            PriceLabel.Text = "Price:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(260, 271);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            invoiceNumberLabel.TabIndex = 78;
            invoiceNumberLabel.Text = "Invoice Number:";
            invoiceNumberLabel.Click += new System.EventHandler(this.customeridLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
            this.dateDateTimePicker.Enabled = false;
            this.dateDateTimePicker.Location = new System.Drawing.Point(351, 295);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 75;
            // 
            // CarLicenseTB
            // 
            this.CarLicenseTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Car_License", true));
            this.CarLicenseTB.Location = new System.Drawing.Point(351, 321);
            this.CarLicenseTB.Name = "CarLicenseTB";
            this.CarLicenseTB.ReadOnly = true;
            this.CarLicenseTB.Size = new System.Drawing.Size(200, 20);
            this.CarLicenseTB.TabIndex = 77;
            // 
            // PayButton
            // 
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayButton.ForeColor = System.Drawing.Color.Tomato;
            this.PayButton.Location = new System.Drawing.Point(325, 431);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(210, 90);
            this.PayButton.TabIndex = 80;
            this.PayButton.Text = "מעבר לתשלום";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.Pay_Click);
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(351, 347);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.Size = new System.Drawing.Size(200, 20);
            this.PriceTB.TabIndex = 82;
            // 
            // invoiceNumberTB
            // 
            this.invoiceNumberTB.Location = new System.Drawing.Point(351, 268);
            this.invoiceNumberTB.Name = "invoiceNumberTB";
            this.invoiceNumberTB.ReadOnly = true;
            this.invoiceNumberTB.Size = new System.Drawing.Size(200, 20);
            this.invoiceNumberTB.TabIndex = 79;
            // 
            // ReturnButton
            // 
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.ForeColor = System.Drawing.Color.Tomato;
            this.ReturnButton.Location = new System.Drawing.Point(12, 53);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(94, 40);
            this.ReturnButton.TabIndex = 83;
            this.ReturnButton.Text = "חזרה";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.databaseCarRental;
            // 
            // databaseCarRental
            // 
            this.databaseCarRental.DataSetName = "DatabaseCarRental";
            this.databaseCarRental.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(PriceLabel);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(CarLicenseLabel);
            this.Controls.Add(this.CarLicenseTB);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseCarRental databaseCarRental;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DatabaseCarRentalTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private DatabaseCarRentalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox CarLicenseTB;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox invoiceNumberTB;
        private System.Windows.Forms.Button ReturnButton;
    }
}