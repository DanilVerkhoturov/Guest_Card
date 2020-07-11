using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddApplication : Form
    {
        public AddApplication()
        {
            InitializeComponent();

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;

            Functions.NewlineProcessing(UsersDataGridView, new string[] { "1", "Введите ФИО", "Таб.номер", "Дата от", "Дата до", "Локация" });
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            UsersDataGridView.Rows.Add();
        }

        private void SendToCustomerButton_Click(object sender, EventArgs e)
        {
            // UNDONE: Сделать проверку корректности введённых данных.
            if (CustomerComboBox.SelectedIndex > 0 && LocationComboBox.SelectedIndex > 0) // Если заполнены все обязательные поля.
            {
                // Открытие формы уведомления о созданной заявке.
                NotificationsForm notification = new NotificationsForm();
                notification.NotificationLabel.Text = "Заявка добавлена";
                notification.Owner = this;
                notification.StartPosition = FormStartPosition.CenterParent;
                notification.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
