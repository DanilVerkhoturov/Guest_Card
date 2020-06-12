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
    public partial class ShowApplicationVer2 : System.Windows.Forms.Form
    {
        public ShowApplicationVer2()
        {
            InitializeComponent();
            this.GridTable.Rows.Add("1", "Иванов Иван Иванович", "ННГ/Цех 136/112", "06.06.2020", "06.06.2020");
            this.GridTable.Rows.Add("2", "Петров Петр Петрович", "ННГ/Цех 136/113", "06.06.2020", "06.06.2020");
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
            notification.Owner = this;
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            GridTable.AllowUserToAddRows = true;
            GridTable.AllowUserToDeleteRows = true;
            GridTable.AllowUserToResizeColumns = true;
            GridTable.ReadOnly = false;

        }

        private void GridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var form = new InfoUserForm();
                form.Owner = this;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }
    }
}
