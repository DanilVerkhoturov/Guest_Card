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
                Functions.Connection.Open();
        }

        #endregion

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
                dgv.RowsAdded += new DataGridViewRowsAddedEventHandler(RowsAdded);
                dgv.CellEnter += new DataGridViewCellEventHandler(CellEnter);
                dgv.CellLeave += new DataGridViewCellEventHandler(CellLeave);
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

            if (e.ColumnIndex != 0 && dgv[e.ColumnIndex, e.RowIndex].Value != null && dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == dgv.Columns[e.ColumnIndex].ToolTipText)
            {
                dgv[e.ColumnIndex, e.RowIndex].Value = null;
            }
        }

        /// <summary>
        /// Обработка окончания редактирования ячейки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.ColumnIndex != 0 && dgv[e.ColumnIndex, e.RowIndex].Value == null)
            {
                dgv[e.ColumnIndex, e.RowIndex].Value = dgv.Columns[e.ColumnIndex].ToolTipText;
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
