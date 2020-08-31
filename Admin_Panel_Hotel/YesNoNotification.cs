using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class YesNoNotification : Form
    {
        public YesNoNotification(string notificationText)
        {
            InitializeComponent();

            NotificationTextLabel.Text = notificationText;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
