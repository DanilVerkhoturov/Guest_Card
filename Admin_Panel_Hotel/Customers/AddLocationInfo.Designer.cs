namespace Admin_Panel_Hotel.Customers
{
    partial class AddLocationInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerLocationNameLabel = new System.Windows.Forms.Label();
            this.LocationDataLabel = new System.Windows.Forms.Label();
            this.LocationsDataGridView = new System.Windows.Forms.DataGridView();
            this.hotel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.locationName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.CardCountTextBox = new System.Windows.Forms.TextBox();
            this.LocationNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveCustomerButton = new System.Windows.Forms.Button();
            this.RoomCountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BedsCountTextBox = new System.Windows.Forms.TextBox();
            this.AddLocationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddRoomsLabel = new System.Windows.Forms.Label();
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.bedsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLocationNameLabel
            // 
            this.CustomerLocationNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerLocationNameLabel.AutoEllipsis = true;
            this.CustomerLocationNameLabel.AutoSize = true;
            this.CustomerLocationNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerLocationNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLocationNameLabel.Location = new System.Drawing.Point(70, 44);
            this.CustomerLocationNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.CustomerLocationNameLabel.MaximumSize = new System.Drawing.Size(900, 35);
            this.CustomerLocationNameLabel.Name = "CustomerLocationNameLabel";
            this.CustomerLocationNameLabel.Size = new System.Drawing.Size(254, 35);
            this.CustomerLocationNameLabel.TabIndex = 0;
            this.CustomerLocationNameLabel.Text = "Мои заказчики > ";
            this.CustomerLocationNameLabel.Click += new System.EventHandler(this.CustomerLocationNameLabel_Click);
            // 
            // LocationDataLabel
            // 
            this.LocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationDataLabel.AutoSize = true;
            this.LocationDataLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationDataLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationDataLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationDataLabel.Location = new System.Drawing.Point(116, 114);
            this.LocationDataLabel.Margin = new System.Windows.Forms.Padding(142, 35, 3, 0);
            this.LocationDataLabel.Name = "LocationDataLabel";
            this.LocationDataLabel.Size = new System.Drawing.Size(232, 29);
            this.LocationDataLabel.TabIndex = 1;
            this.LocationDataLabel.Text = "Добавить локацию";
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
            this.LocationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.LocationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.num,
            this.locationName,
            this.delete,
            this.hotel_id});
            this.LocationsDataGridView.EnableHeadersVisualStyles = false;
            this.LocationsDataGridView.Location = new System.Drawing.Point(810, 202);
            this.LocationsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LocationsDataGridView.MultiSelect = false;
            this.LocationsDataGridView.Name = "LocationsDataGridView";
            this.LocationsDataGridView.ReadOnly = true;
            this.LocationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LocationsDataGridView.RowHeadersVisible = false;
            this.LocationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocationsDataGridView.Size = new System.Drawing.Size(242, 396);
            this.LocationsDataGridView.TabIndex = 64;
            // 
            // hotel_id
            // 
            this.hotel_id.DataPropertyName = "hotel_id";
            this.hotel_id.HeaderText = "hotel_id";
            this.hotel_id.Name = "hotel_id";
            this.hotel_id.ReadOnly = true;
            this.hotel_id.Visible = false;
            this.hotel_id.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.delete.HeaderText = "DeleteLocation";
            this.delete.Image = global::Admin_Panel_Hotel.Properties.Resources.closeoutline_110831_4;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 5;
            // 
            // locationName
            // 
            this.locationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationName.DataPropertyName = "location_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.locationName.DefaultCellStyle = dataGridViewCellStyle3;
            this.locationName.HeaderText = "Локация";
            this.locationName.Name = "locationName";
            this.locationName.ReadOnly = true;
            this.locationName.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // num
            // 
            this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.num.HeaderText = "№";
            this.num.MaxInputLength = 3;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(96, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(144, 37, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Количество карт для локации:";
            // 
            // CardCountTextBox
            // 
            this.CardCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardCountTextBox.BackColor = System.Drawing.Color.White;
            this.CardCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardCountTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardCountTextBox.Location = new System.Drawing.Point(418, 318);
            this.CardCountTextBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CardCountTextBox.Name = "CardCountTextBox";
            this.CardCountTextBox.Size = new System.Drawing.Size(58, 33);
            this.CardCountTextBox.TabIndex = 61;
            this.CardCountTextBox.Text = "0";
            this.CardCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationNameTextBox
            // 
            this.LocationNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationNameTextBox.BackColor = System.Drawing.Color.White;
            this.LocationNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationNameTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationNameTextBox.Location = new System.Drawing.Point(76, 165);
            this.LocationNameTextBox.Margin = new System.Windows.Forms.Padding(124, 22, 5, 18);
            this.LocationNameTextBox.Name = "LocationNameTextBox";
            this.LocationNameTextBox.Size = new System.Drawing.Size(562, 33);
            this.LocationNameTextBox.TabIndex = 57;
            this.LocationNameTextBox.Tag = "";
            this.LocationNameTextBox.Leave += new System.EventHandler(this.LocationNameTextBox_Leave);
            // 
            // SaveCustomerButton
            // 
            this.SaveCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCustomerButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveCustomerButton.ForeColor = System.Drawing.Color.White;
            this.SaveCustomerButton.Location = new System.Drawing.Point(420, 765);
            this.SaveCustomerButton.Margin = new System.Windows.Forms.Padding(5, 106, 5, 7);
            this.SaveCustomerButton.Name = "SaveCustomerButton";
            this.SaveCustomerButton.Size = new System.Drawing.Size(218, 48);
            this.SaveCustomerButton.TabIndex = 63;
            this.SaveCustomerButton.Text = "Сохранить";
            this.SaveCustomerButton.UseVisualStyleBackColor = false;
            this.SaveCustomerButton.Click += new System.EventHandler(this.SaveCustomerButton_Click);
            // 
            // RoomCountTextBox
            // 
            this.RoomCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomCountTextBox.BackColor = System.Drawing.Color.White;
            this.RoomCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomCountTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomCountTextBox.Location = new System.Drawing.Point(76, 243);
            this.RoomCountTextBox.Margin = new System.Windows.Forms.Padding(5, 38, 5, 7);
            this.RoomCountTextBox.Name = "RoomCountTextBox";
            this.RoomCountTextBox.Size = new System.Drawing.Size(223, 33);
            this.RoomCountTextBox.TabIndex = 59;
            this.RoomCountTextBox.Text = "0";
            this.RoomCountTextBox.Leave += new System.EventHandler(this.LocationNameTextBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(805, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(116, 93, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Добавленные локации";
            // 
            // BedsCountTextBox
            // 
            this.BedsCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BedsCountTextBox.BackColor = System.Drawing.Color.White;
            this.BedsCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BedsCountTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BedsCountTextBox.Location = new System.Drawing.Point(424, 243);
            this.BedsCountTextBox.Margin = new System.Windows.Forms.Padding(120, 7, 5, 7);
            this.BedsCountTextBox.Name = "BedsCountTextBox";
            this.BedsCountTextBox.Size = new System.Drawing.Size(214, 33);
            this.BedsCountTextBox.TabIndex = 60;
            this.BedsCountTextBox.Text = "0";
            this.BedsCountTextBox.Leave += new System.EventHandler(this.LocationNameTextBox_Leave);
            // 
            // AddLocationLinkLabel
            // 
            this.AddLocationLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLocationLinkLabel.AutoSize = true;
            this.AddLocationLinkLabel.Location = new System.Drawing.Point(71, 722);
            this.AddLocationLinkLabel.Name = "AddLocationLinkLabel";
            this.AddLocationLinkLabel.Size = new System.Drawing.Size(258, 25);
            this.AddLocationLinkLabel.TabIndex = 65;
            this.AddLocationLinkLabel.TabStop = true;
            this.AddLocationLinkLabel.Text = "+ добавить ещё локацию";
            this.AddLocationLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.AddLocationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddLocationLinkLabel_LinkClicked);
            // 
            // AddRoomsLabel
            // 
            this.AddRoomsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddRoomsLabel.AutoSize = true;
            this.AddRoomsLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRoomsLabel.Location = new System.Drawing.Point(75, 397);
            this.AddRoomsLabel.Margin = new System.Windows.Forms.Padding(142, 52, 5, 0);
            this.AddRoomsLabel.Name = "AddRoomsLabel";
            this.AddRoomsLabel.Size = new System.Drawing.Size(225, 29);
            this.AddRoomsLabel.TabIndex = 66;
            this.AddRoomsLabel.Text = "Добавить комнату";
            this.AddRoomsLabel.Visible = false;
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToAddRows = false;
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            this.RoomsDataGridView.AllowUserToResizeRows = false;
            this.RoomsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomsDataGridView.ColumnHeadersHeight = 35;
            this.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RoomsDataGridView.ColumnHeadersVisible = false;
            this.RoomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumber,
            this.bedsCount});
            this.RoomsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RoomsDataGridView.EnableHeadersVisualStyles = false;
            this.RoomsDataGridView.Location = new System.Drawing.Point(74, 440);
            this.RoomsDataGridView.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.RowHeadersVisible = false;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RoomsDataGridView.RowTemplate.Height = 30;
            this.RoomsDataGridView.Size = new System.Drawing.Size(562, 259);
            this.RoomsDataGridView.TabIndex = 67;
            this.RoomsDataGridView.Visible = false;
            this.RoomsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGridView_CellEndEdit);
            // 
            // bedsCount
            // 
            this.bedsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bedsCount.DataPropertyName = "beds_count";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.bedsCount.DefaultCellStyle = dataGridViewCellStyle6;
            this.bedsCount.HeaderText = "Количество мест";
            this.bedsCount.Name = "bedsCount";
            this.bedsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNumber.DataPropertyName = "room_name";
            this.roomNumber.HeaderText = "Номер комнаты";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddLocationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.RoomsDataGridView);
            this.Controls.Add(this.LocationDataLabel);
            this.Controls.Add(this.AddRoomsLabel);
            this.Controls.Add(this.CustomerLocationNameLabel);
            this.Controls.Add(this.AddLocationLinkLabel);
            this.Controls.Add(this.BedsCountTextBox);
            this.Controls.Add(this.LocationNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LocationsDataGridView);
            this.Controls.Add(this.RoomCountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveCustomerButton);
            this.Controls.Add(this.CardCountTextBox);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddLocationInfo";
            this.Text = "AddLocationInfo";
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLocationNameLabel;
        private System.Windows.Forms.Label LocationDataLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView LocationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewLinkColumn locationName;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CardCountTextBox;
        private System.Windows.Forms.TextBox LocationNameTextBox;
        private System.Windows.Forms.Button SaveCustomerButton;
        private System.Windows.Forms.TextBox RoomCountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BedsCountTextBox;
        private System.Windows.Forms.LinkLabel AddLocationLinkLabel;
        private System.Windows.Forms.Label AddRoomsLabel;
        private System.Windows.Forms.DataGridView RoomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsCount;
    }
}