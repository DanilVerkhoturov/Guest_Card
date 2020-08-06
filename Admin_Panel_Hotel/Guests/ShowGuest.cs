using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class ShowGuest : Form
    {
        public ShowGuest()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            NotificationsGuest notificationsGuest = new NotificationsGuest();
            notificationsGuest.Owner = this;
            notificationsGuest.Open("Для подтверждения поднесите карту к магнитному считывателю", Properties.Resources.ToAccept);
        }
    }
}
