using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = Applications.GetDrafts();

            if (ApplicationsDataGridView.RowCount == 0)
            {
                ApplicationsDataGridView.Visible = false;
                NotificationLabel.Visible = true;
            }
        }

        private void DraftDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Customer.Name = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                Applications.Date = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                Applications.Id = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
            }
        }

        private void DraftDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
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
