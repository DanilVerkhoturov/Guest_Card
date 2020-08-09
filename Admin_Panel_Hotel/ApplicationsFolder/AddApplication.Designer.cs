﻿namespace Admin_Panel_Hotel.ApplicationsFolder
{
    partial class AddApplication
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.SendToCustomerButton = new System.Windows.Forms.Button();
            this.ToDraftButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.fio,
            this.tabNum,
            this.from,
            this.to,
            this.location});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.UsersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(76, 169);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(4, 21, 4, 5);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.UsersDataGridView.TabIndex = 51;
            this.UsersDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellEndEdit);
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddUserLabel.Location = new System.Drawing.Point(901, 118);
            this.AddUserLabel.Margin = new System.Windows.Forms.Padding(48, 0, 3, 0);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(166, 25);
            this.AddUserLabel.TabIndex = 59;
            this.AddUserLabel.Text = "+ добавить еще";
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
            this.ImportButton.Location = new System.Drawing.Point(680, 115);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(22, 34, 0, 0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(186, 33);
            this.ImportButton.TabIndex = 58;
            this.ImportButton.Text = "Импорт данных";
            this.ImportButton.UseVisualStyleBackColor = false;
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
            "Локация"});
            this.LocationComboBox.Location = new System.Drawing.Point(378, 115);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(22, 6, 0, 0);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(280, 33);
            this.LocationComboBox.TabIndex = 57;
            this.LocationComboBox.ValueMember = "location_id";
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
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
            "Заказчик"});
            this.CustomerComboBox.Location = new System.Drawing.Point(76, 115);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(123, 48, 0, 0);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(280, 33);
            this.CustomerComboBox.TabIndex = 56;
            this.CustomerComboBox.ValueMember = "id";
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // SendToCustomerButton
            // 
            this.SendToCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SendToCustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendToCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToCustomerButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendToCustomerButton.ForeColor = System.Drawing.Color.White;
            this.SendToCustomerButton.Location = new System.Drawing.Point(802, 778);
            this.SendToCustomerButton.Name = "SendToCustomerButton";
            this.SendToCustomerButton.Size = new System.Drawing.Size(265, 48);
            this.SendToCustomerButton.TabIndex = 55;
            this.SendToCustomerButton.Text = "Отправить заказчику";
            this.SendToCustomerButton.UseVisualStyleBackColor = false;
            this.SendToCustomerButton.Click += new System.EventHandler(this.SendToCustomerButton_Click);
            // 
            // ToDraftButton
            // 
            this.ToDraftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.ToDraftButton.FlatAppearance.BorderSize = 0;
            this.ToDraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDraftButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraftButton.ForeColor = System.Drawing.Color.White;
            this.ToDraftButton.Location = new System.Drawing.Point(927, 36);
            this.ToDraftButton.Margin = new System.Windows.Forms.Padding(33, 23, 3, 3);
            this.ToDraftButton.Name = "ToDraftButton";
            this.ToDraftButton.Size = new System.Drawing.Size(140, 35);
            this.ToDraftButton.TabIndex = 53;
            this.ToDraftButton.Text = "Черновик";
            this.ToDraftButton.UseVisualStyleBackColor = false;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormNameLabel.Location = new System.Drawing.Point(70, 32);
            this.FormNameLabel.Margin = new System.Windows.Forms.Padding(61, 23, 4, 0);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(251, 35);
            this.FormNameLabel.TabIndex = 50;
            this.FormNameLabel.Text = "Добавить заявку";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 57;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fio.DefaultCellStyle = dataGridViewCellStyle3;
            this.fio.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fio.FillWeight = 112.3096F;
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabNum
            // 
            this.tabNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tabNum.FillWeight = 112.3096F;
            this.tabNum.HeaderText = "Таб.номер";
            this.tabNum.Name = "tabNum";
            this.tabNum.Width = 138;
            // 
            // from
            // 
            this.from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.from.DefaultCellStyle = dataGridViewCellStyle4;
            this.from.FillWeight = 112.3096F;
            this.from.HeaderText = "Дата от";
            this.from.MinimumWidth = 10;
            this.from.Name = "from";
            this.from.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // to
            // 
            this.to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.to.DefaultCellStyle = dataGridViewCellStyle5;
            this.to.FillWeight = 112.3096F;
            this.to.HeaderText = "Дата до";
            this.to.MinimumWidth = 10;
            this.to.Name = "to";
            this.to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // AddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.SendToCustomerButton);
            this.Controls.Add(this.ToDraftButton);
            this.Controls.Add(this.FormNameLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddApplication";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Button SendToCustomerButton;
        private System.Windows.Forms.Button ToDraftButton;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewComboBoxColumn location;
    }
}