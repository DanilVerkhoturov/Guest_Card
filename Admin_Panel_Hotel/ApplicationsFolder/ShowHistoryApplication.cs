using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class ShowApplicationHistory : Form
    {
        public ShowApplicationHistory()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);

            UsersDataGridView.DataSource = Applications.Users.Get();

            ApplicationNameLabel.Text = $"История заявок > {Customer.Name} - {Applications.Date}";
        }

        private void NewApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new HistoryApplications(), MainForm.ContP);
        }
    }
}
