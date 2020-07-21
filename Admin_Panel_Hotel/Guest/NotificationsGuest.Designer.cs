namespace Admin_Panel_Hotel.Guest.Notification
{
    partial class NotificationsGuest
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
            this.NotificationTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NotificationImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationTextLabel
            // 
            this.NotificationTextLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationTextLabel.Location = new System.Drawing.Point(64, 52);
            this.NotificationTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NotificationTextLabel.Name = "NotificationTextLabel";
            this.NotificationTextLabel.Size = new System.Drawing.Size(475, 114);
            this.NotificationTextLabel.TabIndex = 0;
            this.NotificationTextLabel.Text = "Карта активирована";
            this.NotificationTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Panel_Hotel.Properties.Resources.UserCard;
            this.pictureBox1.Location = new System.Drawing.Point(152, 202);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 36, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationImagePictureBox
            // 
            this.NotificationImagePictureBox.Location = new System.Drawing.Point(305, 202);
            this.NotificationImagePictureBox.Name = "NotificationImagePictureBox";
            this.NotificationImagePictureBox.Size = new System.Drawing.Size(89, 86);
            this.NotificationImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationImagePictureBox.TabIndex = 2;
            this.NotificationImagePictureBox.TabStop = false;
            // 
            // NotificationsGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 359);
            this.Controls.Add(this.NotificationImagePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotificationTextLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotificationsGuest";
            this.Text = "NotificationsGuest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NotificationTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox NotificationImagePictureBox;
    }
}