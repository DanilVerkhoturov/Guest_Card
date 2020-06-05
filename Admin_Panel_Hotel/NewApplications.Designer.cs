namespace Admin_Panel_Hotel
{
    partial class NewApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewApplications));
            this.Castomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplicationsNameTextBox1 = new System.Windows.Forms.TextBox();
            this.ApplicationsNameTextBox2 = new System.Windows.Forms.TextBox();
            this.WatchApplicationsButton1 = new System.Windows.Forms.Button();
            this.WatchApplicationsButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Castomer
            // 
            this.Castomer.HeaderText = "Заявка №";
            this.Castomer.Name = "Castomer";
            this.Castomer.ReadOnly = true;
            this.Castomer.Width = 81;
            // 
            // Location
            // 
            this.Location.HeaderText = "Дата";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новые заявки";
            // 
            // ApplicationsNameTextBox1
            // 
            this.ApplicationsNameTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox1.Location = new System.Drawing.Point(33, 65);
            this.ApplicationsNameTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.ApplicationsNameTextBox1.Multiline = true;
            this.ApplicationsNameTextBox1.Name = "ApplicationsNameTextBox1";
            this.ApplicationsNameTextBox1.Size = new System.Drawing.Size(287, 25);
            this.ApplicationsNameTextBox1.TabIndex = 3;
            // 
            // ApplicationsNameTextBox2
            // 
            this.ApplicationsNameTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox2.Location = new System.Drawing.Point(33, 102);
            this.ApplicationsNameTextBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ApplicationsNameTextBox2.Multiline = true;
            this.ApplicationsNameTextBox2.Name = "ApplicationsNameTextBox2";
            this.ApplicationsNameTextBox2.Size = new System.Drawing.Size(287, 25);
            this.ApplicationsNameTextBox2.TabIndex = 6;
            // 
            // WatchApplicationsButton1
            // 
            this.WatchApplicationsButton1.BackColor = System.Drawing.Color.Transparent;
            this.WatchApplicationsButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WatchApplicationsButton1.BackgroundImage")));
            this.WatchApplicationsButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WatchApplicationsButton1.Location = new System.Drawing.Point(326, 65);
            this.WatchApplicationsButton1.Name = "WatchApplicationsButton1";
            this.WatchApplicationsButton1.Size = new System.Drawing.Size(25, 25);
            this.WatchApplicationsButton1.TabIndex = 7;
            this.WatchApplicationsButton1.UseVisualStyleBackColor = false;
            // 
            // WatchApplicationsButton2
            // 
            this.WatchApplicationsButton2.BackColor = System.Drawing.Color.Transparent;
            this.WatchApplicationsButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WatchApplicationsButton2.BackgroundImage")));
            this.WatchApplicationsButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WatchApplicationsButton2.Location = new System.Drawing.Point(326, 102);
            this.WatchApplicationsButton2.Name = "WatchApplicationsButton2";
            this.WatchApplicationsButton2.Size = new System.Drawing.Size(25, 25);
            this.WatchApplicationsButton2.TabIndex = 8;
            this.WatchApplicationsButton2.UseVisualStyleBackColor = false;
            // 
            // NewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 745);
            this.Controls.Add(this.WatchApplicationsButton2);
            this.Controls.Add(this.WatchApplicationsButton1);
            this.Controls.Add(this.ApplicationsNameTextBox2);
            this.Controls.Add(this.ApplicationsNameTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewApplications";
            this.Text = "Applications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Castomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApplicationsNameTextBox1;
        private System.Windows.Forms.TextBox ApplicationsNameTextBox2;
        private System.Windows.Forms.Button WatchApplicationsButton1;
        private System.Windows.Forms.Button WatchApplicationsButton2;
    }
}