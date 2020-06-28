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
    public partial class ShowApplicationDraft : System.Windows.Forms.Form
    {
        public ShowApplicationDraft()
        {
            InitializeComponent();
            this.GridTable.Rows.Add("ГПН", "06.06.2020");
            this.GridTable.Rows.Add("ННГ", "06.06.2020");
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

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            GridTable.AllowUserToAddRows = true;
            GridTable.AllowUserToDeleteRows = true;
            GridTable.AllowUserToResizeColumns = true;
            GridTable.ReadOnly = false;
        }

        private void GridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
