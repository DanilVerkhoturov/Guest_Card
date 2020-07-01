using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();
            this.DraftDataGridView.Rows.Add("ННГ", "06.06.2020");
            this.DraftDataGridView.Rows.Add("ГПН", "06.06.2020");
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
    }
}
