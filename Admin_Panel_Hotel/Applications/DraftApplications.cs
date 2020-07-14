using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();
            Functions.LoadApplications(ApplicationsDataGridView, 3);
        }

        private void DraftDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowApplicationDraft.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowApplicationDraft.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowApplicationDraft.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
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
