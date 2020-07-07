using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationNew : Form
    {
        /// <summary>
        /// Имя локации из заявки.
        /// </summary>
        public static string LocationName;
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

            NewApplicationNameLabel.Text = $"Новые заявки > {LocationName} от {ApplicationDate}";

            MySqlCommand select = new MySqlCommand($"SELECT (SELECT user_profile.firstname FROM user_profile WHERE user_profile.user_id = contract_user.user_id)" +
                $", (SELECT user_profile.middlename FROM user_profile WHERE user_profile.user_id = contract_user.user_id)" +
                $", (SELECT user_profile.lastname FROM user_profile WHERE user_profile.user_id = contract_user.user_id)" +
                $", (SELECT (SELECT subdivision.name FROM subdivision WHERE subdivision.id = user_profile.subdivision_id) FROM user_profile WHERE user_profile.user_id = contract_user.user_id)" +
                $", (SELECT event.start_at FROM event WHERE event.id = contract_user.event_id)" +
                $", (SELECT event.end_at FROM event WHERE event.id = contract_user.event_id)" +
                $"FROM contract_user" +
                $" WHERE contract_id = {ApplicationId}", Functions.Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read()) // Получаем данные из запроса.
            {
                string userName = $"{reader[0]} {reader[1]} {reader[2]}";
                string tabNum = null;
                string userPost = null;
                string subdivision = reader[3].ToString();

                UsersDataGridView.Rows.Add(UsersDataGridView.Rows.Count + 1, userName, tabNum, userPost, subdivision, DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[4].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim(), DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[5].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim());
            }
            reader.Close();
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

        private void GridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var form = new InfoUserForm();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }
    }
}
