namespace Admin_Panel_Hotel.Guests
{
    partial class NotificationCardGuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.LostCardRadioButton = new System.Windows.Forms.RadioButton();
            this.BrokenCardRarioButton = new System.Windows.Forms.RadioButton();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 79, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите причину не сдачи магнитной карты";
            // 
            // LostCardRadioButton
            // 
            this.LostCardRadioButton.AutoSize = true;
            this.LostCardRadioButton.Location = new System.Drawing.Point(239, 158);
            this.LostCardRadioButton.Margin = new System.Windows.Forms.Padding(230, 41, 3, 3);
            this.LostCardRadioButton.Name = "LostCardRadioButton";
            this.LostCardRadioButton.Size = new System.Drawing.Size(110, 29);
            this.LostCardRadioButton.TabIndex = 1;
            this.LostCardRadioButton.TabStop = true;
            this.LostCardRadioButton.Text = "Утеряна";
            this.LostCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // BrokenCardRarioButton
            // 
            this.BrokenCardRarioButton.AutoSize = true;
            this.BrokenCardRarioButton.Location = new System.Drawing.Point(239, 231);
            this.BrokenCardRarioButton.Margin = new System.Windows.Forms.Padding(230, 41, 3, 3);
            this.BrokenCardRarioButton.Name = "BrokenCardRarioButton";
            this.BrokenCardRarioButton.Size = new System.Drawing.Size(118, 29);
            this.BrokenCardRarioButton.TabIndex = 2;
            this.BrokenCardRarioButton.TabStop = true;
            this.BrokenCardRarioButton.Text = "Сломана";
            this.BrokenCardRarioButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(219, 292);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(210, 3, 3, 10);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(165, 48);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            // 
            // NotificationCardGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(588, 359);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.BrokenCardRarioButton);
            this.Controls.Add(this.LostCardRadioButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotificationCardGuest";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotificationCadrdGues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LostCardRadioButton;
        private System.Windows.Forms.RadioButton BrokenCardRarioButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}