using Admin_Panel_Hotel.ApplicationsFolder;
using System;
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
            DialogResult = DialogResult.OK;
            Functions.OpenChildForm(new CurrentApplications(), MainForm.ContP);
        }

        private void AddApplicationsLabel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Functions.OpenChildForm(new AddApplication(), MainForm.ContP);
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
