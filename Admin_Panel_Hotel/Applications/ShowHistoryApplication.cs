using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationHistory : Form
    {
        public ShowApplicationHistory()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);

            UsersDataGridView.DataSource = ApplicationDB.GetUsers();

            ApplicationNameLabel.Text = $"История заявок > {Customer.Name} - {ApplicationDB.Date}";
        }

        private void NewApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new HistoryApplications(), MainForm.ContP);
        }
    }
}
