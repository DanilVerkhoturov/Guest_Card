namespace Admin_Panel_Hotel
{
    partial class DraftApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DraftApplications));
            this.Castomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplicationsNameTextBox1 = new System.Windows.Forms.TextBox();
            this.ApplicationsNameTextBox2 = new System.Windows.Forms.TextBox();
            this.ShowApplicationButton1 = new System.Windows.Forms.Button();
            this.ShowApplicationsButton2 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Черновики";
            // 
            // ApplicationsNameTextBox1
            // 
            this.ApplicationsNameTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsNameTextBox1.Location = new System.Drawing.Point(33, 67);
            this.ApplicationsNameTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.ApplicationsNameTextBox1.Multiline = true;
            this.ApplicationsNameTextBox1.Name = "ApplicationsNameTextBox1";
            this.ApplicationsNameTextBox1.ReadOnly = true;
            this.ApplicationsNameTextBox1.Size = new System.Drawing.Size(287, 25);
            this.ApplicationsNameTextBox1.TabIndex = 3;
            this.ApplicationsNameTextBox1.Text = "Заявка-1";
            this.ApplicationsNameTextBox1.TextChanged += new System.EventHandler(this.ApplicationsNameTextBox1_TextChanged);
            // 
            // ApplicationsNameTextBox2
            // 
            this.ApplicationsNameTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApplicationsNameTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationsNameTextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationsNameTextBox2.Location = new System.Drawing.Point(33, 104);
            this.ApplicationsNameTextBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ApplicationsNameTextBox2.Multiline = true;
            this.ApplicationsNameTextBox2.Name = "ApplicationsNameTextBox2";
            this.ApplicationsNameTextBox2.ReadOnly = true;
            this.ApplicationsNameTextBox2.Size = new System.Drawing.Size(287, 25);
            this.ApplicationsNameTextBox2.TabIndex = 6;
            this.ApplicationsNameTextBox2.Text = "Заявка-2";
            this.ApplicationsNameTextBox2.TextChanged += new System.EventHandler(this.ApplicationsNameTextBox2_TextChanged);
            // 
            // ShowApplicationButton1
            // 
            this.ShowApplicationButton1.BackColor = System.Drawing.Color.Transparent;
            this.ShowApplicationButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowApplicationButton1.BackgroundImage")));
            this.ShowApplicationButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowApplicationButton1.Location = new System.Drawing.Point(326, 67);
            this.ShowApplicationButton1.Name = "ShowApplicationButton1";
            this.ShowApplicationButton1.Size = new System.Drawing.Size(25, 25);
            this.ShowApplicationButton1.TabIndex = 7;
            this.ShowApplicationButton1.UseVisualStyleBackColor = false;
            this.ShowApplicationButton1.Click += new System.EventHandler(this.ShowApplicationButton1_Click);
            // 
            // ShowApplicationsButton2
            // 
            this.ShowApplicationsButton2.BackColor = System.Drawing.Color.Transparent;
            this.ShowApplicationsButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowApplicationsButton2.BackgroundImage")));
            this.ShowApplicationsButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowApplicationsButton2.Location = new System.Drawing.Point(326, 104);
            this.ShowApplicationsButton2.Name = "ShowApplicationsButton2";
            this.ShowApplicationsButton2.Size = new System.Drawing.Size(25, 25);
            this.ShowApplicationsButton2.TabIndex = 8;
            this.ShowApplicationsButton2.UseVisualStyleBackColor = false;
            this.ShowApplicationsButton2.Click += new System.EventHandler(this.ShowApplicationsButton2_Click);
            // 
            // DraftApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 745);
            this.Controls.Add(this.ShowApplicationsButton2);
            this.Controls.Add(this.ShowApplicationButton1);
            this.Controls.Add(this.ApplicationsNameTextBox2);
            this.Controls.Add(this.ApplicationsNameTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DraftApplications";
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
        private System.Windows.Forms.Button ShowApplicationButton1;
        private System.Windows.Forms.Button ShowApplicationsButton2;
    }
}