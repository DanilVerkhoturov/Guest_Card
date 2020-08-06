using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class ShowEvictionGuest : Form
    {
        public ShowEvictionGuest()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            NotificationsEvictionGuest notificationsEvictionGuest = new NotificationsEvictionGuest();
            notificationsEvictionGuest.Owner = this;
            notificationsEvictionGuest.Open("Для подтверждения поднесите карту к магнитному считывателю", Properties.Resources.ToAccept);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NotificationTMCGuest notification = new NotificationTMCGuest();
            notification.Owner = this;
            notification.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NotificationCardGuest notification = new NotificationCardGuest();
            notification.Owner = this;
            notification.ShowDialog();
        }
    }
}
