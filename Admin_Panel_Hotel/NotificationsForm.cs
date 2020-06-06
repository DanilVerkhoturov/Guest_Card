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
    public partial class NotificationsForm : Form
    {
        public static string NotificationText = null;

        public NotificationsForm()
        {
            InitializeComponent();
        }

        private void CurrentApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CurrentApplications(), MainForm.ContP);
        }

        private void AddApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddApplication(), MainForm.ContP);
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
