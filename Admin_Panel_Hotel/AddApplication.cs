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
    public partial class AddApplication : System.Windows.Forms.Form
    {
        public AddApplication()
        {
            InitializeComponent();
        }

        private void NewApplication_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), MainForm.ContP);
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
