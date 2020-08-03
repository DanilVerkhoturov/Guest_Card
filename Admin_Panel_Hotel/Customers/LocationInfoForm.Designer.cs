namespace Admin_Panel_Hotel.Customers
{
    partial class LocationInfoForm
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
            this.CustomerLocationNameLabel = new System.Windows.Forms.Label();
            this.LocationDataLabel = new System.Windows.Forms.Label();
            this.CardPropertiesLabel = new System.Windows.Forms.Label();
            this.Analyticslabel = new System.Windows.Forms.Label();
            this.LocationInfoPanel = new System.Windows.Forms.Panel();
            this.AddRoomLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameHelpLabel = new System.Windows.Forms.Label();
            this.EditRoomBedsCountButton = new System.Windows.Forms.Button();
            this.EditNameButton = new System.Windows.Forms.Button();
            this.SaveLocationInfoButton = new System.Windows.Forms.Button();
            this.CardsCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BedsCountTextBox = new System.Windows.Forms.TextBox();
            this.RoomCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CardPropertiesPanel = new System.Windows.Forms.Panel();
            this.Set2HelpButton = new System.Windows.Forms.Button();
            this.Set1HelpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FireSafetyCheckBox = new System.Windows.Forms.CheckBox();
            this.AllPropertiesCheckBox = new System.Windows.Forms.CheckBox();
            this.ResidenceRulesCheckBox = new System.Windows.Forms.CheckBox();
            this.GiveOutLinenCheckBox = new System.Windows.Forms.CheckBox();
            this.Set1CheckBox = new System.Windows.Forms.CheckBox();
            this.Set2CheckBox = new System.Windows.Forms.CheckBox();
            this.InstructedCheckBox = new System.Windows.Forms.CheckBox();
            this.EditCardPropertiesButton = new System.Windows.Forms.Button();
            this.SaveCardPropertiesButton = new System.Windows.Forms.Button();
            this.LocationInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.CardPropertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerLocationNameLabel
            // 
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
            this.LocationDataLabel.AutoSize = true;
            this.LocationDataLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationDataLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.LocationDataLabel.Location = new System.Drawing.Point(151, 114);
            this.LocationDataLabel.Margin = new System.Windows.Forms.Padding(142, 35, 3, 0);
            this.LocationDataLabel.Name = "LocationDataLabel";
            this.LocationDataLabel.Size = new System.Drawing.Size(104, 29);
            this.LocationDataLabel.TabIndex = 1;
            this.LocationDataLabel.Text = "Данные";
            this.LocationDataLabel.Click += new System.EventHandler(this.LocationDataLabel_Click);
            // 
            // CardPropertiesLabel
            // 
            this.CardPropertiesLabel.AutoSize = true;
            this.CardPropertiesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardPropertiesLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardPropertiesLabel.ForeColor = System.Drawing.Color.Black;
            this.CardPropertiesLabel.Location = new System.Drawing.Point(293, 114);
            this.CardPropertiesLabel.Margin = new System.Windows.Forms.Padding(35, 35, 3, 0);
            this.CardPropertiesLabel.Name = "CardPropertiesLabel";
            this.CardPropertiesLabel.Size = new System.Drawing.Size(179, 29);
            this.CardPropertiesLabel.TabIndex = 2;
            this.CardPropertiesLabel.Text = "Свойства карт";
            this.CardPropertiesLabel.Click += new System.EventHandler(this.CardPropertiesLabel_Click);
            // 
            // Analyticslabel
            // 
            this.Analyticslabel.AutoSize = true;
            this.Analyticslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Analyticslabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Analyticslabel.ForeColor = System.Drawing.Color.Black;
            this.Analyticslabel.Location = new System.Drawing.Point(510, 114);
            this.Analyticslabel.Margin = new System.Windows.Forms.Padding(35, 35, 3, 0);
            this.Analyticslabel.Name = "Analyticslabel";
            this.Analyticslabel.Size = new System.Drawing.Size(135, 29);
            this.Analyticslabel.TabIndex = 3;
            this.Analyticslabel.Text = "Аналитика";
            // 
            // LocationInfoPanel
            // 
            this.LocationInfoPanel.Controls.Add(this.AddRoomLinkLabel);
            this.LocationInfoPanel.Controls.Add(this.RoomsDataGridView);
            this.LocationInfoPanel.Controls.Add(this.NameHelpLabel);
            this.LocationInfoPanel.Controls.Add(this.EditRoomBedsCountButton);
            this.LocationInfoPanel.Controls.Add(this.EditNameButton);
            this.LocationInfoPanel.Controls.Add(this.SaveLocationInfoButton);
            this.LocationInfoPanel.Controls.Add(this.CardsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.label3);
            this.LocationInfoPanel.Controls.Add(this.label2);
            this.LocationInfoPanel.Controls.Add(this.BedsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.RoomCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.label1);
            this.LocationInfoPanel.Controls.Add(this.NameTextBox);
            this.LocationInfoPanel.Location = new System.Drawing.Point(133, 165);
            this.LocationInfoPanel.Margin = new System.Windows.Forms.Padding(124, 22, 3, 3);
            this.LocationInfoPanel.Name = "LocationInfoPanel";
            this.LocationInfoPanel.Size = new System.Drawing.Size(923, 686);
            this.LocationInfoPanel.TabIndex = 4;
            // 
            // AddRoomLinkLabel
            // 
            this.AddRoomLinkLabel.AutoSize = true;
            this.AddRoomLinkLabel.Enabled = false;
            this.AddRoomLinkLabel.Location = new System.Drawing.Point(526, 164);
            this.AddRoomLinkLabel.Name = "AddRoomLinkLabel";
            this.AddRoomLinkLabel.Size = new System.Drawing.Size(208, 25);
            this.AddRoomLinkLabel.TabIndex = 58;
            this.AddRoomLinkLabel.TabStop = true;
            this.AddRoomLinkLabel.Text = "+ добавить комнату";
            this.AddRoomLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddRoomLinkLabel_LinkClicked);
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToAddRows = false;
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            this.RoomsDataGridView.AllowUserToResizeRows = false;
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.RoomsDataGridView.Location = new System.Drawing.Point(0, 228);
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
            this.RoomsDataGridView.Size = new System.Drawing.Size(734, 374);
            this.RoomsDataGridView.TabIndex = 57;
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
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.BedsCount.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // NameHelpLabel
            // 
            this.NameHelpLabel.AutoEllipsis = true;
            this.NameHelpLabel.AutoSize = true;
            this.NameHelpLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.NameHelpLabel.Location = new System.Drawing.Point(760, 3);
            this.NameHelpLabel.Name = "NameHelpLabel";
            this.NameHelpLabel.Size = new System.Drawing.Size(139, 30);
            this.NameHelpLabel.TabIndex = 25;
            this.NameHelpLabel.Text = "Редактируйте поле и \r\nнажмите Сохранить";
            this.NameHelpLabel.Visible = false;
            // 
            // EditRoomBedsCountButton
            // 
            this.EditRoomBedsCountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.EditRoomBedsCountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditRoomBedsCountButton.FlatAppearance.BorderSize = 0;
            this.EditRoomBedsCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRoomBedsCountButton.ForeColor = System.Drawing.Color.White;
            this.EditRoomBedsCountButton.Location = new System.Drawing.Point(747, 91);
            this.EditRoomBedsCountButton.Name = "EditRoomBedsCountButton";
            this.EditRoomBedsCountButton.Size = new System.Drawing.Size(173, 33);
            this.EditRoomBedsCountButton.TabIndex = 23;
            this.EditRoomBedsCountButton.Text = "Редактировать";
            this.EditRoomBedsCountButton.UseVisualStyleBackColor = false;
            this.EditRoomBedsCountButton.Click += new System.EventHandler(this.EditRoomBedsCountButton_Click);
            // 
            // EditNameButton
            // 
            this.EditNameButton.BackColor = System.Drawing.Color.Transparent;
            this.EditNameButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNameButton.FlatAppearance.BorderSize = 0;
            this.EditNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNameButton.Location = new System.Drawing.Point(747, 3);
            this.EditNameButton.Name = "EditNameButton";
            this.EditNameButton.Size = new System.Drawing.Size(24, 24);
            this.EditNameButton.TabIndex = 16;
            this.EditNameButton.UseVisualStyleBackColor = false;
            this.EditNameButton.Click += new System.EventHandler(this.EditNameButton_Click);
            // 
            // SaveLocationInfoButton
            // 
            this.SaveLocationInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveLocationInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveLocationInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLocationInfoButton.ForeColor = System.Drawing.Color.White;
            this.SaveLocationInfoButton.Location = new System.Drawing.Point(556, 626);
            this.SaveLocationInfoButton.Name = "SaveLocationInfoButton";
            this.SaveLocationInfoButton.Size = new System.Drawing.Size(178, 44);
            this.SaveLocationInfoButton.TabIndex = 15;
            this.SaveLocationInfoButton.Text = "Сохранить";
            this.SaveLocationInfoButton.UseVisualStyleBackColor = false;
            this.SaveLocationInfoButton.Visible = false;
            this.SaveLocationInfoButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CardsCountTextBox
            // 
            this.CardsCountTextBox.Enabled = false;
            this.CardsCountTextBox.Location = new System.Drawing.Point(340, 161);
            this.CardsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.CardsCountTextBox.Name = "CardsCountTextBox";
            this.CardsCountTextBox.Size = new System.Drawing.Size(67, 33);
            this.CardsCountTextBox.TabIndex = 14;
            this.CardsCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(186, 37, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество карт для локации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(186, 22, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество мест";
            // 
            // BedsCountTextBox
            // 
            this.BedsCountTextBox.Location = new System.Drawing.Point(376, 91);
            this.BedsCountTextBox.Margin = new System.Windows.Forms.Padding(20, 8, 3, 3);
            this.BedsCountTextBox.Name = "BedsCountTextBox";
            this.BedsCountTextBox.ReadOnly = true;
            this.BedsCountTextBox.Size = new System.Drawing.Size(358, 33);
            this.BedsCountTextBox.TabIndex = 11;
            // 
            // RoomCountTextBox
            // 
            this.RoomCountTextBox.Location = new System.Drawing.Point(0, 91);
            this.RoomCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.RoomCountTextBox.Name = "RoomCountTextBox";
            this.RoomCountTextBox.ReadOnly = true;
            this.RoomCountTextBox.Size = new System.Drawing.Size(353, 33);
            this.RoomCountTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(146, 22, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество комнат";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(734, 33);
            this.NameTextBox.TabIndex = 0;
            // 
            // CardPropertiesPanel
            // 
            this.CardPropertiesPanel.Controls.Add(this.Set2HelpButton);
            this.CardPropertiesPanel.Controls.Add(this.Set1HelpButton);
            this.CardPropertiesPanel.Controls.Add(this.label5);
            this.CardPropertiesPanel.Controls.Add(this.FireSafetyCheckBox);
            this.CardPropertiesPanel.Controls.Add(this.AllPropertiesCheckBox);
            this.CardPropertiesPanel.Controls.Add(this.ResidenceRulesCheckBox);
            this.CardPropertiesPanel.Controls.Add(this.GiveOutLinenCheckBox);
            this.CardPropertiesPanel.Controls.Add(this.Set1CheckBox);
            this.CardPropertiesPanel.Controls.Add(this.Set2CheckBox);
            this.CardPropertiesPanel.Controls.Add(this.InstructedCheckBox);
            this.CardPropertiesPanel.Controls.Add(this.EditCardPropertiesButton);
            this.CardPropertiesPanel.Controls.Add(this.SaveCardPropertiesButton);
            this.CardPropertiesPanel.Location = new System.Drawing.Point(133, 165);
            this.CardPropertiesPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CardPropertiesPanel.Name = "CardPropertiesPanel";
            this.CardPropertiesPanel.Size = new System.Drawing.Size(923, 686);
            this.CardPropertiesPanel.TabIndex = 47;
            this.CardPropertiesPanel.Visible = false;
            // 
            // Set2HelpButton
            // 
            this.Set2HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.Set2HelpButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.question_icon_icons_com_69315;
            this.Set2HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Set2HelpButton.FlatAppearance.BorderSize = 0;
            this.Set2HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set2HelpButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set2HelpButton.Location = new System.Drawing.Point(265, 200);
            this.Set2HelpButton.Margin = new System.Windows.Forms.Padding(5);
            this.Set2HelpButton.Name = "Set2HelpButton";
            this.Set2HelpButton.Size = new System.Drawing.Size(31, 31);
            this.Set2HelpButton.TabIndex = 23;
            this.Set2HelpButton.UseVisualStyleBackColor = false;
            this.Set2HelpButton.Click += new System.EventHandler(this.Set2HelpButton_Click);
            // 
            // Set1HelpButton
            // 
            this.Set1HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.Set1HelpButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.question_icon_icons_com_69315;
            this.Set1HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Set1HelpButton.FlatAppearance.BorderSize = 0;
            this.Set1HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set1HelpButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set1HelpButton.Location = new System.Drawing.Point(265, 139);
            this.Set1HelpButton.Margin = new System.Windows.Forms.Padding(5);
            this.Set1HelpButton.Name = "Set1HelpButton";
            this.Set1HelpButton.Size = new System.Drawing.Size(31, 31);
            this.Set1HelpButton.TabIndex = 22;
            this.Set1HelpButton.UseVisualStyleBackColor = false;
            this.Set1HelpButton.Click += new System.EventHandler(this.Set1HelpButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(72, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(123, 40, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Свойства карт";
            // 
            // FireSafetyCheckBox
            // 
            this.FireSafetyCheckBox.AutoSize = true;
            this.FireSafetyCheckBox.Enabled = false;
            this.FireSafetyCheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FireSafetyCheckBox.Location = new System.Drawing.Point(108, 400);
            this.FireSafetyCheckBox.Margin = new System.Windows.Forms.Padding(5, 25, 5, 7);
            this.FireSafetyCheckBox.Name = "FireSafetyCheckBox";
            this.FireSafetyCheckBox.Size = new System.Drawing.Size(283, 29);
            this.FireSafetyCheckBox.TabIndex = 16;
            this.FireSafetyCheckBox.Text = "Пожарная безопастность";
            this.FireSafetyCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllPropertiesCheckBox
            // 
            this.AllPropertiesCheckBox.AutoSize = true;
            this.AllPropertiesCheckBox.Enabled = false;
            this.AllPropertiesCheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPropertiesCheckBox.Location = new System.Drawing.Point(278, 17);
            this.AllPropertiesCheckBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AllPropertiesCheckBox.Name = "AllPropertiesCheckBox";
            this.AllPropertiesCheckBox.Size = new System.Drawing.Size(66, 29);
            this.AllPropertiesCheckBox.TabIndex = 12;
            this.AllPropertiesCheckBox.Text = "Все";
            this.AllPropertiesCheckBox.UseVisualStyleBackColor = true;
            this.AllPropertiesCheckBox.CheckedChanged += new System.EventHandler(this.AllPropertiesCheckBox_CheckedChanged);
            // 
            // ResidenceRulesCheckBox
            // 
            this.ResidenceRulesCheckBox.AutoSize = true;
            this.ResidenceRulesCheckBox.Enabled = false;
            this.ResidenceRulesCheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidenceRulesCheckBox.Location = new System.Drawing.Point(105, 339);
            this.ResidenceRulesCheckBox.Margin = new System.Windows.Forms.Padding(5, 25, 5, 7);
            this.ResidenceRulesCheckBox.Name = "ResidenceRulesCheckBox";
            this.ResidenceRulesCheckBox.Size = new System.Drawing.Size(244, 29);
            this.ResidenceRulesCheckBox.TabIndex = 15;
            this.ResidenceRulesCheckBox.Text = "Правила проживания";
            this.ResidenceRulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // GiveOutLinenCheckBox
            // 
            this.GiveOutLinenCheckBox.AutoSize = true;
            this.GiveOutLinenCheckBox.Enabled = false;
            this.GiveOutLinenCheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveOutLinenCheckBox.Location = new System.Drawing.Point(77, 83);
            this.GiveOutLinenCheckBox.Margin = new System.Windows.Forms.Padding(5, 40, 5, 7);
            this.GiveOutLinenCheckBox.Name = "GiveOutLinenCheckBox";
            this.GiveOutLinenCheckBox.Size = new System.Drawing.Size(190, 29);
            this.GiveOutLinenCheckBox.TabIndex = 13;
            this.GiveOutLinenCheckBox.Text = "Выдавать бельё";
            this.GiveOutLinenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Set1CheckBox
            // 
            this.Set1CheckBox.AutoSize = true;
            this.Set1CheckBox.Enabled = false;
            this.Set1CheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set1CheckBox.Location = new System.Drawing.Point(108, 141);
            this.Set1CheckBox.Margin = new System.Windows.Forms.Padding(5, 25, 5, 7);
            this.Set1CheckBox.Name = "Set1CheckBox";
            this.Set1CheckBox.Size = new System.Drawing.Size(147, 29);
            this.Set1CheckBox.TabIndex = 17;
            this.Set1CheckBox.Text = "Комплект-1";
            this.Set1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Set2CheckBox
            // 
            this.Set2CheckBox.AutoSize = true;
            this.Set2CheckBox.Enabled = false;
            this.Set2CheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set2CheckBox.Location = new System.Drawing.Point(108, 202);
            this.Set2CheckBox.Margin = new System.Windows.Forms.Padding(5, 25, 5, 7);
            this.Set2CheckBox.Name = "Set2CheckBox";
            this.Set2CheckBox.Size = new System.Drawing.Size(147, 29);
            this.Set2CheckBox.TabIndex = 18;
            this.Set2CheckBox.Text = "Комплект-2";
            this.Set2CheckBox.UseVisualStyleBackColor = true;
            // 
            // InstructedCheckBox
            // 
            this.InstructedCheckBox.AutoSize = true;
            this.InstructedCheckBox.Enabled = false;
            this.InstructedCheckBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructedCheckBox.Location = new System.Drawing.Point(77, 278);
            this.InstructedCheckBox.Margin = new System.Windows.Forms.Padding(5, 40, 5, 7);
            this.InstructedCheckBox.Name = "InstructedCheckBox";
            this.InstructedCheckBox.Size = new System.Drawing.Size(257, 29);
            this.InstructedCheckBox.TabIndex = 14;
            this.InstructedCheckBox.Text = "Проходить инструктаж";
            this.InstructedCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditCardPropertiesButton
            // 
            this.EditCardPropertiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.EditCardPropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditCardPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCardPropertiesButton.ForeColor = System.Drawing.Color.White;
            this.EditCardPropertiesButton.Location = new System.Drawing.Point(489, 608);
            this.EditCardPropertiesButton.Name = "EditCardPropertiesButton";
            this.EditCardPropertiesButton.Size = new System.Drawing.Size(201, 44);
            this.EditCardPropertiesButton.TabIndex = 61;
            this.EditCardPropertiesButton.Text = "Редактировать";
            this.EditCardPropertiesButton.UseVisualStyleBackColor = false;
            this.EditCardPropertiesButton.Click += new System.EventHandler(this.EditCardPropertiesButton_Click);
            // 
            // SaveCardPropertiesButton
            // 
            this.SaveCardPropertiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveCardPropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveCardPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCardPropertiesButton.ForeColor = System.Drawing.Color.White;
            this.SaveCardPropertiesButton.Location = new System.Drawing.Point(489, 608);
            this.SaveCardPropertiesButton.Name = "SaveCardPropertiesButton";
            this.SaveCardPropertiesButton.Size = new System.Drawing.Size(201, 44);
            this.SaveCardPropertiesButton.TabIndex = 60;
            this.SaveCardPropertiesButton.Text = "Сохранить";
            this.SaveCardPropertiesButton.UseVisualStyleBackColor = false;
            this.SaveCardPropertiesButton.Visible = false;
            // 
            // LocationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.Analyticslabel);
            this.Controls.Add(this.CardPropertiesLabel);
            this.Controls.Add(this.LocationDataLabel);
            this.Controls.Add(this.CustomerLocationNameLabel);
            this.Controls.Add(this.LocationInfoPanel);
            this.Controls.Add(this.CardPropertiesPanel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LocationInfoForm";
            this.Text = "LocationInfoForm";
            this.LocationInfoPanel.ResumeLayout(false);
            this.LocationInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.CardPropertiesPanel.ResumeLayout(false);
            this.CardPropertiesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLocationNameLabel;
        private System.Windows.Forms.Label LocationDataLabel;
        private System.Windows.Forms.Label CardPropertiesLabel;
        private System.Windows.Forms.Label Analyticslabel;
        private System.Windows.Forms.Panel LocationInfoPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BedsCountTextBox;
        private System.Windows.Forms.TextBox RoomCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardsCountTextBox;
        private System.Windows.Forms.Button SaveLocationInfoButton;
        private System.Windows.Forms.Button EditNameButton;
        private System.Windows.Forms.Button EditRoomBedsCountButton;
        private System.Windows.Forms.Label NameHelpLabel;
        private System.Windows.Forms.DataGridView RoomsDataGridView;
        private System.Windows.Forms.Panel CardPropertiesPanel;
        private System.Windows.Forms.Button Set2HelpButton;
        private System.Windows.Forms.Button Set1HelpButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FireSafetyCheckBox;
        private System.Windows.Forms.CheckBox AllPropertiesCheckBox;
        private System.Windows.Forms.CheckBox ResidenceRulesCheckBox;
        private System.Windows.Forms.CheckBox GiveOutLinenCheckBox;
        private System.Windows.Forms.CheckBox Set1CheckBox;
        private System.Windows.Forms.CheckBox Set2CheckBox;
        private System.Windows.Forms.CheckBox InstructedCheckBox;
        private System.Windows.Forms.Button EditCardPropertiesButton;
        private System.Windows.Forms.Button SaveCardPropertiesButton;
        private System.Windows.Forms.LinkLabel AddRoomLinkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}