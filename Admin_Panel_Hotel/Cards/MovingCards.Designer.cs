namespace Admin_Panel_Hotel.Cards
{
    partial class MovingCards
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
            this.CardCountLabel = new System.Windows.Forms.Label();
            this.FilterLocationComboBox = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.AllCardLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CardsDataGridView = new System.Windows.Forms.DataGridView();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.card_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CardCountLabel
            // 
            this.CardCountLabel.AutoSize = true;
            this.CardCountLabel.Location = new System.Drawing.Point(71, 784);
            this.CardCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CardCountLabel.Name = "CardCountLabel";
            this.CardCountLabel.Size = new System.Drawing.Size(173, 25);
            this.CardCountLabel.TabIndex = 50;
            this.CardCountLabel.Text = "Карт выбрано: 0";
            // 
            // FilterLocationComboBox
            // 
            this.FilterLocationComboBox.BackColor = System.Drawing.Color.White;
            this.FilterLocationComboBox.DisplayMember = "location_name";
            this.FilterLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterLocationComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterLocationComboBox.FormattingEnabled = true;
            this.FilterLocationComboBox.Items.AddRange(new object[] {
            "Офис"});
            this.FilterLocationComboBox.Location = new System.Drawing.Point(76, 126);
            this.FilterLocationComboBox.Margin = new System.Windows.Forms.Padding(123, 47, 5, 6);
            this.FilterLocationComboBox.Name = "FilterLocationComboBox";
            this.FilterLocationComboBox.Size = new System.Drawing.Size(294, 33);
            this.FilterLocationComboBox.TabIndex = 47;
            this.FilterLocationComboBox.ValueMember = "location_id";
            this.FilterLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterLocationComboBox_SelectedIndexChanged);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(775, 698);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(259, 59);
            this.AcceptButton.TabIndex = 45;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AllCardLabel
            // 
            this.AllCardLabel.AutoSize = true;
            this.AllCardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCardLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCardLabel.Location = new System.Drawing.Point(70, 44);
            this.AllCardLabel.Margin = new System.Windows.Forms.Padding(61, 35, 5, 0);
            this.AllCardLabel.Name = "AllCardLabel";
            this.AllCardLabel.Size = new System.Drawing.Size(275, 35);
            this.AllCardLabel.TabIndex = 43;
            this.AllCardLabel.Text = "Перемещение карт";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // CardsDataGridView
            // 
            this.CardsDataGridView.AllowUserToAddRows = false;
            this.CardsDataGridView.AllowUserToDeleteRows = false;
            this.CardsDataGridView.AllowUserToResizeRows = false;
            this.CardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CardsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CardsDataGridView.ColumnHeadersHeight = 35;
            this.CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.serial_num,
            this.short_name,
            this.status_id,
            this.location_id,
            this.checkBoxColumn,
            this.card_id});
            this.CardsDataGridView.EnableHeadersVisualStyles = false;
            this.CardsDataGridView.GridColor = System.Drawing.Color.Black;
            this.CardsDataGridView.Location = new System.Drawing.Point(76, 187);
            this.CardsDataGridView.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.CardsDataGridView.MultiSelect = false;
            this.CardsDataGridView.Name = "CardsDataGridView";
            this.CardsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CardsDataGridView.RowHeadersVisible = false;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.Height = 30;
            this.CardsDataGridView.Size = new System.Drawing.Size(958, 408);
            this.CardsDataGridView.TabIndex = 54;
            this.CardsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CardsDataGridView_CellMouseUp);
            this.CardsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardsDataGridView_CellValueChanged);
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DisplayMember = "location_name";
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Локация"});
            this.LocationComboBox.Location = new System.Drawing.Point(76, 631);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(250, 33);
            this.LocationComboBox.TabIndex = 55;
            this.LocationComboBox.ValueMember = "location_id";
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(732, 126);
            this.FromTextBox.Margin = new System.Windows.Forms.Padding(36, 3, 3, 3);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 33);
            this.FromTextBox.TabIndex = 56;
            this.FromTextBox.TextChanged += new System.EventHandler(this.FromToTextBox_TextChanged);
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(871, 126);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(36, 3, 3, 3);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(100, 33);
            this.ToTextBox.TabIndex = 57;
            this.ToTextBox.TextChanged += new System.EventHandler(this.FromToTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Диапазон от/до";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(399, 126);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(294, 33);
            this.SearchTextBox.TabIndex = 59;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 38;
            // 
            // serial_num
            // 
            this.serial_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial_num.DataPropertyName = "serial_num";
            this.serial_num.HeaderText = "ID карты";
            this.serial_num.Name = "serial_num";
            this.serial_num.ReadOnly = true;
            this.serial_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // short_name
            // 
            this.short_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.short_name.DataPropertyName = "short_name";
            this.short_name.HeaderText = "Номер карты";
            this.short_name.Name = "short_name";
            this.short_name.ReadOnly = true;
            this.short_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // status_id
            // 
            this.status_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_id.DataPropertyName = "status_id";
            this.status_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.status_id.HeaderText = "Статус";
            this.status_id.Name = "status_id";
            this.status_id.ReadOnly = true;
            this.status_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // location_id
            // 
            this.location_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.location_id.DataPropertyName = "location_id";
            this.location_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.location_id.HeaderText = "Местонахождение";
            this.location_id.Name = "location_id";
            this.location_id.ReadOnly = true;
            this.location_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.location_id.Width = 198;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.checkBoxColumn.HeaderText = "Все";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 51;
            // 
            // card_id
            // 
            this.card_id.DataPropertyName = "card_id";
            this.card_id.HeaderText = "card_id";
            this.card_id.Name = "card_id";
            this.card_id.Visible = false;
            // 
            // MovingCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CardsDataGridView);
            this.Controls.Add(this.CardCountLabel);
            this.Controls.Add(this.FilterLocationComboBox);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.AllCardLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MovingCards";
            this.Text = "MovingGards";
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CardCountLabel;
        private System.Windows.Forms.ComboBox FilterLocationComboBox;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label AllCardLabel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView CardsDataGridView;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn status_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn location_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_id;
    }
}