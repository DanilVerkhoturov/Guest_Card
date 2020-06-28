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
            this.CardsPanel = new System.Windows.Forms.Panel();
            this.MovingCardsButton = new System.Windows.Forms.Button();
            this.AddCardsButton = new System.Windows.Forms.Button();
            this.AllCardsButton = new System.Windows.Forms.Button();
            this.CardsButton = new System.Windows.Forms.Button();
            this.ApplicationsPanel = new System.Windows.Forms.Panel();
            this.NewCount = new System.Windows.Forms.Label();
            this.DraftCount = new System.Windows.Forms.Label();
            this.DraftsButton = new System.Windows.Forms.Button();
            this.HistoryApplicationsButton = new System.Windows.Forms.Button();
            this.AddApplicationButton = new System.Windows.Forms.Button();
            this.CurrentApplicationsButton = new System.Windows.Forms.Button();
            this.NewApplicationsButton = new System.Windows.Forms.Button();
            this.ApplicationsButton = new System.Windows.Forms.Button();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.MyCustomersButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.OutButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.LeftMenu.SuspendLayout();
            this.CardsPanel.SuspendLayout();
            this.ApplicationsPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.AutoScroll = true;
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.LeftMenu.Controls.Add(this.CardsPanel);
            this.LeftMenu.Controls.Add(this.CardsButton);
            this.LeftMenu.Controls.Add(this.ApplicationsPanel);
            this.LeftMenu.Controls.Add(this.ApplicationsButton);
            this.LeftMenu.Controls.Add(this.CustomersPanel);
            this.LeftMenu.Controls.Add(this.CustomersButton);
            this.LeftMenu.Controls.Add(this.PanelLogo);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(393, 985);
            this.LeftMenu.TabIndex = 0;
            // 
            // CardsPanel
            // 
            this.CardsPanel.Controls.Add(this.MovingCardsButton);
            this.CardsPanel.Controls.Add(this.AddCardsButton);
            this.CardsPanel.Controls.Add(this.AllCardsButton);
            this.CardsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardsPanel.Location = new System.Drawing.Point(0, 536);
            this.CardsPanel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CardsPanel.Name = "CardsPanel";
            this.CardsPanel.Size = new System.Drawing.Size(393, 140);
            this.CardsPanel.TabIndex = 6;
            // 
            // MovingCardsButton
            // 
            this.MovingCardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MovingCardsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovingCardsButton.FlatAppearance.BorderSize = 0;
            this.MovingCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovingCardsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovingCardsButton.ForeColor = System.Drawing.Color.White;
            this.MovingCardsButton.Location = new System.Drawing.Point(0, 86);
            this.MovingCardsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MovingCardsButton.Name = "MovingCardsButton";
            this.MovingCardsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.MovingCardsButton.Size = new System.Drawing.Size(393, 43);
            this.MovingCardsButton.TabIndex = 6;
            this.MovingCardsButton.Text = "Перемещение";
            this.MovingCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MovingCardsButton.UseVisualStyleBackColor = true;
            this.MovingCardsButton.Click += new System.EventHandler(this.MovingCardsButton_Click);
            // 
            // AddCardsButton
            // 
            this.AddCardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCardsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCardsButton.FlatAppearance.BorderSize = 0;
            this.AddCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardsButton.ForeColor = System.Drawing.Color.White;
            this.AddCardsButton.Location = new System.Drawing.Point(0, 43);
            this.AddCardsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AddCardsButton.Name = "AddCardsButton";
            this.AddCardsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.AddCardsButton.Size = new System.Drawing.Size(393, 43);
            this.AddCardsButton.TabIndex = 3;
            this.AddCardsButton.Text = "Добавить карты";
            this.AddCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCardsButton.UseVisualStyleBackColor = true;
            this.AddCardsButton.Click += new System.EventHandler(this.AddCardsButton_Click);
            // 
            // AllCardsButton
            // 
            this.AllCardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllCardsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllCardsButton.FlatAppearance.BorderSize = 0;
            this.AllCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCardsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCardsButton.ForeColor = System.Drawing.Color.White;
            this.AllCardsButton.Location = new System.Drawing.Point(0, 0);
            this.AllCardsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AllCardsButton.Name = "AllCardsButton";
            this.AllCardsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.AllCardsButton.Size = new System.Drawing.Size(393, 43);
            this.AllCardsButton.TabIndex = 2;
            this.AllCardsButton.Text = "Все карты";
            this.AllCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllCardsButton.UseVisualStyleBackColor = true;
            this.AllCardsButton.Click += new System.EventHandler(this.AllCardsButton_Click);
            // 
            // CardsButton
            // 
            this.CardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CardsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardsButton.FlatAppearance.BorderSize = 0;
            this.CardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardsButton.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsButton.ForeColor = System.Drawing.Color.White;
            this.CardsButton.Location = new System.Drawing.Point(0, 478);
            this.CardsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CardsButton.Name = "CardsButton";
            this.CardsButton.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.CardsButton.Size = new System.Drawing.Size(393, 58);
            this.CardsButton.TabIndex = 5;
            this.CardsButton.Text = "Карты";
            this.CardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CardsButton.UseVisualStyleBackColor = true;
            this.CardsButton.Click += new System.EventHandler(this.CardsButton_Click);
            // 
            // ApplicationsPanel
            // 
            this.ApplicationsPanel.Controls.Add(this.NewCount);
            this.ApplicationsPanel.Controls.Add(this.DraftCount);
            this.ApplicationsPanel.Controls.Add(this.DraftsButton);
            this.ApplicationsPanel.Controls.Add(this.HistoryApplicationsButton);
            this.ApplicationsPanel.Controls.Add(this.AddApplicationButton);
            this.ApplicationsPanel.Controls.Add(this.CurrentApplicationsButton);
            this.ApplicationsPanel.Controls.Add(this.NewApplicationsButton);
            this.ApplicationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationsPanel.Location = new System.Drawing.Point(0, 258);
            this.ApplicationsPanel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ApplicationsPanel.Name = "ApplicationsPanel";
            this.ApplicationsPanel.Size = new System.Drawing.Size(393, 220);
            this.ApplicationsPanel.TabIndex = 4;
            // 
            // NewCount
            // 
            this.NewCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewCount.AutoSize = true;
            this.NewCount.BackColor = System.Drawing.Color.Transparent;
            this.NewCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCount.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCount.ForeColor = System.Drawing.Color.Red;
            this.NewCount.Location = new System.Drawing.Point(153, 7);
            this.NewCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NewCount.Name = "NewCount";
            this.NewCount.Size = new System.Drawing.Size(26, 29);
            this.NewCount.TabIndex = 8;
            this.NewCount.Text = "0";
            // 
            // DraftCount
            // 
            this.DraftCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DraftCount.AutoSize = true;
            this.DraftCount.BackColor = System.Drawing.Color.Transparent;
            this.DraftCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftCount.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DraftCount.ForeColor = System.Drawing.Color.Red;
            this.DraftCount.Location = new System.Drawing.Point(198, 179);
            this.DraftCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DraftCount.Name = "DraftCount";
            this.DraftCount.Size = new System.Drawing.Size(26, 29);
            this.DraftCount.TabIndex = 7;
            this.DraftCount.Text = "0";
            // 
            // DraftsButton
            // 
            this.DraftsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DraftsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraftsButton.FlatAppearance.BorderSize = 0;
            this.DraftsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DraftsButton.ForeColor = System.Drawing.Color.White;
            this.DraftsButton.Location = new System.Drawing.Point(0, 172);
            this.DraftsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.DraftsButton.Name = "DraftsButton";
            this.DraftsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.DraftsButton.Size = new System.Drawing.Size(393, 43);
            this.DraftsButton.TabIndex = 6;
            this.DraftsButton.Text = "Черновики";
            this.DraftsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftsButton.UseVisualStyleBackColor = true;
            this.DraftsButton.Click += new System.EventHandler(this.DraftsButton_Click);
            // 
            // HistoryApplicationsButton
            // 
            this.HistoryApplicationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HistoryApplicationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryApplicationsButton.FlatAppearance.BorderSize = 0;
            this.HistoryApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryApplicationsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryApplicationsButton.ForeColor = System.Drawing.Color.White;
            this.HistoryApplicationsButton.Location = new System.Drawing.Point(0, 129);
            this.HistoryApplicationsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.HistoryApplicationsButton.Name = "HistoryApplicationsButton";
            this.HistoryApplicationsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.HistoryApplicationsButton.Size = new System.Drawing.Size(393, 43);
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
            this.AddApplicationButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddApplicationButton.ForeColor = System.Drawing.Color.White;
            this.AddApplicationButton.Location = new System.Drawing.Point(0, 86);
            this.AddApplicationButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AddApplicationButton.Name = "AddApplicationButton";
            this.AddApplicationButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.AddApplicationButton.Size = new System.Drawing.Size(393, 43);
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
            this.CurrentApplicationsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentApplicationsButton.ForeColor = System.Drawing.Color.White;
            this.CurrentApplicationsButton.Location = new System.Drawing.Point(0, 43);
            this.CurrentApplicationsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CurrentApplicationsButton.Name = "CurrentApplicationsButton";
            this.CurrentApplicationsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.CurrentApplicationsButton.Size = new System.Drawing.Size(393, 43);
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
            this.NewApplicationsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewApplicationsButton.ForeColor = System.Drawing.Color.White;
            this.NewApplicationsButton.Location = new System.Drawing.Point(0, 0);
            this.NewApplicationsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.NewApplicationsButton.Name = "NewApplicationsButton";
            this.NewApplicationsButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.NewApplicationsButton.Size = new System.Drawing.Size(393, 43);
            this.NewApplicationsButton.TabIndex = 2;
            this.NewApplicationsButton.Text = "Новые";
            this.NewApplicationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewApplicationsButton.UseVisualStyleBackColor = true;
            this.NewApplicationsButton.Click += new System.EventHandler(this.NewApplicationsButton_Click);
            // 
            // ApplicationsButton
            // 
            this.ApplicationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplicationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationsButton.FlatAppearance.BorderSize = 0;
            this.ApplicationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationsButton.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsButton.ForeColor = System.Drawing.Color.White;
            this.ApplicationsButton.Location = new System.Drawing.Point(0, 200);
            this.ApplicationsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ApplicationsButton.Name = "ApplicationsButton";
            this.ApplicationsButton.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.ApplicationsButton.Size = new System.Drawing.Size(393, 58);
            this.ApplicationsButton.TabIndex = 3;
            this.ApplicationsButton.Text = "Заявки";
            this.ApplicationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplicationsButton.UseVisualStyleBackColor = true;
            this.ApplicationsButton.Click += new System.EventHandler(this.ApplicationsButton_Click);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.AddCustomerButton);
            this.CustomersPanel.Controls.Add(this.MyCustomersButton);
            this.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersPanel.Location = new System.Drawing.Point(0, 110);
            this.CustomersPanel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(393, 90);
            this.CustomersPanel.TabIndex = 2;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Location = new System.Drawing.Point(0, 43);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.AddCustomerButton.Size = new System.Drawing.Size(393, 43);
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
            this.MyCustomersButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyCustomersButton.ForeColor = System.Drawing.Color.White;
            this.MyCustomersButton.Location = new System.Drawing.Point(0, 0);
            this.MyCustomersButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MyCustomersButton.Name = "MyCustomersButton";
            this.MyCustomersButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.MyCustomersButton.Size = new System.Drawing.Size(393, 43);
            this.MyCustomersButton.TabIndex = 2;
            this.MyCustomersButton.Text = "Мои заказчики";
            this.MyCustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyCustomersButton.UseVisualStyleBackColor = true;
            this.MyCustomersButton.Click += new System.EventHandler(this.MyCustomersButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Location = new System.Drawing.Point(0, 52);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.CustomersButton.Size = new System.Drawing.Size(393, 58);
            this.CustomersButton.TabIndex = 1;
            this.CustomersButton.Text = "Заказчики";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.White;
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(393, 52);
            this.PanelLogo.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(393, 50);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1031, 935);
            this.ContentPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 933);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.OutButton);
            this.TopPanel.Controls.Add(this.UserButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(393, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1031, 50);
            this.TopPanel.TabIndex = 1;
            // 
            // OutButton
            // 
            this.OutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutButton.AutoSize = true;
            this.OutButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.Out;
            this.OutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OutButton.FlatAppearance.BorderSize = 0;
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.Location = new System.Drawing.Point(976, 8);
            this.OutButton.Margin = new System.Windows.Forms.Padding(5);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(34, 37);
            this.OutButton.TabIndex = 1;
            this.OutButton.UseVisualStyleBackColor = true;
            // 
            // UserButton
            // 
            this.UserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserButton.BackgroundImage = global::Admin_Panel_Hotel.Properties.Resources.User;
            this.UserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Location = new System.Drawing.Point(916, 8);
            this.UserButton.Margin = new System.Windows.Forms.Padding(5);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(34, 37);
            this.UserButton.TabIndex = 0;
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftMenu);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1440, 1024);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.LeftMenu.ResumeLayout(false);
            this.CardsPanel.ResumeLayout(false);
            this.ApplicationsPanel.ResumeLayout(false);
            this.ApplicationsPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button MyCustomersButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button ApplicationsButton;
        private System.Windows.Forms.Panel ApplicationsPanel;
        private System.Windows.Forms.Button AddApplicationButton;
        private System.Windows.Forms.Button CurrentApplicationsButton;
        private System.Windows.Forms.Button NewApplicationsButton;
        private System.Windows.Forms.Button HistoryApplicationsButton;
        private System.Windows.Forms.Button DraftsButton;
        public System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Panel CardsPanel;
        private System.Windows.Forms.Button MovingCardsButton;
        private System.Windows.Forms.Button AddCardsButton;
        private System.Windows.Forms.Button AllCardsButton;
        private System.Windows.Forms.Button CardsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NewCount;
        private System.Windows.Forms.Label DraftCount;
    }
}

