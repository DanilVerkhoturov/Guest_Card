namespace Admin_Panel_Hotel.Customers
{
    partial class CustomerInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.EditCustomerInfoButton = new System.Windows.Forms.Button();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.LocationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameLabel.AutoEllipsis = true;
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(70, 44);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.CustomerNameLabel.MaximumSize = new System.Drawing.Size(600, 35);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(247, 35);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Мои заказчики >";
            // 
            // EditCustomerInfoButton
            // 
            this.EditCustomerInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditCustomerInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.EditCustomerInfoButton.FlatAppearance.BorderSize = 0;
            this.EditCustomerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomerInfoButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.EditCustomerInfoButton.Location = new System.Drawing.Point(686, 43);
            this.EditCustomerInfoButton.Margin = new System.Windows.Forms.Padding(244, 34, 3, 3);
            this.EditCustomerInfoButton.Name = "EditCustomerInfoButton";
            this.EditCustomerInfoButton.Size = new System.Drawing.Size(131, 37);
            this.EditCustomerInfoButton.TabIndex = 1;
            this.EditCustomerInfoButton.Text = "Изменить";
            this.EditCustomerInfoButton.UseVisualStyleBackColor = false;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.AddLocationButton.FlatAppearance.BorderSize = 0;
            this.AddLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocationButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLocationButton.ForeColor = System.Drawing.Color.White;
            this.AddLocationButton.Location = new System.Drawing.Point(853, 43);
            this.AddLocationButton.Margin = new System.Windows.Forms.Padding(33, 34, 3, 3);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(131, 37);
            this.AddLocationButton.TabIndex = 2;
            this.AddLocationButton.Text = "Добавить";
            this.AddLocationButton.UseVisualStyleBackColor = false;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterComboBox.BackColor = System.Drawing.Color.White;
            this.FilterComboBox.ForeColor = System.Drawing.Color.Silver;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Все локации"});
            this.FilterComboBox.Location = new System.Drawing.Point(132, 113);
            this.FilterComboBox.Margin = new System.Windows.Forms.Padding(123, 34, 3, 3);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(239, 33);
            this.FilterComboBox.TabIndex = 3;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.ForeColor = System.Drawing.Color.Silver;
            this.FindTextBox.Location = new System.Drawing.Point(398, 113);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(236, 33);
            this.FindTextBox.TabIndex = 4;
            this.FindTextBox.Text = "Поиск";
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
            this.LocationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LocationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LocationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.LocationsDataGridView.EnableHeadersVisualStyles = false;
            this.LocationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.LocationsDataGridView.Location = new System.Drawing.Point(132, 181);
            this.LocationsDataGridView.Margin = new System.Windows.Forms.Padding(5, 32, 5, 4);
            this.LocationsDataGridView.MultiSelect = false;
            this.LocationsDataGridView.Name = "LocationsDataGridView";
            this.LocationsDataGridView.ReadOnly = true;
            this.LocationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LocationsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(17, 14, 17, 14);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LocationsDataGridView.RowTemplate.Height = 25;
            this.LocationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.LocationsDataGridView.Size = new System.Drawing.Size(852, 658);
            this.LocationsDataGridView.TabIndex = 47;
            this.LocationsDataGridView.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.LocationsDataGridView);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.EditCustomerInfoButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1029, 933);
            this.MinimumSize = new System.Drawing.Size(1029, 933);
            this.Name = "CustomerInfoForm";
            this.Text = "CustomerInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.LocationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button EditCustomerInfoButton;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.DataGridView LocationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}