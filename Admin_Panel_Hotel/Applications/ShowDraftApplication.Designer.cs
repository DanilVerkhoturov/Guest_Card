namespace Admin_Panel_Hotel
{
    partial class ShowApplicationDraft
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.SendToCustomerButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoEllipsis = true;
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationNameLabel.Location = new System.Drawing.Point(70, 44);
            this.ApplicationNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 0, 45);
            this.ApplicationNameLabel.MaximumSize = new System.Drawing.Size(900, 35);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(179, 35);
            this.ApplicationNameLabel.TabIndex = 22;
            this.ApplicationNameLabel.Text = "Черновик > ";
            this.ApplicationNameLabel.Click += new System.EventHandler(this.DraftApplicationNameLabel_Click);
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.UsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGridView.ColumnHeadersHeight = 35;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.location});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.UsersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UsersDataGridView.Enabled = false;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(76, 186);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(4, 21, 4, 5);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.UsersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.UsersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDataGridView.RowTemplate.Height = 30;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(991, 583);
            this.UsersDataGridView.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 112.3096F;
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.FillWeight = 112.3096F;
            this.Column3.HeaderText = "Таб.номер";
            this.Column3.Name = "Column3";
            this.Column3.Width = 141;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.FillWeight = 112.3096F;
            this.Column4.HeaderText = "Дата от";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.FillWeight = 112.3096F;
            this.Column5.HeaderText = "Дата до";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // location
            // 
            this.location.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.location.HeaderText = "Локация";
            this.location.Items.AddRange(new object[] {
            "Локация"});
            this.location.Name = "location";
            this.location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddUserLabel.Location = new System.Drawing.Point(901, 135);
            this.AddUserLabel.Margin = new System.Windows.Forms.Padding(48, 0, 3, 0);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(166, 25);
            this.AddUserLabel.TabIndex = 65;
            this.AddUserLabel.Text = "+ добавить еще";
            this.AddUserLabel.Visible = false;
            this.AddUserLabel.Click += new System.EventHandler(this.AddUserLabel_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.White;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ImportButton.FlatAppearance.BorderSize = 2;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ImportButton.Image = global::Admin_Panel_Hotel.Properties.Resources.Import;
            this.ImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportButton.Location = new System.Drawing.Point(680, 132);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(22, 34, 0, 0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(209, 33);
            this.ImportButton.TabIndex = 64;
            this.ImportButton.Text = "Импорт данных";
            this.ImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Visible = false;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.White;
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Enabled = false;
            this.LocationComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Локация"});
            this.LocationComboBox.Location = new System.Drawing.Point(378, 132);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(22, 6, 0, 0);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(280, 33);
            this.LocationComboBox.TabIndex = 63;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.Enabled = false;
            this.CustomerComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerComboBox.ForeColor = System.Drawing.Color.Black;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Items.AddRange(new object[] {
            "Заказчик"});
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 132);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(123, 46, 0, 0);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(280, 33);
            this.CustomerComboBox.TabIndex = 62;
            // 
            // SendToCustomerButton
            // 
            this.SendToCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SendToCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendToCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToCustomerButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendToCustomerButton.ForeColor = System.Drawing.Color.White;
            this.SendToCustomerButton.Location = new System.Drawing.Point(802, 795);
            this.SendToCustomerButton.Name = "SendToCustomerButton";
            this.SendToCustomerButton.Size = new System.Drawing.Size(265, 48);
            this.SendToCustomerButton.TabIndex = 61;
            this.SendToCustomerButton.Text = "Отправить заказчику";
            this.SendToCustomerButton.UseVisualStyleBackColor = false;
            this.SendToCustomerButton.Visible = false;
            this.SendToCustomerButton.Click += new System.EventHandler(this.SendToCustomerButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(728, 795);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(339, 48);
            this.EditButton.TabIndex = 66;
            this.EditButton.Text = "Продолжить редактирование";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(936, 44);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(33, 23, 124, 44);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 35);
            this.DeleteButton.TabIndex = 67;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ShowApplicationDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.SendToCustomerButton);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShowApplicationDraft";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn location;
        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Button SendToCustomerButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}