using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Admin_Panel_Hotel.ApplicationsFolder
{
    public partial class AddApplication : Form
    {
        public AddApplication()
        {
            InitializeComponent();

            Functions.NewlineProcessing(UsersDataGridView);

            UsersDataGridView.Columns["tabNum"].ValueType = Type.GetType("System.Int64");
            UsersDataGridView.Columns["from"].ValueType = Type.GetType("System.DateTime");
            UsersDataGridView.Columns["to"].ValueType = Type.GetType("System.DateTime");

            DivisionsComboBox.DataSource = Customer.GetAllDivisionsAndSubdivisions();
            LocationComboBox.DataSource = Locations.GetAll(Customer.Id);

            Functions.FillLocationsInDataGridViewComboBox(UsersDataGridView, Customer.Id);
        }

        private void AddUserLabel_Click(object sender, EventArgs e)
        {
            AddUserLabel.Focus();

            if (CheckLastUser())
                UsersDataGridView.Rows.Add(null, null, null, null, null, LocationComboBox.SelectedValue);
        }

        /// <summary>
        /// Проверить последнюю добавленную строку в таблице сотрудников.
        /// </summary>
        /// <returns>True - если все данные введены корректно. False - если не все данные введены.</returns>
        private bool CheckLastUser()
        {
            int lastUser = UsersDataGridView.Rows.Count - 1;
            DateTime dateFrom = DateTime.MinValue;
            DateTime dateTo = DateTime.MinValue;

            if (UsersDataGridView.Rows.Count == 0
                || (UsersDataGridView.Rows.Count > 0
                && UsersDataGridView["user_id", lastUser].Value != null
                && UsersDataGridView["tabNum", lastUser].Value != null
                && UsersDataGridView["from", lastUser].Value != null
                && UsersDataGridView["to", lastUser].Value != null
                && UsersDataGridView["location_id", lastUser].Value != null
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
            if (CheckLastUser()) // Если заполнены все обязательные поля.
            {
                if (Customer.GetCustomerId(Convert.ToInt64(DivisionsComboBox.SelectedValue), out long customerId) && Applications.Add(out long applicationId, customerId, 2))
                {
                    for (int i = 0; i < UsersDataGridView.RowCount; i++)
                    {
                        if (!Applications.Users.Add(Convert.ToInt64(UsersDataGridView["user_id", i].Value), Convert.ToDateTime(UsersDataGridView["from", i].Value), Convert.ToDateTime(UsersDataGridView["to", i].Value), Convert.ToInt64(UsersDataGridView["location_id", i].Value), 0))
                        {
                            MessageBox.Show("Возникла ошибка при добавлении клиента в заявке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    string fileExcel = Functions.DataGridViewToExcel(UsersDataGridView, $@"{Environment.CurrentDirectory}\{DivisionsComboBox.Text} - {DateTime.Now.Date.ToShortDateString()}", out string filePath);
                    Functions.SendMail($"Заявка на согласование", "", fileExcel);
                    if (Notify() == DialogResult.Cancel)
                    {
                        Functions.OpenChildForm(new NewApplications(), MainForm.ContP);
                    }
                }
                else
                {
                    MessageBox.Show("Возникла ошибка при добавлении заявки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Открыть форму уведомления о созданной заявке.
        /// </summary>
        private DialogResult Notify()
        {
            // Открытие формы уведомления о созданной заявке.
            NotificationsForm notification = new NotificationsForm();
            notification.NotificationLabel.Text = "Заявка отправлена";
            notification.Owner = this;
            notification.StartPosition = FormStartPosition.CenterParent;
            return notification.ShowDialog();
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

            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["location_id"];

            // Проверка выбора локации.
            if (e.ColumnIndex == 5 && UsersDataGridView[5, e.RowIndex].Value != null)
            {
                UsersDataGridView[5, e.RowIndex].ErrorText = UsersDataGridView[5, e.RowIndex].Value.ToString() == locationsComboBox.Items[0].ToString() ? "Выберите локацию из выпадающего списка" : null;
            }
        }

        private void DivisionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если удалось получить уникальный номер (Id) заказчика.
            if (Customer.GetDivisionId(Convert.ToInt64(DivisionsComboBox.SelectedValue), DivisionsComboBox.Text, out long divisionId))
            {
                Functions.FillUsersInDataGridViewComboBox(UsersDataGridView, Convert.ToInt64(DivisionsComboBox.SelectedValue));

                if (Customer.GetCustomerId(divisionId, out long customerId))
                {
                    // Подгрузить список локаций в выпадающий список на форме.
                    Customer.Id = customerId;
                    LocationComboBox.DataSource = Locations.GetAll(customerId);
                    LocationComboBox.DisplayMember = "location_name";
                    LocationComboBox.ValueMember = "location_id";

                    Functions.FillLocationsInDataGridViewComboBox(UsersDataGridView, customerId);
                }
                else
                {
                    DataGridViewComboBoxColumn locationComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["location_id"];

                    if (LocationComboBox.DataSource == null)
                    {
                        LocationComboBox.Items.Clear();
                        locationComboBox.Items.Clear();
                    }
                    else
                    {
                        LocationComboBox.DataSource = null;
                        locationComboBox.DataSource = null;
                    }
                }
            }
            else
            {
                DataGridViewComboBoxColumn usersComboBox = (DataGridViewComboBoxColumn)UsersDataGridView.Columns["user_id"];

                if (usersComboBox.DataSource == null)
                {
                    usersComboBox.Items.Clear();
                }
                else
                {
                    usersComboBox.DataSource = null;
                }
            }
        }

        private void UsersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            UsersDataGridView[e.ColumnIndex, e.RowIndex].Value = null;
        }
    }
}
