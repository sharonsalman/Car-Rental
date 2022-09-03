
namespace Project_OOP
{
    partial class FamilyCar
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
            System.Windows.Forms.Label vehicleNameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label safetyLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label doorsLabel;
            System.Windows.Forms.Label seatsLabel;
            System.Windows.Forms.Label storageLabel;
            System.Windows.Forms.Label kidSeatHowMuchLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyCar));
            System.Windows.Forms.Label priceLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataOOP = new Project_OOP.DatabaseDataOOP();
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
            this.tableTableAdapter = new Project_OOP.DatabaseDataOOPTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Project_OOP.DatabaseDataOOPTableAdapters.TableAdapterManager();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.safetyTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.storageTextBox = new System.Windows.Forms.TextBox();
            this.kidSeatRadioButton = new System.Windows.Forms.RadioButton();
            this.kidSeatHowMuchComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            vehicleNameLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            safetyLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            doorsLabel = new System.Windows.Forms.Label();
            seatsLabel = new System.Windows.Forms.Label();
            storageLabel = new System.Windows.Forms.Label();
            kidSeatHowMuchLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataOOP)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleNameLabel
            // 
            vehicleNameLabel.AutoSize = true;
            vehicleNameLabel.Location = new System.Drawing.Point(12, 53);
            vehicleNameLabel.Name = "vehicleNameLabel";
            vehicleNameLabel.Size = new System.Drawing.Size(76, 13);
            vehicleNameLabel.TabIndex = 42;
            vehicleNameLabel.Text = "Vehicle Name:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(12, 85);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 43;
            companyNameLabel.Text = "Company Name:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 115);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 44;
            colorLabel.Text = "Color:";
            // 
            // safetyLabel
            // 
            safetyLabel.AutoSize = true;
            safetyLabel.Location = new System.Drawing.Point(12, 145);
            safetyLabel.Name = "safetyLabel";
            safetyLabel.Size = new System.Drawing.Size(40, 13);
            safetyLabel.TabIndex = 45;
            safetyLabel.Text = "Safety:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 178);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 46;
            yearLabel.Text = "Year:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Location = new System.Drawing.Point(14, 207);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new System.Drawing.Size(38, 13);
            doorsLabel.TabIndex = 47;
            doorsLabel.Text = "Doors:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new System.Drawing.Point(15, 236);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new System.Drawing.Size(37, 13);
            seatsLabel.TabIndex = 48;
            seatsLabel.Text = "Seats:";
            // 
            // storageLabel
            // 
            storageLabel.AutoSize = true;
            storageLabel.Location = new System.Drawing.Point(15, 266);
            storageLabel.Name = "storageLabel";
            storageLabel.Size = new System.Drawing.Size(47, 13);
            storageLabel.TabIndex = 49;
            storageLabel.Text = "Storage:";
            // 
            // kidSeatHowMuchLabel
            // 
            kidSeatHowMuchLabel.AutoSize = true;
            kidSeatHowMuchLabel.Location = new System.Drawing.Point(113, 306);
            kidSeatHowMuchLabel.Name = "kidSeatHowMuchLabel";
            kidSeatHowMuchLabel.Size = new System.Drawing.Size(62, 13);
            kidSeatHowMuchLabel.TabIndex = 51;
            kidSeatHowMuchLabel.Text = "How Much:";
            kidSeatHowMuchLabel.Click += new System.EventHandler(this.kidSeatHowMuchLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
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
            this.tableBindingNavigator.TabIndex = 42;
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
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataOOP;
            // 
            // databaseDataOOP
            // 
            this.databaseDataOOP.DataSetName = "DatabaseDataOOP";
            this.databaseDataOOP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "VehicleName", true));
            this.vehicleNameTextBox.Location = new System.Drawing.Point(94, 50);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTextBox.TabIndex = 43;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(103, 82);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 44;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(52, 112);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(58, 20);
            this.colorTextBox.TabIndex = 45;
            // 
            // safetyTextBox
            // 
            this.safetyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Safety", true));
            this.safetyTextBox.Location = new System.Drawing.Point(58, 142);
            this.safetyTextBox.Name = "safetyTextBox";
            this.safetyTextBox.Size = new System.Drawing.Size(39, 20);
            this.safetyTextBox.TabIndex = 46;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(50, 175);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(60, 20);
            this.yearTextBox.TabIndex = 47;
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Doors", true));
            this.doorsTextBox.Location = new System.Drawing.Point(58, 204);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(39, 20);
            this.doorsTextBox.TabIndex = 48;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Seats", true));
            this.seatsTextBox.Location = new System.Drawing.Point(58, 233);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(39, 20);
            this.seatsTextBox.TabIndex = 49;
            // 
            // storageTextBox
            // 
            this.storageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Storage", true));
            this.storageTextBox.Location = new System.Drawing.Point(68, 263);
            this.storageTextBox.Name = "storageTextBox";
            this.storageTextBox.Size = new System.Drawing.Size(42, 20);
            this.storageTextBox.TabIndex = 50;
            // 
            // kidSeatRadioButton
            // 
            this.kidSeatRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tableBindingSource, "KidSeat", true));
            this.kidSeatRadioButton.Location = new System.Drawing.Point(18, 300);
            this.kidSeatRadioButton.Name = "kidSeatRadioButton";
            this.kidSeatRadioButton.Size = new System.Drawing.Size(104, 24);
            this.kidSeatRadioButton.TabIndex = 51;
            this.kidSeatRadioButton.TabStop = true;
            this.kidSeatRadioButton.Text = "Kids Seat";
            this.kidSeatRadioButton.UseVisualStyleBackColor = true;
            this.kidSeatRadioButton.CheckedChanged += new System.EventHandler(this.kidSeatRadioButton_CheckedChanged);
            // 
            // kidSeatHowMuchComboBox
            // 
            this.kidSeatHowMuchComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "KidSeatHowMuch", true));
            this.kidSeatHowMuchComboBox.Enabled = false;
            this.kidSeatHowMuchComboBox.FormattingEnabled = true;
            this.kidSeatHowMuchComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.kidSeatHowMuchComboBox.Location = new System.Drawing.Point(190, 303);
            this.kidSeatHowMuchComboBox.Name = "kidSeatHowMuchComboBox";
            this.kidSeatHowMuchComboBox.Size = new System.Drawing.Size(56, 21);
            this.kidSeatHowMuchComboBox.TabIndex = 52;
            this.kidSeatHowMuchComboBox.SelectedIndexChanged += new System.EventHandler(this.kidSeatHowMuchComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(449, 366);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 52;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(489, 363);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 53;
            // 
            // FamilyCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(kidSeatHowMuchLabel);
            this.Controls.Add(this.kidSeatHowMuchComboBox);
            this.Controls.Add(this.kidSeatRadioButton);
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
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FamilyCar";
            this.Text = "FamilyCar";
            this.Load += new System.EventHandler(this.FamilyCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataOOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox safetyTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox storageTextBox;
        private System.Windows.Forms.RadioButton kidSeatRadioButton;
        private System.Windows.Forms.ComboBox kidSeatHowMuchComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}