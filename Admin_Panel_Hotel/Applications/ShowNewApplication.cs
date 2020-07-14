using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationNew : Form
    {
        /// <summary>
        /// Название заказчика из заявки.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Дата заявки.
        /// </summary>
        public static string ApplicationDate;
        /// <summary>
        /// Уникальный номер заявки.
        /// </summary>
        public static long ApplicationId;

        public ShowApplicationNew()
        {
            InitializeComponent();
            Functions.LoadApplicationUsers(UsersDataGridView, ApplicationId);

            NewApplicationNameLabel.Text = $"Новые заявки > {CustomerName} - {ApplicationDate}";
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
