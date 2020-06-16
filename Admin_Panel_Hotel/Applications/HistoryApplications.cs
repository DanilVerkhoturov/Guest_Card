using System;

namespace Admin_Panel_Hotel
{
    public partial class HistoryApplications : System.Windows.Forms.Form
    {
        public HistoryApplications()
        {
            InitializeComponent();
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplication(), MainForm.ContP);
        }

        private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplication(), MainForm.ContP);
        }

       

        
    }
}
