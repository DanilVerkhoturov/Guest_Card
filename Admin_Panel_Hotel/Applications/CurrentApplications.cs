using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationVer2(), MainForm.ContP);
        }

        private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new ShowApplicationVer2(), MainForm.ContP);
        }
    }
}
