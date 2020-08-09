using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationDraft : Form
    {
        public ShowApplicationDraft()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);

            UsersDataGridView.DataSource = ApplicationDB.Users.Get();

            ApplicationNameLabel.Text = $"Черновик > {Customer.Name} - {ApplicationDB.Date}";
        }

        private void DraftApplicationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new DraftApplications(), MainForm.ContP);
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            if (CheckLastUser())
            {
                UsersDataGridView.Rows.Add();
            }
        }

        /// <summary>
        /// Проверить последнюю добавленную строку в таблице сотрудников.
        /// </summary>
        /// <returns>True - если все данные введены корректно. False - если не все данные введены.</returns>
        private bool CheckLastUser()
        {
            int lastUser = UsersDataGridView.Rows.Count - 1;
            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["location"];
            DateTime dateFrom = DateTime.MinValue;
            DateTime dateTo = DateTime.MinValue;

            if (UsersDataGridView.Rows.Count == 0
                || (UsersDataGridView.Rows.Count > 0
                && UsersDataGridView[1, lastUser].Value != null && UsersDataGridView[1, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[2, lastUser].Value != null && UsersDataGridView[2, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[3, lastUser].Value != null && UsersDataGridView[3, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[4, lastUser].Value != null && UsersDataGridView[4, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[5, lastUser].Value != null && UsersDataGridView[5, lastUser].Value.ToString() != locationsComboBox.Items[0].ToString()
                && DateTime.TryParse(UsersDataGridView[3, lastUser].Value.ToString(), out dateFrom)
                && DateTime.TryParse(UsersDataGridView[4, lastUser].Value.ToString(), out dateTo))
                && dateFrom < dateTo)
            {
                return true;
            }
            else
            {
                if (dateFrom == DateTime.MinValue)
                {
                    UsersDataGridView[3, lastUser].ErrorText = "Введите корректную дату";
                }
                if (dateTo == DateTime.MinValue)
                {
                    UsersDataGridView[4, lastUser].ErrorText = "Введите корректную дату";
                }
                return false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SendToCustomerButton.Visible = true;
            AddUserLabel.Visible = true;
            ImportButton.Visible = true;
            CustomerComboBox.Enabled = true;
            LocationComboBox.Enabled = true;
            UsersDataGridView.Enabled = false;
        }

        private void SendToCustomerButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку заполнения всех полей.
            if (true) // Если заполнены все поля.
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
