using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    internal class Functions
    {
        #region Переменные

        /// <summary>
        /// Строка подключения.
        /// </summary>
        private static string ConnectionString = "Data Source=82.202.172.129; User Id=u117511_hotel; Password=wjkbc0r7; Database=u117511_hotel; CharSet=utf8";
        /// <summary>
        /// Соединение с базой данных.
        /// </summary>
        public static MySqlConnection Connection = new MySqlConnection(ConnectionString);
        /// <summary>
        /// Активная форма в панели контента.
        /// </summary>
        private static Form ActiveForm = null;
        /// <summary>
        /// Магнитный считыватель.
        /// </summary>
        public static SerialPort RFID;
        /// <summary>
        /// Серийный номер приложенной карты к магнитному считывателю.
        /// </summary>
        public static string CardSerialNumberFromRFID;

        #endregion

        #region БД

        /// <summary>
        /// Обработка изменения статуса подключения к БД.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void MySQLConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            // Если подключение к БД стало закрытым, то открываем его.
            if (e.CurrentState == ConnectionState.Closed)
                Connection.Open();
        }

        /// <summary>
        /// Запрос к базе данных для получения данных.
        /// </summary>
        /// <param name="query">Текст запроса.</param>
        /// <returns>Возвращает таблицу с данными.</returns>
        public static DataTable ExecuteSql(string query)
        {
            try
            {
                DataTable table = new DataTable();
                //MySqlCommand command = new MySqlCommand(query, Connection);
                //command.CommandTimeout = 999999;

                //command.ExecuteNonQuery();

                //MySqlDataReader reader = command.ExecuteReader();
                //table.Load(reader);

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection);

                adapter.Fill(table);

                return table;
            }
            catch (Exception e)
            {
                return ExecuteSql(query);
            }
        }

        /// <summary>
        /// Запрос на добавление данных в БД.
        /// </summary>
        /// <param name="query">Запрос.</param>
        /// <returns>Уникальный номер (Id) последних добавленных данных или -1 если возникла ошибка.</returns>
        public static long SqlInsert(string query)
        {
            try
            {
                MySqlCommand insert = new MySqlCommand(query, Connection);
                insert.CommandTimeout = 86400;
                insert.ExecuteNonQuery();
                return insert.LastInsertedId;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        /// <summary>
        /// Запрос на изменение данных в БД.
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <returns>Уникальный номер (Id) последней обновлённой строки или -1 если возникла ошибка.</returns>
        public static long SqlUpdate(string query)
        {
            try
            {
                MySqlCommand update = new MySqlCommand(query, Connection);
                update.CommandTimeout = 86400;
                update.ExecuteNonQuery();
                return update.LastInsertedId;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        /// <summary>
        /// Получить только Id элемента из запроса.
        /// </summary>
        /// <param name="query">Запрос.</param>
        /// <param name="id">Уникальный номер найденного элемента. -1 - если возникла ошибка или элемент не найден.</param>
        /// <returns>Возвращает результат получения.</returns>
        public static bool GetId(string query, out long id)
        {
            try
            {
                id = -1;

                MySqlCommand select = new MySqlCommand(query, Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                    id = Convert.ToInt64(reader[0].ToString());
                reader.Close();

                return id != -1;
            }
            catch (Exception)
            {
                id = -1;
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Отправка письма на почтовый ящик.
        /// </summary>
        /// <param name="mailto">Адрес получателя.</param>
        /// <param name="caption">Тема письма.</param>
        /// <param name="message">Сообщение.</param>
        /// <param name="attachFile">Присоединенный файл.</param>
        public static void SendMail(/*string mailto,*/ string caption, string message, string attachFile = null)
        {
            try
            {
                string from = "andrey.miolt@mail.ru";
                string password = "3IRgiiPI7jy$";
                string mailto = "mio.leantech@gmail.com";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;

                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        /// <summary>
        /// Заполнить выпадающий список локаций в таблице.
        /// </summary>
        /// <param name="dgv">Таблица.</param>
        /// <param name="customerId">Уникальный номер (Id) заказчика.</param>
        public static void FillLocationsInDataGridViewComboBox(DataGridView dgv, long customerId)
        {
            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)dgv.Columns["location_id"];
            locationsComboBox.DataSource = Locations.GetAll(customerId);
            locationsComboBox.ValueMember = "location_id";
            locationsComboBox.DisplayMember = "location_name";
        }

        /// <summary>
        /// Заполнить выпадающий список локаций в таблице.
        /// </summary>
        /// <param name="dgv">Таблица.</param>
        public static void FillLocationsInDataGridViewComboBox(DataGridView dgv)
        {
            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)dgv.Columns["location_id"];
            locationsComboBox.DataSource = Locations.GetAll();
            locationsComboBox.ValueMember = "location_id";
            locationsComboBox.DisplayMember = "location_name";
        }

        /// <summary>
        /// Заполнить выпадающий список пользователей организации в таблице.
        /// </summary>
        /// <param name="dgv">Таблица</param>
        /// <param name="divisionId">Уникальный номер организации.</param>
        public static void FillUsersInDataGridViewComboBox(DataGridView dgv, long divisionId)
        {
            DataGridViewComboBoxColumn usersComboBox = (DataGridViewComboBoxColumn)dgv.Columns["user_id"];
            usersComboBox.DataSource = Users.GetAll(divisionId);
            usersComboBox.ValueMember = "user_id";
            usersComboBox.DisplayMember = "fio";
        }

        /// <summary>
        /// Заполнить выпадающий список пользователей организации в таблице.
        /// </summary>
        /// <param name="dgv">Таблица</param>
        public static void FillUsersInDataGridViewComboBox(DataGridView dgv)
        {
            DataGridViewComboBoxColumn usersComboBox = (DataGridViewComboBoxColumn)dgv.Columns["user_id"];
            usersComboBox.DataSource = Applications.Users.Get();
            usersComboBox.ValueMember = "user_id";
            usersComboBox.DisplayMember = "fio";
        }

        /// <summary>
        /// Заполнить выпадающий список статусов в таблице.
        /// </summary>
        /// <param name="dgv">Таблица</param>
        public static void FillCardStatusesInDataGridView(DataGridView dgv)
        {
            // Подгрузка статусов карт в выпадающий список таблицы.
            DataGridViewComboBoxColumn statusesComboBox = (DataGridViewComboBoxColumn)dgv.Columns["status_id"];
            statusesComboBox.DataSource = Card.GetStatuses();
            statusesComboBox.ValueMember = "status_id";
            statusesComboBox.DisplayMember = "status_name";
        }

        public static void RFID_DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            CardSerialNumberFromRFID = serialPort.ReadLine();
            RFID.Close();
        }

        /// <summary>
        /// Конвертировать дату в Unix-формат.
        /// </summary>
        /// <param name="dateTime">Дата для конвертации.</param>
        /// <returns>Возвращает дату в формате Unixtime</returns>
        public static int ToUnixTime(DateTime dateTime)
        {
            if (dateTime > new DateTime(1970, 1, 1))
            {
                return (int)(dateTime - new DateTime(1970, 1, 1)).TotalSeconds;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Получить дату из Unixtime.
        /// </summary>
        /// <param name="unix">Дата в формате Unixtime.</param>
        /// <returns>Возвращает дату в формате "Дата и время".</returns>
        public static DateTime FromUnixTime(int unix)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unix).DateTime;
        }

        /// <summary>
        /// Открыть дочернюю форму на форме.
        /// </summary>
        /// <param name="childForm">Дочерняя форма.</param>
        /// <param name="contentPanel">Панель на которой требуется отобразить форму.</param>
        public static void OpenChildForm(Form childForm, Panel contentPanel)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Установить подсказку для текстового поля.
        /// </summary>
        /// <param name="textBox">Объект текстового поля.</param>
        /// <param name="placeholderText">Текст подсказки.</param>
        public static void SetPlaceholderTextBox(Control textBox, string placeholderText)
        {
            textBox.ForeColor = Color.Silver;
            textBox.Tag = placeholderText;
            textBox.Text = placeholderText;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
        }

        /// <summary>
        /// Установить подсказку для поля выбора даты.
        /// </summary>
        /// <param name="dtp">Объект поля выбора даты.</param>
        /// <param name="placeholderText">Текст подсказки.</param>
        public static void SetPlaceholderDateTimePicker(DateTimePicker dtp, string placeholderText)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = placeholderText;
            dtp.Tag = placeholderText;
            dtp.Enter += DateTimePicker_Enter;
            dtp.Leave += DateTimePicker_Leave;
        }

        /// <summary>
        /// Обработка события начала работы с датой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void DateTimePicker_Enter(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;

            if (dtp.Format == DateTimePickerFormat.Custom) // Если в поле с датой стоит подсказка, то отображаем дату.
            {
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Value = dtp.MinDate;
            }
        }

        /// <summary>
        /// Обработка события окончания работы с датой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void DateTimePicker_Leave(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;

            if (dtp.Value == dtp.MinDate) // Если в поле написана минимальная дата, то отображаем подсказку.
            {
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = dtp.Tag.ToString();
            }
        }

        /// <summary>
        /// Обработка события при нажатии на текстовое поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TextBox_Enter(object sender, EventArgs e)
        {
            Control textbox = sender as Control;

            if (textbox.Text.Trim() == textbox.Tag.ToString()) // Если в текстовом поле написан текст подсказки.
            {
                textbox.Text = null;
                textbox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Обработка события окончания работы с текстовым полем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TextBox_Leave(object sender, EventArgs e)
        {
            Control textbox = sender as Control;

            if (textbox.Text.Trim().Length == 0 || textbox.Text.Trim() == textbox.Tag.ToString()) // Если текстовое поле пустое или текст в поле равен тексту подсказки.
            {
                textbox.Text = textbox.Tag.ToString();
                textbox.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// Обработка добавления новых строк: установка номера новой строки(в первый столбец!).
        /// </summary>
        /// <param name = "dgv" > Объект таблицы для обработки.</param>
        public static void NewlineProcessing(DataGridView dgv)
        {
            dgv.RowsAdded += SetRowNumber;
        }

        /// <summary>
        /// Обработка события добавления новой строки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SetRowNumber(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int rowIndex = e.RowIndex;

            for (int i = 0; i < e.RowCount; i++)
            {
                // Заполнение номера строки в первый столбец.
                dgv[0, rowIndex].Value = ++rowIndex;
            }
        }

        /// <summary>
        /// Установка ограничения на ввод только цифр для текстового поля.
        /// </summary>
        /// <param name="textBox">Объект текстового поля.</param>
        public static void OnlyNumbersInTextBox(TextBox textBox)
        {
            textBox.KeyPress += TextBox_KeyPress;
        }

        /// <summary>
        /// Обработка события нажатия на клавишу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
