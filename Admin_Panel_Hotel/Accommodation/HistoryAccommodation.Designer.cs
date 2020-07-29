namespace Admin_Panel_Hotel.Accommodation
{
    partial class HistoryAccommodation
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowUserInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PeriodToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PeriodFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.ShowUserInfo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(65, 290);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(122, 42, 51, 5);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.UsersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDataGridView.RowTemplate.Height = 30;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(994, 590);
            this.UsersDataGridView.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 20F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 33;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 112.3096F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 187;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 112.3096F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Таб.номер";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 186;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 112.3096F;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Дата от";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 187;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 112.3096F;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Дата до";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 186;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Локация";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 166;
            // 
            // ShowUserInfo
            // 
            this.ShowUserInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ShowUserInfo.HeaderText = "Все";
            this.ShowUserInfo.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.ShowUserInfo.Name = "ShowUserInfo";
            this.ShowUserInfo.ReadOnly = true;
            this.ShowUserInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowUserInfo.Width = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "История";
            // 
            // PeriodToDateTimePicker
            // 
            this.PeriodToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodToDateTimePicker.Location = new System.Drawing.Point(324, 174);
            this.PeriodToDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.PeriodToDateTimePicker.Name = "PeriodToDateTimePicker";
            this.PeriodToDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodToDateTimePicker.TabIndex = 60;
            // 
            // PeriodFromDateTimePicker
            // 
            this.PeriodFromDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodFromDateTimePicker.Location = new System.Drawing.Point(101, 174);
            this.PeriodFromDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 25, 5);
            this.PeriodFromDateTimePicker.Name = "PeriodFromDateTimePicker";
            this.PeriodFromDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodFromDateTimePicker.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(274, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(141, 54, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Диапазон проживания";
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
            this.CustomerComboBox.Location = new System.Drawing.Point(65, 229);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(122, 37, 22, 10);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(234, 33);
            this.CustomerComboBox.TabIndex = 62;
            this.CustomerComboBox.ValueMember = "id";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.White;
            this.LocationComboBox.DisplayMember = "location_name";
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Все локации"});
            this.LocationComboBox.Location = new System.Drawing.Point(343, 229);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(22, 10, 43, 10);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(236, 33);
            this.LocationComboBox.TabIndex = 63;
            this.LocationComboBox.ValueMember = "location_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 115, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Табельный номер/ФИО";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindTextBox.ForeColor = System.Drawing.Color.Silver;
            this.FindTextBox.Location = new System.Drawing.Point(761, 174);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(368, 8, 3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(258, 33);
            this.FindTextBox.TabIndex = 65;
            this.FindTextBox.Text = "Поиск";
            // 
            // HistoryAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PeriodToDateTimePicker);
            this.Controls.Add(this.PeriodFromDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersDataGridView);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HistoryAccommodation";
            this.Text = "HistoryAccommodation";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn ShowUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PeriodToDateTimePicker;
        private System.Windows.Forms.DateTimePicker PeriodFromDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FindTextBox;
    }
}