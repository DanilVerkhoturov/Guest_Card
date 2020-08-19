namespace Admin_Panel_Hotel.Customers
{
    partial class AddSubdivision
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
            this.CustomerLocationNameLabel = new System.Windows.Forms.Label();
            this.LocationDataLabel = new System.Windows.Forms.Label();
            this.LocationInfoPanel = new System.Windows.Forms.Panel();
            this.SaveLocationInfoButton = new System.Windows.Forms.Button();
            this.EditNameButton = new System.Windows.Forms.Button();
            this.AddRoomLabel = new System.Windows.Forms.Label();
            this.BedsCountTextBox = new System.Windows.Forms.TextBox();
            this.RoomsCountTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubDivisionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivisionName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubDivisionsDataGridView)).BeginInit();
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
            this.LocationDataLabel.Location = new System.Drawing.Point(87, 114);
            this.LocationDataLabel.Margin = new System.Windows.Forms.Padding(142, 35, 3, 0);
            this.LocationDataLabel.Name = "LocationDataLabel";
            this.LocationDataLabel.Size = new System.Drawing.Size(509, 29);
            this.LocationDataLabel.TabIndex = 1;
            this.LocationDataLabel.Text = "Данные подрядных организаций заказчика";
            this.LocationDataLabel.Click += new System.EventHandler(this.LocationDataLabel_Click);
            // 
            // LocationInfoPanel
            // 
            this.LocationInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationInfoPanel.Controls.Add(this.SubDivisionsDataGridView);
            this.LocationInfoPanel.Controls.Add(this.label1);
            this.LocationInfoPanel.Controls.Add(this.SaveLocationInfoButton);
            this.LocationInfoPanel.Controls.Add(this.EditNameButton);
            this.LocationInfoPanel.Controls.Add(this.BedsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.RoomsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.NameTextBox);
            this.LocationInfoPanel.Location = new System.Drawing.Point(92, 156);
            this.LocationInfoPanel.Name = "LocationInfoPanel";
            this.LocationInfoPanel.Size = new System.Drawing.Size(1001, 735);
            this.LocationInfoPanel.TabIndex = 74;
            // 
            // SaveLocationInfoButton
            // 
            this.SaveLocationInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveLocationInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveLocationInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocationInfoButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLocationInfoButton.ForeColor = System.Drawing.Color.White;
            this.SaveLocationInfoButton.Location = new System.Drawing.Point(508, 640);
            this.SaveLocationInfoButton.Name = "SaveLocationInfoButton";
            this.SaveLocationInfoButton.Size = new System.Drawing.Size(202, 42);
            this.SaveLocationInfoButton.TabIndex = 67;
            this.SaveLocationInfoButton.Text = "Далее";
            this.SaveLocationInfoButton.UseVisualStyleBackColor = false;
            this.SaveLocationInfoButton.Visible = false;
            this.SaveLocationInfoButton.Click += new System.EventHandler(this.SaveLocationInfoButton_Click);
            // 
            // EditNameButton
            // 
            this.EditNameButton.BackColor = System.Drawing.Color.Transparent;
            this.EditNameButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.Accept;
            this.EditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditNameButton.FlatAppearance.BorderSize = 0;
            this.EditNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNameButton.Location = new System.Drawing.Point(733, 33);
            this.EditNameButton.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.EditNameButton.Name = "EditNameButton";
            this.EditNameButton.Size = new System.Drawing.Size(24, 24);
            this.EditNameButton.TabIndex = 66;
            this.EditNameButton.UseVisualStyleBackColor = false;
            this.EditNameButton.Click += new System.EventHandler(this.EditNameButton_Click_1);
            // 
            // AddRoomLabel
            // 
            this.AddRoomLabel.AutoSize = true;
            this.AddRoomLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoomLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddRoomLabel.Location = new System.Drawing.Point(619, 118);
            this.AddRoomLabel.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.AddRoomLabel.Name = "AddRoomLabel";
            this.AddRoomLabel.Size = new System.Drawing.Size(166, 25);
            this.AddRoomLabel.TabIndex = 9;
            this.AddRoomLabel.Text = "+ добавить еще";
            this.AddRoomLabel.Visible = false;
            this.AddRoomLabel.Click += new System.EventHandler(this.AddRoomLabel_Click);
            // 
            // BedsCountTextBox
            // 
            this.BedsCountTextBox.Location = new System.Drawing.Point(413, 72);
            this.BedsCountTextBox.Margin = new System.Windows.Forms.Padding(20, 9, 3, 3);
            this.BedsCountTextBox.Name = "BedsCountTextBox";
            this.BedsCountTextBox.ReadOnly = true;
            this.BedsCountTextBox.Size = new System.Drawing.Size(297, 33);
            this.BedsCountTextBox.TabIndex = 2;
            this.BedsCountTextBox.Text = "0";
            // 
            // RoomsCountTextBox
            // 
            this.RoomsCountTextBox.Location = new System.Drawing.Point(0, 72);
            this.RoomsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 0, 3);
            this.RoomsCountTextBox.Name = "RoomsCountTextBox";
            this.RoomsCountTextBox.ReadOnly = true;
            this.RoomsCountTextBox.Size = new System.Drawing.Size(290, 33);
            this.RoomsCountTextBox.TabIndex = 1;
            this.RoomsCountTextBox.Text = "0";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(0, 30);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(710, 33);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(775, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Добавленные организации";
            // 
            // SubDivisionsDataGridView
            // 
            this.SubDivisionsDataGridView.AllowUserToAddRows = false;
            this.SubDivisionsDataGridView.AllowUserToDeleteRows = false;
            this.SubDivisionsDataGridView.AllowUserToResizeColumns = false;
            this.SubDivisionsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubDivisionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubDivisionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SubDivisionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SubDivisionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubDivisionsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SubDivisionsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubDivisionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubDivisionsDataGridView.ColumnHeadersVisible = false;
            this.SubDivisionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.subdivisionName,
            this.Column1,
            this.customer_id});
            this.SubDivisionsDataGridView.EnableHeadersVisualStyles = false;
            this.SubDivisionsDataGridView.Location = new System.Drawing.Point(779, 62);
            this.SubDivisionsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.SubDivisionsDataGridView.MultiSelect = false;
            this.SubDivisionsDataGridView.Name = "SubDivisionsDataGridView";
            this.SubDivisionsDataGridView.ReadOnly = true;
            this.SubDivisionsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubDivisionsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SubDivisionsDataGridView.RowHeadersVisible = false;
            this.SubDivisionsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SubDivisionsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SubDivisionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubDivisionsDataGridView.Size = new System.Drawing.Size(217, 396);
            this.SubDivisionsDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // subdivisionName
            // 
            this.subdivisionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subdivisionName.DataPropertyName = "subdivision_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.subdivisionName.DefaultCellStyle = dataGridViewCellStyle3;
            this.subdivisionName.HeaderText = "Название организации";
            this.subdivisionName.Name = "subdivisionName";
            this.subdivisionName.ReadOnly = true;
            this.subdivisionName.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Image = global::Admin_Panel_Hotel.Properties.Resources.closeoutline_110831_4;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "subdivision_id";
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            this.customer_id.Width = 5;
            // 
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.LocationDataLabel);
            this.Controls.Add(this.CustomerLocationNameLabel);
            this.Controls.Add(this.LocationInfoPanel);
            this.Controls.Add(this.AddRoomLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddOrganization";
            this.Text = "SubDivisionInfoForm";
            this.LocationInfoPanel.ResumeLayout(false);
            this.LocationInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubDivisionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLocationNameLabel;
        private System.Windows.Forms.Label LocationDataLabel;
        private System.Windows.Forms.Panel LocationInfoPanel;
        private System.Windows.Forms.TextBox BedsCountTextBox;
        private System.Windows.Forms.TextBox RoomsCountTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AddRoomLabel;
        private System.Windows.Forms.Button EditNameButton;
        private System.Windows.Forms.Button SaveLocationInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SubDivisionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn subdivisionName;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
    }
}