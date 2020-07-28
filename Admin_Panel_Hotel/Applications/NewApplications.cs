using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = ApplicationDB.GetNew();

            if (ApplicationsDataGridView.RowCount == 0)
            {
                ApplicationsDataGridView.Visible = false;
                NotificationLabel.Visible = true;
            }
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Customer.Name = ApplicationsDataGridView["name", e.RowIndex].Value.ToString();
                ApplicationDB.Date = ApplicationsDataGridView["date", e.RowIndex].Value.ToString();
                ApplicationDB.Id = Convert.ToInt64(ApplicationsDataGridView["id", e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
            }
        }

        private void ApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ApplicationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                ApplicationsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
