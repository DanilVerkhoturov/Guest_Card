namespace Admin_Panel_Hotel
{
    partial class AddCustomer
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
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Мои заказчики");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Текущие");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Добавить заявку");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("История заявок");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Черновики");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Заявки", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode106,
            treeNode107});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.INNTextBox = new System.Windows.Forms.TextBox();
            this.OGRNTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContractTimetextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.ContractNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AllPropertiesCheckBox = new System.Windows.Forms.CheckBox();
            this.GiveOutLinenCheckBox = new System.Windows.Forms.CheckBox();
            this.InstructedCheckBox = new System.Windows.Forms.CheckBox();
            this.ResidenceRulesCheckBox = new System.Windows.Forms.CheckBox();
            this.FireSafetyCheckBox = new System.Windows.Forms.CheckBox();
            this.Set1CheckBox = new System.Windows.Forms.CheckBox();
            this.Set2checkBox = new System.Windows.Forms.CheckBox();
            this.Set2HelpButton = new System.Windows.Forms.Button();
            this.Set1HelpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.treeView1.Name = "treeView1";
            treeNode100.Name = "MyCustomersNode";
            treeNode100.Text = "Мои заказчики";
            treeNode101.Name = "AddCustomerNode";
            treeNode101.Text = "Добавить заказчика";
            treeNode102.Name = "CustomersNode";
            treeNode102.Text = "Заказчики";
            treeNode103.Name = "NewApplicationsNode";
            treeNode103.Text = "Новые";
            treeNode104.Name = "CurrentApplicationsNode";
            treeNode104.Text = "Текущие";
            treeNode105.Name = "AddApplicationsNode";
            treeNode105.Text = "Добавить заявку";
            treeNode106.Name = "HistoryApplicationsNode";
            treeNode106.Text = "История заявок";
            treeNode107.Name = "DraftApplicationsNode";
            treeNode107.Text = "Черновики";
            treeNode108.Name = "ApplicationsNode";
            treeNode108.Text = "Заявки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode108});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(226, 558);
            this.treeView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить заказчика";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(278, 71);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(412, 25);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.Tag = "Наименование организации";
            this.CustomerNameTextBox.Text = "Наименование организации";
            this.CustomerNameTextBox.Enter += new System.EventHandler(this.CustomerNameTextBox_Enter);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressTextBox.Location = new System.Drawing.Point(278, 102);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(412, 25);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.Tag = "Наименование организации";
            this.AddressTextBox.Text = "Адрес";
            this.AddressTextBox.Enter += new System.EventHandler(this.AddressTextBox_Enter);
            // 
            // INNTextBox
            // 
            this.INNTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.INNTextBox.Location = new System.Drawing.Point(278, 133);
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.Size = new System.Drawing.Size(412, 25);
            this.INNTextBox.TabIndex = 3;
            this.INNTextBox.Tag = "Наименование организации";
            this.INNTextBox.Text = "ИНН";
            this.INNTextBox.Enter += new System.EventHandler(this.INNTextBox_Enter);
            // 
            // OGRNTextBox
            // 
            this.OGRNTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OGRNTextBox.Location = new System.Drawing.Point(278, 164);
            this.OGRNTextBox.Name = "OGRNTextBox";
            this.OGRNTextBox.Size = new System.Drawing.Size(412, 25);
            this.OGRNTextBox.TabIndex = 4;
            this.OGRNTextBox.Tag = "Наименование организации";
            this.OGRNTextBox.Text = "ОГРН";
            this.OGRNTextBox.Enter += new System.EventHandler(this.OGRNTextBox_Enter);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailTextBox.Location = new System.Drawing.Point(278, 288);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(412, 25);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.Tag = "Наименование организации";
            this.EmailTextBox.Text = "Электронная почта заказчика";
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
            // 
            // ContractTimetextBox
            // 
            this.ContractTimetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContractTimetextBox.Location = new System.Drawing.Point(278, 257);
            this.ContractTimetextBox.Name = "ContractTimetextBox";
            this.ContractTimetextBox.Size = new System.Drawing.Size(412, 25);
            this.ContractTimetextBox.TabIndex = 7;
            this.ContractTimetextBox.Tag = "Наименование организации";
            this.ContractTimetextBox.Text = "Срок договора";
            this.ContractTimetextBox.Enter += new System.EventHandler(this.ContractTimetextBox_Enter);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LocationTextBox.Location = new System.Drawing.Point(278, 226);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(412, 25);
            this.LocationTextBox.TabIndex = 6;
            this.LocationTextBox.Tag = "Наименование организации";
            this.LocationTextBox.Text = "Локация";
            this.LocationTextBox.Enter += new System.EventHandler(this.LocationTextBox_Enter);
            // 
            // ContractNumberTextBox
            // 
            this.ContractNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContractNumberTextBox.Location = new System.Drawing.Point(278, 195);
            this.ContractNumberTextBox.Name = "ContractNumberTextBox";
            this.ContractNumberTextBox.Size = new System.Drawing.Size(412, 25);
            this.ContractNumberTextBox.TabIndex = 5;
            this.ContractNumberTextBox.Tag = "Наименование организации";
            this.ContractNumberTextBox.Text = "Номер договора";
            this.ContractNumberTextBox.Enter += new System.EventHandler(this.ContractNumberTextBox_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Set1HelpButton);
            this.panel1.Controls.Add(this.Set2HelpButton);
            this.panel1.Controls.Add(this.Set2checkBox);
            this.panel1.Controls.Add(this.Set1CheckBox);
            this.panel1.Controls.Add(this.FireSafetyCheckBox);
            this.panel1.Controls.Add(this.ResidenceRulesCheckBox);
            this.panel1.Controls.Add(this.InstructedCheckBox);
            this.panel1.Controls.Add(this.GiveOutLinenCheckBox);
            this.panel1.Controls.Add(this.AllPropertiesCheckBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(278, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 197);
            this.panel1.TabIndex = 9;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddLocationButton.BackgroundImage")));
            this.AddLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddLocationButton.FlatAppearance.BorderSize = 0;
            this.AddLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocationButton.Location = new System.Drawing.Point(696, 226);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(26, 25);
            this.AddLocationButton.TabIndex = 10;
            this.AddLocationButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Свойства карт";
            // 
            // AllPropertiesCheckBox
            // 
            this.AllPropertiesCheckBox.AutoSize = true;
            this.AllPropertiesCheckBox.Location = new System.Drawing.Point(165, 2);
            this.AllPropertiesCheckBox.Name = "AllPropertiesCheckBox";
            this.AllPropertiesCheckBox.Size = new System.Drawing.Size(48, 21);
            this.AllPropertiesCheckBox.TabIndex = 12;
            this.AllPropertiesCheckBox.Text = "Все";
            this.AllPropertiesCheckBox.UseVisualStyleBackColor = true;
            this.AllPropertiesCheckBox.CheckedChanged += new System.EventHandler(this.AllPropertiesCheckBox_CheckedChanged);
            // 
            // GiveOutLinenCheckBox
            // 
            this.GiveOutLinenCheckBox.AutoSize = true;
            this.GiveOutLinenCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveOutLinenCheckBox.Location = new System.Drawing.Point(7, 34);
            this.GiveOutLinenCheckBox.Name = "GiveOutLinenCheckBox";
            this.GiveOutLinenCheckBox.Size = new System.Drawing.Size(130, 21);
            this.GiveOutLinenCheckBox.TabIndex = 13;
            this.GiveOutLinenCheckBox.Text = "Выдавать бельё";
            this.GiveOutLinenCheckBox.UseVisualStyleBackColor = true;
            // 
            // InstructedCheckBox
            // 
            this.InstructedCheckBox.AutoSize = true;
            this.InstructedCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructedCheckBox.Location = new System.Drawing.Point(7, 70);
            this.InstructedCheckBox.Name = "InstructedCheckBox";
            this.InstructedCheckBox.Size = new System.Drawing.Size(175, 21);
            this.InstructedCheckBox.TabIndex = 14;
            this.InstructedCheckBox.Text = "Проходить инструктаж";
            this.InstructedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResidenceRulesCheckBox
            // 
            this.ResidenceRulesCheckBox.AutoSize = true;
            this.ResidenceRulesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResidenceRulesCheckBox.Location = new System.Drawing.Point(38, 97);
            this.ResidenceRulesCheckBox.Name = "ResidenceRulesCheckBox";
            this.ResidenceRulesCheckBox.Size = new System.Drawing.Size(168, 21);
            this.ResidenceRulesCheckBox.TabIndex = 15;
            this.ResidenceRulesCheckBox.Text = "Правила проживания";
            this.ResidenceRulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // FireSafetyCheckBox
            // 
            this.FireSafetyCheckBox.AutoSize = true;
            this.FireSafetyCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FireSafetyCheckBox.Location = new System.Drawing.Point(38, 124);
            this.FireSafetyCheckBox.Name = "FireSafetyCheckBox";
            this.FireSafetyCheckBox.Size = new System.Drawing.Size(188, 21);
            this.FireSafetyCheckBox.TabIndex = 16;
            this.FireSafetyCheckBox.Text = "Пожарная безопастность";
            this.FireSafetyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Set1CheckBox
            // 
            this.Set1CheckBox.AutoSize = true;
            this.Set1CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set1CheckBox.Location = new System.Drawing.Point(153, 34);
            this.Set1CheckBox.Name = "Set1CheckBox";
            this.Set1CheckBox.Size = new System.Drawing.Size(101, 21);
            this.Set1CheckBox.TabIndex = 17;
            this.Set1CheckBox.Text = "Комплект-1";
            this.Set1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Set2checkBox
            // 
            this.Set2checkBox.AutoSize = true;
            this.Set2checkBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set2checkBox.Location = new System.Drawing.Point(284, 34);
            this.Set2checkBox.Name = "Set2checkBox";
            this.Set2checkBox.Size = new System.Drawing.Size(101, 21);
            this.Set2checkBox.TabIndex = 18;
            this.Set2checkBox.Text = "Комплект-2";
            this.Set2checkBox.UseVisualStyleBackColor = true;
            // 
            // Set2HelpButton
            // 
            this.Set2HelpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Set2HelpButton.BackgroundImage")));
            this.Set2HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Set2HelpButton.Location = new System.Drawing.Point(381, 32);
            this.Set2HelpButton.Name = "Set2HelpButton";
            this.Set2HelpButton.Size = new System.Drawing.Size(20, 21);
            this.Set2HelpButton.TabIndex = 19;
            this.Set2HelpButton.UseVisualStyleBackColor = true;
            // 
            // Set1HelpButton
            // 
            this.Set1HelpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Set1HelpButton.BackgroundImage")));
            this.Set1HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Set1HelpButton.Location = new System.Drawing.Point(248, 32);
            this.Set1HelpButton.Name = "Set1HelpButton";
            this.Set1HelpButton.Size = new System.Drawing.Size(20, 21);
            this.Set1HelpButton.TabIndex = 20;
            this.Set1HelpButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(313, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(739, 558);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ContractTimetextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.ContractNumberTextBox);
            this.Controls.Add(this.OGRNTextBox);
            this.Controls.Add(this.INNTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox INNTextBox;
        private System.Windows.Forms.TextBox OGRNTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ContractTimetextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox ContractNumberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button Set1HelpButton;
        private System.Windows.Forms.Button Set2HelpButton;
        private System.Windows.Forms.CheckBox Set2checkBox;
        private System.Windows.Forms.CheckBox Set1CheckBox;
        private System.Windows.Forms.CheckBox FireSafetyCheckBox;
        private System.Windows.Forms.CheckBox ResidenceRulesCheckBox;
        private System.Windows.Forms.CheckBox InstructedCheckBox;
        private System.Windows.Forms.CheckBox GiveOutLinenCheckBox;
        private System.Windows.Forms.CheckBox AllPropertiesCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}