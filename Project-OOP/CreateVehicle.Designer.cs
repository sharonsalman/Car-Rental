
namespace Project_OOP
{
    partial class CreateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehicle));
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label vehicleNameLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label safetyLabel;
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label seatsLabel;
            System.Windows.Forms.Label storageLabel;
            System.Windows.Forms.Label maxSpeedLabel;
            System.Windows.Forms.Label fuelPerKMLabel;
            System.Windows.Forms.Label typeLabel;
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.databaseCarRental = new Project_OOP.DatabaseCarRental();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Project_OOP.DatabaseCarRentalTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager();
            this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.carBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.safetyTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.storageTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.fuelPerKMTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            licensePlateLabel = new System.Windows.Forms.Label();
            vehicleNameLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            safetyLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            seatsLabel = new System.Windows.Forms.Label();
            storageLabel = new System.Windows.Forms.Label();
            maxSpeedLabel = new System.Windows.Forms.Label();
            fuelPerKMLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
            this.carBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Tomato;
            this.Delete.Location = new System.Drawing.Point(641, 543);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(167, 53);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "מחיקה";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.ForeColor = System.Drawing.Color.Tomato;
            this.Save.Location = new System.Drawing.Point(397, 543);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(167, 53);
            this.Save.TabIndex = 6;
            this.Save.Text = "שמירה";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BackMenu
            // 
            this.BackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackMenu.ForeColor = System.Drawing.Color.Tomato;
            this.BackMenu.Location = new System.Drawing.Point(153, 543);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(167, 53);
            this.BackMenu.TabIndex = 5;
            this.BackMenu.Text = "חזרה לתפריט הראשי";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_OOP.DatabaseCarRentalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carBindingNavigator
            // 
            this.carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carBindingNavigator.BindingSource = this.carBindingSource;
            this.carBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carBindingNavigatorSaveItem});
            this.carBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBindingNavigator.Name = "carBindingNavigator";
            this.carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.carBindingNavigator.TabIndex = 8;
            this.carBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // carBindingNavigatorSaveItem
            // 
            this.carBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carBindingNavigatorSaveItem.Image")));
            this.carBindingNavigatorSaveItem.Name = "carBindingNavigatorSaveItem";
            this.carBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carBindingNavigatorSaveItem.Text = "Save Data";
            this.carBindingNavigatorSaveItem.Click += new System.EventHandler(this.carBindingNavigatorSaveItem_Click);
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(36, 222);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(74, 13);
            licensePlateLabel.TabIndex = 8;
            licensePlateLabel.Text = "License Plate:";
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(127, 219);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateTextBox.TabIndex = 9;
            // 
            // vehicleNameLabel
            // 
            vehicleNameLabel.AutoSize = true;
            vehicleNameLabel.Location = new System.Drawing.Point(36, 248);
            vehicleNameLabel.Name = "vehicleNameLabel";
            vehicleNameLabel.Size = new System.Drawing.Size(76, 13);
            vehicleNameLabel.TabIndex = 10;
            vehicleNameLabel.Text = "Vehicle Name:";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "VehicleName", true));
            this.vehicleNameTextBox.Location = new System.Drawing.Point(127, 245);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTextBox.TabIndex = 11;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(36, 274);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 12;
            colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(127, 271);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 13;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(36, 300);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 14;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(127, 297);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 15;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(36, 326);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(127, 323);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            // 
            // safetyLabel
            // 
            safetyLabel.AutoSize = true;
            safetyLabel.Location = new System.Drawing.Point(36, 352);
            safetyLabel.Name = "safetyLabel";
            safetyLabel.Size = new System.Drawing.Size(40, 13);
            safetyLabel.TabIndex = 18;
            safetyLabel.Text = "Safety:";
            // 
            // safetyTextBox
            // 
            this.safetyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Safety", true));
            this.safetyTextBox.Location = new System.Drawing.Point(127, 349);
            this.safetyTextBox.Name = "safetyTextBox";
            this.safetyTextBox.Size = new System.Drawing.Size(100, 20);
            this.safetyTextBox.TabIndex = 19;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(36, 378);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(52, 13);
            distanceLabel.TabIndex = 20;
            distanceLabel.Text = "Distance:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(127, 375);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 21;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(36, 404);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 22;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(127, 401);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 23;
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(526, 245);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(38, 13);
            doorsLabel.TabIndex = 24;
            doorsLabel.Text = "Doors:";
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Doors", true));
            this.doorsTextBox.Location = new System.Drawing.Point(617, 242);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.doorsTextBox.TabIndex = 25;
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new System.Drawing.Point(526, 271);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new System.Drawing.Size(37, 13);
            seatsLabel.TabIndex = 26;
            seatsLabel.Text = "Seats:";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Seats", true));
            this.seatsTextBox.Location = new System.Drawing.Point(617, 268);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.seatsTextBox.TabIndex = 27;
            // 
            // storageLabel
            // 
            storageLabel.AutoSize = true;
            storageLabel.Location = new System.Drawing.Point(526, 297);
            storageLabel.Name = "storageLabel";
            storageLabel.Size = new System.Drawing.Size(47, 13);
            storageLabel.TabIndex = 28;
            storageLabel.Text = "Storage:";
            // 
            // storageTextBox
            // 
            this.storageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Storage", true));
            this.storageTextBox.Location = new System.Drawing.Point(617, 294);
            this.storageTextBox.Name = "storageTextBox";
            this.storageTextBox.Size = new System.Drawing.Size(100, 20);
            this.storageTextBox.TabIndex = 29;
            // 
            // maxSpeedLabel
            // 
            maxSpeedLabel.AutoSize = true;
            maxSpeedLabel.Location = new System.Drawing.Point(526, 401);
            maxSpeedLabel.Name = "maxSpeedLabel";
            maxSpeedLabel.Size = new System.Drawing.Size(64, 13);
            maxSpeedLabel.TabIndex = 30;
            maxSpeedLabel.Text = "Max Speed:";
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "MaxSpeed", true));
            this.maxSpeedTextBox.Location = new System.Drawing.Point(617, 398);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxSpeedTextBox.TabIndex = 31;
            // 
            // fuelPerKMLabel
            // 
            fuelPerKMLabel.AutoSize = true;
            fuelPerKMLabel.Location = new System.Drawing.Point(526, 326);
            fuelPerKMLabel.Name = "fuelPerKMLabel";
            fuelPerKMLabel.Size = new System.Drawing.Size(68, 13);
            fuelPerKMLabel.TabIndex = 32;
            fuelPerKMLabel.Text = "Fuel Per KM:";
            // 
            // fuelPerKMTextBox
            // 
            this.fuelPerKMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "FuelPerKM", true));
            this.fuelPerKMTextBox.Location = new System.Drawing.Point(617, 323);
            this.fuelPerKMTextBox.Name = "fuelPerKMTextBox";
            this.fuelPerKMTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelPerKMTextBox.TabIndex = 33;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(36, 432);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 34;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(127, 429);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 35;
            // 
            // CreateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(vehicleNameLabel);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(safetyLabel);
            this.Controls.Add(this.safetyTextBox);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(doorsLabel);
            this.Controls.Add(this.doorsTextBox);
            this.Controls.Add(seatsLabel);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(storageLabel);
            this.Controls.Add(this.storageTextBox);
            this.Controls.Add(maxSpeedLabel);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(fuelPerKMLabel);
            this.Controls.Add(this.fuelPerKMTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.carBindingNavigator);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateVehicle";
            this.Text = "CreateVehicle";
            this.Load += new System.EventHandler(this.CreateVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCarRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
            this.carBindingNavigator.ResumeLayout(false);
            this.carBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseCarRental databaseCarRental;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DatabaseCarRentalTableAdapters.CarTableAdapter carTableAdapter;
        private DatabaseCarRentalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox safetyTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox storageTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.TextBox fuelPerKMTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}