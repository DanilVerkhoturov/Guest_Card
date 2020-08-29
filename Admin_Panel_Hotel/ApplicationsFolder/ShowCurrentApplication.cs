using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class ShowCurrentApplication : Form
    {
        public ShowCurrentApplication()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);
            Functions.FillUsersInDataGridViewComboBox(UsersDataGridView);
            Functions.FillLocationsInDataGridViewComboBox(UsersDataGridView, Customer.Id);

            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.DataSource = Applications.Users.Get();

            ApplicationNameLabel.Text = $"Текущие заявки > {Customer.Name} - {Applications.Date}";
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // Открытие формы уведомления о подтверждённой заявке.
            var notification = new NotificationsForm();
            notification.NotificationLabel.Text = "Заявка подтверждена";
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UsersDataGridView.ReadOnly = false;
        }

        private void ApplicationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CurrentApplications(), MainForm.ContP);
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var form = new InfoUserForm();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }

        private void UsersDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                UsersDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                UsersDataGridView.Cursor = Cursors.Default;
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string fileExcel = Functions.DataGridViewToExcel(UsersDataGridView, $"Текущие заявки - {Customer.Name} - {Applications.Date}", out string filePath);
            Process.Start(filePath);
        }
    }
}
