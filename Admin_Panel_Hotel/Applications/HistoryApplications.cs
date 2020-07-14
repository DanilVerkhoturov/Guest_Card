using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class HistoryApplications : Form
    {
        public HistoryApplications()
        {
            InitializeComponent();
            Functions.LoadApplications(ApplicationsDataGridView, 4);

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowApplicationHistory.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowApplicationHistory.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowApplicationHistory.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationHistory(), MainForm.ContP);
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
