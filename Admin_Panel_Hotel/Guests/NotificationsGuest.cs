using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class NotificationsGuest : Form
    {
        public NotificationsGuest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отобразить уведомление.
        /// </summary>
        /// <param name="parent">Родительская форма.</param>
        /// <param name="notificationText">Текст уведомления.</param>
        /// <param name="notificationImage">Иконка уведомления.</param>
        public void Open(string notificationText, Bitmap notificationImage)
        {
            NotificationTextLabel.Text = notificationText;
            NotificationImagePictureBox.Image = notificationImage;

            ShowDialog();
        }

        private void CheckCard()
        {
            bool accept = false;

            while (!accept)
            {
                Functions.RFID.Open();

                while (Functions.RFID.IsOpen)
                {
                    Thread.Sleep(1000);
                }

                // Если карта успешно считалась.
                if (long.TryParse(Functions.CardSerialNumberFromRFID, out long serialNumber))
                {
                    NotificationTextLabel.Invoke((MethodInvoker)delegate
                    {
                        NotificationTextLabel.Text = "Карта активирована";
                    });

                    NotificationImagePictureBox.Invoke((MethodInvoker)delegate
                    {
                        NotificationImagePictureBox.Image = Properties.Resources.Accept;
                    });

                    accept = true;
                    if (MessageBox.Show($"Серийный номер карты: {Functions.CardSerialNumberFromRFID}.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            Close();
                        });
                    }
                }
                else // Если карта не считалась.
                {
                    NotificationTextLabel.Invoke((MethodInvoker)delegate
                    {
                        NotificationTextLabel.Text = "Ошибка! Карта  не читается, приложите другую карту.";
                    });

                    NotificationImagePictureBox.Invoke((MethodInvoker)delegate
                    {
                        NotificationImagePictureBox.Image = Properties.Resources.Exclamation;
                    });

                    MessageBox.Show($"Серийный номер карты: {Functions.CardSerialNumberFromRFID}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void NotificationsGuest_Load(object sender, System.EventArgs e)
        {
            await Task.Run(() => CheckCard());
        }
    }
}
