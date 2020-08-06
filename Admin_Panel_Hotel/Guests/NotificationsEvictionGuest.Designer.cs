namespace Admin_Panel_Hotel.Guests
{
    partial class NotificationsEvictionGuest
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
            this.NotificationImagePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NotificationTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationImagePictureBox
            // 
            this.NotificationImagePictureBox.Location = new System.Drawing.Point(303, 203);
            this.NotificationImagePictureBox.Name = "NotificationImagePictureBox";
            this.NotificationImagePictureBox.Size = new System.Drawing.Size(89, 86);
            this.NotificationImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationImagePictureBox.TabIndex = 5;
            this.NotificationImagePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Panel_Hotel.Properties.Resources.UserCard;
            this.pictureBox1.Location = new System.Drawing.Point(150, 203);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 36, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationTextLabel
            // 
            this.NotificationTextLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationTextLabel.Location = new System.Drawing.Point(62, 53);
            this.NotificationTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NotificationTextLabel.Name = "NotificationTextLabel";
            this.NotificationTextLabel.Size = new System.Drawing.Size(475, 114);
            this.NotificationTextLabel.TabIndex = 3;
            this.NotificationTextLabel.Text = "Карта активирована";
            this.NotificationTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationsEvictionGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(588, 359);
            this.Controls.Add(this.NotificationImagePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotificationTextLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotificationsEvictionGuest";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotificationsEvictionGuest";
            this.Load += new System.EventHandler(this.NotificationsEvictionGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NotificationImagePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NotificationTextLabel;
    }
}