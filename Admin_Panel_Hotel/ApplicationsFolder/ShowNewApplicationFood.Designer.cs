namespace Admin_Panel_Hotel.ApplicationsFolder
{
    partial class ShowApplicationNewFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewApplicationNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ToDraftButton = new System.Windows.Forms.Button();
            this.Acceptbutton = new System.Windows.Forms.Button();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.AddUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NewApplicationNameLabel
            // 
            this.NewApplicationNameLabel.AutoEllipsis = true;
            this.NewApplicationNameLabel.AutoSize = true;
            this.NewApplicationNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewApplicationNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewApplicationNameLabel.Location = new System.Drawing.Point(70, 44);
            this.NewApplicationNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 0, 0);
            this.NewApplicationNameLabel.MaximumSize = new System.Drawing.Size(730, 35);
            this.NewApplicationNameLabel.Name = "NewApplicationNameLabel";
            this.NewApplicationNameLabel.Size = new System.Drawing.Size(234, 35);
            this.NewApplicationNameLabel.TabIndex = 0;
            this.NewApplicationNameLabel.Text = "Новые заявки >";
            this.NewApplicationNameLabel.Click += new System.EventHandler(this.NewApplicationsLabel_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // ToDraftButton
            // 
            this.ToDraftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ToDraftButton.FlatAppearance.BorderSize = 0;
            this.ToDraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDraftButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraftButton.ForeColor = System.Drawing.Color.White;
            this.ToDraftButton.Location = new System.Drawing.Point(945, 44);
            this.ToDraftButton.Margin = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.ToDraftButton.Name = "ToDraftButton";
            this.ToDraftButton.Size = new System.Drawing.Size(123, 35);
            this.ToDraftButton.TabIndex = 19;
            this.ToDraftButton.Text = "Черновик";
            this.ToDraftButton.UseVisualStyleBackColor = false;
            // 
            // Acceptbutton
            // 
            this.Acceptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.Acceptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Acceptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceptbutton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acceptbutton.ForeColor = System.Drawing.Color.White;
            this.Acceptbutton.Location = new System.Drawing.Point(761, 809);
            this.Acceptbutton.Margin = new System.Windows.Forms.Padding(3, 46, 3, 3);
            this.Acceptbutton.Name = "Acceptbutton";
            this.Acceptbutton.Size = new System.Drawing.Size(307, 42);
            this.Acceptbutton.TabIndex = 21;
            this.Acceptbutton.Text = "Отправить заказчику";
            this.Acceptbutton.UseVisualStyleBackColor = false;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.UsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGridView.ColumnHeadersHeight = 35;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.user_id,
            this.tabNum,
            this.start_at,
            this.end_at,
            this.location_id});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.UsersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(76, 179);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(122, 21, 123, 5);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UsersDataGridView.RowHeadersVisible = false;
            this.UsersDataGridView.RowHeadersWidth = 10;
            this.UsersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.UsersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDataGridView.RowTemplate.Height = 30;
            this.UsersDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(992, 563);
            this.UsersDataGridView.TabIndex = 69;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "user_id";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.user_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.user_id.FillWeight = 112.3096F;
            this.user_id.HeaderText = "ФИО";
            this.user_id.MinimumWidth = 100;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabNum
            // 
            this.tabNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tabNum.DataPropertyName = "tab_number";
            this.tabNum.FillWeight = 112.3096F;
            this.tabNum.HeaderText = "Таб.номер";
            this.tabNum.Name = "tabNum";
            this.tabNum.ReadOnly = true;
            // 
            // start_at
            // 
            this.start_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_at.DataPropertyName = "start_at";
            this.start_at.FillWeight = 112.3096F;
            this.start_at.HeaderText = "Дата от";
            this.start_at.MinimumWidth = 10;
            this.start_at.Name = "start_at";
            this.start_at.ReadOnly = true;
            this.start_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // end_at
            // 
            this.end_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_at.DataPropertyName = "end_at";
            this.end_at.FillWeight = 112.3096F;
            this.end_at.HeaderText = "Дата до";
            this.end_at.MinimumWidth = 10;
            this.end_at.Name = "end_at";
            this.end_at.ReadOnly = true;
            this.end_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // location_id
            // 
            this.location_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location_id.DataPropertyName = "location_id";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.location_id.DefaultCellStyle = dataGridViewCellStyle4;
            this.location_id.HeaderText = "Сумма, руб.";
            this.location_id.Name = "location_id";
            this.location_id.ReadOnly = true;
            this.location_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.location_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 125);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(123, 46, 0, 0);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(228, 33);
            this.CustomerComboBox.TabIndex = 70;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBox.Location = new System.Drawing.Point(326, 125);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(22, 3, 0, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(243, 33);
            this.SearchTextBox.TabIndex = 71;
            this.SearchTextBox.Text = "Сумма";
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.White;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ImportButton.FlatAppearance.BorderSize = 2;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ImportButton.Location = new System.Drawing.Point(591, 125);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(22, 34, 0, 0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(179, 33);
            this.ImportButton.TabIndex = 72;
            this.ImportButton.Text = "Импорт данных";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddUserLabel.Location = new System.Drawing.Point(818, 128);
            this.AddUserLabel.Margin = new System.Windows.Forms.Padding(48, 0, 3, 0);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(166, 25);
            this.AddUserLabel.TabIndex = 73;
            this.AddUserLabel.Text = "+ добавить еще";
            this.AddUserLabel.Visible = false;
            // 
            // ShowApplicationNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.NewApplicationNameLabel);
            this.Controls.Add(this.ToDraftButton);
            this.Controls.Add(this.Acceptbutton);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowApplicationNewFood";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewApplicationNameLabel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button ToDraftButton;
        private System.Windows.Forms.Button Acceptbutton;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label AddUserLabel;
    }
}