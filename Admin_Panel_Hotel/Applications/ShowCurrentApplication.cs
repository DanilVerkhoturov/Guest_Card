using Admin_Panel_Hotel.Applications;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowCurrentApplication : Form
    {
        /// <summary>
        /// Название заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public static string ApplicationDate;
        /// <summary>
        /// Уникальный номер заявки.
        /// </summary>
        public static long ApplicationId;

        public ShowCurrentApplication()
        {
            InitializeComponent();
            Functions.LoadApplicationUsers(UsersDataGridView, ApplicationId);

            ApplicationNameLabel.Text = $"Текущие заявки > {CustomerName} - {ApplicationDate}";
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
    }
}
