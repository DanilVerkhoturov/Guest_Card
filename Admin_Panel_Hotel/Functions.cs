using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    internal class Functions
    {
        #region Переменные

        /// <summary>
        /// Строка подключения.
        /// </summary>
        private static string ConnectionString = "Data Source=82.202.172.129; User Id=u117511_hotel; Password=wjkbc0r7; Database=u117511_hotel";

        /// <summary>
        /// Соединение с базой данных.
        /// </summary>
        public static MySqlConnection Connection = new MySqlConnection(ConnectionString);

        /// <summary>
        /// Активная форма в панели контента.
        /// </summary>
        private static Form ActiveForm = null;

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
            DataTable table = new DataTable();
            var command = Connection.CreateCommand();
            command.CommandTimeout = 86400;
            command.CommandText = query;
            var reader = command.ExecuteReader();
            table.Load(reader);
            return table;
        }

        /// <summary>
        /// Запрос на добавление данных в БД.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Уникальный номер (id) последних добавленных данных или -1 если возникла ошибка.</returns>
        public static long SqlInsert(string query)
        {
            try
            {
                MySqlCommand insert = new MySqlCommand(query, Connection);
                insert.ExecuteNonQuery();
                return insert.LastInsertedId;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }

        /// <summary>
        /// Загрузить заявки из базы данных в таблицу.
        /// </summary>
        /// <param name="dgv">Таблица, для загрузки в неё данных.</param>
        /// <param name="applicationsStatus">Статус заявки.</param>
        public static void LoadApplications(DataGridView dgv, int applicationsStatus)
        {
            MySqlCommand select = new MySqlCommand($"SELECT id" +
                $", (SELECT name as 'name' FROM customer_legal_info WHERE id = applications.customer_id)" +
                $", created_at as 'date'" +
                $" FROM applications" +
                $" WHERE status_id = {applicationsStatus}", Connection);
            select.CommandTimeout = 86400;
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(reader[1].ToString(), FromUnixTime(Convert.ToInt32(reader[2].ToString())).Date.ToShortDateString(), null, reader[0].ToString());
            }
            reader.Close();
        }

        /// <summary>
        /// Загрузить людей из заявки.
        /// </summary>
        /// <param name="dgv">Таблица, для загрузки в неё данных</param>
        /// <param name="applicationId">Уникальный номер заявки.</param>
        public static void LoadApplicationUsers(DataGridView dgv, long applicationId)
        {
            MySqlCommand select = new MySqlCommand($"SELECT (SELECT user_profile.firstname FROM user_profile WHERE user_profile.user_id = applications_user.user_id) as 'firstname'" +
                $", (SELECT user_profile.middlename FROM user_profile WHERE user_profile.user_id = applications_user.user_id) as 'middlename'" +
                $", (SELECT user_profile.lastname FROM user_profile WHERE user_profile.user_id = applications_user.user_id) as 'lastname'" +
                $", (SELECT event.start_at FROM event WHERE event.id = applications_user.event_id) as 'start_at'" +
                $", (SELECT event.end_at FROM event WHERE event.id = applications_user.event_id) as 'end_at'" +
                $", (SELECT customer_location.name FROM customer_location WHERE customer_location.customer_id = (SELECT applications.customer_id FROM applications WHERE applications.id = {applicationId}) AND customer_location.location_id = (SELECT location_id FROM applications WHERE applications.id = {applicationId})) as 'locationname'" +
                $" FROM applications_user" +
                $" WHERE application_id = {applicationId}", Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read()) // Получаем данные из запроса и заполняем их в таблицу.
            {
                string userName = $"{reader[0]} {reader[1]} {reader[2]}";
                string tabNum = null;

                int addedRow = dgv.Rows.Add(dgv.Rows.Count + 1
                    , userName
                    , tabNum
                    , FromUnixTime(Convert.ToInt32(reader[3].ToString())).Date.ToShortDateString()
                    , FromUnixTime(Convert.ToInt32(reader[4].ToString())).Date.ToShortDateString());

                DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)dgv.Columns["location"];
                int addedLocation = 0;

                if (locationsComboBox == null) // Если локации в таблице, в виде "TextBox".
                {
                    dgv[5, addedRow].Value = reader[5].ToString();
                }
                else // Если локации в таблице, в виде "ComboBox".
                {
                    if (locationsComboBox.Items.Contains(reader[5].ToString()))
                    {
                        addedLocation = locationsComboBox.Items.Count - 1;
                    }
                    else
                    {
                        addedLocation = locationsComboBox.Items.Add(reader[5].ToString());
                    }

                    dgv[5, addedRow].Value = locationsComboBox.Items[addedLocation];
                }
            }
            reader.Close();
        }

        #endregion

        /// <summary>
        /// Конвертировать дату в Unix-формат.
        /// </summary>
        /// <param name="dateTime">Дата для конвертации.</param>
        /// <returns>Дату в формате Unixtime</returns>
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
        /// <returns>Дату в виде "Дата и время".</returns>
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
        /// Обработка добавления новых строк: установка номера новой строки(в первый столбец!!), заполнение подсказок.
        /// </summary>
        /// <param name = "dgv" > Объект таблицы для обработки.</param>
        /// <param name = "helpTexts" > Тексты для подсказок столбцов (вписать попорядку для каждого столбца). Если текст для столбца не нужен - писать null!</param>
        public static void NewlineProcessing(DataGridView dgv, string[] helpTexts)
        {
            for (int c = 0; c < dgv.Columns.Count; c++)
            {
                dgv.Columns[c].ToolTipText = helpTexts[c];
                dgv.RowsAdded += RowsAdded;
                dgv.CellEnter += CellEnter;
                dgv.CellEndEdit += CellEndEdit;
            }
        }

        /// <summary>
        /// Обработка окончания редактирования ячейки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Если был отредактирован не первый столбец (номер строки) и в ячейке нет текста.
            if (e.ColumnIndex != 0 && (dgv[e.ColumnIndex, e.RowIndex].Value == null
                || string.IsNullOrEmpty(dgv[e.ColumnIndex, e.RowIndex].Value.ToString().Trim())
                || dgv[e.ColumnIndex, e.RowIndex].Value.ToString().Trim().ToLower() == dgv.Columns[e.ColumnIndex].ToolTipText.ToLower()))
            {
                dgv[e.ColumnIndex, e.RowIndex].Value = dgv.Columns[e.ColumnIndex].ToolTipText;
            }
        }

        /// <summary>
        /// Обработка события добавления новой строки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Заполнение номера строки в первый столбец.
            dgv[0, e.RowIndex].Value = e.RowIndex + 1;

            // Заполнение подсказок в новые поля.
            for (int c = 1; c < dgv.Columns.Count; c++)
            {
                if (dgv[c, e.RowIndex] is DataGridViewComboBoxCell) // Выбор первого элемента из списка, являющегося подсказкой.
                {
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)dgv[c, e.RowIndex];
                    dgv[c, e.RowIndex].Value = comboBoxCell.Items[0];
                }
                else
                {
                    dgv[c, e.RowIndex].Value = dgv.Columns[c].ToolTipText;
                }
            }
        }

        /// <summary>
        /// Обработка события начала редактирования ячейки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Если началось редактирование не первого столбца (номер строки) и в ячейке есть текст, который является подсказкой.
            if (e.ColumnIndex != 0 && dgv[e.ColumnIndex, e.RowIndex].Value != null && dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == dgv.Columns[e.ColumnIndex].ToolTipText)
            {
                dgv[e.ColumnIndex, e.RowIndex].Value = null;
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
