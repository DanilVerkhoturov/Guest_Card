using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();

            Functions.SetWaterMark(Name_Customer_TextBox, "Наименование организации");
            Functions.SetWaterMark(Address_Customer_TextBox, "Адрес");
            Functions.SetWaterMark(INN_Customer_TextBox, "ИНН");
            Functions.SetWaterMark(OGRN_Customer_TextBox, "ОГРН");
            Functions.SetWaterMark(ContractNumber_Customer_TextBox, "Номер договора");
            Functions.SetWaterMark(LocationName_Customer_TextBox, "Локация");
            Functions.SetWaterMark(Email_Customer_TextBox, "Электронная почта заказчика");
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

            ErrorProvider.SetError(Name_Customer_TextBox, "* - обязательное поле");
            ErrorProvider.SetError(ContractNumber_Customer_TextBox, "* - обязательное поле");
            ErrorProvider.SetError(ToContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(FromContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(Email_Customer_TextBox, "* - обязательное поле");
            ErrorProvider.SetError(LocationName_Customer_TextBox, "* - обязательное поле");
            ErrorProvider.SetError(RoomCountTextBox, "* - обязательное поле");
            ErrorProvider.SetError(BedsCountTextBox, "* - обязательное поле");

            // Подсказки для комплектов белья.
            HelpProvider.SetError(Set1_Customer_CheckBox, "В \"Комплект-1\" входит:\nНаволочка, подушка, одеяло, пододеяльник.");
            HelpProvider.SetError(Set2_Customer_CheckBox, "В \"Комплект-2\" входит:\nПростыня, подушка, одеяло.");


            using (MySqlConnection connection = new MySqlConnection(Functions.ConnectionString))
            {
                connection.Open();
                MySqlCommand select = new MySqlCommand("Select * FROM region", connection);
                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    RegionComboBox.Items.Add(reader[1].ToString());
                }

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
            if (Name_Customer_TextBox.TextLength > 0 && Name_Customer_TextBox.Text != "Наименование организации"
                            && Address_Customer_TextBox.TextLength > 0 && Address_Customer_TextBox.Text != "Адрес"
                            && INN_Customer_TextBox.TextLength > 0 && INN_Customer_TextBox.Text != "ИНН"
                            && OGRN_Customer_TextBox.TextLength > 0 && OGRN_Customer_TextBox.Text != "ОГРН"
                            && ContractNumber_Customer_TextBox.TextLength > 0 && ContractNumber_Customer_TextBox.Text != "Номер договора"
                            && LocationName_Customer_TextBox.TextLength > 0 && LocationName_Customer_TextBox.Text != "Локация"
                            && Email_Customer_TextBox.TextLength > 0 && Email_Customer_TextBox.Text != "Электронная почта заказчика") // Если все обязательные поля заполнены корректно.
            {
                // TODO: Проверка корректности эл.почты и срока договора.
                return true;
            }
            else // Если какое-либо или все обязательные поля незаполнены.
            {
                ErrorProvider.SetError(Name_Customer_TextBox, "Введите наименование организации!");
                ErrorProvider.SetError(ContractNumber_Customer_TextBox, "Введите номер договора!");
                return false;
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            // Открытие формы добавления локации
            var addLocation = new AddLocationFrom();
            addLocation.Owner = this;
            addLocation.StartPosition = FormStartPosition.CenterParent;
            addLocation.ShowDialog();
        }

        private void BedsCountTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(BedsCountTextBox.Text, out int bedsCount))
            {
                CardCountTextBox.Text = (((bedsCount * 10) / 100) + bedsCount).ToString(); // Расчёт количества карт по формуле: количество мест + 10%.
            }
        }
    }
}
