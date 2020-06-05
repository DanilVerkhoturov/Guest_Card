namespace Admin_Panel_Hotel
{
    partial class PatternForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Мои заказчики");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Добавить заказчика");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Заказчики", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Текущие");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Добавить заявку");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("История заявок");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Черновики");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Заявки", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(44, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "MyCustomersNode";
            treeNode1.Text = "Мои заказчики";
            treeNode2.Name = "AddCustomerNode";
            treeNode2.Text = "Добавить заказчика";
            treeNode3.Name = "CustomersNode";
            treeNode3.Text = "Заказчики";
            treeNode4.Name = "NewApplicationsNode";
            treeNode4.Text = "Новые";
            treeNode5.Name = "CurrentApplicationsNode";
            treeNode5.Text = "Текущие";
            treeNode6.Name = "AddApplicationsNode";
            treeNode6.Text = "Добавить заявку";
            treeNode7.Name = "HistoryApplicationsNode";
            treeNode7.Text = "История заявок";
            treeNode8.Name = "DraftApplicationsNode";
            treeNode8.Text = "Черновики";
            treeNode9.Name = "ApplicationsNode";
            treeNode9.Text = "Заявки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(196, 370);
            this.treeView1.TabIndex = 2;
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 667);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PatternForm";
            this.Text = "PatternForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}