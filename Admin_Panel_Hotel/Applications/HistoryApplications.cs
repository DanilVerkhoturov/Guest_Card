using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class HistoryApplications : Form
    {
        public HistoryApplications()
        {
            InitializeComponent();

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;

            HistoryDataGridView.Rows.Add("ННГ", "06.06.2020");
            HistoryDataGridView.Rows.Add("ГПН", "06.06.2020");
        }

        private void HistoryDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                // TODO: Передача данных для выгрузки заявки из базы.
                //ShowApplicationHistory.CustomerName = CustomersDataGridView[0, e.RowIndex].Value.ToString();
                //ShowApplicationHistory.CustomerId = Convert.ToInt64(CustomersDataGridView[2, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationHistory(), MainForm.ContP);
            }
        }

        private void HistoryDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                HistoryDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                HistoryDataGridView.Cursor = Cursors.Default;
            }
        }

      
    }
}
