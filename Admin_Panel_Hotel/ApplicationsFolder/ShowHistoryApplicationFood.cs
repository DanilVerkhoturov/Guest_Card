using System;
using System.Diagnostics;
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

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string fileExcel = Functions.DataGridViewToExcel(UsersDataGridView, $@"{Environment.CurrentDirectory}\Питание - история заявок - {Customer.Name} - {DateTime.Now.ToShortDateString()}", out string filePath);
            Process.Start(filePath);
        }
    }
}
