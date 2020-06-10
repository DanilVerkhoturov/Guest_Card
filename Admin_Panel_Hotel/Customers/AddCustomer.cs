using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();

            OpenCustomerInfoPanel();

            // Установка подсказок в текстовых полях.
            Functions.SetWaterMark(NameTextBox, "Наименование организации");
            Functions.SetWaterMark(AddressTextBox, "Адрес");
            Functions.SetWaterMark(INNTextBox, "ИНН");
            Functions.SetWaterMark(OGRNTextBox, "ОГРН");
            Functions.SetWaterMark(ContractNumberTextBox, "Номер договора");
            Functions.SetWaterMark(LocationNameTextBox, "Локация");
            Functions.SetWaterMark(EmailTextBox, "Электронная почта заказчика");
            Functions.SetWaterMark(RegionComboBox, "Регион");
            Functions.SetWaterMark(StateComboBox, "Область");
            Functions.SetWaterMark(CityComboBox, "Город");
            Functions.SetWaterMark(StreetTypeComboBox, "Тип улицы");
            Functions.SetWaterMark(StreetNameComboBox, "Улица");
            Functions.SetWaterMark(HouseTextBox, "Дом");
            Functions.SetWaterMark(CorpsTextBox, "Корпус");
            Functions.SetWaterMark(BuildTextBox, "Строение");
            Functions.SetWaterMark(RoomCountTextBox, "Количество комнат");
            Functions.SetWaterMark(BedsCountTextBox, "Количество мест");

            // Установка подсказок обязательных полей.
            ErrorProvider.SetError(NameTextBox, "* - обязательное поле");
            ErrorProvider.SetError(ContractNumberTextBox, "* - обязательное поле");
            ErrorProvider.SetError(ToContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(FromContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(EmailTextBox, "* - обязательное поле");
            ErrorProvider.SetError(LocationNameTextBox, "* - обязательное поле");
            ErrorProvider.SetError(RoomCountTextBox, "* - обязательное поле");
            ErrorProvider.SetError(BedsCountTextBox, "* - обязательное поле");

            // Подсказки для комплектов белья.
            HelpProvider.SetError(Set1_Customer_CheckBox, "В \"Комплект-1\" входит:\nНаволочка, подушка, одеяло, пододеяльник.");
            HelpProvider.SetError(Set2_Customer_CheckBox, "В \"Комплект-2\" входит:\nПростыня, подушка, одеяло.");


            using (MySqlConnection connection = new MySqlConnection(Functions.ConnectionString))
            {
                connection.Open();
                MySqlCommand select = new MySqlCommand("Select name FROM region", connection);
                MySqlDataReader reader = select.ExecuteReader();

                // Заполнение названий регонов.
                while (reader.Read())
                {
                    RegionComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                select.CommandText = "Select name FROM state";
                reader = select.ExecuteReader();

                // Заполнение названий областей.
                while (reader.Read())
                {
                    StateComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                select.CommandText = "Select name FROM city";
                reader = select.ExecuteReader();

                // Заполнение названий городов.
                while (reader.Read())
                {
                    CityComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                select.CommandText = "Select name FROM street_type";
                reader = select.ExecuteReader();

                // Заполнение типов улиц.
                while (reader.Read())
                {
                    StreetTypeComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                select.CommandText = "Select name FROM street_name";
                reader = select.ExecuteReader();

                // Заполнение названий улиц.
                while (reader.Read())
                {
                    StreetNameComboBox.Items.Add(reader[0].ToString());
                }
                reader.Close();

                connection.Close();
            }
        }

        private void AllProperties_Customer_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GiveOutLinen_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
            Set1_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
            Set2_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
            Instructed_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
            ResidenceRules_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
            FireSafety_Customer_CheckBox.Checked = AllProperties_Customer_CheckBox.Checked;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            CheckCustomerAddInfo();
            // TODO: Добавление заказчика в базу данных.
        }

        /// <summary>
        /// Проверка заполнения полей при добавлении заказчика.
        /// </summary>
        /// <returns></returns>
        private bool CheckCustomerAddInfo()
        {
            // TODO: Отредактировать условие в зависимости от таблицы в БД.
            if (NameTextBox.TextLength > 0 && NameTextBox.Text != "Наименование организации"
                            && AddressTextBox.TextLength > 0 && AddressTextBox.Text != "Адрес"
                            && INNTextBox.TextLength > 0 && INNTextBox.Text != "ИНН"
                            && OGRNTextBox.TextLength > 0 && OGRNTextBox.Text != "ОГРН"
                            && ContractNumberTextBox.TextLength > 0 && ContractNumberTextBox.Text != "Номер договора"
                            && LocationNameTextBox.TextLength > 0 && LocationNameTextBox.Text != "Локация"
                            && EmailTextBox.TextLength > 0 && EmailTextBox.Text != "Электронная почта заказчика") // Если все обязательные поля заполнены корректно.
            {
                // TODO: Проверка корректности эл.почты и срока договора.
                return true;
            }
            else // Если какое-либо или все обязательные поля незаполнены.
            {
                ErrorProvider.SetError(NameTextBox, "Введите наименование организации!");
                ErrorProvider.SetError(ContractNumberTextBox, "Введите номер договора!");
                return false;
            }
        }

        private void BedsCountTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(BedsCountTextBox.Text, out int bedsCount))
            {
                CardCountTextBox.Text = (((bedsCount * 10) / 100) + bedsCount).ToString(); // Расчёт количества карт по формуле: количество мест + 10%.
            }
        }

        private void CustomerInfoNextButton_Click(object sender, EventArgs e)
        {
            OpenAddCustomerLocationPanel();
        }

        /// <summary>
        /// Отображение панели с добавлением локаций заказчика.
        /// </summary>
        private void OpenAddCustomerLocationPanel()
        {
            CustomerInfoPanel.Visible = false;
            AddCustomerLocationPanel.Visible = true;
            CardPropertiesPanel.Visible = false;

            CustomerInfoPictureBox.Image = Properties.Resources.GreyCircle;
            AddCustomerLocationPictureBox.Image = Properties.Resources.BlueCircle;
            CardPropertiesPictureBox.Image = Properties.Resources.GreyCircle;
        }

        private void AddLocationNextButton_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        /// <summary>
        /// Отображение панели с выбором свойств карт заказчика.
        /// </summary>
        private void OpenCardPropertiesPanel()
        {
            CustomerInfoPanel.Visible = false;
            AddCustomerLocationPanel.Visible = false;
            CardPropertiesPanel.Visible = true;

            CustomerInfoPictureBox.Image = Properties.Resources.GreyCircle;
            AddCustomerLocationPictureBox.Image = Properties.Resources.GreyCircle;
            CardPropertiesPictureBox.Image = Properties.Resources.BlueCircle;
        }

        private void CustomerInfoPictureBox_Click(object sender, EventArgs e)
        {
            OpenCustomerInfoPanel();
        }

        /// <summary>
        /// Отображение панели с данными заказчика.
        /// </summary>
        private void OpenCustomerInfoPanel()
        {
            CustomerInfoPanel.Visible = true;
            AddCustomerLocationPanel.Visible = false;
            CardPropertiesPanel.Visible = false;

            CustomerInfoPictureBox.Image = Properties.Resources.BlueCircle;
            AddCustomerLocationPictureBox.Image = Properties.Resources.GreyCircle;
            CardPropertiesPictureBox.Image = Properties.Resources.GreyCircle;
        }

        private void AddCustomerLocationPictureBox_Click(object sender, EventArgs e)
        {
            OpenAddCustomerLocationPanel();
        }

        private void CardPropertiesPictureBox_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            // TODO: Проверка заполнения обязательных полей.
            int lastRow = LocationsDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (lastRow >= 0)
            {
                LocationsDataGridView.Rows.Add(lastRow + 2, LocationNameTextBox.Text);
            }
            else
            {
                LocationsDataGridView.Rows.Add(1, LocationNameTextBox.Text);
            }
        }
    }
}
