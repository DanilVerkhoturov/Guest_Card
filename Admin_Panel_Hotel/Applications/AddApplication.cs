using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddApplication : System.Windows.Forms.Form
    {
        public AddApplication()
        {
            InitializeComponent();
        }

        private void NewApplication_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), MainForm.ContP);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку корректности введённых данных.
            // Открытие формы уведомления о созданной заявке.
            var notification = new NotificationsForm();
            notification.NotificationLabel.Text = "Заявка добавлена";
            notification.Owner = this;
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
