namespace Admin_Panel_Hotel.Guests
{
    partial class EvictionGuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.todayLabel = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.PeriodToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PeriodFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выселение гостей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(316, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(371, 349, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "У вас сегодня нет гостей на выселение";
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
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(138, 177);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(127, 20, 123, 5);
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
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(919, 577);
            this.UsersDataGridView.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 112.3096F;
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 112.3096F;
            this.Column3.HeaderText = "Таб.номер";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 112.3096F;
            this.Column4.HeaderText = "Заехал";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 112.3096F;
            this.Column5.HeaderText = "Выезд";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Заселить";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Roboto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.todayLabel.Location = new System.Drawing.Point(144, 128);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(135, 49, 0, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(107, 29);
            this.todayLabel.TabIndex = 26;
            this.todayLabel.Text = "Сегодня";
            this.todayLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tomorrowLabel.Location = new System.Drawing.Point(295, 128);
            this.tomorrowLabel.Margin = new System.Windows.Forms.Padding(45, 49, 0, 0);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(100, 29);
            this.tomorrowLabel.TabIndex = 27;
            this.tomorrowLabel.Text = "Завтра";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.afterLabel.Location = new System.Drawing.Point(432, 128);
            this.afterLabel.Margin = new System.Windows.Forms.Padding(45, 49, 0, 0);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(173, 29);
            this.afterLabel.TabIndex = 28;
            this.afterLabel.Text = "Послезавтра";
            // 
            // PeriodToDateTimePicker
            // 
            this.PeriodToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodToDateTimePicker.Location = new System.Drawing.Point(911, 128);
            this.PeriodToDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PeriodToDateTimePicker.Name = "PeriodToDateTimePicker";
            this.PeriodToDateTimePicker.Size = new System.Drawing.Size(146, 33);
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
            this.PeriodFromDateTimePicker.Location = new System.Drawing.Point(733, 128);
            this.PeriodFromDateTimePicker.Margin = new System.Windows.Forms.Padding(157, 0, 25, 5);
            this.PeriodFromDateTimePicker.Name = "PeriodFromDateTimePicker";
            this.PeriodFromDateTimePicker.Size = new System.Drawing.Size(148, 33);
            this.PeriodFromDateTimePicker.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label6.Location = new System.Drawing.Point(906, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Период до";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label7.Location = new System.Drawing.Point(728, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Период от";
            // 
            // EvictionGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.PeriodToDateTimePicker);
            this.Controls.Add(this.PeriodFromDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersDataGridView);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EvictionGuest";
            this.Text = "NewGuest";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.DateTimePicker PeriodToDateTimePicker;
        private System.Windows.Forms.DateTimePicker PeriodFromDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}