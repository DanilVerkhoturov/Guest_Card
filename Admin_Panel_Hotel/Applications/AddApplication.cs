using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddApplication : Form
    {
        public AddApplication()
        {
            InitializeComponent();

           Functions.NewlineProcessing(UsersDataGridView, new string[] { "1", "Введите ФИО", "Таб.номер", "Дата от", "Дата до", "Локация" });
        }

        private void NewApplication_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), MainForm.ContP);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку корректности введённых данных.
            if (true)
            {
                // Открытие формы уведомления о созданной заявке.
                var notification = new NotificationsForm();
                notification.NotificationLabel.Text = "Заявка добавлена";
                notification.Owner = this;
                notification.StartPosition = FormStartPosition.CenterParent;
                notification.ShowDialog();
            }
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            UsersDataGridView.Rows.Add();
        }
    }
}
