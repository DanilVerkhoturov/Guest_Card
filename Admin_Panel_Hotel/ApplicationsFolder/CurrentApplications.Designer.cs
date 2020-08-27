namespace Admin_Panel_Hotel.ApplicationsFolder
{
    partial class CurrentApplications
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
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ApplicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showApplication = new System.Windows.Forms.DataGridViewImageColumn();
            this.applicationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLabel.Location = new System.Drawing.Point(70, 32);
            this.CurrentLabel.Margin = new System.Windows.Forms.Padding(61, 23, 6, 0);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(236, 35);
            this.CurrentLabel.TabIndex = 2;
            this.CurrentLabel.Text = "Текущие заявки";
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
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 104);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(122, 37, 0, 0);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(223, 33);
            this.CustomerComboBox.TabIndex = 35;
            this.CustomerComboBox.ValueMember = "id";
            // 
            // ApplicationsDataGridView
            // 
            this.ApplicationsDataGridView.AllowUserToAddRows = false;
            this.ApplicationsDataGridView.AllowUserToDeleteRows = false;
            this.ApplicationsDataGridView.AllowUserToResizeColumns = false;
            this.ApplicationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ApplicationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApplicationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ApplicationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApplicationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApplicationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ApplicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationsDataGridView.ColumnHeadersVisible = false;
            this.ApplicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.date,
            this.showApplication,
            this.applicationid,
            this.customerid});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ApplicationsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ApplicationsDataGridView.EnableHeadersVisualStyles = false;
            this.ApplicationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.Location = new System.Drawing.Point(76, 153);
            this.ApplicationsDataGridView.Margin = new System.Windows.Forms.Padding(5, 16, 5, 4);
            this.ApplicationsDataGridView.MultiSelect = false;
            this.ApplicationsDataGridView.Name = "ApplicationsDataGridView";
            this.ApplicationsDataGridView.ReadOnly = true;
            this.ApplicationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApplicationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ApplicationsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ApplicationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ApplicationsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ApplicationsDataGridView.RowTemplate.Height = 25;
            this.ApplicationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ApplicationsDataGridView.Size = new System.Drawing.Size(907, 658);
            this.ApplicationsDataGridView.TabIndex = 48;
            this.ApplicationsDataGridView.TabStop = false;
            this.ApplicationsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApplicationsDataGridView_CellMouseClick);
            this.ApplicationsDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ApplicationsDataGridView_CellMouseMove);
            this.ApplicationsDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ApplicationsDataGridView_CellPainting);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.date.DefaultCellStyle = dataGridViewCellStyle4;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 5;
            // 
            // showApplication
            // 
            this.showApplication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            this.customerid.HeaderText = "customerid";
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Visible = false;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel.Location = new System.Drawing.Point(284, 425);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(557, 44);
            this.NotificationLabel.TabIndex = 58;
            this.NotificationLabel.Text = "У вас пока нет Текущих заявок";
            this.NotificationLabel.Visible = false;
            // 
            // CurrentApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.ApplicationsDataGridView);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CurrentLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrentApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Applications";
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.DataGridView ApplicationsDataGridView;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewImageColumn showApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
    }
}