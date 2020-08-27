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
            this.History = new System.Windows.Forms.Label();
            this.PeriodToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PeriodFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.DowonloadButton = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabNamber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.All = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.Number,
            this.Fio,
            this.TabNamber,
            this.DateStart,
            this.DateEnd,
            this.Location,
            this.All});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(75, 290);
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
            this.UsersDataGridView.Size = new System.Drawing.Size(996, 590);
            this.UsersDataGridView.TabIndex = 18;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Location = new System.Drawing.Point(70, 44);
            this.History.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(131, 35);
            this.History.TabIndex = 19;
            this.History.Text = "История";
            // 
            // PeriodToDateTimePicker
            // 
            this.PeriodToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodToDateTimePicker.Location = new System.Drawing.Point(353, 174);
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
            this.PeriodFromDateTimePicker.Location = new System.Drawing.Point(118, 174);
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
            this.label3.Location = new System.Drawing.Point(293, 177);
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
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(61, 0, 5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 141);
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
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 229);
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
            this.FindTextBox.Location = new System.Drawing.Point(773, 174);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(368, 8, 3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(258, 33);
            this.FindTextBox.TabIndex = 65;
            this.FindTextBox.Text = "Поиск";
            // 
            // DowonloadButton
            // 
            this.DowonloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.DowonloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DowonloadButton.FlatAppearance.BorderSize = 0;
            this.DowonloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DowonloadButton.ForeColor = System.Drawing.Color.White;
            this.DowonloadButton.Location = new System.Drawing.Point(858, 28);
            this.DowonloadButton.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.DowonloadButton.Name = "DowonloadButton";
            this.DowonloadButton.Size = new System.Drawing.Size(173, 33);
            this.DowonloadButton.TabIndex = 66;
            this.DowonloadButton.Text = "Скачать";
            this.DowonloadButton.UseVisualStyleBackColor = false;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number.FillWeight = 20F;
            this.Number.Frozen = true;
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 33;
            // 
            // Fio
            // 
            this.Fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Fio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fio.FillWeight = 112.3096F;
            this.Fio.Frozen = true;
            this.Fio.HeaderText = "ФИО";
            this.Fio.MinimumWidth = 100;
            this.Fio.Name = "Fio";
            this.Fio.ReadOnly = true;
            this.Fio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fio.Width = 187;
            // 
            // TabNamber
            // 
            this.TabNamber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TabNamber.FillWeight = 112.3096F;
            this.TabNamber.Frozen = true;
            this.TabNamber.HeaderText = "Таб.номер";
            this.TabNamber.Name = "TabNamber";
            this.TabNamber.ReadOnly = true;
            this.TabNamber.Width = 186;
            // 
            // DateStart
            // 
            this.DateStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateStart.FillWeight = 112.3096F;
            this.DateStart.Frozen = true;
            this.DateStart.HeaderText = "Дата от";
            this.DateStart.MinimumWidth = 10;
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            this.DateStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateStart.Width = 187;
            // 
            // DateEnd
            // 
            this.DateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateEnd.FillWeight = 112.3096F;
            this.DateEnd.Frozen = true;
            this.DateEnd.HeaderText = "Дата до";
            this.DateEnd.MinimumWidth = 10;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            this.DateEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateEnd.Width = 186;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Location.Frozen = true;
            this.Location.HeaderText = "Локация";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Location.Width = 166;
            // 
            // All
            // 
            this.All.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.All.HeaderText = "Все";
            this.All.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.All.Name = "All";
            this.All.ReadOnly = true;
            this.All.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.All.Width = 51;
            // 
            // HistoryAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.DowonloadButton);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PeriodToDateTimePicker);
            this.Controls.Add(this.PeriodFromDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.History);
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
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.DateTimePicker PeriodToDateTimePicker;
        private System.Windows.Forms.DateTimePicker PeriodFromDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button DowonloadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNamber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewImageColumn All;
    }
}