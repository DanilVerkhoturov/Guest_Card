namespace Admin_Panel_Hotel
{
    partial class ShowApplicationVer2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowApplicationVer2));
            this.NewApplicationsLabel = new System.Windows.Forms.Label();
            this.NameCustomer = new System.Windows.Forms.Label();
            this.DateAplication = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DraftButton = new System.Windows.Forms.Button();
            this.NameApplication = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowUserInfo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NewApplicationsLabel
            // 
            this.NewApplicationsLabel.AutoSize = true;
            this.NewApplicationsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewApplicationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NewApplicationsLabel.Location = new System.Drawing.Point(25, 25);
            this.NewApplicationsLabel.Name = "NewApplicationsLabel";
            this.NewApplicationsLabel.Size = new System.Drawing.Size(156, 24);
            this.NewApplicationsLabel.TabIndex = 0;
            this.NewApplicationsLabel.Text = "Новые заявки  >";
            this.NewApplicationsLabel.Click += new System.EventHandler(this.NewApplicationsLabel_Click);
            // 
            // NameCustomer
            // 
            this.NameCustomer.AutoSize = true;
            this.NameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCustomer.Location = new System.Drawing.Point(26, 77);
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.Size = new System.Drawing.Size(101, 16);
            this.NameCustomer.TabIndex = 1;
            this.NameCustomer.Text = "Заказчик ННГ";
            // 
            // DateAplication
            // 
            this.DateAplication.AutoSize = true;
            this.DateAplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateAplication.Location = new System.Drawing.Point(144, 77);
            this.DateAplication.Name = "DateAplication";
            this.DateAplication.Size = new System.Drawing.Size(108, 16);
            this.DateAplication.TabIndex = 2;
            this.DateAplication.Text = "Дата: 02.07.2020";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(577, 25);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(67, 29);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // DraftButton
            // 
            this.DraftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DraftButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.DraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DraftButton.Location = new System.Drawing.Point(650, 25);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(81, 29);
            this.DraftButton.TabIndex = 14;
            this.DraftButton.Text = "Черновик";
            this.DraftButton.UseVisualStyleBackColor = false;
            // 
            // NameApplication
            // 
            this.NameApplication.AutoSize = true;
            this.NameApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NameApplication.Location = new System.Drawing.Point(179, 25);
            this.NameApplication.Name = "NameApplication";
            this.NameApplication.Size = new System.Drawing.Size(94, 24);
            this.NameApplication.TabIndex = 15;
            this.NameApplication.Text = "Заявка -1";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(844, 539);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(107, 29);
            this.AcceptButton.TabIndex = 16;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // GridTable
            // 
            this.GridTable.AllowUserToAddRows = false;
            this.GridTable.AllowUserToDeleteRows = false;
            this.GridTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTable.BackgroundColor = System.Drawing.Color.White;
            this.GridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.UserPost,
            this.Division,
            this.SubDivision,
            this.Column4,
            this.Column5,
            this.ShowUserInfo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridTable.EnableHeadersVisualStyles = false;
            this.GridTable.Location = new System.Drawing.Point(19, 107);
            this.GridTable.Name = "GridTable";
            this.GridTable.ReadOnly = true;
            this.GridTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.GridTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridTable.Size = new System.Drawing.Size(932, 426);
            this.GridTable.TabIndex = 17;
            this.GridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTable_CellClick);
            this.GridTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTable_CellMouseEnter);
            this.GridTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTable_CellMouseLeave);
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
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(542, 25);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(29, 29);
            this.EditButton.TabIndex = 12;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 20F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 112.3096F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 212;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.FillWeight = 112.3096F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Табельный номер";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // UserPost
            // 
            this.UserPost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserPost.HeaderText = "Должность";
            this.UserPost.Name = "UserPost";
            this.UserPost.ReadOnly = true;
            this.UserPost.Width = 98;
            // 
            // Division
            // 
            this.Division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Division.HeaderText = "Организация";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            this.Division.Width = 110;
            // 
            // SubDivision
            // 
            this.SubDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubDivision.HeaderText = "Подразделение";
            this.SubDivision.Name = "SubDivision";
            this.SubDivision.ReadOnly = true;
            this.SubDivision.Width = 126;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.FillWeight = 112.3096F;
            this.Column4.HeaderText = "Дата от";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 77;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.FillWeight = 112.3096F;
            this.Column5.HeaderText = "Дата до";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 79;
            // 
            // ShowUserInfo
            // 
            this.ShowUserInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShowUserInfo.HeaderText = "";
            this.ShowUserInfo.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.ShowUserInfo.Name = "ShowUserInfo";
            this.ShowUserInfo.ReadOnly = true;
            this.ShowUserInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowUserInfo.Width = 30;
            // 
            // ShowApplicationVer2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 711);
            this.Controls.Add(this.GridTable);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.NameApplication);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DateAplication);
            this.Controls.Add(this.NameCustomer);
            this.Controls.Add(this.NewApplicationsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowApplicationVer2";
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewApplicationsLabel;
        private System.Windows.Forms.Label NameCustomer;
        private System.Windows.Forms.Label DateAplication;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button DraftButton;
        private System.Windows.Forms.Label NameApplication;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.DataGridView GridTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn ShowUserInfo;
    }
}