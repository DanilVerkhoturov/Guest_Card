using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Applications
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();
            Functions.LoadApplications(ApplicationsDataGridView, 2);

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowCurrentApplication.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowCurrentApplication.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowCurrentApplication.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowCurrentApplication(), MainForm.ContP);
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
    