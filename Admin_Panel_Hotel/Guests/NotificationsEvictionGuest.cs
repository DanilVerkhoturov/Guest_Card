using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class NotificationsEvictionGuest : Form
    {
        public NotificationsEvictionGuest()
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

                if (long.TryParse(Functions.CardSerialNumberFromRFID, out long serialNumber)) // Если карта успешно считалась.
                {
                    if (Functions.CardSerialNumberFromRFID == Guest.Card.SerialNum) // Если была считана карта текущего гостя.
                    {
                        DateTime evictionTime = DateTime.Now;

                        NotificationTextLabel.Invoke((MethodInvoker)delegate
                        {
                            NotificationTextLabel.Text = $"Гость: {Guest.Name} выехал {evictionTime.ToShortDateString()} в {evictionTime.ToShortTimeString()}";
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

                        // TODO: Реализовать выселение гостя.
                    }
                    else // Если была считана другая карта.
                    {
                        NotificationTextLabel.Invoke((MethodInvoker)delegate
                        {
                            NotificationTextLabel.Text = "Ошибка! Была приложена другая карта. Приложите настоящую карту!";
                        });

                        NotificationImagePictureBox.Invoke((MethodInvoker)delegate
                        {
                            NotificationImagePictureBox.Image = Properties.Resources.Exclamation;
                        });

                        MessageBox.Show($"Серийный номер карты: {Functions.CardSerialNumberFromRFID}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Если карта не считалась.
                {
                    NotificationTextLabel.Invoke((MethodInvoker)delegate
                    {
                        NotificationTextLabel.Text = "Ошибка! Карта  не читается!";
                    });

                    NotificationImagePictureBox.Invoke((MethodInvoker)delegate
                    {
                        NotificationImagePictureBox.Image = Properties.Resources.Exclamation;
                    });

                    MessageBox.Show($"Серийный номер карты: {Functions.CardSerialNumberFromRFID}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void NotificationsEvictionGuest_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CheckCard());
        }
    }
}
