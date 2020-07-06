using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Applications
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
           
            CurrentApplicationsDataGridView.Rows.Add("ННГ","06.06.2020");
            CurrentApplicationsDataGridView.Rows.Add("ГПН", "06.06.2020");
        }

        private void CurrentDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                
                Functions.OpenChildForm(new ShowCurrentApplication(), MainForm.ContP);
            }
        }

        private void CurrentApplicationsDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                // TODO: Передача данных для выгрузки заявки из базы.
                //ShowApplication.CustomerName = CustomersDataGridView[0, e.RowIndex].Value.ToString();
                //ShowApplication.CustomerId = Convert.ToInt64(CustomersDataGridView[2, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowCurrentApplication(), MainForm.ContP);
            }
        }

        private void CurrentApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                CurrentApplicationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                CurrentApplicationsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
    