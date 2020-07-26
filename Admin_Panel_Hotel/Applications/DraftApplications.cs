using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = ApplicationDB.GetDrafts();
        }

        private void DraftDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Customer.Name = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ApplicationDB.Date = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ApplicationDB.Id = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
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
