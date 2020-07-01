using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();
            this.DraftsDataGridView.Rows.Add("ННГ", "06.06.2020");
            this.DraftsDataGridView.Rows.Add("ГПН", "06.06.2020");
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
        }

        private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
        }

        private void ApplicationsNameTextBox2_TextChanged(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
        }

        private void ApplicationsNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
        }

        private void DraftDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // TODO: Передача данных для выгрузки заявки из базы.
            //ShowApplicationDraft.CustomerName = CustomersDataGridView[0, e.RowIndex].Value.ToString();
            //ShowApplicationDraft.CustomerId = Convert.ToInt64(CustomersDataGridView[2, e.RowIndex].Value.ToString());
            Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
        }

        private void DraftDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DraftsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                DraftsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
