namespace Admin_Panel_Hotel.Customers
{
    partial class CustomerInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.LocationsDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showLocation = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.LocationSearchTextBox = new System.Windows.Forms.TextBox();
            this.LocationsLabel = new System.Windows.Forms.Label();
            this.SubDivisionsLabel = new System.Windows.Forms.Label();
            this.AddSubDivisionButton = new System.Windows.Forms.Button();
            this.LocationsPanel = new System.Windows.Forms.Panel();
            this.SubDivisionsPanel = new System.Windows.Forms.Panel();
            this.SubDivisionSearchTextBox = new System.Windows.Forms.TextBox();
            this.SubDivisionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subdivision_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.subdivision_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddLocations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).BeginInit();
            this.LocationsPanel.SuspendLayout();
            this.SubDivisionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubDivisionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameLabel.AutoEllipsis = true;
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(70, 44);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.CustomerNameLabel.MaximumSize = new System.Drawing.Size(600, 35);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(247, 35);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Мои заказчики >";
            this.CustomerNameLabel.Click += new System.EventHandler(this.CustomerNameLabel_Click);
            // 
            // LocationsDataGridView
            // 
            this.LocationsDataGridView.AllowUserToAddRows = false;
            this.LocationsDataGridView.AllowUserToDeleteRows = false;
            this.LocationsDataGridView.AllowUserToResizeColumns = false;
            this.LocationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LocationsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationsDataGridView.ColumnHeadersVisible = false;
            this.LocationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.showLocation,
            this.id});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.LocationsDataGridView.EnableHeadersVisualStyles = false;
            this.LocationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.Location = new System.Drawing.Point(56, 69);
            this.LocationsDataGridView.Margin = new System.Windows.Forms.Padding(5, 21, 5, 4);
            this.LocationsDataGridView.MultiSelect = false;
            this.LocationsDataGridView.Name = "LocationsDataGridView";
            this.LocationsDataGridView.ReadOnly = true;
            this.LocationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LocationsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.RowTemplate.Height = 25;
            this.LocationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.LocationsDataGridView.Size = new System.Drawing.Size(823, 471);
            this.LocationsDataGridView.TabIndex = 47;
            this.LocationsDataGridView.TabStop = false;
            this.LocationsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LocationsDataGridView_CellMouseClick);
            this.LocationsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LocationsDataGridView_CellMouseMove);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "location_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Column1";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // showLocation
            // 
            this.showLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.showLocation.HeaderText = "Просмотр";
            this.showLocation.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.showLocation.Name = "showLocation";
            this.showLocation.ReadOnly = true;
            this.showLocation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.showLocation.Width = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "hotel_id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "Просмотр";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.AddLocationButton.FlatAppearance.BorderSize = 0;
            this.AddLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocationButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLocationButton.ForeColor = System.Drawing.Color.White;
            this.AddLocationButton.Location = new System.Drawing.Point(768, 47);
            this.AddLocationButton.Margin = new System.Windows.Forms.Padding(0, 34, 3, 3);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(131, 37);
            this.AddLocationButton.TabIndex = 2;
            this.AddLocationButton.Text = "Добавить";
            this.AddLocationButton.UseVisualStyleBackColor = false;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // LocationSearchTextBox
            // 
            this.LocationSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationSearchTextBox.BackColor = System.Drawing.Color.White;
            this.LocationSearchTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationSearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.LocationSearchTextBox.Location = new System.Drawing.Point(56, 12);
            this.LocationSearchTextBox.Margin = new System.Windows.Forms.Padding(123, 49, 3, 3);
            this.LocationSearchTextBox.Name = "LocationSearchTextBox";
            this.LocationSearchTextBox.Size = new System.Drawing.Size(258, 33);
            this.LocationSearchTextBox.TabIndex = 4;
            this.LocationSearchTextBox.Text = "Поиск";
            this.LocationSearchTextBox.TextChanged += new System.EventHandler(this.LocationSearchTextBox_TextChanged);
            // 
            // LocationsLabel
            // 
            this.LocationsLabel.AutoSize = true;
            this.LocationsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationsLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.LocationsLabel.Location = new System.Drawing.Point(132, 138);
            this.LocationsLabel.Margin = new System.Windows.Forms.Padding(123, 59, 0, 0);
            this.LocationsLabel.Name = "LocationsLabel";
            this.LocationsLabel.Size = new System.Drawing.Size(97, 25);
            this.LocationsLabel.TabIndex = 48;
            this.LocationsLabel.Text = "Локации";
            this.LocationsLabel.Click += new System.EventHandler(this.LocationsLabel_Click);
            // 
            // SubDivisionsLabel
            // 
            this.SubDivisionsLabel.AutoSize = true;
            this.SubDivisionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubDivisionsLabel.Location = new System.Drawing.Point(300, 138);
            this.SubDivisionsLabel.Margin = new System.Windows.Forms.Padding(71, 0, 3, 0);
            this.SubDivisionsLabel.Name = "SubDivisionsLabel";
            this.SubDivisionsLabel.Size = new System.Drawing.Size(140, 25);
            this.SubDivisionsLabel.TabIndex = 49;
            this.SubDivisionsLabel.Text = "Организации";
            this.SubDivisionsLabel.Click += new System.EventHandler(this.SubDivisionsLabel_Click);
            // 
            // AddSubDivisionButton
            // 
            this.AddSubDivisionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddSubDivisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.AddSubDivisionButton.FlatAppearance.BorderSize = 0;
            this.AddSubDivisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubDivisionButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubDivisionButton.ForeColor = System.Drawing.Color.White;
            this.AddSubDivisionButton.Location = new System.Drawing.Point(768, 47);
            this.AddSubDivisionButton.Margin = new System.Windows.Forms.Padding(0, 34, 3, 3);
            this.AddSubDivisionButton.Name = "AddSubDivisionButton";
            this.AddSubDivisionButton.Size = new System.Drawing.Size(131, 37);
            this.AddSubDivisionButton.TabIndex = 51;
            this.AddSubDivisionButton.Text = "Добавить";
            this.AddSubDivisionButton.UseVisualStyleBackColor = false;
            this.AddSubDivisionButton.Visible = false;
            // 
            // LocationsPanel
            // 
            this.LocationsPanel.Controls.Add(this.LocationSearchTextBox);
            this.LocationsPanel.Controls.Add(this.LocationsDataGridView);
            this.LocationsPanel.Location = new System.Drawing.Point(76, 193);
            this.LocationsPanel.Name = "LocationsPanel";
            this.LocationsPanel.Size = new System.Drawing.Size(911, 610);
            this.LocationsPanel.TabIndex = 52;
            // 
            // SubDivisionsPanel
            // 
            this.SubDivisionsPanel.Controls.Add(this.SubDivisionSearchTextBox);
            this.SubDivisionsPanel.Controls.Add(this.SubDivisionsDataGridView);
            this.SubDivisionsPanel.Location = new System.Drawing.Point(76, 193);
            this.SubDivisionsPanel.Name = "SubDivisionsPanel";
            this.SubDivisionsPanel.Size = new System.Drawing.Size(911, 610);
            this.SubDivisionsPanel.TabIndex = 53;
            this.SubDivisionsPanel.Visible = false;
            // 
            // SubDivisionSearchTextBox
            // 
            this.SubDivisionSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubDivisionSearchTextBox.BackColor = System.Drawing.Color.White;
            this.SubDivisionSearchTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubDivisionSearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SubDivisionSearchTextBox.Location = new System.Drawing.Point(56, 12);
            this.SubDivisionSearchTextBox.Margin = new System.Windows.Forms.Padding(123, 49, 3, 3);
            this.SubDivisionSearchTextBox.Name = "SubDivisionSearchTextBox";
            this.SubDivisionSearchTextBox.Size = new System.Drawing.Size(258, 33);
            this.SubDivisionSearchTextBox.TabIndex = 4;
            this.SubDivisionSearchTextBox.Text = "Поиск";
            this.SubDivisionSearchTextBox.TextChanged += new System.EventHandler(this.SubDivisionSearchTextBox_TextChanged);
            // 
            // SubDivisionsDataGridView
            // 
            this.SubDivisionsDataGridView.AllowUserToAddRows = false;
            this.SubDivisionsDataGridView.AllowUserToDeleteRows = false;
            this.SubDivisionsDataGridView.AllowUserToResizeColumns = false;
            this.SubDivisionsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubDivisionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.SubDivisionsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubDivisionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubDivisionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SubDivisionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubDivisionsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SubDivisionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubDivisionsDataGridView.ColumnHeadersVisible = false;
            this.SubDivisionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subdivision_name,
            this.dataGridViewImageColumn2,
            this.subdivision_id});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubDivisionsDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.SubDivisionsDataGridView.EnableHeadersVisualStyles = false;
            this.SubDivisionsDataGridView.GridColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.Location = new System.Drawing.Point(56, 69);
            this.SubDivisionsDataGridView.Margin = new System.Windows.Forms.Padding(5, 21, 5, 4);
            this.SubDivisionsDataGridView.MultiSelect = false;
            this.SubDivisionsDataGridView.Name = "SubDivisionsDataGridView";
            this.SubDivisionsDataGridView.ReadOnly = true;
            this.SubDivisionsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.SubDivisionsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.SubDivisionsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.RowTemplate.Height = 25;
            this.SubDivisionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SubDivisionsDataGridView.Size = new System.Drawing.Size(823, 471);
            this.SubDivisionsDataGridView.TabIndex = 47;
            this.SubDivisionsDataGridView.TabStop = false;
            this.SubDivisionsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SubDivisionsDataGridView_CellMouseClick);
            this.SubDivisionsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SubDivisionsDataGridView_CellMouseMove);
            // 
            // subdivision_name
            // 
            this.subdivision_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subdivision_name.DataPropertyName = "subdivision_name";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.subdivision_name.DefaultCellStyle = dataGridViewCellStyle9;
            this.subdivision_name.HeaderText = "subdivision_name";
            this.subdivision_name.Name = "subdivision_name";
            this.subdivision_name.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.HeaderText = "Просмотр";
            this.dataGridViewImageColumn2.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // subdivision_id
            // 
            this.subdivision_id.DataPropertyName = "subdivision_id";
            this.subdivision_id.HeaderText = "subdivision_id";
            this.subdivision_id.Name = "subdivision_id";
            this.subdivision_id.ReadOnly = true;
            this.subdivision_id.Visible = false;
            // 
            // AddLocations
            // 
            this.AddLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.AddLocations.FlatAppearance.BorderSize = 0;
            this.AddLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocations.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLocations.ForeColor = System.Drawing.Color.White;
            this.AddLocations.Location = new System.Drawing.Point(768, 47);
            this.AddLocations.Margin = new System.Windows.Forms.Padding(0, 34, 3, 3);
            this.AddLocations.Name = "AddLocations";
            this.AddLocations.Size = new System.Drawing.Size(131, 37);
            this.AddLocations.TabIndex = 54;
            this.AddLocations.Text = "Добавить";
            this.AddLocations.UseVisualStyleBackColor = false;
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.SubDivisionsLabel);
            this.Controls.Add(this.LocationsLabel);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.AddLocations);
            this.Controls.Add(this.AddSubDivisionButton);
            this.Controls.Add(this.LocationsPanel);
            this.Controls.Add(this.SubDivisionsPanel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1029, 933);
            this.Name = "CustomerInfoForm";
            this.Text = "CustomerInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).EndInit();
            this.LocationsPanel.ResumeLayout(false);
            this.LocationsPanel.PerformLayout();
            this.SubDivisionsPanel.ResumeLayout(false);
            this.SubDivisionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubDivisionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.DataGridView LocationsDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.TextBox LocationSearchTextBox;
        private System.Windows.Forms.Label LocationsLabel;
        private System.Windows.Forms.Label SubDivisionsLabel;
        private System.Windows.Forms.Button AddSubDivisionButton;
        private System.Windows.Forms.Panel LocationsPanel;
        private System.Windows.Forms.Panel SubDivisionsPanel;
        private System.Windows.Forms.TextBox SubDivisionSearchTextBox;
        private System.Windows.Forms.DataGridView SubDivisionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_name;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_id;
        private System.Windows.Forms.Button AddLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn showLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}