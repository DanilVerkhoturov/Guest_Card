using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();
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
    }
}
