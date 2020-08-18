namespace Admin_Panel_Hotel.ApplicationsFolder
{
    partial class NewApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Castomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showApplication = new System.Windows.Forms.DataGridViewImageColumn();
            this.applicationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.PeriodToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PeriodFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Acceptbutton = new System.Windows.Forms.Button();
            this.AddUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Castomer
            // 
            this.Castomer.HeaderText = "Заявка №";
            this.Castomer.Name = "Castomer";
            this.Castomer.ReadOnly = true;
            this.Castomer.Width = 81;
            // 
            // Location
            // 
            this.Location.HeaderText = "Дата";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 55;
            // 
            // ApplicationsDataGridView
            // 
            this.ApplicationsDataGridView.AllowUserToAddRows = false;
            this.ApplicationsDataGridView.AllowUserToDeleteRows = false;
            this.ApplicationsDataGridView.AllowUserToResizeColumns = false;
            this.ApplicationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ApplicationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ApplicationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApplicationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ApplicationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApplicationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApplicationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ApplicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsDataGridView.ColumnHeadersVisible = false;
            this.ApplicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.date,
            this.showApplication,
            this.applicationid,
            this.customerid});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ApplicationsDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.ApplicationsDataGridView.EnableHeadersVisualStyles = false;
            this.ApplicationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.Location = new System.Drawing.Point(76, 165);
            this.ApplicationsDataGridView.Margin = new System.Windows.Forms.Padding(122, 42, 5, 4);
            this.ApplicationsDataGridView.MultiSelect = false;
            this.ApplicationsDataGridView.Name = "ApplicationsDataGridView";
            this.ApplicationsDataGridView.ReadOnly = true;
            this.ApplicationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApplicationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ApplicationsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ApplicationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.RowTemplate.Height = 25;
            this.ApplicationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ApplicationsDataGridView.Size = new System.Drawing.Size(1003, 612);
            this.ApplicationsDataGridView.TabIndex = 56;
            this.ApplicationsDataGridView.TabStop = false;
            this.ApplicationsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApplicationsDataGridView_CellMouseClick);
            this.ApplicationsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApplicationsDataGridView_CellMouseMove);
            this.ApplicationsDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ApplicationsDataGridView_CellPainting);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle10;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.date.DefaultCellStyle = dataGridViewCellStyle11;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 5;
            // 
            // showApplication
            // 
            this.showApplication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.showApplication.HeaderText = "Просмотр";
            this.showApplication.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.showApplication.Name = "showApplication";
            this.showApplication.ReadOnly = true;
            this.showApplication.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.showApplication.Width = 5;
            // 
            // applicationid
            // 
            this.applicationid.DataPropertyName = "application_id";
            this.applicationid.HeaderText = "applicationid";
            this.applicationid.Name = "applicationid";
            this.applicationid.ReadOnly = true;
            this.applicationid.Visible = false;
            // 
            // customerid
            // 
            this.customerid.DataPropertyName = "customer_id";
            this.customerid.HeaderText = "customer_id";
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "Новые заявки";
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel.Location = new System.Drawing.Point(284, 425);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(525, 44);
            this.NotificationLabel.TabIndex = 58;
            this.NotificationLabel.Text = "У вас пока нет Новых заявок";
            this.NotificationLabel.Visible = false;
            // 
            // PeriodToDateTimePicker
            // 
            this.PeriodToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodToDateTimePicker.Location = new System.Drawing.Point(678, 116);
            this.PeriodToDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.PeriodToDateTimePicker.Name = "PeriodToDateTimePicker";
            this.PeriodToDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodToDateTimePicker.TabIndex = 63;
            // 
            // PeriodFromDateTimePicker
            // 
            this.PeriodFromDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodFromDateTimePicker.Location = new System.Drawing.Point(494, 116);
            this.PeriodFromDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 24, 5);
            this.PeriodFromDateTimePicker.Name = "PeriodFromDateTimePicker";
            this.PeriodFromDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodFromDateTimePicker.TabIndex = 62;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerComboBox.DisplayMember = "name";
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerComboBox.ForeColor = System.Drawing.Color.Black;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Items.AddRange(new object[] {
            "Все заказчики"});
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 116);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(122, 37, 20, 10);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(188, 33);
            this.CustomerComboBox.TabIndex = 59;
            this.CustomerComboBox.ValueMember = "id";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все заказчики"});
            this.comboBox1.Location = new System.Drawing.Point(284, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0, 37, 22, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.ValueMember = "id";
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
            this.ImportButton.Location = new System.Drawing.Point(871, 116);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(22, 34, 0, 0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(208, 33);
            this.ImportButton.TabIndex = 65;
            this.ImportButton.Text = "Импорт данных";
            this.ImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Visible = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(949, 44);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(33, 23, 124, 44);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(131, 35);
            this.PrintButton.TabIndex = 66;
            this.PrintButton.Text = "Черновик";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // Acceptbutton
            // 
            this.Acceptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.Acceptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Acceptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceptbutton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acceptbutton.ForeColor = System.Drawing.Color.White;
            this.Acceptbutton.Location = new System.Drawing.Point(831, 792);
            this.Acceptbutton.Margin = new System.Windows.Forms.Padding(3, 46, 3, 3);
            this.Acceptbutton.Name = "Acceptbutton";
            this.Acceptbutton.Size = new System.Drawing.Size(248, 38);
            this.Acceptbutton.TabIndex = 67;
            this.Acceptbutton.Text = "Отправить заказчику";
            this.Acceptbutton.UseVisualStyleBackColor = false;
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddUserLabel.Location = new System.Drawing.Point(71, 799);
            this.AddUserLabel.Margin = new System.Windows.Forms.Padding(48, 0, 3, 0);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(166, 25);
            this.AddUserLabel.TabIndex = 68;
            this.AddUserLabel.Text = "+ добавить еще";
            this.AddUserLabel.Visible = false;
            // 
            // NewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.Acceptbutton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PeriodToDateTimePicker);
            this.Controls.Add(this.PeriodFromDateTimePicker);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplicationsDataGridView);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewApplications";
            this.Text = "Applications";
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Castomer;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridView ApplicationsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewImageColumn showApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DateTimePicker PeriodToDateTimePicker;
        private System.Windows.Forms.DateTimePicker PeriodFromDateTimePicker;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button Acceptbutton;
        private System.Windows.Forms.Label AddUserLabel;
    }
}