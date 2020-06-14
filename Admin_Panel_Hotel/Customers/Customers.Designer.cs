namespace Admin_Panel_Hotel
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.ShowApplicationsButton2 = new System.Windows.Forms.Button();
            this.ShowApplicationButton1 = new System.Windows.Forms.Button();
            this.ApplicationsNameTextBox2 = new System.Windows.Forms.TextBox();
            this.ApplicationsNameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountCusstomersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Имя заказчика";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LocationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(283, 85);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(233, 28);
            this.LocationComboBox.TabIndex = 43;
            this.LocationComboBox.Text = "Локация";
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(22, 85);
            this.CustomersComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(233, 28);
            this.CustomersComboBox.TabIndex = 42;
            this.CustomersComboBox.Text = "Заказчик";
            // 
            // ShowApplicationsButton2
            // 
            this.ShowApplicationsButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowApplicationsButton2.BackColor = System.Drawing.Color.Transparent;
            this.ShowApplicationsButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowApplicationsButton2.BackgroundImage")));
            this.ShowApplicationsButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowApplicationsButton2.Location = new System.Drawing.Point(363, 194);
            this.ShowApplicationsButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowApplicationsButton2.Name = "ShowApplicationsButton2";
            this.ShowApplicationsButton2.Size = new System.Drawing.Size(29, 33);
            this.ShowApplicationsButton2.TabIndex = 41;
            this.ShowApplicationsButton2.UseVisualStyleBackColor = false;
            // 
            // ShowApplicationButton1
            // 
            this.ShowApplicationButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowApplicationButton1.BackColor = System.Drawing.Color.Transparent;
            this.ShowApplicationButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowApplicationButton1.BackgroundImage")));
            this.ShowApplicationButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowApplicationButton1.Location = new System.Drawing.Point(363, 145);
            this.ShowApplicationButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowApplicationButton1.Name = "ShowApplicationButton1";
            this.ShowApplicationButton1.Size = new System.Drawing.Size(29, 33);
            this.ShowApplicationButton1.TabIndex = 40;
            this.ShowApplicationButton1.UseVisualStyleBackColor = false;
            // 
            // ApplicationsNameTextBox2
            // 
            this.ApplicationsNameTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationsNameTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsNameTextBox2.Location = new System.Drawing.Point(22, 194);
            this.ApplicationsNameTextBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.ApplicationsNameTextBox2.Multiline = true;
            this.ApplicationsNameTextBox2.Name = "ApplicationsNameTextBox2";
            this.ApplicationsNameTextBox2.Size = new System.Drawing.Size(334, 32);
            this.ApplicationsNameTextBox2.TabIndex = 39;
            this.ApplicationsNameTextBox2.Text = "Заявка-2";
            // 
            // ApplicationsNameTextBox1
            // 
            this.ApplicationsNameTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationsNameTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsNameTextBox1.Location = new System.Drawing.Point(22, 145);
            this.ApplicationsNameTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 16);
            this.ApplicationsNameTextBox1.Multiline = true;
            this.ApplicationsNameTextBox1.Name = "ApplicationsNameTextBox1";
            this.ApplicationsNameTextBox1.Size = new System.Drawing.Size(334, 32);
            this.ApplicationsNameTextBox1.TabIndex = 38;
            this.ApplicationsNameTextBox1.Text = "Заявка-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Текущие заявки";
            // 
            // CountCusstomersLabel
            // 
            this.CountCusstomersLabel.AutoSize = true;
            this.CountCusstomersLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountCusstomersLabel.Location = new System.Drawing.Point(21, 46);
            this.CountCusstomersLabel.Name = "CountCusstomersLabel";
            this.CountCusstomersLabel.Size = new System.Drawing.Size(118, 17);
            this.CountCusstomersLabel.TabIndex = 44;
            this.CountCusstomersLabel.Text = "Всего: 2 заказчика";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 552);
            this.Controls.Add(this.CountCusstomersLabel);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.CustomersComboBox);
            this.Controls.Add(this.ShowApplicationsButton2);
            this.Controls.Add(this.ShowApplicationButton1);
            this.Controls.Add(this.ApplicationsNameTextBox2);
            this.Controls.Add(this.ApplicationsNameTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customers";
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox CustomersComboBox;
        private System.Windows.Forms.Button ShowApplicationsButton2;
        private System.Windows.Forms.Button ShowApplicationButton1;
        private System.Windows.Forms.TextBox ApplicationsNameTextBox2;
        private System.Windows.Forms.TextBox ApplicationsNameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountCusstomersLabel;
    }
}