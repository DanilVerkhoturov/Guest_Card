using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();

            ApplicationsDataGridView.DataSource = Applications.GetNew();

            if (ApplicationsDataGridView.RowCount == 0)
            {
                ApplicationsDataGridView.Visible = false;
                NotificationLabel.Visible = true;
            }
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ApplicationsDataGridView.Columns[e.ColumnIndex].Name == "showApplication")
            {
                Customer.Id = Convert.ToInt64(ApplicationsDataGridView["customerid", e.RowIndex].Value.ToString());
                Customer.Name = ApplicationsDataGridView["name", e.RowIndex].Value.ToString();
                Applications.Date = ApplicationsDataGridView["date", e.RowIndex].Value.ToString();
                Applications.Id = Convert.ToInt64(ApplicationsDataGridView["applicationid", e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
            }
        }

        private void ApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ApplicationsDataGridView.Columns[e.ColumnIndex].Name == "showApplication")
            {
                ApplicationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                ApplicationsDataGridView.Cursor = Cursors.Default;
            }
        }

        private void ApplicationsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (ApplicationsDataGridView.Columns[e.ColumnIndex].Name == "name")
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
        }
    }
}
