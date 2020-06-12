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
    public partial class ShowApplicationVer2 : Form
    {
        InfoUserForm DialogForm = null;

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
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog(this);
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
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }

        private void GridTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (DialogForm == null)
                {
                    // Открытие окна с информацией пользователя на координатах мыши +15 в каждую сторону.
                    DialogForm = new InfoUserForm();
                    DialogForm.StartPosition = FormStartPosition.Manual;
                    DialogForm.Location = new Point(MousePosition.X + 15, MousePosition.Y + 15);
                    DialogForm.Show(this);
                }
            }
        }

        private void GridTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogForm.Close();
                DialogForm = null;
            }
        }
    }
}
