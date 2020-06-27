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
            this.components = new System.ComponentModel.Container();
            this.CustomerLocationNameLabel = new System.Windows.Forms.Label();
            this.LocationDataLabel = new System.Windows.Forms.Label();
            this.CardPropertiesLabel = new System.Windows.Forms.Label();
            this.Analyticslabel = new System.Windows.Forms.Label();
            this.LocationInfoPanel = new System.Windows.Forms.Panel();
            this.EditCardsCountButton = new System.Windows.Forms.Button();
            this.EditRoomBedsCountButton = new System.Windows.Forms.Button();
            this.EditHouseCorpsBuildButton = new System.Windows.Forms.Button();
            this.EditStreetButton = new System.Windows.Forms.Button();
            this.EditStreetTypeButton = new System.Windows.Forms.Button();
            this.EditCityButton = new System.Windows.Forms.Button();
            this.EditStateButton = new System.Windows.Forms.Button();
            this.EditRegionButton = new System.Windows.Forms.Button();
            this.EditNameButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CardsCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BedsCountTextBox = new System.Windows.Forms.TextBox();
            this.RoomCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuildTextBox = new System.Windows.Forms.TextBox();
            this.CorpsTextBox = new System.Windows.Forms.TextBox();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.StreetComboBox = new System.Windows.Forms.ComboBox();
            this.StreetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.RegionComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LocationInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerLocationNameLabel
            // 
            this.CustomerLocationNameLabel.AutoEllipsis = true;
            this.CustomerLocationNameLabel.AutoSize = true;
            this.CustomerLocationNameLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLocationNameLabel.Location = new System.Drawing.Point(70, 44);
            this.CustomerLocationNameLabel.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.CustomerLocationNameLabel.MaximumSize = new System.Drawing.Size(900, 35);
            this.CustomerLocationNameLabel.Name = "CustomerLocationNameLabel";
            this.CustomerLocationNameLabel.Size = new System.Drawing.Size(254, 35);
            this.CustomerLocationNameLabel.TabIndex = 0;
            this.CustomerLocationNameLabel.Text = "Мои заказчики > ";
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
            this.LocationInfoPanel.Controls.Add(this.EditCardsCountButton);
            this.LocationInfoPanel.Controls.Add(this.EditRoomBedsCountButton);
            this.LocationInfoPanel.Controls.Add(this.EditHouseCorpsBuildButton);
            this.LocationInfoPanel.Controls.Add(this.EditStreetButton);
            this.LocationInfoPanel.Controls.Add(this.EditStreetTypeButton);
            this.LocationInfoPanel.Controls.Add(this.EditCityButton);
            this.LocationInfoPanel.Controls.Add(this.EditStateButton);
            this.LocationInfoPanel.Controls.Add(this.EditRegionButton);
            this.LocationInfoPanel.Controls.Add(this.EditNameButton);
            this.LocationInfoPanel.Controls.Add(this.SaveButton);
            this.LocationInfoPanel.Controls.Add(this.CardsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.label3);
            this.LocationInfoPanel.Controls.Add(this.label2);
            this.LocationInfoPanel.Controls.Add(this.BedsCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.RoomCountTextBox);
            this.LocationInfoPanel.Controls.Add(this.label1);
            this.LocationInfoPanel.Controls.Add(this.BuildTextBox);
            this.LocationInfoPanel.Controls.Add(this.CorpsTextBox);
            this.LocationInfoPanel.Controls.Add(this.HouseTextBox);
            this.LocationInfoPanel.Controls.Add(this.StreetComboBox);
            this.LocationInfoPanel.Controls.Add(this.StreetTypeComboBox);
            this.LocationInfoPanel.Controls.Add(this.CityComboBox);
            this.LocationInfoPanel.Controls.Add(this.StateComboBox);
            this.LocationInfoPanel.Controls.Add(this.RegionComboBox);
            this.LocationInfoPanel.Controls.Add(this.NameTextBox);
            this.LocationInfoPanel.Location = new System.Drawing.Point(133, 165);
            this.LocationInfoPanel.Margin = new System.Windows.Forms.Padding(124, 22, 3, 3);
            this.LocationInfoPanel.Name = "LocationInfoPanel";
            this.LocationInfoPanel.Size = new System.Drawing.Size(834, 686);
            this.LocationInfoPanel.TabIndex = 4;
            // 
            // EditCardsCountButton
            // 
            this.EditCardsCountButton.BackColor = System.Drawing.Color.Transparent;
            this.EditCardsCountButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditCardsCountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditCardsCountButton.FlatAppearance.BorderSize = 0;
            this.EditCardsCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCardsCountButton.Location = new System.Drawing.Point(413, 574);
            this.EditCardsCountButton.Name = "EditCardsCountButton";
            this.EditCardsCountButton.Size = new System.Drawing.Size(24, 24);
            this.EditCardsCountButton.TabIndex = 24;
            this.EditCardsCountButton.UseVisualStyleBackColor = false;
            // 
            // EditRoomBedsCountButton
            // 
            this.EditRoomBedsCountButton.BackColor = System.Drawing.Color.Transparent;
            this.EditRoomBedsCountButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditRoomBedsCountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditRoomBedsCountButton.FlatAppearance.BorderSize = 0;
            this.EditRoomBedsCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRoomBedsCountButton.Location = new System.Drawing.Point(670, 504);
            this.EditRoomBedsCountButton.Name = "EditRoomBedsCountButton";
            this.EditRoomBedsCountButton.Size = new System.Drawing.Size(24, 24);
            this.EditRoomBedsCountButton.TabIndex = 23;
            this.EditRoomBedsCountButton.UseVisualStyleBackColor = false;
            // 
            // EditHouseCorpsBuildButton
            // 
            this.EditHouseCorpsBuildButton.BackColor = System.Drawing.Color.Transparent;
            this.EditHouseCorpsBuildButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditHouseCorpsBuildButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditHouseCorpsBuildButton.FlatAppearance.BorderSize = 0;
            this.EditHouseCorpsBuildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditHouseCorpsBuildButton.Location = new System.Drawing.Point(670, 411);
            this.EditHouseCorpsBuildButton.Name = "EditHouseCorpsBuildButton";
            this.EditHouseCorpsBuildButton.Size = new System.Drawing.Size(24, 24);
            this.EditHouseCorpsBuildButton.TabIndex = 22;
            this.EditHouseCorpsBuildButton.UseVisualStyleBackColor = false;
            // 
            // EditStreetButton
            // 
            this.EditStreetButton.BackColor = System.Drawing.Color.Transparent;
            this.EditStreetButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditStreetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditStreetButton.FlatAppearance.BorderSize = 0;
            this.EditStreetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStreetButton.Location = new System.Drawing.Point(670, 343);
            this.EditStreetButton.Name = "EditStreetButton";
            this.EditStreetButton.Size = new System.Drawing.Size(24, 24);
            this.EditStreetButton.TabIndex = 21;
            this.EditStreetButton.UseVisualStyleBackColor = false;
            // 
            // EditStreetTypeButton
            // 
            this.EditStreetTypeButton.BackColor = System.Drawing.Color.Transparent;
            this.EditStreetTypeButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditStreetTypeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditStreetTypeButton.FlatAppearance.BorderSize = 0;
            this.EditStreetTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStreetTypeButton.Location = new System.Drawing.Point(670, 275);
            this.EditStreetTypeButton.Name = "EditStreetTypeButton";
            this.EditStreetTypeButton.Size = new System.Drawing.Size(24, 24);
            this.EditStreetTypeButton.TabIndex = 20;
            this.EditStreetTypeButton.UseVisualStyleBackColor = false;
            // 
            // EditCityButton
            // 
            this.EditCityButton.BackColor = System.Drawing.Color.Transparent;
            this.EditCityButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditCityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditCityButton.FlatAppearance.BorderSize = 0;
            this.EditCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCityButton.Location = new System.Drawing.Point(670, 207);
            this.EditCityButton.Name = "EditCityButton";
            this.EditCityButton.Size = new System.Drawing.Size(24, 24);
            this.EditCityButton.TabIndex = 19;
            this.EditCityButton.UseVisualStyleBackColor = false;
            // 
            // EditStateButton
            // 
            this.EditStateButton.BackColor = System.Drawing.Color.Transparent;
            this.EditStateButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditStateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditStateButton.FlatAppearance.BorderSize = 0;
            this.EditStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStateButton.Location = new System.Drawing.Point(670, 139);
            this.EditStateButton.Name = "EditStateButton";
            this.EditStateButton.Size = new System.Drawing.Size(24, 24);
            this.EditStateButton.TabIndex = 18;
            this.EditStateButton.UseVisualStyleBackColor = false;
            // 
            // EditRegionButton
            // 
            this.EditRegionButton.BackColor = System.Drawing.Color.Transparent;
            this.EditRegionButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditRegionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditRegionButton.FlatAppearance.BorderSize = 0;
            this.EditRegionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRegionButton.Location = new System.Drawing.Point(670, 71);
            this.EditRegionButton.Name = "EditRegionButton";
            this.EditRegionButton.Size = new System.Drawing.Size(24, 24);
            this.EditRegionButton.TabIndex = 17;
            this.EditRegionButton.UseVisualStyleBackColor = false;
            this.EditRegionButton.Click += new System.EventHandler(this.EditRegionButton_Click);
            // 
            // EditNameButton
            // 
            this.EditNameButton.BackColor = System.Drawing.Color.Transparent;
            this.EditNameButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.pngflow_1;
            this.EditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNameButton.FlatAppearance.BorderSize = 0;
            this.EditNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNameButton.Location = new System.Drawing.Point(670, 3);
            this.EditNameButton.Name = "EditNameButton";
            this.EditNameButton.Size = new System.Drawing.Size(24, 24);
            this.EditNameButton.TabIndex = 16;
            this.EditNameButton.UseVisualStyleBackColor = false;
            this.EditNameButton.Click += new System.EventHandler(this.EditNameButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(503, 631);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(161, 38);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            // 
            // CardsCountTextBox
            // 
            this.CardsCountTextBox.Location = new System.Drawing.Point(340, 571);
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
            this.label3.Location = new System.Drawing.Point(22, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(186, 37, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество карт для локации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 468);
            this.label2.Margin = new System.Windows.Forms.Padding(186, 24, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество мест";
            // 
            // BedsCountTextBox
            // 
            this.BedsCountTextBox.Location = new System.Drawing.Point(343, 501);
            this.BedsCountTextBox.Margin = new System.Windows.Forms.Padding(20, 8, 3, 3);
            this.BedsCountTextBox.Name = "BedsCountTextBox";
            this.BedsCountTextBox.Size = new System.Drawing.Size(321, 33);
            this.BedsCountTextBox.TabIndex = 11;
            // 
            // RoomCountTextBox
            // 
            this.RoomCountTextBox.Location = new System.Drawing.Point(0, 501);
            this.RoomCountTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.RoomCountTextBox.Name = "RoomCountTextBox";
            this.RoomCountTextBox.Size = new System.Drawing.Size(320, 33);
            this.RoomCountTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(146, 24, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество комнат";
            // 
            // BuildTextBox
            // 
            this.BuildTextBox.Location = new System.Drawing.Point(456, 408);
            this.BuildTextBox.Margin = new System.Windows.Forms.Padding(21, 32, 3, 3);
            this.BuildTextBox.Name = "BuildTextBox";
            this.BuildTextBox.Size = new System.Drawing.Size(208, 33);
            this.BuildTextBox.TabIndex = 8;
            // 
            // CorpsTextBox
            // 
            this.CorpsTextBox.Location = new System.Drawing.Point(226, 408);
            this.CorpsTextBox.Margin = new System.Windows.Forms.Padding(21, 32, 3, 3);
            this.CorpsTextBox.Name = "CorpsTextBox";
            this.CorpsTextBox.Size = new System.Drawing.Size(206, 33);
            this.CorpsTextBox.TabIndex = 7;
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Location = new System.Drawing.Point(0, 408);
            this.HouseTextBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(202, 33);
            this.HouseTextBox.TabIndex = 6;
            // 
            // StreetComboBox
            // 
            this.StreetComboBox.DisplayMember = "0";
            this.StreetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.StreetComboBox.FormattingEnabled = true;
            this.StreetComboBox.Items.AddRange(new object[] {
            "Регион"});
            this.StreetComboBox.Location = new System.Drawing.Point(0, 340);
            this.StreetComboBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.StreetComboBox.Name = "StreetComboBox";
            this.StreetComboBox.Size = new System.Drawing.Size(664, 33);
            this.StreetComboBox.TabIndex = 5;
            // 
            // StreetTypeComboBox
            // 
            this.StreetTypeComboBox.DisplayMember = "0";
            this.StreetTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.StreetTypeComboBox.FormattingEnabled = true;
            this.StreetTypeComboBox.Items.AddRange(new object[] {
            "Регион"});
            this.StreetTypeComboBox.Location = new System.Drawing.Point(0, 272);
            this.StreetTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.StreetTypeComboBox.Name = "StreetTypeComboBox";
            this.StreetTypeComboBox.Size = new System.Drawing.Size(664, 33);
            this.StreetTypeComboBox.TabIndex = 4;
            // 
            // CityComboBox
            // 
            this.CityComboBox.DisplayMember = "0";
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Items.AddRange(new object[] {
            "Регион"});
            this.CityComboBox.Location = new System.Drawing.Point(0, 204);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(664, 33);
            this.CityComboBox.TabIndex = 3;
            // 
            // StateComboBox
            // 
            this.StateComboBox.DisplayMember = "0";
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "Регион"});
            this.StateComboBox.Location = new System.Drawing.Point(0, 136);
            this.StateComboBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(664, 33);
            this.StateComboBox.TabIndex = 2;
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.DisplayMember = "0";
            this.RegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.RegionComboBox.FormattingEnabled = true;
            this.RegionComboBox.Items.AddRange(new object[] {
            "Регион"});
            this.RegionComboBox.Location = new System.Drawing.Point(0, 68);
            this.RegionComboBox.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(664, 33);
            this.RegionComboBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(664, 33);
            this.NameTextBox.TabIndex = 0;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.Transparent;
            this.ToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            // 
            // LocationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.LocationInfoPanel);
            this.Controls.Add(this.Analyticslabel);
            this.Controls.Add(this.CardPropertiesLabel);
            this.Controls.Add(this.LocationDataLabel);
            this.Controls.Add(this.CustomerLocationNameLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1029, 933);
            this.MinimumSize = new System.Drawing.Size(1029, 933);
            this.Name = "LocationInfoForm";
            this.Text = "LocationInfoForm";
            this.LocationInfoPanel.ResumeLayout(false);
            this.LocationInfoPanel.PerformLayout();
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
        private System.Windows.Forms.ComboBox RegionComboBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ComboBox StreetComboBox;
        private System.Windows.Forms.ComboBox StreetTypeComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.TextBox BuildTextBox;
        private System.Windows.Forms.TextBox CorpsTextBox;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BedsCountTextBox;
        private System.Windows.Forms.TextBox RoomCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardsCountTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditNameButton;
        private System.Windows.Forms.Button EditHouseCorpsBuildButton;
        private System.Windows.Forms.Button EditStreetButton;
        private System.Windows.Forms.Button EditStreetTypeButton;
        private System.Windows.Forms.Button EditCityButton;
        private System.Windows.Forms.Button EditStateButton;
        private System.Windows.Forms.Button EditRegionButton;
        private System.Windows.Forms.Button EditRoomBedsCountButton;
        private System.Windows.Forms.Button EditCardsCountButton;
    }
}