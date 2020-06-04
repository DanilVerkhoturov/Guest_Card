namespace Admin_Panel_Hotel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Мои заказчики");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Текущие");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Добавить заявку");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("История заявок");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Черновики");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Заявки", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.panel_left_menu = new System.Windows.Forms.Panel();
            this.panel_sbbutton_2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_subbutton_1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_window = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_left_menu.SuspendLayout();
            this.panel_sbbutton_2.SuspendLayout();
            this.panel_subbutton_1.SuspendLayout();
            this.panel_window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left_menu
            // 
            this.panel_left_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_left_menu.Controls.Add(this.panel_sbbutton_2);
            this.panel_left_menu.Controls.Add(this.button5);
            this.panel_left_menu.Controls.Add(this.panel_subbutton_1);
            this.panel_left_menu.Controls.Add(this.button1);
            this.panel_left_menu.Controls.Add(this.panel_logo);
            this.panel_left_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_left_menu.Name = "panel_left_menu";
            this.panel_left_menu.Size = new System.Drawing.Size(200, 547);
            this.panel_left_menu.TabIndex = 0;
            this.panel_left_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_left_menu_Paint);
            // 
            // panel_sbbutton_2
            // 
            this.panel_sbbutton_2.Controls.Add(this.button9);
            this.panel_sbbutton_2.Controls.Add(this.button4);
            this.panel_sbbutton_2.Controls.Add(this.button6);
            this.panel_sbbutton_2.Controls.Add(this.button7);
            this.panel_sbbutton_2.Controls.Add(this.button8);
            this.panel_sbbutton_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sbbutton_2.Location = new System.Drawing.Point(0, 245);
            this.panel_sbbutton_2.Name = "panel_sbbutton_2";
            this.panel_sbbutton_2.Size = new System.Drawing.Size(200, 131);
            this.panel_sbbutton_2.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 101);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(200, 26);
            this.button9.TabIndex = 6;
            this.button9.Text = "Черновики";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 75);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "История заявок";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 50);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 25);
            this.button6.TabIndex = 4;
            this.button6.Text = "Добавить заявку";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 25);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 25);
            this.button7.TabIndex = 3;
            this.button7.Text = "Текущие";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(200, 25);
            this.button8.TabIndex = 2;
            this.button8.Text = "Новые";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 45);
            this.button5.TabIndex = 3;
            this.button5.Text = "Заявки";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel_subbutton_1
            // 
            this.panel_subbutton_1.Controls.Add(this.button3);
            this.panel_subbutton_1.Controls.Add(this.button2);
            this.panel_subbutton_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subbutton_1.Location = new System.Drawing.Point(0, 145);
            this.panel_subbutton_1.Name = "panel_subbutton_1";
            this.panel_subbutton_1.Size = new System.Drawing.Size(200, 55);
            this.panel_subbutton_1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 25);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить заказчика";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Мои заказчики";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заказчики";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_logo.BackgroundImage")));
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_window
            // 
            this.panel_window.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_window.Controls.Add(this.treeView1);
            this.panel_window.Controls.Add(this.pictureBox1);
            this.panel_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_window.Location = new System.Drawing.Point(200, 0);
            this.panel_window.Name = "panel_window";
            this.panel_window.Size = new System.Drawing.Size(813, 547);
            this.panel_window.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(35, 100);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "MyCustomersNode";
            treeNode1.Text = "Мои заказчики";
            treeNode2.Name = "AddCustomerNode";
            treeNode2.Text = "Добавить заказчика";
            treeNode3.Name = "CustomersNode";
            treeNode3.Text = "Заказчики";
            treeNode4.Name = "NewApplicationsNode";
            treeNode4.Text = "Новые";
            treeNode5.Name = "CurrentApplicationsNode";
            treeNode5.Text = "Текущие";
            treeNode6.Name = "AddApplicationsNode";
            treeNode6.Text = "Добавить заявку";
            treeNode7.Name = "HistoryApplicationsNode";
            treeNode7.Text = "История заявок";
            treeNode8.Name = "DraftApplicationsNode";
            treeNode8.Text = "Черновики";
            treeNode9.Name = "ApplicationsNode";
            treeNode9.Text = "Заявки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(217, 370);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 547);
            this.Controls.Add(this.panel_window);
            this.Controls.Add(this.panel_left_menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_left_menu.ResumeLayout(false);
            this.panel_sbbutton_2.ResumeLayout(false);
            this.panel_subbutton_1.ResumeLayout(false);
            this.panel_window.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left_menu;
        private System.Windows.Forms.Panel panel_window;
        private System.Windows.Forms.Panel panel_subbutton_1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_sbbutton_2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TreeView treeView1;
    }
}

