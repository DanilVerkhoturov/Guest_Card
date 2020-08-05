using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Admin_Panel_Hotel
{
    public partial class AddApplication : Form
    {
        public AddApplication()
        {
            InitializeComponent();

            CustomerComboBox.DataSource = Customer.GetAllDivisions();
            LocationComboBox.DataSource = Locations.GetAll();

            Functions.NewlineProcessing(UsersDataGridView, new string[] { "1", "Введите ФИО", "Таб.номер", "Дата от", "Дата до", "Локация" });
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            if (CheckLastUser())
            {
                UsersDataGridView.Rows.Add();
            }
        }

        /// <summary>
        /// Проверить последнюю добавленную строку в таблице сотрудников.
        /// </summary>
        /// <returns>True - если все данные введены корректно. False - если не все данные введены.</returns>
        private bool CheckLastUser()
        {
            int lastUser = UsersDataGridView.Rows.Count - 1;
            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["location"];
            DateTime dateFrom = DateTime.MinValue;
            DateTime dateTo = DateTime.MinValue;

            if (UsersDataGridView.Rows.Count == 0
                || (UsersDataGridView.Rows.Count > 0
                && UsersDataGridView[1, lastUser].Value != null && UsersDataGridView[1, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[2, lastUser].Value != null && UsersDataGridView[2, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[3, lastUser].Value != null && UsersDataGridView[3, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                && UsersDataGridView[4, lastUser].Value != null && UsersDataGridView[4, lastUser].Value.ToString() != UsersDataGridView[0, lastUser].ToolTipText
                //&& UsersDataGridView[5, lastUser].Value != null && UsersDataGridView[5, lastUser].Value.ToString() != locationsComboBox.Items[0].ToString()
                && DateTime.TryParse(UsersDataGridView[3, lastUser].Value.ToString(), out dateFrom)
                && DateTime.TryParse(UsersDataGridView[4, lastUser].Value.ToString(), out dateTo))
                && dateFrom < dateTo)
            {
                return true;
            }
            else
            {
                if (dateFrom == DateTime.MinValue)
                {
                    UsersDataGridView[3, lastUser].ErrorText = "Введите корректную дату";
                }
                if (dateTo == DateTime.MinValue)
                {
                    UsersDataGridView[4, lastUser].ErrorText = "Введите корректную дату";
                }
                return false;
            }
        }

        private void SendToCustomerButton_Click(object sender, EventArgs e)
        {
            if (/*CustomerComboBox.SelectedIndex > 0 && LocationComboBox.SelectedIndex > 0 &&*/ CheckLastUser()) // Если заполнены все обязательные поля.
            {
                string fileExcel = UsersToExcel();

                // TODO: Сделать создание заявки в БД.

                // TODO: Сделать отправку письма с файлом на почту заказчика.

                Notify();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Открыть форму уведомления о созданной заявке.
        /// </summary>
        private void Notify()
        {
            // Открытие формы уведомления о созданной заявке.
            NotificationsForm notification = new NotificationsForm();
            notification.NotificationLabel.Text = "Заявка добавлена";
            notification.Owner = this;
            notification.StartPosition = FormStartPosition.CenterParent;
            notification.ShowDialog();
        }

        /// <summary>
        /// Загрузка сотрудников из таблицы в файл Excel.
        /// </summary>
        /// <returns>Путь к созданному файлу.</returns>
        private string UsersToExcel()
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
            Excel.Sheets excelsheets = workbook.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

            for (int i = 1; i < UsersDataGridView.RowCount + 1; i++)
            {
                for (int j = 1; j < UsersDataGridView.ColumnCount + 1; j++)
                {
                    excelworksheet.Rows[i].Columns[j] = UsersDataGridView.Rows[i - 1].Cells[j - 1].Value;
                }
            }

            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs($@"{Environment.CurrentDirectory}\{CustomerComboBox.Text} - {DateTime.Now.Date.ToShortDateString()}.xls");
            excelapp.Quit();

            return workbook.FullName;
        }

        private void UsersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && UsersDataGridView[3, e.RowIndex].Value != null) // Проверка корректного заполнения столбца "Дата от".
            {
                UsersDataGridView[3, e.RowIndex].ErrorText = DateTime.TryParse(UsersDataGridView[3, e.RowIndex].Value.ToString(), out DateTime dateFrom) ? null : "Введите корректную дату";
            }
            else if (e.ColumnIndex == 4 && UsersDataGridView[4, e.RowIndex].Value != null) // Проверка корректного заполнения столбца "Дата до".
            {
                UsersDataGridView[4, e.RowIndex].ErrorText = DateTime.TryParse(UsersDataGridView[4, e.RowIndex].Value.ToString(), out DateTime dateTo) ? null : "Введите корректную дату";
            }

            // Проверка условия "Дата от < Дата до".
            if ((e.ColumnIndex == 3 || e.ColumnIndex == 4) && (UsersDataGridView[3, e.RowIndex].Value != null && UsersDataGridView[4, e.RowIndex].Value != null))
            {
                if (DateTime.TryParse(UsersDataGridView[3, e.RowIndex].Value.ToString(), out DateTime dateFrom)
                    && DateTime.TryParse(UsersDataGridView[4, e.RowIndex].Value.ToString(), out DateTime dateTo))
                {
                    if (dateFrom >= dateTo)// Если "Дата от" больше или равна "Дата до".
                    {
                        UsersDataGridView[3, e.RowIndex].ErrorText = "Введите корректную дату";
                        UsersDataGridView[4, e.RowIndex].ErrorText = "Введите корректную дату";
                    }
                    else
                    {
                        UsersDataGridView[3, e.RowIndex].ErrorText = null;
                        UsersDataGridView[4, e.RowIndex].ErrorText = null;
                    }

                }
            }

            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["location"];

            // Проверка выбора локации.
            if (e.ColumnIndex == 5 && UsersDataGridView[5, e.RowIndex].Value != null)
            {
                UsersDataGridView[5, e.RowIndex].ErrorText = UsersDataGridView[5, e.RowIndex].Value.ToString() == locationsComboBox.Items[0].ToString() ? "Выберите локацию из выпадающего списка" : null;
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customer.GetDivisionId(Convert.ToInt64(CustomerComboBox.SelectedValue), out long divisionId) && Customer.GetCustomerId(divisionId, out long customerId))
            {
                Customer.Id = customerId;
                LocationComboBox.DataSource = Locations.GetAll();
            }
            else
            {
                if (LocationComboBox.DataSource == null)
                {
                    LocationComboBox.Items.Clear();
                }
                else
                {
                    LocationComboBox.DataSource = null;
                }
            }
        }
    }
}
