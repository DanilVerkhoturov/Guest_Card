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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public static Panel ContP = null;
        public MainForm()
        {
            InitializeComponent();
            ContP = ContentPanel;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddCustomer(), ContentPanel);
        }

        private void NewApplicationsButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddApplication(), ContentPanel);
        }

        private void CurrentApplicationsButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CurrentApplications(), ContentPanel);
        }
    }
}
