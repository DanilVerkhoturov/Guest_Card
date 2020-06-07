namespace Admin_Panel_Hotel
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.ApplicationsSubMenu = new System.Windows.Forms.Panel();
            this.DraftButton = new System.Windows.Forms.Button();
            this.HistoryApplicationsButton = new System.Windows.Forms.Button();
            this.AddApplicationButton = new System.Windows.Forms.Button();
            this.CurrentApplicationsButton = new System.Windows.Forms.Button();
            this.NewApplicationsButton = new System.Windows.Forms.Button();
            this.Applications = new System.Windows.Forms.Button();
            this.CustomersSubMenu = new System.Windows.Forms.Panel();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.MyCustomersButton = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftMenu.SuspendLayout();
            this.ApplicationsSubMenu.SuspendLayout();
            this.CustomersSubMenu.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.AutoScroll = true;
            this.LeftMenu.BackColor = System.Drawing.Color.White;
            this.LeftMenu.Controls.Add(this.ApplicationsSubMenu);
            this.LeftMenu.Controls.Add(this.Applications);
            this.LeftMenu.Controls.Add(this.CustomersSubMenu);
            this.LeftMenu.Controls.Add(this.Customers);
            this.LeftMenu.Controls.Add(this.PanelLogo);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(229, 745);
            this.LeftMenu.TabIndex = 0;
            // 
            // ApplicationsSubMenu
            // 
            this.ApplicationsSubMenu.Controls.Add(this.DraftButton);
            this.ApplicationsSubMenu.Controls.Add(this.HistoryApplicationsButton);
            this.ApplicationsSubMenu.Controls.Add(this.AddApplicationButton);
            this.ApplicationsSubMenu.Controls.Add(this.CurrentApplicationsButton);
            this.ApplicationsSubMenu.Controls.Add(this.NewApplicationsButton);
            this.ApplicationsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationsSubMenu.Location = new System.Drawing.Point(0, 272);
            this.ApplicationsSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplicationsSubMenu.Name = "ApplicationsSubMenu";
            this.ApplicationsSubMenu.Size = new System.Drawing.Size(229, 150);
            this.ApplicationsSubMenu.TabIndex = 4;
            // 
            // DraftButton
            // 
            this.DraftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DraftButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraftButton.FlatAppearance.BorderSize = 0;
            this.DraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftButton.Location = new System.Drawing.Point(0, 120);
            this.DraftButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.DraftButton.Size = new System.Drawing.Size(229, 30);
            this.DraftButton.TabIndex = 6;
            this.DraftButton.Text = "Черновики";
            this.DraftButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftButton.UseVisualStyleBackColor = true;
            this.DraftButton.Click += new System.EventHandler(this.DraftButton_Click);
            // 
            // HistoryApplicationsButton
            // 
            this.HistoryApplicationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HistoryApplicationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryApplicationsButton.FlatAppearance.BorderSize = 0;
            this.HistoryApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryApplicationsButton.Location = new System.Drawing.Point(0, 90);
            this.HistoryApplicationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryApplicationsButton.Name = "HistoryApplicationsButton";
            this.HistoryApplicationsButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.HistoryApplicationsButton.Size = new System.Drawing.Size(229, 30);
            this.HistoryApplicationsButton.TabIndex = 5;
            this.HistoryApplicationsButton.Text = "История заявок";
            this.HistoryApplicationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoryApplicationsButton.UseVisualStyleBackColor = true;
            this.HistoryApplicationsButton.Click += new System.EventHandler(this.HistoryApplicationsButton_Click);
            // 
            // AddApplicationButton
            // 
            this.AddApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddApplicationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddApplicationButton.FlatAppearance.BorderSize = 0;
            this.AddApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApplicationButton.Location = new System.Drawing.Point(0, 60);
            this.AddApplicationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddApplicationButton.Name = "AddApplicationButton";
            this.AddApplicationButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.AddApplicationButton.Size = new System.Drawing.Size(229, 30);
            this.AddApplicationButton.TabIndex = 4;
            this.AddApplicationButton.Text = "Добавить заявку";
            this.AddApplicationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddApplicationButton.UseVisualStyleBackColor = true;
            this.AddApplicationButton.Click += new System.EventHandler(this.AddApplicationButton_Click);
            // 
            // CurrentApplicationsButton
            // 
            this.CurrentApplicationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentApplicationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentApplicationsButton.FlatAppearance.BorderSize = 0;
            this.CurrentApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentApplicationsButton.Location = new System.Drawing.Point(0, 30);
            this.CurrentApplicationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentApplicationsButton.Name = "CurrentApplicationsButton";
            this.CurrentApplicationsButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.CurrentApplicationsButton.Size = new System.Drawing.Size(229, 30);
            this.CurrentApplicationsButton.TabIndex = 3;
            this.CurrentApplicationsButton.Text = "Текущие";
            this.CurrentApplicationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentApplicationsButton.UseVisualStyleBackColor = true;
            this.CurrentApplicationsButton.Click += new System.EventHandler(this.CurrentApplicationsButton_Click);
            // 
            // NewApplicationsButton
            // 
            this.NewApplicationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewApplicationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewApplicationsButton.FlatAppearance.BorderSize = 0;
            this.NewApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewApplicationsButton.Location = new System.Drawing.Point(0, 0);
            this.NewApplicationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewApplicationsButton.Name = "NewApplicationsButton";
            this.NewApplicationsButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.NewApplicationsButton.Size = new System.Drawing.Size(229, 30);
            this.NewApplicationsButton.TabIndex = 2;
            this.NewApplicationsButton.Text = "Новые";
            this.NewApplicationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewApplicationsButton.UseVisualStyleBackColor = true;
            this.NewApplicationsButton.Click += new System.EventHandler(this.NewApplicationsButton_Click);
            // 
            // Applications
            // 
            this.Applications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Applications.Dock = System.Windows.Forms.DockStyle.Top;
            this.Applications.FlatAppearance.BorderSize = 0;
            this.Applications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Applications.Location = new System.Drawing.Point(0, 232);
            this.Applications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Applications.Name = "Applications";
            this.Applications.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Applications.Size = new System.Drawing.Size(229, 40);
            this.Applications.TabIndex = 3;
            this.Applications.Text = "Заявки";
            this.Applications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Applications.UseVisualStyleBackColor = true;
            this.Applications.Click += new System.EventHandler(this.Applications_Click);
            // 
            // CustomersSubMenu
            // 
            this.CustomersSubMenu.Controls.Add(this.AddCustomerButton);
            this.CustomersSubMenu.Controls.Add(this.MyCustomersButton);
            this.CustomersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersSubMenu.Location = new System.Drawing.Point(0, 171);
            this.CustomersSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersSubMenu.Name = "CustomersSubMenu";
            this.CustomersSubMenu.Size = new System.Drawing.Size(229, 61);
            this.CustomersSubMenu.TabIndex = 2;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Location = new System.Drawing.Point(0, 30);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.AddCustomerButton.Size = new System.Drawing.Size(229, 30);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Добавить заказчика";
            this.AddCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // MyCustomersButton
            // 
            this.MyCustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyCustomersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyCustomersButton.FlatAppearance.BorderSize = 0;
            this.MyCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyCustomersButton.Location = new System.Drawing.Point(0, 0);
            this.MyCustomersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyCustomersButton.Name = "MyCustomersButton";
            this.MyCustomersButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.MyCustomersButton.Size = new System.Drawing.Size(229, 30);
            this.MyCustomersButton.TabIndex = 2;
            this.MyCustomersButton.Text = "Мои заказчики";
            this.MyCustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyCustomersButton.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.Customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers.FlatAppearance.BorderSize = 0;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.Location = new System.Drawing.Point(0, 131);
            this.Customers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Customers.Size = new System.Drawing.Size(229, 40);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Заказчики";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(229, 131);
            this.PanelLogo.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(229, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(888, 745);
            this.ContentPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 745);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 745);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.LeftMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1133, 784);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.LeftMenu.ResumeLayout(false);
            this.ApplicationsSubMenu.ResumeLayout(false);
            this.CustomersSubMenu.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel CustomersSubMenu;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button MyCustomersButton;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button Applications;
        private System.Windows.Forms.Panel ApplicationsSubMenu;
        private System.Windows.Forms.Button AddApplicationButton;
        private System.Windows.Forms.Button CurrentApplicationsButton;
        private System.Windows.Forms.Button NewApplicationsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HistoryApplicationsButton;
        private System.Windows.Forms.Button DraftButton;
        public System.Windows.Forms.Panel ContentPanel;
    }
}

