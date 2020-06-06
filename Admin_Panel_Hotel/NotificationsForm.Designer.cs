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
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.GoOverText = new System.Windows.Forms.Label();
            this.CurrentApplicationsLabel = new System.Windows.Forms.Label();
            this.OrText = new System.Windows.Forms.Label();
            this.NotificationLabel2 = new System.Windows.Forms.Label();
            this.AddApplicationsLabel = new System.Windows.Forms.Label();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel.Location = new System.Drawing.Point(200, 89);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(284, 45);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Заявка добавлена";
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
            // 
            // CurrentApplicationsLabel
            // 
            this.CurrentApplicationsLabel.AutoEllipsis = true;
            this.CurrentApplicationsLabel.AutoSize = true;
            this.CurrentApplicationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.CurrentApplicationsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentApplicationsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentApplicationsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentApplicationsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentApplicationsLabel.Location = new System.Drawing.Point(281, 149);
            this.CurrentApplicationsLabel.Name = "CurrentApplicationsLabel";
            this.CurrentApplicationsLabel.Size = new System.Drawing.Size(190, 32);
            this.CurrentApplicationsLabel.TabIndex = 2;
            this.CurrentApplicationsLabel.Text = "текущие заявки";
            this.CurrentApplicationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentApplicationsLabel.Click += new System.EventHandler(this.CurrentApplicationsLabel_Click);
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
            // NotificationLabel2
            // 
            this.NotificationLabel2.AutoSize = true;
            this.NotificationLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.NotificationLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel2.Location = new System.Drawing.Point(202, 181);
            this.NotificationLabel2.Name = "NotificationLabel2";
            this.NotificationLabel2.Size = new System.Drawing.Size(117, 32);
            this.NotificationLabel2.TabIndex = 4;
            this.NotificationLabel2.Text = "добавить";
            this.NotificationLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddApplicationsLabel
            // 
            this.AddApplicationsLabel.AutoSize = true;
            this.AddApplicationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.AddApplicationsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddApplicationsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApplicationsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddApplicationsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddApplicationsLabel.Location = new System.Drawing.Point(317, 181);
            this.AddApplicationsLabel.Name = "AddApplicationsLabel";
            this.AddApplicationsLabel.Size = new System.Drawing.Size(167, 32);
            this.AddApplicationsLabel.TabIndex = 5;
            this.AddApplicationsLabel.Text = "новую заявку";
            this.AddApplicationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddApplicationsLabel.Click += new System.EventHandler(this.AddApplicationsLabel_Click);
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePictureBox.Image")));
            this.ClosePictureBox.Location = new System.Drawing.Point(641, 3);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(29, 29);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePictureBox.TabIndex = 6;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(672, 399);
            this.Controls.Add(this.ClosePictureBox);
            this.Controls.Add(this.AddApplicationsLabel);
            this.Controls.Add(this.NotificationLabel2);
            this.Controls.Add(this.OrText);
            this.Controls.Add(this.CurrentApplicationsLabel);
            this.Controls.Add(this.GoOverText);
            this.Controls.Add(this.NotificationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationsForm";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GoOverText;
        private System.Windows.Forms.Label CurrentApplicationsLabel;
        private System.Windows.Forms.Label OrText;
        private System.Windows.Forms.Label NotificationLabel2;
        private System.Windows.Forms.Label AddApplicationsLabel;
        private System.Windows.Forms.PictureBox ClosePictureBox;
        public System.Windows.Forms.Label NotificationLabel;
    }
}