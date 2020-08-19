namespace Admin_Panel_Hotel.Customers
{
    partial class AddLocationInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerLocationNameLabel = new System.Windows.Forms.Label();
            this.LocationDataLabel = new System.Windows.Forms.Label();
            this.CardPropertiesPanel = new System.Windows.Forms.Panel();
            this.CardPropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SaveCardPropertiesButton = new System.Windows.Forms.Button();
            this.EditCardPropertiesButton = new System.Windows.Forms.Button();
            this.LocationInfoPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveLocationInfoButton = new System.Windows.Forms.Button();
            this.EditNameButton = new System.Windows.Forms.Button();
            this.AddRoomLabel = new System.Windows.Forms.Label();
            this.CardsCountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BedsCountTextBox = new System.Windows.Forms.TextBox();
            this.RoomsCountTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CardPropertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPropertiesDataGridView)).BeginInit();
            this.LocationInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLocationNameLabel
            // 
            this.CustomerLocationNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerLocationNameLabel.AutoEllipsis = true;
            this.CustomerLocationNameLabel.AutoSize = true;
            this.CustomerLocationNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerLocationNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLocationNameLabel.Location = new System.Drawing.Point(70, 44);
            this.CustomerLocationNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.CustomerLocationNameLabel.MaximumSize = new System.Drawing.Size(900, 35);
            this.CustomerLocationNameLabel.Name = "CustomerLocationNameLabel";
            this.CustomerLocationNameLabel.Size = new System.Drawing.Size(254, 35);
            this.CustomerLocationNameLabel.TabIndex = 0;
            this.CustomerLocationNameLabel.Text = "Мои заказчики > ";
            this.CustomerLocationNameLabel.Click += new System.EventHandler(this.CustomerLocationNameLabel_Click);
            // 
            // LocationDataLabel
            // 
            this.LocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationDataLabel.AutoSize = true;
            this.LocationDataLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationDataLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationDataLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationDataLabel.Location = new System.Drawing.Point(82, 114);
            this.LocationDataLabel.Margin = new System.Windows.Forms.Padding(142, 35, 3, 0);
            this.LocationDataLabel.Name = "LocationDataLabel";
            this.LocationDataLabel.Size = new System.Drawing.Size(104, 29);
            this.LocationDataLabel.TabIndex = 1;
            this.LocationDataLabel.Text = "Данные";
            this.LocationDataLabel.Click += new System.EventHandler(this.LocationDataLabel_Click);
            // 
            // CardPropertiesPanel
            // 
            this.CardPropertiesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardPropertiesPanel.Controls.Add(this.CardPropertiesDataGridView);
            this.CardPropertiesPanel.Controls.Add(this.SaveCardPropertiesButton);
            this.CardPropertiesPanel.Controls.Add(this.EditCardPropertiesButton);
            this.CardPropertiesPanel.Location = new System.Drawing.Point(133, 163);
            this.CardPropertiesPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CardPropertiesPanel.Name = "CardPropertiesPanel";
            this.CardPropertiesPanel.Size = new System.Drawing.Size(621, 686);
            this.CardPropertiesPanel.TabIndex = 47;
            this.CardPropertiesPanel.Visible = false;
            // 
            // CardPropertiesDataGridView
            // 
            this.CardPropertiesDataGridView.AllowUserToAddRows = false;
            this.CardPropertiesDataGridView.AllowUserToDeleteRows = false;
            this.CardPropertiesDataGridView.AllowUserToResizeColumns = false;
            this.CardPropertiesDataGridView.AllowUserToResizeRows = false;
            this.CardPropertiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardPropertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardPropertiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CardPropertiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardPropertiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CardPropertiesDataGridView.ColumnHeadersHeight = 35;
            this.CardPropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CardPropertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.propertyColumn,
            this.valueColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.CardPropertiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.CardPropertiesDataGridView.Enabled = false;
            this.CardPropertiesDataGridView.EnableHeadersVisualStyles = false;
            this.CardPropertiesDataGridView.GridColor = System.Drawing.Color.Black;
            this.CardPropertiesDataGridView.Location = new System.Drawing.Point(13, 16);
            this.CardPropertiesDataGridView.Margin = new System.Windows.Forms.Padding(3, 31, 3, 3);
            this.CardPropertiesDataGridView.MultiSelect = false;
            this.CardPropertiesDataGridView.Name = "CardPropertiesDataGridView";
            this.CardPropertiesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardPropertiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CardPropertiesDataGridView.RowHeadersVisible = false;
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.CardPropertiesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CardPropertiesDataGridView.RowTemplate.Height = 30;
            this.CardPropertiesDataGridView.ShowCellErrors = false;
            this.CardPropertiesDataGridView.ShowCellToolTips = false;
            this.CardPropertiesDataGridView.ShowEditingIcon = false;
            this.CardPropertiesDataGridView.ShowRowErrors = false;
            this.CardPropertiesDataGridView.Size = new System.Drawing.Size(348, 337);
            this.CardPropertiesDataGridView.TabIndex = 62;
            this.CardPropertiesDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // propertyColumn
            // 
            this.propertyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.propertyColumn.HeaderText = "Свойства карт";
            this.propertyColumn.Name = "propertyColumn";
            this.propertyColumn.ReadOnly = true;
            this.propertyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N0";
            this.valueColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valueColumn.HeaderText = "";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            this.valueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.closeoutline_110831_4;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // SaveCardPropertiesButton
            // 
            this.SaveCardPropertiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveCardPropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveCardPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCardPropertiesButton.ForeColor = System.Drawing.Color.White;
            this.SaveCardPropertiesButton.Location = new System.Drawing.Point(403, 16);
            this.SaveCardPropertiesButton.Name = "SaveCardPropertiesButton";
            this.SaveCardPropertiesButton.Size = new System.Drawing.Size(201, 36);
            this.SaveCardPropertiesButton.TabIndex = 60;
            this.SaveCardPropertiesButton.Text = "Сохранить";
            this.SaveCardPropertiesButton.UseVisualStyleBackColor = false;
            this.SaveCardPropertiesButton.Visible = false;
            this.SaveCardPropertiesButton.Click += new System.EventHandler(this.SaveCardPropertiesButton_Click);
            // 
            // EditCardPropertiesButton
            // 
            this.EditCardPropertiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.EditCardPropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditCardPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCardPropertiesButton.ForeColor = System.Drawing.Color.White;
            this.EditCardPropertiesButton.Location = new System.Drawing.Point(403, 16);
            this.EditCardPropertiesButton.Name = "EditCardPropertiesButton";
            this.EditCardPropertiesButton.Size = new System.Drawing.Size(201, 36);
            this.EditCardPropertiesButton.TabIndex = 61;
            this.EditCardPropertiesButton.Text = "Редактировать";
            this.EditCardPropertiesButton.UseVisualStyleBackColor = false;
            this.EditCardPropertiesButton.Click += new System.EventHandler(this.EditCardPropertiesButton_Click);
            // 
            // LocationInfoPanel
            // 
            this.LocationInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationInfoPanel.Controls.Add(this.button1);
            this.LocationInfoPanel.Controls.Add(this.label2);
            this.LocationInfoPanel.Controls.Add(this.label1);
            this.LocationInfoPanel.Controls.Add(this.SaveLocationInfoButton);
            this.LocationInfoPanel.Controls.Add(this.EditNameButton);
            this.LocationInfoPanel.Controls.Add(this.AddRoomLabel);
            this.LocationInfoPanel.Controls.Add(this.CardsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.label9);
            this.LocationInfoPanel.Controls.Add(this.label8);
            this.LocationInfoPanel.Controls.Add(this.label6);
            this.LocationInfoPanel.Controls.Add(this.BedsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.RoomsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.NameTextBox);
            this.LocationInfoPanel.Controls.Add(this.RoomsDataGridView);
            this.LocationInfoPanel.Location = new System.Drawing.Point(87, 163);
            this.LocationInfoPanel.Name = "LocationInfoPanel";
            this.LocationInfoPanel.Size = new System.Drawing.Size(1003, 686);
            this.LocationInfoPanel.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.closeoutline_110831_4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(921, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 12);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(778, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "1. Локация -1";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(779, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(142, 35, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Добавленные локации";
            // 
            // SaveLocationInfoButton
            // 
            this.SaveLocationInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveLocationInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveLocationInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocationInfoButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLocationInfoButton.ForeColor = System.Drawing.Color.White;
            this.SaveLocationInfoButton.Location = new System.Drawing.Point(532, 635);
            this.SaveLocationInfoButton.Name = "SaveLocationInfoButton";
            this.SaveLocationInfoButton.Size = new System.Drawing.Size(202, 48);
            this.SaveLocationInfoButton.TabIndex = 67;
            this.SaveLocationInfoButton.Text = "Сохранить";
            this.SaveLocationInfoButton.UseVisualStyleBackColor = false;
            this.SaveLocationInfoButton.Visible = false;
            this.SaveLocationInfoButton.Click += new System.EventHandler(this.SaveLocationInfoButton_Click);
            // 
            // EditNameButton
            // 
            this.EditNameButton.BackColor = System.Drawing.Color.Transparent;
            this.EditNameButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.Accept;
            this.EditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditNameButton.FlatAppearance.BorderSize = 0;
            this.EditNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNameButton.Location = new System.Drawing.Point(745, 22);
            this.EditNameButton.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.EditNameButton.Name = "EditNameButton";
            this.EditNameButton.Size = new System.Drawing.Size(24, 24);
            this.EditNameButton.TabIndex = 66;
            this.EditNameButton.UseVisualStyleBackColor = false;
            this.EditNameButton.Click += new System.EventHandler(this.EditNameButton_Click_1);
            // 
            // AddRoomLabel
            // 
            this.AddRoomLabel.AutoSize = true;
            this.AddRoomLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoomLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AddRoomLabel.Location = new System.Drawing.Point(22, 635);
            this.AddRoomLabel.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.AddRoomLabel.Name = "AddRoomLabel";
            this.AddRoomLabel.Size = new System.Drawing.Size(258, 25);
            this.AddRoomLabel.TabIndex = 9;
            this.AddRoomLabel.Text = "+ добавить еще локацию";
            this.AddRoomLabel.Visible = false;
            this.AddRoomLabel.Click += new System.EventHandler(this.AddRoomLabel_Click);
            // 
            // CardsCountTextBox
            // 
            this.CardsCountTextBox.Location = new System.Drawing.Point(362, 172);
            this.CardsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 0, 3);
            this.CardsCountTextBox.Name = "CardsCountTextBox";
            this.CardsCountTextBox.ReadOnly = true;
            this.CardsCountTextBox.Size = new System.Drawing.Size(78, 33);
            this.CardsCountTextBox.TabIndex = 8;
            this.CardsCountTextBox.Text = "0";
            this.CardsCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(30, 37, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Колличество карт для  локации: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(186, 16, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Колличество мест";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 16, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Колличество комнат";
            // 
            // BedsCountTextBox
            // 
            this.BedsCountTextBox.Location = new System.Drawing.Point(375, 102);
            this.BedsCountTextBox.Margin = new System.Windows.Forms.Padding(20, 9, 3, 3);
            this.BedsCountTextBox.Name = "BedsCountTextBox";
            this.BedsCountTextBox.ReadOnly = true;
            this.BedsCountTextBox.Size = new System.Drawing.Size(343, 33);
            this.BedsCountTextBox.TabIndex = 2;
            this.BedsCountTextBox.Text = "0";
            // 
            // RoomsCountTextBox
            // 
            this.RoomsCountTextBox.Location = new System.Drawing.Point(12, 102);
            this.RoomsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 0, 3);
            this.RoomsCountTextBox.Name = "RoomsCountTextBox";
            this.RoomsCountTextBox.ReadOnly = true;
            this.RoomsCountTextBox.Size = new System.Drawing.Size(343, 33);
            this.RoomsCountTextBox.TabIndex = 1;
            this.RoomsCountTextBox.Text = "0";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 19);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(710, 33);
            this.NameTextBox.TabIndex = 0;
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToAddRows = false;
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            this.RoomsDataGridView.AllowUserToResizeRows = false;
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomsDataGridView.ColumnHeadersHeight = 35;
            this.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RoomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.RoomNumber,
            this.BedsCount,
            this.id,
            this.delete});
            this.RoomsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RoomsDataGridView.Enabled = false;
            this.RoomsDataGridView.EnableHeadersVisualStyles = false;
            this.RoomsDataGridView.Location = new System.Drawing.Point(12, 239);
            this.RoomsDataGridView.Margin = new System.Windows.Forms.Padding(3, 31, 3, 3);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.ReadOnly = true;
            this.RoomsDataGridView.RowHeadersVisible = false;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RoomsDataGridView.RowTemplate.Height = 30;
            this.RoomsDataGridView.Size = new System.Drawing.Size(710, 374);
            this.RoomsDataGridView.TabIndex = 65;
            this.RoomsDataGridView.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "№";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNumber.DataPropertyName = "name";
            this.RoomNumber.HeaderText = "Комнаты";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BedsCount
            // 
            this.BedsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BedsCount.DataPropertyName = "count_beds";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.BedsCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.BedsCount.HeaderText = "Количество мест";
            this.BedsCount.Name = "BedsCount";
            this.BedsCount.ReadOnly = true;
            this.BedsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::Admin_Panel_Hotel.Properties.Resources.closeoutline_110831_4;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Visible = false;
            // 
            // AddLocationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.LocationDataLabel);
            this.Controls.Add(this.CustomerLocationNameLabel);
            this.Controls.Add(this.LocationInfoPanel);
            this.Controls.Add(this.CardPropertiesPanel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddLocationInfo";
            this.Text = "AddLocationInfo";
            this.CardPropertiesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardPropertiesDataGridView)).EndInit();
            this.LocationInfoPanel.ResumeLayout(false);
            this.LocationInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLocationNameLabel;
        private System.Windows.Forms.Label LocationDataLabel;
        private System.Windows.Forms.Panel CardPropertiesPanel;
        private System.Windows.Forms.Button EditCardPropertiesButton;
        private System.Windows.Forms.Button SaveCardPropertiesButton;
        private System.Windows.Forms.DataGridView CardPropertiesDataGridView;
        private System.Windows.Forms.Panel LocationInfoPanel;
        private System.Windows.Forms.TextBox BedsCountTextBox;
        private System.Windows.Forms.TextBox RoomsCountTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CardsCountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RoomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button EditNameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button SaveLocationInfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddRoomLabel;
    }
}