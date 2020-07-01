using System;

namespace Admin_Panel_Hotel
{
    public partial class HistoryApplications : System.Windows.Forms.Form
    {
        public HistoryApplications()
        {
            InitializeComponent();
            this.HistoryDataGridView.Rows.Add("ННГ", "06.06.2020");
            this.HistoryDataGridView.Rows.Add("ГПН", "06.06.2020");
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationHistory(), MainForm.ContP);
        }

        private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationHistory(), MainForm.ContP);
        }

       

        
    }
}
