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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.AddCustomers = new System.Windows.Forms.Button();
            this.LocationsPanel = new System.Windows.Forms.Panel();
            this.SubDivisionsPanel = new System.Windows.Forms.Panel();
            this.SubDivisionSearchTextBox = new System.Windows.Forms.TextBox();
            this.SubDivisionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subdivision_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.subdivision_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.LocationsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.LocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationsDataGridView.ColumnHeadersVisible = false;
            this.LocationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.showLocation,
            this.id});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationsDataGridView.DefaultCellStyle = dataGridViewCellStyle28;
            this.LocationsDataGridView.EnableHeadersVisualStyles = false;
            this.LocationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.Location = new System.Drawing.Point(56, 69);
            this.LocationsDataGridView.Margin = new System.Windows.Forms.Padding(5, 21, 5, 4);
            this.LocationsDataGridView.MultiSelect = false;
            this.LocationsDataGridView.Name = "LocationsDataGridView";
            this.LocationsDataGridView.ReadOnly = true;
            this.LocationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.LocationsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.NullValue = null;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle27;
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
            this.id.DataPropertyName = "location_id";
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
            // AddCustomers
            // 
            this.AddCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.AddCustomers.FlatAppearance.BorderSize = 0;
            this.AddCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomers.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCustomers.ForeColor = System.Drawing.Color.White;
            this.AddCustomers.Location = new System.Drawing.Point(768, 47);
            this.AddCustomers.Margin = new System.Windows.Forms.Padding(0, 34, 3, 3);
            this.AddCustomers.Name = "AddCustomers";
            this.AddCustomers.Size = new System.Drawing.Size(131, 37);
            this.AddCustomers.TabIndex = 51;
            this.AddCustomers.Text = "Добавить";
            this.AddCustomers.UseVisualStyleBackColor = false;
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
            // 
            // SubDivisionsDataGridView
            // 
            this.SubDivisionsDataGridView.AllowUserToAddRows = false;
            this.SubDivisionsDataGridView.AllowUserToDeleteRows = false;
            this.SubDivisionsDataGridView.AllowUserToResizeColumns = false;
            this.SubDivisionsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubDivisionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.SubDivisionsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubDivisionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubDivisionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SubDivisionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubDivisionsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.SubDivisionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubDivisionsDataGridView.ColumnHeadersVisible = false;
            this.SubDivisionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subdivision_name,
            this.dataGridViewImageColumn2,
            this.subdivision_id});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubDivisionsDataGridView.DefaultCellStyle = dataGridViewCellStyle34;
            this.SubDivisionsDataGridView.EnableHeadersVisualStyles = false;
            this.SubDivisionsDataGridView.GridColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.Location = new System.Drawing.Point(56, 69);
            this.SubDivisionsDataGridView.Margin = new System.Windows.Forms.Padding(5, 21, 5, 4);
            this.SubDivisionsDataGridView.MultiSelect = false;
            this.SubDivisionsDataGridView.Name = "SubDivisionsDataGridView";
            this.SubDivisionsDataGridView.ReadOnly = true;
            this.SubDivisionsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.SubDivisionsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.NullValue = null;
            dataGridViewCellStyle36.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.SubDivisionsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle36;
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.subdivision_name.DefaultCellStyle = dataGridViewCellStyle33;
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
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.AddCustomers);
            this.Controls.Add(this.SubDivisionsLabel);
            this.Controls.Add(this.LocationsLabel);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.CustomerNameLabel);
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
        private System.Windows.Forms.Button AddCustomers;
        private System.Windows.Forms.Panel LocationsPanel;
        private System.Windows.Forms.Panel SubDivisionsPanel;
        private System.Windows.Forms.TextBox SubDivisionSearchTextBox;
        private System.Windows.Forms.DataGridView SubDivisionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn showLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_name;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_id;
    }
}