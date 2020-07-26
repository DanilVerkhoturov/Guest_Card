using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class HistoryApplications : Form
    {
        public HistoryApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = ApplicationDB.GetHistory();

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Customer.Name = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ApplicationDB.Date = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ApplicationDB.Id = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
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
