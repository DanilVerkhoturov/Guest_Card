using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class AddLocationInfo : Form
    {
        public AddLocationInfo()
        {
            InitializeComponent();

            // Установка подсказок в текстовых полях.
            Functions.SetPlaceholderTextBox(LocationNameTextBox, "Название локации");
            Functions.SetPlaceholderTextBox(RoomCountTextBox, "Количество комнат");
            Functions.SetPlaceholderTextBox(BedsCountTextBox, "Количество мест");

            // Установка ограничений для текстовых полей.
            Functions.OnlyNumbersInTextBox(CardCountTextBox);
            Functions.OnlyNumbersInTextBox(RoomCountTextBox);
            Functions.OnlyNumbersInTextBox(BedsCountTextBox);

            CustomerLocationNameLabel.Text = $"Мои заказчики > {Customer.Name}";
        }

        private void CustomerLocationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
        }

        /// <summary>
        /// Проверка заполнения данных в добавленных комнатах.
        /// </summary>
        /// <returns>True - если все данные заполнены. False - если есть незаполненные области.</returns>
        private bool CheckRoomsData()
        {
            // Проверка заполнения всех ячеек.
            for (int i = 0; i < RoomsDataGridView.Rows.Count; i++)
            {
                try
                {
                    // Если в ячейке нет данных или написан текст подсказки.
                    if (RoomsDataGridView[0, i].Value == null
                        || RoomsDataGridView[0, i].Value.ToString().Trim().ToLower() == RoomsDataGridView.Columns[0].ToolTipText.ToLower()
                        || RoomsDataGridView[1, i].Value == null
                        || RoomsDataGridView[1, i].Value.ToString().Trim().ToLower() == RoomsDataGridView.Columns[1].ToolTipText.ToLower()
                        || !int.TryParse(RoomsDataGridView[1, i].Value.ToString().Trim().ToLower(), out int bedsCount))
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Проверка заполнения обязательных полей и добавление локации в базу данных.
        /// </summary>
        /// <returns>True - если все обязательные поля заполнены и локация добавлена в БД. False - если заполнены не все обязательные поля или возникла ошибка при добавлении данных в БД.</returns>
        private bool AddLocation()
        {
            if (LocationNameTextBox.TextLength > 0 && LocationNameTextBox.Text != LocationNameTextBox.Tag.ToString()
                && RoomCountTextBox.TextLength > 0 && RoomCountTextBox.Text != RoomCountTextBox.Tag.ToString()
                && BedsCountTextBox.TextLength > 0 && BedsCountTextBox.Text != BedsCountTextBox.Tag.ToString()
                && CheckRoomsData()) // Если все обязательные поля заполнены.
            {
                long locationId = Locations.Add(LocationNameTextBox.Text.Trim());
                if (locationId >= 0)
                {
                    long hotelId = Hotels.Add(locationId, Customer.Id, Convert.ToInt32(RoomCountTextBox.Text), Convert.ToInt32(BedsCountTextBox.Text), Convert.ToInt32(CardCountTextBox.Text));
                    if (hotelId >= 0)
                    {
                        for (int i = 0; i < RoomsDataGridView.RowCount; i++)
                        {
                            string roomName = RoomsDataGridView["RoomNumber", i].Value.ToString().Trim();
                            string bedsCount = RoomsDataGridView["BedsCount", i].Value.ToString().Trim();

                            if (Hotels.FindRoom(roomName, hotelId, out long roomId)) // Если в БД есть такие комнаты.
                            {
                                Hotels.EditRoom(roomId, roomName, Convert.ToInt64(bedsCount));
                            }
                            else
                            {
                                Hotels.AddRoom(hotelId, roomName, Convert.ToInt32(bedsCount));
                            }
                        }

                        LocationsDataGridView.DataSource = Hotels.GetAll(Customer.Id);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void AddLocationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AddLocation())
            {
                LocationNameTextBox.Text = LocationNameTextBox.Tag.ToString();
                RoomCountTextBox.Text = RoomCountTextBox.Tag.ToString();
                BedsCountTextBox.Text = BedsCountTextBox.Tag.ToString();
                CardCountTextBox.Text = "0";
                AddRoomsLabel.Visible = false;
                RoomsDataGridView.Visible = false;
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            if (LocationsDataGridView.RowCount > 0)
            {
                if (AddLocation())
                {
                    LocationNameTextBox.Text = LocationNameTextBox.Tag.ToString();
                    RoomCountTextBox.Text = RoomCountTextBox.Tag.ToString();
                    BedsCountTextBox.Text = BedsCountTextBox.Tag.ToString();
                    CardCountTextBox.Text = "0";
                    AddRoomsLabel.Visible = false;
                    RoomsDataGridView.Visible = false;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Заполнены не все поля, введённые данные будут утеряны! Завершить добавление локации?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes) // Если добавление заказчика завершено.
                    {
                        MainForm.SubMenuProcessing(MainForm.MyCustomersBtn, MainForm.CustomersBtn, MainForm.CustomersP);
                        Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BedsCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Отобразить панель с добавлением комнат.
        /// </summary>
        private void VisibleAddRooms()
        {
            RoomsDataGridView.Rows.Clear();

            if (LocationNameTextBox.TextLength > 0 && LocationNameTextBox.Text != LocationNameTextBox.Tag.ToString()
                && RoomCountTextBox.TextLength > 0 && RoomCountTextBox.Text != RoomCountTextBox.Tag.ToString()
                && BedsCountTextBox.TextLength > 0 && BedsCountTextBox.Text != BedsCountTextBox.Tag.ToString()) // Если заполнены все обязательные поля.
            {
                for (int i = 0; i < Convert.ToInt32(RoomCountTextBox.Text); i++)
                {
                    int row = RoomsDataGridView.Rows.Add();
                    RoomsDataGridView[0, row].ErrorText = "* - обязательное поле";
                    RoomsDataGridView[1, row].ErrorText = "* - обязательное поле";
                }

                AddRoomsLabel.Visible = true;
                RoomsDataGridView.Visible = true;
            }
        }

        private void RoomsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Если закончилось редактирование не первого столбца (номер строки) и в ячейке нет текста.
            if (RoomsDataGridView[e.ColumnIndex, e.RowIndex].Value == null)
            {
                RoomsDataGridView[e.ColumnIndex, e.RowIndex].ErrorText = "* - обязательное поле";
            }
            else
            {
                RoomsDataGridView[e.ColumnIndex, e.RowIndex].ErrorText = null;
            }
        }

        private void LocationNameTextBox_Leave(object sender, EventArgs e)
        {
            VisibleAddRooms();
        }
    }
}
