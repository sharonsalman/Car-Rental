
namespace Project_OOP
{
    partial class CreateVehicles
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
            System.Windows.Forms.Label storageLabel;
            System.Windows.Forms.Label seatsLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label safetyLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label vehicleNameLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label fuelPerKMLabel;
            System.Windows.Forms.Label maxSpeedLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehicles));
            this.storageTextBox = new System.Windows.Forms.TextBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.safetyTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.databaseDataOOP = new Project_OOP.DatabaseDataOOP();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Project_OOP.DatabaseDataOOPTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Project_OOP.DatabaseDataOOPTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.fuelPerKMTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            storageLabel = new System.Windows.Forms.Label();
            seatsLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            safetyLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            vehicleNameLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            fuelPerKMLabel = new System.Windows.Forms.Label();
            maxSpeedLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataOOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storageLabel
            // 
            storageLabel.AutoSize = true;
            storageLabel.Location = new System.Drawing.Point(261, 153);
            storageLabel.Name = "storageLabel";
            storageLabel.Size = new System.Drawing.Size(47, 13);
            storageLabel.TabIndex = 67;
            storageLabel.Text = "Storage:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new System.Drawing.Point(261, 123);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new System.Drawing.Size(37, 13);
            seatsLabel.TabIndex = 64;
            seatsLabel.Text = "Seats:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(260, 94);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(38, 13);
            doorsLabel.TabIndex = 62;
            doorsLabel.Text = "Doors:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 233);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 61;
            yearLabel.Text = "Year:";
            // 
            // safetyLabel
            // 
            safetyLabel.AutoSize = true;
            safetyLabel.Location = new System.Drawing.Point(12, 200);
            safetyLabel.Name = "safetyLabel";
            safetyLabel.Size = new System.Drawing.Size(40, 13);
            safetyLabel.TabIndex = 59;
            safetyLabel.Text = "Safety:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 170);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 57;
            colorLabel.Text = "Color:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(12, 140);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 55;
            companyNameLabel.Text = "Company Name:";
            // 
            // vehicleNameLabel
            // 
            vehicleNameLabel.AutoSize = true;
            vehicleNameLabel.Location = new System.Drawing.Point(12, 108);
            vehicleNameLabel.Name = "vehicleNameLabel";
            vehicleNameLabel.Size = new System.Drawing.Size(76, 13);
            vehicleNameLabel.TabIndex = 53;
            vehicleNameLabel.Text = "Vehicle Name:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(12, 81);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(74, 13);
            licensePlateLabel.TabIndex = 72;
            licensePlateLabel.Text = "License Plate:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(15, 47);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 73;
            typeLabel.Text = "Type:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 260);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 74;
            priceLabel.Text = "Price:";
            // 
            // fuelPerKMLabel
            // 
            fuelPerKMLabel.AutoSize = true;
            fuelPerKMLabel.Location = new System.Drawing.Point(260, 69);
            fuelPerKMLabel.Name = "fuelPerKMLabel";
            fuelPerKMLabel.Size = new System.Drawing.Size(68, 13);
            fuelPerKMLabel.TabIndex = 75;
            fuelPerKMLabel.Text = "Fuel Per KM:";
            // 
            // maxSpeedLabel
            // 
            maxSpeedLabel.AutoSize = true;
            maxSpeedLabel.Location = new System.Drawing.Point(561, 66);
            maxSpeedLabel.Name = "maxSpeedLabel";
            maxSpeedLabel.Size = new System.Drawing.Size(64, 13);
            maxSpeedLabel.TabIndex = 76;
            maxSpeedLabel.Text = "Max Speed:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(13, 304);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 77;
            imageLabel.Text = "Image:";
            // 
            // storageTextBox
            // 
            this.storageTextBox.Location = new System.Drawing.Point(314, 150);
            this.storageTextBox.Name = "storageTextBox";
            this.storageTextBox.Size = new System.Drawing.Size(42, 20);
            this.storageTextBox.TabIndex = 68;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(304, 120);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(39, 20);
            this.seatsTextBox.TabIndex = 66;
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.Location = new System.Drawing.Point(304, 91);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(39, 20);
            this.doorsTextBox.TabIndex = 65;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(50, 230);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(60, 20);
            this.yearTextBox.TabIndex = 63;
            // 
            // safetyTextBox
            // 
            this.safetyTextBox.Location = new System.Drawing.Point(58, 197);
            this.safetyTextBox.Name = "safetyTextBox";
            this.safetyTextBox.Size = new System.Drawing.Size(39, 20);
            this.safetyTextBox.TabIndex = 60;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(52, 167);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(58, 20);
            this.colorTextBox.TabIndex = 58;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(103, 137);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 56;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(94, 105);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTextBox.TabIndex = 54;
            // 
            // databaseDataOOP
            // 
            this.databaseDataOOP.DataSetName = "DatabaseDataOOP";
            this.databaseDataOOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataOOP;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_OOP.DatabaseDataOOPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tableBindingNavigator.TabIndex = 72;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(92, 78);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateTextBox.TabIndex = 73;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Bikes",
            "Family car",
            "Sports car"});
            this.typeComboBox.Location = new System.Drawing.Point(55, 44);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 74;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(52, 257);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 75;
            // 
            // fuelPerKMTextBox
            // 
            this.fuelPerKMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "FuelPerKM", true));
            this.fuelPerKMTextBox.Location = new System.Drawing.Point(334, 66);
            this.fuelPerKMTextBox.Name = "fuelPerKMTextBox";
            this.fuelPerKMTextBox.Size = new System.Drawing.Size(48, 20);
            this.fuelPerKMTextBox.TabIndex = 76;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "MaxSpeed", true));
            this.maxSpeedTextBox.Location = new System.Drawing.Point(631, 63);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(39, 20);
            this.maxSpeedTextBox.TabIndex = 77;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(58, 304);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(145, 106);
            this.imagePictureBox.TabIndex = 78;
            this.imagePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Only for Family car:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Only for Sports car/Bikes:";
            // 
            // CreateVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(maxSpeedLabel);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(fuelPerKMLabel);
            this.Controls.Add(this.fuelPerKMTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(storageLabel);
            this.Controls.Add(this.storageTextBox);
            this.Controls.Add(seatsLabel);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(doorsLabel);
            this.Controls.Add(this.doorsTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(safetyLabel);
            this.Controls.Add(this.safetyTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(vehicleNameLabel);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Name = "CreateVehicles";
            this.Text = "CreateVehicles";
            this.Load += new System.EventHandler(this.CreateVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataOOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox storageTextBox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox safetyTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private DatabaseDataOOP databaseDataOOP;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataOOPTableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseDataOOPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox fuelPerKMTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}