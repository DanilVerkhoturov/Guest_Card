﻿using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class ShowApplicationHistoryFood : Form
    {
        public ShowApplicationHistoryFood()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);
            Functions.FillUsersInDataGridViewComboBox(UsersDataGridView);
            Functions.FillLocationsInDataGridViewComboBox(UsersDataGridView, Customer.Id);

            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.DataSource = Applications.Users.Get();

            ApplicationNameLabel.Text = $"История заявок > {Customer.Name} - {Applications.Date}";
        }

        private void NewApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new HistoryApplications(), MainForm.ContP);
        }
    }
}
