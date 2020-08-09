using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class ShowApplicationNew : Form
    {
        public ShowApplicationNew()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);

            DataGridViewComboBoxColumn locationsColumn = UsersDataGridView.Columns["location"] as DataGridViewComboBoxColumn;
            locationsColumn.DisplayMember = "location_name";
            locationsColumn.ValueMember = "location_id";
            locationsColumn.DataSource = Locations.GetAll();

            UsersDataGridView.DataSource = Applications.Users.Get();

            NewApplicationNameLabel.Text = $"Новые заявки > {Customer.Name} - {Applications.Date}";
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
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UsersDataGridView.ReadOnly = false;
        }
    }
}