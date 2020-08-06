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
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.AddCustomers = new System.Windows.Forms.Button();
            this.PanelLocation = new System.Windows.Forms.Panel();
            this.PanelOrganization = new System.Windows.Forms.Panel();
            this.SearchOrganization = new System.Windows.Forms.TextBox();
            this.OrganizationDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).BeginInit();
            this.PanelLocation.SuspendLayout();
            this.PanelOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGrid)).BeginInit();
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
            this.Column2,
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
            this.LocationsDataGridView.Size = new System.Drawing.Size(823, 658);
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Просмотр";
            this.Column2.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 5;
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
            // FindTextBox
            // 
            this.FindTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindTextBox.ForeColor = System.Drawing.Color.Silver;
            this.FindTextBox.Location = new System.Drawing.Point(56, 12);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(123, 49, 3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(258, 33);
            this.FindTextBox.TabIndex = 4;
            this.FindTextBox.Text = "Поиск";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.LocationLabel.Location = new System.Drawing.Point(132, 138);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(123, 59, 0, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(97, 25);
            this.LocationLabel.TabIndex = 48;
            this.LocationLabel.Text = "Локации";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Location = new System.Drawing.Point(300, 138);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(71, 0, 3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(140, 25);
            this.CustomersLabel.TabIndex = 49;
            this.CustomersLabel.Text = "Организации";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLabel.ForeColor = System.Drawing.Color.White;
            this.ChangeLabel.Location = new System.Drawing.Point(624, 54);
            this.ChangeLabel.Margin = new System.Windows.Forms.Padding(71, 0, 45, 0);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(99, 23);
            this.ChangeLabel.TabIndex = 50;
            this.ChangeLabel.Text = "Изменить";
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
            // PanelLocation
            // 
            this.PanelLocation.Controls.Add(this.FindTextBox);
            this.PanelLocation.Controls.Add(this.LocationsDataGridView);
            this.PanelLocation.Location = new System.Drawing.Point(76, 193);
            this.PanelLocation.Name = "PanelLocation";
            this.PanelLocation.Size = new System.Drawing.Size(911, 610);
            this.PanelLocation.TabIndex = 52;
            // 
            // PanelOrganization
            // 
            this.PanelOrganization.Controls.Add(this.SearchOrganization);
            this.PanelOrganization.Controls.Add(this.OrganizationDataGrid);
            this.PanelOrganization.Location = new System.Drawing.Point(76, 193);
            this.PanelOrganization.Name = "PanelOrganization";
            this.PanelOrganization.Size = new System.Drawing.Size(911, 610);
            this.PanelOrganization.TabIndex = 53;
            // 
            // SearchOrganization
            // 
            this.SearchOrganization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchOrganization.BackColor = System.Drawing.Color.White;
            this.SearchOrganization.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchOrganization.ForeColor = System.Drawing.Color.Silver;
            this.SearchOrganization.Location = new System.Drawing.Point(56, 12);
            this.SearchOrganization.Margin = new System.Windows.Forms.Padding(123, 49, 3, 3);
            this.SearchOrganization.Name = "SearchOrganization";
            this.SearchOrganization.Size = new System.Drawing.Size(258, 33);
            this.SearchOrganization.TabIndex = 4;
            this.SearchOrganization.Text = "Поиск";
            // 
            // OrganizationDataGrid
            // 
            this.OrganizationDataGrid.AllowUserToAddRows = false;
            this.OrganizationDataGrid.AllowUserToDeleteRows = false;
            this.OrganizationDataGrid.AllowUserToResizeColumns = false;
            this.OrganizationDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrganizationDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrganizationDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrganizationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrganizationDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrganizationDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.OrganizationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrganizationDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrganizationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganizationDataGrid.ColumnHeadersVisible = false;
            this.OrganizationDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrganizationDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.OrganizationDataGrid.EnableHeadersVisualStyles = false;
            this.OrganizationDataGrid.GridColor = System.Drawing.Color.Black;
            this.OrganizationDataGrid.Location = new System.Drawing.Point(56, 69);
            this.OrganizationDataGrid.Margin = new System.Windows.Forms.Padding(5, 21, 5, 4);
            this.OrganizationDataGrid.MultiSelect = false;
            this.OrganizationDataGrid.Name = "OrganizationDataGrid";
            this.OrganizationDataGrid.ReadOnly = true;
            this.OrganizationDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganizationDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.OrganizationDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.OrganizationDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.OrganizationDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.OrganizationDataGrid.RowTemplate.Height = 25;
            this.OrganizationDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OrganizationDataGrid.Size = new System.Drawing.Size(823, 658);
            this.OrganizationDataGrid.TabIndex = 47;
            this.OrganizationDataGrid.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "location_name";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "location_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.AddCustomers);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.PanelOrganization);
            this.Controls.Add(this.PanelLocation);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1029, 933);
            this.Name = "CustomerInfoForm";
            this.Text = "CustomerInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).EndInit();
            this.PanelLocation.ResumeLayout(false);
            this.PanelLocation.PerformLayout();
            this.PanelOrganization.ResumeLayout(false);
            this.PanelOrganization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.DataGridView LocationsDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button AddCustomers;
        private System.Windows.Forms.Panel PanelLocation;
        private System.Windows.Forms.Panel PanelOrganization;
        private System.Windows.Forms.TextBox SearchOrganization;
        private System.Windows.Forms.DataGridView OrganizationDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}