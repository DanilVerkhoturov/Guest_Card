namespace Admin_Panel_Hotel
{
    partial class NotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsForm));
            this.ApplicationAddText = new System.Windows.Forms.Label();
            this.GoOverText = new System.Windows.Forms.Label();
            this.CurrentApplicationsText = new System.Windows.Forms.Label();
            this.OrText = new System.Windows.Forms.Label();
            this.AddText = new System.Windows.Forms.Label();
            this.AddApplicationsText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationAddText
            // 
            this.ApplicationAddText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationAddText.AutoSize = true;
            this.ApplicationAddText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationAddText.Location = new System.Drawing.Point(200, 89);
            this.ApplicationAddText.Name = "ApplicationAddText";
            this.ApplicationAddText.Size = new System.Drawing.Size(284, 45);
            this.ApplicationAddText.TabIndex = 0;
            this.ApplicationAddText.Text = "Заявка добавлена";
            this.ApplicationAddText.Click += new System.EventHandler(this.ApplicationAddText_Click);
            // 
            // GoOverText
            // 
            this.GoOverText.AutoSize = true;
            this.GoOverText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.GoOverText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoOverText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOverText.Location = new System.Drawing.Point(154, 149);
            this.GoOverText.Name = "GoOverText";
            this.GoOverText.Size = new System.Drawing.Size(130, 32);
            this.GoOverText.TabIndex = 1;
            this.GoOverText.Text = "Перейти в";
            this.GoOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoOverText.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentApplicationsText
            // 
            this.CurrentApplicationsText.AutoEllipsis = true;
            this.CurrentApplicationsText.AutoSize = true;
            this.CurrentApplicationsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.CurrentApplicationsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentApplicationsText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentApplicationsText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentApplicationsText.Location = new System.Drawing.Point(281, 149);
            this.CurrentApplicationsText.Name = "CurrentApplicationsText";
            this.CurrentApplicationsText.Size = new System.Drawing.Size(190, 32);
            this.CurrentApplicationsText.TabIndex = 2;
            this.CurrentApplicationsText.Text = "текущие заявки";
            this.CurrentApplicationsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentApplicationsText.Click += new System.EventHandler(this.label2_Click);
            // 
            // OrText
            // 
            this.OrText.AutoSize = true;
            this.OrText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.OrText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrText.Location = new System.Drawing.Point(467, 149);
            this.OrText.Name = "OrText";
            this.OrText.Size = new System.Drawing.Size(56, 32);
            this.OrText.TabIndex = 3;
            this.OrText.Text = "или\r\n";
            this.OrText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddText
            // 
            this.AddText.AutoSize = true;
            this.AddText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.AddText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddText.Location = new System.Drawing.Point(202, 181);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(117, 32);
            this.AddText.TabIndex = 4;
            this.AddText.Text = "добавить";
            this.AddText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddApplicationsText
            // 
            this.AddApplicationsText.AutoSize = true;
            this.AddApplicationsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.AddApplicationsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApplicationsText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddApplicationsText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddApplicationsText.Location = new System.Drawing.Point(317, 181);
            this.AddApplicationsText.Name = "AddApplicationsText";
            this.AddApplicationsText.Size = new System.Drawing.Size(167, 32);
            this.AddApplicationsText.TabIndex = 5;
            this.AddApplicationsText.Text = "новую заявку";
            this.AddApplicationsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(672, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddApplicationsText);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.OrText);
            this.Controls.Add(this.CurrentApplicationsText);
            this.Controls.Add(this.GoOverText);
            this.Controls.Add(this.ApplicationAddText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationsForm";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplicationAddText;
        private System.Windows.Forms.Label GoOverText;
        private System.Windows.Forms.Label CurrentApplicationsText;
        private System.Windows.Forms.Label OrText;
        private System.Windows.Forms.Label AddText;
        private System.Windows.Forms.Label AddApplicationsText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}