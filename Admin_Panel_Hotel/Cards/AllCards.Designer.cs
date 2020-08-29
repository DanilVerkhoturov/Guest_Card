namespace Admin_Panel_Hotel.Cards
{
    partial class AllCards
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
            this.CardsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showUserInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AllCardLabel = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CardsCountLabel = new System.Windows.Forms.Label();
            this.ShowAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeStatusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsDataGridView
            // 
            this.CardsDataGridView.AllowUserToAddRows = false;
            this.CardsDataGridView.AllowUserToDeleteRows = false;
            this.CardsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CardsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CardsDataGridView.ColumnHeadersHeight = 35;
            this.CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.serialNum,
            this.shortName,
            this.status_id,
            this.placeName,
            this.card_id,
            this.showUserInfo,
            this.checkBoxColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CardsDataGridView.EnableHeadersVisualStyles = false;
            this.CardsDataGridView.Location = new System.Drawing.Point(76, 185);
            this.CardsDataGridView.Margin = new System.Windows.Forms.Padding(5, 21, 5, 6);
            this.CardsDataGridView.Name = "CardsDataGridView";
            this.CardsDataGridView.ReadOnly = true;
            this.CardsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CardsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.CardsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.Height = 30;
            this.CardsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CardsDataGridView.Size = new System.Drawing.Size(983, 441);
            this.CardsDataGridView.TabIndex = 26;
            this.CardsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CardsDataGridView_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.FillWeight = 20F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 57;
            // 
            // serialNum
            // 
            this.serialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialNum.DataPropertyName = "serial_num";
            this.serialNum.FillWeight = 112.3096F;
            this.serialNum.HeaderText = "ID карты";
            this.serialNum.Name = "serialNum";
            this.serialNum.ReadOnly = true;
            this.serialNum.Visible = false;
            // 
            // shortName
            // 
            this.shortName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shortName.DataPropertyName = "short_name";
            this.shortName.HeaderText = "Номер карты";
            this.shortName.Name = "shortName";
            this.shortName.ReadOnly = true;
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
            // placeName
            // 
            this.placeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeName.DataPropertyName = "place_name";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.placeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.placeName.HeaderText = "Местонахождение";
            this.placeName.Name = "placeName";
            this.placeName.ReadOnly = true;
            this.placeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.placeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // card_id
            // 
            this.card_id.DataPropertyName = "card_id";
            this.card_id.HeaderText = "card_id";
            this.card_id.Name = "card_id";
            this.card_id.ReadOnly = true;
            this.card_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.card_id.Visible = false;
            // 
            // showUserInfo
            // 
            this.showUserInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.showUserInfo.HeaderText = "Все";
            this.showUserInfo.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.showUserInfo.Name = "showUserInfo";
            this.showUserInfo.ReadOnly = true;
            this.showUserInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.showUserInfo.Width = 51;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.NullValue = false;
            this.checkBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkBoxColumn.FalseValue = "0";
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.IndeterminateValue = "0";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.ReadOnly = true;
            this.checkBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBoxColumn.TrueValue = "1";
            this.checkBoxColumn.Visible = false;
            this.checkBoxColumn.Width = 30;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(841, 760);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(218, 48);
            this.AcceptButton.TabIndex = 25;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Visible = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.DownloadButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.ForeColor = System.Drawing.Color.White;
            this.DownloadButton.Location = new System.Drawing.Point(934, 44);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(125, 35);
            this.DownloadButton.TabIndex = 22;
            this.DownloadButton.Text = "Скачать";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AllCardLabel
            // 
            this.AllCardLabel.AutoSize = true;
            this.AllCardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCardLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCardLabel.Location = new System.Drawing.Point(70, 44);
            this.AllCardLabel.Margin = new System.Windows.Forms.Padding(61, 35, 5, 0);
            this.AllCardLabel.Name = "AllCardLabel";
            this.AllCardLabel.Size = new System.Drawing.Size(154, 35);
            this.AllCardLabel.TabIndex = 18;
            this.AllCardLabel.Text = "Все карты";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.White;
            this.LocationComboBox.DisplayMember = "location_name";
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Все карты"});
            this.LocationComboBox.Location = new System.Drawing.Point(76, 127);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(123, 48, 5, 4);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(288, 33);
            this.LocationComboBox.TabIndex = 38;
            this.LocationComboBox.ValueMember = "location_id";
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            // 
            // CardsCountLabel
            // 
            this.CardsCountLabel.AutoSize = true;
            this.CardsCountLabel.Location = new System.Drawing.Point(71, 760);
            this.CardsCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CardsCountLabel.Name = "CardsCountLabel";
            this.CardsCountLabel.Size = new System.Drawing.Size(196, 25);
            this.CardsCountLabel.TabIndex = 41;
            this.CardsCountLabel.Text = "1-50 из 10000 карт";
            // 
            // ShowAllLinkLabel
            // 
            this.ShowAllLinkLabel.AutoSize = true;
            this.ShowAllLinkLabel.Location = new System.Drawing.Point(307, 760);
            this.ShowAllLinkLabel.Margin = new System.Windows.Forms.Padding(35, 0, 5, 0);
            this.ShowAllLinkLabel.Name = "ShowAllLinkLabel";
            this.ShowAllLinkLabel.Size = new System.Drawing.Size(143, 25);
            this.ShowAllLinkLabel.TabIndex = 42;
            this.ShowAllLinkLabel.TabStop = true;
            this.ShowAllLinkLabel.Text = "Показать все";
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
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(391, 127);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(274, 33);
            this.SearchTextBox.TabIndex = 43;
            this.SearchTextBox.Text = "Поиск";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DisplayMember = "status_name";
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Статус"});
            this.StatusComboBox.Location = new System.Drawing.Point(76, 665);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(288, 33);
            this.StatusComboBox.TabIndex = 44;
            this.StatusComboBox.ValueMember = "status_id";
            this.StatusComboBox.Visible = false;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ChangeStatusButton
            // 
            this.ChangeStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ChangeStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChangeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeStatusButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStatusButton.ForeColor = System.Drawing.Color.White;
            this.ChangeStatusButton.Location = new System.Drawing.Point(668, 44);
            this.ChangeStatusButton.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.ChangeStatusButton.Name = "ChangeStatusButton";
            this.ChangeStatusButton.Size = new System.Drawing.Size(228, 35);
            this.ChangeStatusButton.TabIndex = 45;
            this.ChangeStatusButton.Text = "Изменить статус";
            this.ChangeStatusButton.UseVisualStyleBackColor = false;
            this.ChangeStatusButton.Click += new System.EventHandler(this.ChangeStatusButton_Click);
            // 
            // AllCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.ChangeStatusButton);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ShowAllLinkLabel);
            this.Controls.Add(this.CardsCountLabel);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.AllCardLabel);
            this.Controls.Add(this.CardsDataGridView);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AllCards";
            this.Text = "AllCard";
            this.Load += new System.EventHandler(this.AllCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CardsDataGridView;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label AllCardLabel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label CardsCountLabel;
        private System.Windows.Forms.LinkLabel ShowAllLinkLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button ChangeStatusButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortName;
        private System.Windows.Forms.DataGridViewComboBoxColumn status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_id;
        private System.Windows.Forms.DataGridViewImageColumn showUserInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
    }
}