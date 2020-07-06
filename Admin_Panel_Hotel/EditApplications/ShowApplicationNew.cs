using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationNew : Form
    {
        InfoUserForm DialogForm = null;

        public ShowApplicationNew()
        {
            InitializeComponent();
            this.NewApplicationsDataGridView.Rows.Add("1", "Иванов Иван Иванович", "58585857", "Электик","06.06.2020", "06.06.2020", "мясояха");
            this.NewApplicationsDataGridView.Rows.Add("2", "Петров Петр Петрович", "58585857", "Электик","06.06.2020", "06.06.2020", "мясояха");
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
            NewApplicationsDataGridView.ReadOnly = false;
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
