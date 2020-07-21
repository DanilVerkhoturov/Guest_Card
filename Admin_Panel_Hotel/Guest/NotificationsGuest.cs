using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guest.Notification
{
    public partial class NotificationsGuest : Form
    {
        private static string NotificationText;
        private static Bitmap NotificationImage;

        /// <summary>
        /// Отобразить уведомление.
        /// </summary>
        /// <param name="notificationText">Текст уведомления.</param>
        /// <param name="notificationImage">Иконка уведомления.</param>
        public void Open(string notificationText, Bitmap notificationImage)
        {
            NotificationText = notificationText;
            NotificationImage = notificationImage;
            ShowDialog();
        }

        public NotificationsGuest()
        {
            InitializeComponent();

            NotificationTextLabel.Text = NotificationText;
            NotificationImagePictureBox.Image = NotificationImage;
        }
    }
}
