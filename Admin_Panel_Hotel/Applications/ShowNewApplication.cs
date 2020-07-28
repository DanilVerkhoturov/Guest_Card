using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationNew : Form
    {
        public ShowApplicationNew()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn locationsColumn = UsersDataGridView.Columns["location"] as DataGridViewComboBoxColumn;
            locationsColumn.DataSource = Locations.GetAll();
            locationsColumn.DisplayMember = "location_name";
            locationsColumn.ValueMember = "location_name";

            Functions.NewlineProcessing(UsersDataGridView);

            UsersDataGridView.DataSource = ApplicationDB.GetUsers();

            //for (int i = 0; i < UsersDataGridView.RowCount; i++)
            //{
            //    var a = Functions.FromUnixTime(Convert.ToInt32(UsersDataGridView["start_at", i].Value.ToString()));
            //    UsersDataGridView["start_at", i].Value = Functions.FromUnixTime(Convert.ToInt32(UsersDataGridView["start_at", i].Value.ToString()));
            //    UsersDataGridView["end_at", i].Value = Functions.FromUnixTime(Convert.ToInt32(UsersDataGridView["end_at", i].Value.ToString()));
            //}

            NewApplicationNameLabel.Text = $"Новые заявки > {Customer.Name} - {ApplicationDB.Date}";
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