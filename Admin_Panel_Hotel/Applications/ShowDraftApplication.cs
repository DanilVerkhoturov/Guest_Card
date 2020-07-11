using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationDraft : Form
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

        public ShowApplicationDraft()
        {
            InitializeComponent();

            ApplicationNameLabel.Text = $"Черновик > {CustomerName} - {ApplicationDate}";

            LoadApplicationUsers();

            Functions.NewlineProcessing(UsersDataGridView, new string[] { "1", "Введите ФИО", "Таб.номер", "Дата от", "Дата до", "Локация" });
        }

        /// <summary>
        /// Загрузить людей из заявки.
        /// </summary>
        private void LoadApplicationUsers()
        {
            MySqlCommand select = new MySqlCommand($"SELECT (SELECT user_profile.firstname FROM user_profile WHERE user_profile.user_id = contract_user.user_id) as 'firstname'" +
                $", (SELECT user_profile.middlename FROM user_profile WHERE user_profile.user_id = contract_user.user_id) as 'middlename'" +
                $", (SELECT user_profile.lastname FROM user_profile WHERE user_profile.user_id = contract_user.user_id) as 'lastname'" +
                $", (SELECT event.start_at FROM event WHERE event.id = contract_user.event_id) as 'start_at'" +
                $", (SELECT event.end_at FROM event WHERE event.id = contract_user.event_id) as 'end_at'" +
                $", (SELECT customer_location.name FROM customer_location WHERE customer_location.customer_id = (SELECT contract.customer_id FROM contract WHERE contract.id = {ApplicationId}) AND customer_location.location_id = (SELECT location_id FROM contract WHERE contract.id = {ApplicationId})) as 'locationname'" +
                $" FROM contract_user" +
                $" WHERE contract_id = {ApplicationId}", Functions.Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read()) // Получаем данные из запроса и заполняем их в таблицу.
            {
                string userName = $"{reader[0]} {reader[1]} {reader[2]}";
                string tabNum = null;

                int addedRow = UsersDataGridView.Rows.Add(UsersDataGridView.Rows.Count + 1
                    , userName
                    , tabNum
                    , DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[3].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim()
                    , DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[4].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim()
                    /*, comboBoxCell.Items[addedLocation]*/);

                DataGridViewComboBoxColumn locationsComboBox = ((DataGridViewComboBoxColumn)UsersDataGridView.Columns["location"]);
                int addedLocation = 0;
                if (locationsComboBox.Items.Contains(reader[5].ToString()))
                {
                    addedLocation = locationsComboBox.Items.Count - 1;
                }
                else
                {
                    addedLocation = locationsComboBox.Items.Add(reader[5].ToString());
                }

                UsersDataGridView[5, addedRow].Value = locationsComboBox.Items[addedLocation];
            }
            reader.Close();
        }

        private void DraftApplicationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new DraftApplications(), MainForm.ContP);
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку заполнения полей на последней строке.
            if (true)
            {
                UsersDataGridView.Rows.Add();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EditButton.Text == "Продолжить редактирование")
            {
                AddUserLabel.Visible = true;
                UsersDataGridView.ReadOnly = false;
                EditButton.Text = "Сохранить и отправить";
            }
            else
            {
                // TODO: Сделать проверку заполнения полей на последней строке.
                if (true) // Заполнены все поля.
                {
                    // Открытие формы уведомления о подтверждённой заявке.
                    var notification = new NotificationsForm();
                    notification.NotificationLabel.Text = "Заявка подтверждена";
                    notification.Owner = this;
                    notification.StartPosition = FormStartPosition.CenterParent;
                    notification.ShowDialog();
                }
            }
        }
    }
}
