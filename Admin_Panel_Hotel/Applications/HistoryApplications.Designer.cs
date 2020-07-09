namespace Admin_Panel_Hotel
{
    partial class HistoryApplications
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
            this.Castomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PeriodToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShowAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CardsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).BeginInit();
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
            // HistoryDataGridView
            // 
            this.HistoryDataGridView.AllowUserToAddRows = false;
            this.HistoryDataGridView.AllowUserToDeleteRows = false;
            this.HistoryDataGridView.AllowUserToResizeColumns = false;
            this.HistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.HistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataGridView.ColumnHeadersVisible = false;
            this.HistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.HistoryDataGridView.EnableHeadersVisualStyles = false;
            this.HistoryDataGridView.GridColor = System.Drawing.Color.Black;
            this.HistoryDataGridView.Location = new System.Drawing.Point(76, 189);
            this.HistoryDataGridView.Margin = new System.Windows.Forms.Padding(209, 27, 7, 7);
            this.HistoryDataGridView.MultiSelect = false;
            this.HistoryDataGridView.Name = "HistoryDataGridView";
            this.HistoryDataGridView.ReadOnly = true;
            this.HistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.HistoryDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.HistoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.HistoryDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.HistoryDataGridView.RowTemplate.Height = 25;
            this.HistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.HistoryDataGridView.Size = new System.Drawing.Size(907, 507);
            this.HistoryDataGridView.TabIndex = 52;
            this.HistoryDataGridView.TabStop = false;
            this.HistoryDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HistoryDataGridView_CellMouseClick);
            this.HistoryDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HistoryDataGridView_CellMouseMove);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Дата";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 5;
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
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.White;
            this.LocationComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Все локации"});
            this.LocationComboBox.Location = new System.Drawing.Point(354, 119);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(22, 10, 43, 10);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(236, 33);
            this.LocationComboBox.TabIndex = 51;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerComboBox.ForeColor = System.Drawing.Color.Black;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Items.AddRange(new object[] {
            "Все заказчики"});
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 119);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(122, 37, 22, 10);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(234, 33);
            this.CustomerComboBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 49;
            this.label1.Text = "История заявок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(628, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Период от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label3.Location = new System.Drawing.Point(818, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Период до";
            // 
            // PeriodFromDateTimePicker
            // 
            this.PeriodFromDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PeriodFromDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodFromDateTimePicker.Location = new System.Drawing.Point(633, 119);
            this.PeriodFromDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 25, 5);
            this.PeriodFromDateTimePicker.Name = "PeriodFromDateTimePicker";
            this.PeriodFromDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodFromDateTimePicker.TabIndex = 55;
            // 
            // PeriodToDateTimePicker
            // 
            this.PeriodToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodToDateTimePicker.Location = new System.Drawing.Point(823, 119);
            this.PeriodToDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PeriodToDateTimePicker.Name = "PeriodToDateTimePicker";
            this.PeriodToDateTimePicker.Size = new System.Drawing.Size(160, 33);
            this.PeriodToDateTimePicker.TabIndex = 56;
            // 
            // ShowAllLinkLabel
            // 
            this.ShowAllLinkLabel.AutoSize = true;
            this.ShowAllLinkLabel.Location = new System.Drawing.Point(310, 703);
            this.ShowAllLinkLabel.Margin = new System.Windows.Forms.Padding(60, 0, 9, 0);
            this.ShowAllLinkLabel.Name = "ShowAllLinkLabel";
            this.ShowAllLinkLabel.Size = new System.Drawing.Size(143, 25);
            this.ShowAllLinkLabel.TabIndex = 58;
            this.ShowAllLinkLabel.TabStop = true;
            this.ShowAllLinkLabel.Text = "Показать все";
            // 
            // CardsCountLabel
            // 
            this.CardsCountLabel.AutoSize = true;
            this.CardsCountLabel.Location = new System.Drawing.Point(71, 703);
            this.CardsCountLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.CardsCountLabel.Name = "CardsCountLabel";
            this.CardsCountLabel.Size = new System.Drawing.Size(196, 25);
            this.CardsCountLabel.TabIndex = 57;
            this.CardsCountLabel.Text = "1-50 из 10000 карт";
            // 
            // HistoryApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.ShowAllLinkLabel);
            this.Controls.Add(this.CardsCountLabel);
            this.Controls.Add(this.PeriodToDateTimePicker);
            this.Controls.Add(this.PeriodFromDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistoryDataGridView);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HistoryApplications";
            this.Text = "Applications";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Castomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridView HistoryDataGridView;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PeriodFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker PeriodToDateTimePicker;
        private System.Windows.Forms.LinkLabel ShowAllLinkLabel;
        private System.Windows.Forms.Label CardsCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}