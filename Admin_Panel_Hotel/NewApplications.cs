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
    public partial class NewApplications : System.Windows.Forms.Form
    {
        public NewApplications()
        {
            InitializeComponent();
        }

        private void ShowApplicationButton1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddEditApplication(), MainForm.ContP);
        }
    }
}
