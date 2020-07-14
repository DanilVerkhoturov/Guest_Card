using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();
            Functions.LoadApplications(ApplicationsDataGridView, 1);
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowApplicationNew.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowApplicationNew.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowApplicationNew.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
            }
        }

        private void ApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
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
