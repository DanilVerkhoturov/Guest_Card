namespace Admin_Panel_Hotel.Cards
{
    partial class AddCards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.CardsPanel = new System.Windows.Forms.Panel();
            this.DivisionsComboBox = new System.Windows.Forms.ComboBox();
            this.CardsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.CardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(690, 582);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(212, 44);
            this.AcceptButton.TabIndex = 44;
            this.AcceptButton.Text = "Добавить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(61, 35, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "Добавить карты";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DisplayMember = "location_name";
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Местонахождение"});
            this.LocationComboBox.Location = new System.Drawing.Point(0, 517);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(298, 33);
            this.LocationComboBox.TabIndex = 54;
            this.LocationComboBox.ValueMember = "location_id";
            // 
            // CardsPanel
            // 
            this.CardsPanel.Controls.Add(this.DivisionsComboBox);
            this.CardsPanel.Controls.Add(this.CardsDataGridView);
            this.CardsPanel.Controls.Add(this.LocationComboBox);
            this.CardsPanel.Controls.Add(this.AcceptButton);
            this.CardsPanel.Location = new System.Drawing.Point(76, 201);
            this.CardsPanel.Margin = new System.Windows.Forms.Padding(123, 122, 3, 3);
            this.CardsPanel.Name = "CardsPanel";
            this.CardsPanel.Size = new System.Drawing.Size(933, 663);
            this.CardsPanel.TabIndex = 55;
            this.CardsPanel.Visible = false;
            // 
            // DivisionsComboBox
            // 
            this.DivisionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionsComboBox.FormattingEnabled = true;
            this.DivisionsComboBox.Location = new System.Drawing.Point(347, 517);
            this.DivisionsComboBox.Name = "DivisionsComboBox";
            this.DivisionsComboBox.Size = new System.Drawing.Size(298, 33);
            this.DivisionsComboBox.TabIndex = 56;
            // 
            // CardsDataGridView
            // 
            this.CardsDataGridView.AllowUserToAddRows = false;
            this.CardsDataGridView.AllowUserToDeleteRows = false;
            this.CardsDataGridView.AllowUserToResizeRows = false;
            this.CardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CardsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.CardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CardsDataGridView.ColumnHeadersHeight = 35;
            this.CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.serialNum,
            this.shortName,
            this.status_id,
            this.location_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CardsDataGridView.EnableHeadersVisualStyles = false;
            this.CardsDataGridView.GridColor = System.Drawing.Color.Black;
            this.CardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CardsDataGridView.Name = "CardsDataGridView";
            this.CardsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CardsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.CardsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CardsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CardsDataGridView.RowTemplate.Height = 30;
            this.CardsDataGridView.Size = new System.Drawing.Size(902, 472);
            this.CardsDataGridView.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "№";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // serialNum
            // 
            this.serialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialNum.DataPropertyName = "ID карты";
            this.serialNum.HeaderText = "ID карты";
            this.serialNum.Name = "serialNum";
            this.serialNum.ReadOnly = true;
            this.serialNum.Visible = false;
            // 
            // shortName
            // 
            this.shortName.DataPropertyName = "Номер карты";
            this.shortName.HeaderText = "Номер карты";
            this.shortName.Name = "shortName";
            this.shortName.ReadOnly = true;
            // 
            // status_id
            // 
            this.status_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_id.HeaderText = "Статус";
            this.status_id.Name = "status_id";
            this.status_id.ReadOnly = true;
            // 
            // location_id
            // 
            this.location_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location_id.HeaderText = "Местонахождение";
            this.location_id.Name = "location_id";
            this.location_id.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 44);
            this.label2.TabIndex = 56;
            this.label2.Text = "Импортируйте данные из файла";
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ImportButton.FlatAppearance.BorderSize = 0;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(368, 381);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(292, 49);
            this.ImportButton.TabIndex = 57;
            this.ImportButton.Text = "Импорт данных xlc";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // AddCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1093, 894);
            this.Controls.Add(this.CardsPanel);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddCards";
            this.Text = "AddCard";
            this.CardsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Panel CardsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataGridView CardsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewComboBoxColumn location;
        private System.Windows.Forms.ComboBox DivisionsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortName;
        private System.Windows.Forms.DataGridViewComboBoxColumn status_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn location_id;
    }
}