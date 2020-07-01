using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();

            this.NewDataGridView.Rows.Add("ННГ", "01.07.2020");
            this.NewDataGridView.Rows.Add("ГПН", "01.07.2020");
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
        }

        private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
        }

        private void ApplicationsNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
        }

        private void ApplicationsNameTextBox2_TextChanged(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
        }

        private void NewDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // TODO: Передача данных для выгрузки заявки из базы.
            //ShowApplicationNew.CustomerName = CustomersDataGridView[0, e.RowIndex].Value.ToString();
            //ShowApplicationNew.CustomerId = Convert.ToInt64(CustomersDataGridView[2, e.RowIndex].Value.ToString());
            Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
        }

        private void NewDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                NewDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                NewDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
