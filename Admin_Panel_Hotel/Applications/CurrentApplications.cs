using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Applications
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = ApplicationDB.GetCurrent();

            CustomerComboBox.SelectedIndex = 0;
            CustomerComboBox.DataSource = Customer.GetAllDivisions();
            

            if (ApplicationsDataGridView.RowCount == 0)
            {
                ApplicationsDataGridView.Visible = false;
                NotificationLabel.Visible = true;
                CustomerComboBox.Enabled = false;
                
            }
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Customer.Name = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ApplicationDB.Date = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ApplicationDB.Id = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
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
    