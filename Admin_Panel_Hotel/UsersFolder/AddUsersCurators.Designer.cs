namespace Admin_Panel_Hotel.UsersFolder
{
    partial class AddUsersCurators
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
            this.label2 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать роль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(83, 42, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить участника";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.BackColor = System.Drawing.Color.White;
            this.FilterComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Все карты"});
            this.FilterComboBox.Location = new System.Drawing.Point(97, 160);
            this.FilterComboBox.Margin = new System.Windows.Forms.Padding(100, 14, 5, 4);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(951, 33);
            this.FilterComboBox.TabIndex = 40;
            this.FilterComboBox.Text = "Куратор питания";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(97, 216);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(61, 19, 3, 3);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(294, 33);
            this.emailtextbox.TabIndex = 41;
            this.emailtextbox.Text = "Электронная почта";
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.Color.White;
            this.ChangeButton.Location = new System.Drawing.Point(827, 336);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(769, 56, 33, 6);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(221, 42);
            this.ChangeButton.TabIndex = 58;
            this.ChangeButton.Text = "Подтвердить";
            this.ChangeButton.UseVisualStyleBackColor = false;
            // 
            // AddUsersCurators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddUsersCurators";
            this.Text = "AddUsersCurators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.Button ChangeButton;
    }
}