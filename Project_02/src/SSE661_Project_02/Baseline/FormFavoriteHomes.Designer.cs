//using SSE660_Project_01;

namespace Baseline
{
    partial class FormFavoriteHomes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBedrooms = new System.Windows.Forms.Label();
            this.labelBathrooms = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelYearBuilt = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxBedrooms = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBathrooms = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSize = new System.Windows.Forms.MaskedTextBox();
            this.textBoxYearBuilt = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.maskedBoxZip = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxState = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedroomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bathroomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBuiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerSqFtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteHomesDataset = new Baseline.FavoriteHomesDataset();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.favoriteHomesDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteHomesDataset)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteHomesDatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.labelAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBedrooms, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBathrooms, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSize, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelYearBuilt, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStreet, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBedrooms, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBathrooms, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSize, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYearBuilt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedBoxZip, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedBoxState, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 301);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(186, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBedrooms
            // 
            this.labelBedrooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBedrooms.AutoSize = true;
            this.labelBedrooms.Location = new System.Drawing.Point(195, 0);
            this.labelBedrooms.Name = "labelBedrooms";
            this.labelBedrooms.Size = new System.Drawing.Size(90, 13);
            this.labelBedrooms.TabIndex = 0;
            this.labelBedrooms.Text = "Bedrooms";
            this.labelBedrooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBathrooms
            // 
            this.labelBathrooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBathrooms.AutoSize = true;
            this.labelBathrooms.Location = new System.Drawing.Point(291, 0);
            this.labelBathrooms.Name = "labelBathrooms";
            this.labelBathrooms.Size = new System.Drawing.Size(90, 13);
            this.labelBathrooms.TabIndex = 0;
            this.labelBathrooms.Text = "Bathrooms";
            this.labelBathrooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSize
            // 
            this.labelSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(387, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(90, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size (sq. ft.)";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYearBuilt
            // 
            this.labelYearBuilt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYearBuilt.AutoSize = true;
            this.labelYearBuilt.Location = new System.Drawing.Point(483, 0);
            this.labelYearBuilt.Name = "labelYearBuilt";
            this.labelYearBuilt.Size = new System.Drawing.Size(90, 13);
            this.labelYearBuilt.TabIndex = 0;
            this.labelYearBuilt.Text = "Year Built";
            this.labelYearBuilt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(579, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(93, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStreet.Location = new System.Drawing.Point(3, 28);
            this.textBoxStreet.MaxLength = 26;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(186, 20);
            this.textBoxStreet.TabIndex = 0;
            this.textBoxStreet.Text = "Street";
            // 
            // textBoxBedrooms
            // 
            this.textBoxBedrooms.Location = new System.Drawing.Point(195, 28);
            this.textBoxBedrooms.Mask = "0";
            this.textBoxBedrooms.Name = "textBoxBedrooms";
            this.textBoxBedrooms.PromptChar = ' ';
            this.textBoxBedrooms.Size = new System.Drawing.Size(78, 20);
            this.textBoxBedrooms.TabIndex = 4;
            this.textBoxBedrooms.Text = "0";
            this.textBoxBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBathrooms
            // 
            this.textBoxBathrooms.Location = new System.Drawing.Point(291, 28);
            this.textBoxBathrooms.Mask = "0";
            this.textBoxBathrooms.Name = "textBoxBathrooms";
            this.textBoxBathrooms.PromptChar = ' ';
            this.textBoxBathrooms.Size = new System.Drawing.Size(78, 20);
            this.textBoxBathrooms.TabIndex = 5;
            this.textBoxBathrooms.Text = "0";
            this.textBoxBathrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(387, 28);
            this.textBoxSize.Mask = "0000";
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.PromptChar = ' ';
            this.textBoxSize.Size = new System.Drawing.Size(78, 20);
            this.textBoxSize.TabIndex = 6;
            this.textBoxSize.Text = "1000";
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxYearBuilt
            // 
            this.textBoxYearBuilt.Location = new System.Drawing.Point(483, 28);
            this.textBoxYearBuilt.Mask = "0000";
            this.textBoxYearBuilt.Name = "textBoxYearBuilt";
            this.textBoxYearBuilt.PromptChar = ' ';
            this.textBoxYearBuilt.Size = new System.Drawing.Size(78, 20);
            this.textBoxYearBuilt.TabIndex = 7;
            this.textBoxYearBuilt.Text = "2000";
            this.textBoxYearBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(579, 28);
            this.textBoxPrice.Mask = "$999999";
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PromptChar = ' ';
            this.textBoxPrice.Size = new System.Drawing.Size(78, 20);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.Text = "000000";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCity.Location = new System.Drawing.Point(3, 54);
            this.textBoxCity.MaxLength = 26;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(186, 20);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.Text = "City";
            // 
            // maskedBoxZip
            // 
            this.maskedBoxZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBoxZip.Location = new System.Drawing.Point(3, 106);
            this.maskedBoxZip.Mask = "00000";
            this.maskedBoxZip.Name = "maskedBoxZip";
            this.maskedBoxZip.PromptChar = ' ';
            this.maskedBoxZip.Size = new System.Drawing.Size(186, 20);
            this.maskedBoxZip.TabIndex = 3;
            this.maskedBoxZip.Text = "00000";
            this.maskedBoxZip.ValidatingType = typeof(int);
            // 
            // maskedBoxState
            // 
            this.maskedBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedBoxState.Location = new System.Drawing.Point(3, 80);
            this.maskedBoxState.Mask = ">LL";
            this.maskedBoxState.Name = "maskedBoxState";
            this.maskedBoxState.PromptChar = ' ';
            this.maskedBoxState.Size = new System.Drawing.Size(186, 20);
            this.maskedBoxState.TabIndex = 2;
            this.maskedBoxState.Text = "XX";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 295);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.bedroomsDataGridViewTextBoxColumn,
            this.bathroomsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.yearBuiltDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.pricePerSqFtDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dtBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(698, 271);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_RowStateChanged);
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedroomsDataGridViewTextBoxColumn
            // 
            this.bedroomsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bedroomsDataGridViewTextBoxColumn.DataPropertyName = "Bedrooms";
            this.bedroomsDataGridViewTextBoxColumn.HeaderText = "Bedrooms";
            this.bedroomsDataGridViewTextBoxColumn.Name = "bedroomsDataGridViewTextBoxColumn";
            this.bedroomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bathroomsDataGridViewTextBoxColumn
            // 
            this.bathroomsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bathroomsDataGridViewTextBoxColumn.DataPropertyName = "Bathrooms";
            this.bathroomsDataGridViewTextBoxColumn.HeaderText = "Bathrooms";
            this.bathroomsDataGridViewTextBoxColumn.Name = "bathroomsDataGridViewTextBoxColumn";
            this.bathroomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearBuiltDataGridViewTextBoxColumn
            // 
            this.yearBuiltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearBuiltDataGridViewTextBoxColumn.DataPropertyName = "Year Built";
            this.yearBuiltDataGridViewTextBoxColumn.HeaderText = "Year Built";
            this.yearBuiltDataGridViewTextBoxColumn.Name = "yearBuiltDataGridViewTextBoxColumn";
            this.yearBuiltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricePerSqFtDataGridViewTextBoxColumn
            // 
            this.pricePerSqFtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePerSqFtDataGridViewTextBoxColumn.DataPropertyName = "PricePerSqFt";
            this.pricePerSqFtDataGridViewTextBoxColumn.HeaderText = "$ / sq. ft.";
            this.pricePerSqFtDataGridViewTextBoxColumn.Name = "pricePerSqFtDataGridViewTextBoxColumn";
            this.pricePerSqFtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtBindingSource
            // 
            this.dtBindingSource.DataMember = "dt";
            this.dtBindingSource.DataSource = this.favoriteHomesDataset;
            // 
            // favoriteHomesDataset
            // 
            this.favoriteHomesDataset.DataSetName = "FavoriteHomesDataset";
            this.favoriteHomesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(698, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All...";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(279, 443);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(360, 443);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(612, 443);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // favoriteHomesDatasetBindingSource
            // 
            this.favoriteHomesDatasetBindingSource.DataSource = this.favoriteHomesDataset;
            this.favoriteHomesDatasetBindingSource.Position = 0;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // FormFavoriteHomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 478);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormFavoriteHomes";
            this.Text = "My Favorite Homes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteHomesDataset)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteHomesDatasetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBedrooms;
        private System.Windows.Forms.Label labelBathrooms;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelYearBuilt;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.MaskedTextBox textBoxBedrooms;
        private System.Windows.Forms.MaskedTextBox textBoxBathrooms;
        private System.Windows.Forms.MaskedTextBox textBoxSize;
        private System.Windows.Forms.MaskedTextBox textBoxYearBuilt;
        private System.Windows.Forms.MaskedTextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.MaskedTextBox maskedBoxZip;
        private System.Windows.Forms.MaskedTextBox maskedBoxState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource favoriteHomesDatasetBindingSource;
        private FavoriteHomesDataset favoriteHomesDataset;
        private System.Windows.Forms.BindingSource dtBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedroomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bathroomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerSqFtDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;

    }
}