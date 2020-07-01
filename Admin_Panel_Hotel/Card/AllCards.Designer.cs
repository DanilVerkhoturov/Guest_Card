namespace Admin_Panel_Hotel.Card
{
    partial class AllCards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ShowUserInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AllCardLabel = new System.Windows.Forms.Label();
            this.FilterCardsComboBox = new System.Windows.Forms.ComboBox();
            this.CardsCountLabel = new System.Windows.Forms.Label();
            this.ShowAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CardsStatusComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTable
            // 
            this.GridTable.AllowUserToAddRows = false;
            this.GridTable.AllowUserToDeleteRows = false;
            this.GridTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.GridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ShowUserInfo,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridTable.EnableHeadersVisualStyles = false;
            this.GridTable.Location = new System.Drawing.Point(132, 163);
            this.GridTable.Margin = new System.Windows.Forms.Padding(5, 21, 5, 6);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.GridTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridTable.Size = new System.Drawing.Size(790, 441);
            this.GridTable.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.FillWeight = 20F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 112.3096F;
            this.Column2.HeaderText = "ID карты";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Статус";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Местонахождение";
            this.Column4.Name = "Column4";
            // 
            // ShowUserInfo
            // 
            this.ShowUserInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShowUserInfo.HeaderText = "";
            this.ShowUserInfo.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.ShowUserInfo.Name = "ShowUserInfo";
            this.ShowUserInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowUserInfo.Width = 30;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.NullValue = false;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Visible = false;
            this.Column5.Width = 30;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(704, 779);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(218, 48);
            this.AcceptButton.TabIndex = 25;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Visible = false;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(797, 26);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(125, 35);
            this.PrintButton.TabIndex = 22;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // AllCardLabel
            // 
            this.AllCardLabel.AutoSize = true;
            this.AllCardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCardLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCardLabel.Location = new System.Drawing.Point(36, 22);
            this.AllCardLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AllCardLabel.Name = "AllCardLabel";
            this.AllCardLabel.Size = new System.Drawing.Size(154, 35);
            this.AllCardLabel.TabIndex = 18;
            this.AllCardLabel.Text = "Все карты";
            // 
            // FilterCardsComboBox
            // 
            this.FilterCardsComboBox.BackColor = System.Drawing.Color.White;
            this.FilterCardsComboBox.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCardsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.FilterCardsComboBox.FormattingEnabled = true;
            this.FilterCardsComboBox.Items.AddRange(new object[] {
            "Все карты"});
            this.FilterCardsComboBox.Location = new System.Drawing.Point(132, 105);
            this.FilterCardsComboBox.Margin = new System.Windows.Forms.Padding(123, 48, 5, 4);
            this.FilterCardsComboBox.Name = "FilterCardsComboBox";
            this.FilterCardsComboBox.Size = new System.Drawing.Size(340, 33);
            this.FilterCardsComboBox.TabIndex = 38;
            // 
            // CardsCountLabel
            // 
            this.CardsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CardsCountLabel.AutoSize = true;
            this.CardsCountLabel.Location = new System.Drawing.Point(127, 779);
            this.CardsCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CardsCountLabel.Name = "CardsCountLabel";
            this.CardsCountLabel.Size = new System.Drawing.Size(196, 25);
            this.CardsCountLabel.TabIndex = 41;
            this.CardsCountLabel.Text = "1-50 из 10000 карт";
            // 
            // ShowAllLinkLabel
            // 
            this.ShowAllLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowAllLinkLabel.AutoSize = true;
            this.ShowAllLinkLabel.Location = new System.Drawing.Point(363, 779);
            this.ShowAllLinkLabel.Margin = new System.Windows.Forms.Padding(35, 0, 5, 0);
            this.ShowAllLinkLabel.Name = "ShowAllLinkLabel";
            this.ShowAllLinkLabel.Size = new System.Drawing.Size(143, 25);
            this.ShowAllLinkLabel.TabIndex = 42;
            this.ShowAllLinkLabel.TabStop = true;
            this.ShowAllLinkLabel.Text = "Показать все";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(499, 105);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(22, 3, 3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(351, 33);
            this.SearchTextBox.TabIndex = 43;
            this.SearchTextBox.Text = "Поиск";
            // 
            // CardsStatusComboBox
            // 
            this.CardsStatusComboBox.FormattingEnabled = true;
            this.CardsStatusComboBox.Items.AddRange(new object[] {
            "Статус"});
            this.CardsStatusComboBox.Location = new System.Drawing.Point(132, 663);
            this.CardsStatusComboBox.Name = "CardsStatusComboBox";
            this.CardsStatusComboBox.Size = new System.Drawing.Size(244, 33);
            this.CardsStatusComboBox.TabIndex = 44;
            this.CardsStatusComboBox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(543, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 35);
            this.button1.TabIndex = 45;
            this.button1.Text = "Изменить статус";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AllCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1013, 894);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CardsStatusComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ShowAllLinkLabel);
            this.Controls.Add(this.CardsCountLabel);
            this.Controls.Add(this.FilterCardsComboBox);
            this.Controls.Add(this.GridTable);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AllCardLabel);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(1029, 933);
            this.MinimumSize = new System.Drawing.Size(1029, 933);
            this.Name = "AllCards";
            this.Text = "AllCard";
            this.Load += new System.EventHandler(this.AllCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridTable;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label AllCardLabel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox FilterCardsComboBox;
        private System.Windows.Forms.Label CardsCountLabel;
        private System.Windows.Forms.LinkLabel ShowAllLinkLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox CardsStatusComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn ShowUserInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}