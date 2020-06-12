namespace Admin_Panel_Hotel.Card
{
    partial class MovingGards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CountCardLabel = new System.Windows.Forms.Label();
            this.FilterCardComboBox = new System.Windows.Forms.ComboBox();
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.MovingButtonButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AllCardLabel = new System.Windows.Forms.Label();
            this.MovingToComboBox = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.СheckAll = new System.Windows.Forms.CheckBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CountCardLabel
            // 
            this.CountCardLabel.AutoSize = true;
            this.CountCardLabel.Location = new System.Drawing.Point(18, 569);
            this.CountCardLabel.Name = "CountCardLabel";
            this.CountCardLabel.Size = new System.Drawing.Size(110, 17);
            this.CountCardLabel.TabIndex = 50;
            this.CountCardLabel.Text = "Выбрано 50 карт";
            // 
            // FilterCardComboBox
            // 
            this.FilterCardComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FilterCardComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterCardComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterCardComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.FilterCardComboBox.FormattingEnabled = true;
            this.FilterCardComboBox.Location = new System.Drawing.Point(21, 74);
            this.FilterCardComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterCardComboBox.Name = "FilterCardComboBox";
            this.FilterCardComboBox.Size = new System.Drawing.Size(233, 28);
            this.FilterCardComboBox.TabIndex = 47;
            this.FilterCardComboBox.Text = "Фильтр";
            // 
            // GridTable
            // 
            this.GridTable.AllowUserToAddRows = false;
            this.GridTable.AllowUserToDeleteRows = false;
            this.GridTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTable.BackgroundColor = System.Drawing.Color.White;
            this.GridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(172)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridTable.EnableHeadersVisualStyles = false;
            this.GridTable.Location = new System.Drawing.Point(12, 130);
            this.GridTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GridTable.Name = "GridTable";
            this.GridTable.ReadOnly = true;
            this.GridTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridTable.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.GridTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridTable.Size = new System.Drawing.Size(742, 415);
            this.GridTable.TabIndex = 46;
            // 
            // MovingButtonButton
            // 
            this.MovingButtonButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.MovingButtonButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MovingButtonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovingButtonButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MovingButtonButton.ForeColor = System.Drawing.Color.White;
            this.MovingButtonButton.Location = new System.Drawing.Point(626, 560);
            this.MovingButtonButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MovingButtonButton.Name = "MovingButtonButton";
            this.MovingButtonButton.Size = new System.Drawing.Size(126, 35);
            this.MovingButtonButton.TabIndex = 45;
            this.MovingButtonButton.Text = "Переместить";
            this.MovingButtonButton.UseVisualStyleBackColor = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(769, 12);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(91, 36);
            this.PrintButton.TabIndex = 44;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // AllCardLabel
            // 
            this.AllCardLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCardLabel.AutoSize = true;
            this.AllCardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AllCardLabel.Location = new System.Drawing.Point(16, 24);
            this.AllCardLabel.Name = "AllCardLabel";
            this.AllCardLabel.Size = new System.Drawing.Size(137, 24);
            this.AllCardLabel.TabIndex = 43;
            this.AllCardLabel.Text = "Перемещение";
            // 
            // MovingToComboBox
            // 
            this.MovingToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MovingToComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovingToComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovingToComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.MovingToComboBox.FormattingEnabled = true;
            this.MovingToComboBox.Location = new System.Drawing.Point(278, 74);
            this.MovingToComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovingToComboBox.Name = "MovingToComboBox";
            this.MovingToComboBox.Size = new System.Drawing.Size(233, 28);
            this.MovingToComboBox.TabIndex = 52;
            this.MovingToComboBox.Text = "Переместить в";
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
            this.Column2.HeaderText = "Номер карты";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 212;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Статус";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Местонахождение";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Выбор карт";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // СheckAll
            // 
            this.СheckAll.AutoSize = true;
            this.СheckAll.Location = new System.Drawing.Point(626, 101);
            this.СheckAll.Name = "СheckAll";
            this.СheckAll.Size = new System.Drawing.Size(102, 21);
            this.СheckAll.TabIndex = 53;
            this.СheckAll.Text = "Выбрать все";
            this.СheckAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Admin_Panel_Hotel.Properties.Resources.pngwing_8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // MovingGards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 672);
            this.Controls.Add(this.СheckAll);
            this.Controls.Add(this.MovingToComboBox);
            this.Controls.Add(this.CountCardLabel);
            this.Controls.Add(this.FilterCardComboBox);
            this.Controls.Add(this.GridTable);
            this.Controls.Add(this.MovingButtonButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AllCardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovingGards";
            this.Text = "MovingGards";
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountCardLabel;
        private System.Windows.Forms.ComboBox FilterCardComboBox;
        private System.Windows.Forms.DataGridView GridTable;
        private System.Windows.Forms.Button MovingButtonButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label AllCardLabel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.ComboBox MovingToComboBox;
        private System.Windows.Forms.CheckBox СheckAll;
    }
}