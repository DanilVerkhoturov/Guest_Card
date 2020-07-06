﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationDraft : System.Windows.Forms.Form
    {
        public ShowApplicationDraft()
        {
            InitializeComponent();
            this.UsersDataGridView.Rows.Add("1", "Иванов Иван Иванович", "58585857", "Электик", "06.06.2020", "06.06.2020", "мясояха");
            this.UsersDataGridView.Rows.Add("2", "Петров Петр Петрович", "58585857", "Электик", "06.06.2020", "06.06.2020","мясояха");
        }

        private void NewApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), MainForm.ContP);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // Открытие формы уведомления о подтверждённой заявке.
            var notification = new NotificationsForm();
            notification.NotificationLabel.Text = "Заявка подтверждена";
            notification.Owner = this;
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UsersDataGridView.AllowUserToAddRows = true;
            UsersDataGridView.AllowUserToDeleteRows = true;
            UsersDataGridView.AllowUserToResizeColumns = true;
            UsersDataGridView.ReadOnly = false;
        }

        private void GridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}