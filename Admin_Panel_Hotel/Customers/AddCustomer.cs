using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddCustomer : Form
    {
        private static int EmailsCount = 1;

        public AddCustomer()
        {
            InitializeComponent();

            OpenCustomerInfoPanel();

            // Установка подсказок в текстовых полях.
            Functions.SetWaterMarkTextBox(NameTextBox, "Наименование организации");
            Functions.SetWaterMarkTextBox(AddressTextBox, "Адрес");
            Functions.SetWaterMarkTextBox(INNTextBox, "ИНН");
            Functions.SetWaterMarkTextBox(OGRNTextBox, "ОГРН");
            Functions.SetWaterMarkTextBox(ContractNumberTextBox, "Номер договора");
            Functions.SetWaterMarkTextBox(LocationNameTextBox, "Название локации");
            //Functions.SetWaterMark(EmailTextBox, "Электронная почта заказчика");
            Functions.SetWaterMarkTextBox(RegionComboBox, "Регион");
            Functions.SetWaterMarkTextBox(StateComboBox, "Область");
            Functions.SetWaterMarkTextBox(CityComboBox, "Город");
            Functions.SetWaterMarkTextBox(StreetTypeComboBox, "Тип улицы");
            Functions.SetWaterMarkTextBox(StreetNameComboBox, "Улица");
            Functions.SetWaterMarkTextBox(HouseTextBox, "Дом");
            Functions.SetWaterMarkTextBox(CorpsTextBox, "Корпус");
            Functions.SetWaterMarkTextBox(BuildTextBox, "Строение");
            Functions.SetWaterMarkTextBox(RoomCountTextBox, "Количество комнат");
            Functions.SetWaterMarkTextBox(BedsCountTextBox, "Количество мест");
            Functions.SetWaterMarkTextBox(EmailNameTextBox0, "Имя электронной почты заказчика");
            Functions.SetWaterMarkTextBox(EmailTextBox0, "Электронная почта заказчика");

            // Установка ограничений для текстовых полей.
            Functions.OnlyNumbersInTextBox(INNTextBox);
            Functions.OnlyNumbersInTextBox(OGRNTextBox);
            Functions.OnlyNumbersInTextBox(BedsCountTextBox);
            Functions.OnlyNumbersInTextBox(CardCountTextBox);
            Functions.OnlyNumbersInTextBox(RoomCountTextBox);

            // Установка подсказок обязательных полей.
            ErrorProvider.SetError(NameTextBox, "* - обязательное поле");
            ErrorProvider.SetError(ContractNumberTextBox, "* - обязательное поле");
            ErrorProvider.SetError(ToContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(FromContractTime_Customer_DateTimePicker, "* - обязательное поле");
            ErrorProvider.SetError(LocationNameTextBox, "* - обязательное поле");
            ErrorProvider.SetError(RoomCountTextBox, "* - обязательное поле");
            ErrorProvider.SetError(BedsCountTextBox, "* - обязательное поле");
            EmailNamesErrorProvider.SetError(EmailNameTextBox0, "* - обязательное поле");
            EmailsErrorProvider.SetError(EmailTextBox0, "* - обязательное поле");

            EmailNameTextBox0.Leave += new EventHandler(EmailNameTextBox_Leave);
            EmailTextBox0.Leave += new EventHandler(EmailTextBox_Leave);

            LoadLocationsData();
        }

        /// <summary>
        /// Обработка окончания редактирования поля с эл.почтой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TextBox lastTextBox = EmailsPanel.Controls[EmailsPanel.Controls.Count - 1] as TextBox;

            
            if (lastTextBox.Name == textBox.Name && textBox.Text.Trim().Length > 0 && textBox.Text != textBox.Tag.ToString()) // Если введёно имя эл.почты.
            {
                // TODO: Сделать проверку эл.почты по регулярным выражениям.
                if (true)
                {
                    EmailsErrorProvider.Clear();
                }
            }
        }

        /// <summary>
        /// Обработка окончания редактирования поля с именем эл.почты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailNameTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TextBox lastTextBox = EmailNamesPanel.Controls[EmailNamesPanel.Controls.Count - 1] as TextBox;

            if (lastTextBox.Name == textBox.Name && textBox.Text.Trim().Length > 0 && textBox.Text != textBox.Tag.ToString()) // Если введёно имя эл.почты в последнее поле.
            {
                EmailNamesErrorProvider.Clear();
            }
        }

        /// <summary>
        /// Заполнение данных локаций.
        /// </summary>
        private void LoadLocationsData()
        {
            MySqlCommand select = new MySqlCommand("Select name FROM region", Functions.Connection);
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
            select.Cancel();
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
                            /*&& EmailTextBox.TextLength > 0 && EmailTextBox.Text != "Электронная почта заказчика"*/) // Если все обязательные поля заполнены корректно.
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
            // TODO: Сделать проверку заполнения всех обязательных полей.
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

            CustomerInfoButton.BackgroundImage = Properties.Resources.GrayCircle;
            CustomerInfoButton.ForeColor = Color.Black;

            AddLocationsButton.BackgroundImage = Properties.Resources.BlueCircle;
            AddLocationsButton.ForeColor = Color.White;

            CardPropertiesButton.BackgroundImage = Properties.Resources.GrayCircle;
            CardPropertiesButton.ForeColor = Color.Black;
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

            CustomerInfoButton.BackgroundImage = Properties.Resources.GrayCircle;
            CustomerInfoButton.ForeColor = Color.Black;

            AddLocationsButton.BackgroundImage = Properties.Resources.GrayCircle;
            AddLocationsButton.ForeColor = Color.Black;

            CardPropertiesButton.BackgroundImage = Properties.Resources.BlueCircle;
            CardPropertiesButton.ForeColor = Color.White;
        }

        /// <summary>
        /// Отображение панели с данными заказчика.
        /// </summary>
        private void OpenCustomerInfoPanel()
        {
            CustomerInfoPanel.Visible = true;
            AddCustomerLocationPanel.Visible = false;
            CardPropertiesPanel.Visible = false;

            CustomerInfoButton.BackgroundImage = Properties.Resources.BlueCircle;
            CustomerInfoButton.ForeColor = Color.White;

            AddLocationsButton.BackgroundImage = Properties.Resources.GrayCircle;
            AddLocationsButton.ForeColor = Color.Black;

            CardPropertiesButton.BackgroundImage = Properties.Resources.GrayCircle;
            CardPropertiesButton.ForeColor = Color.Black;
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            AddLocation();
        }

        private void AddLocation()
        {
            // TODO: Проверка заполнения обязательных полей.
            int lastRow = LocationsDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible);
            LocationsDataGridView.Rows.Add(lastRow + 2, LocationNameTextBox.Text);
        }

        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            OpenCustomerInfoPanel();
        }

        private void AddLocationsButton_Click(object sender, EventArgs e)
        {
            OpenAddCustomerLocationPanel();
        }

        private void CardPropertiesButton_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void Set1HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В \"Комплект-1\" входит:\nНаволочка, подушка, одеяло, пододеяльник.", "Комплект-1", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Set2HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В \"Комплект-2\" входит:\nПростыня, подушка, одеяло.", "Комплект-2", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddLocation();
        }

        private void AddEmailButton_Click(object sender, EventArgs e)
        {
            TextBox lastEmailNameTextBox = EmailNamesPanel.Controls[EmailNamesPanel.Controls.Count - 1] as TextBox;
            TextBox lastEmailTextBox = EmailsPanel.Controls[EmailsPanel.Controls.Count - 1] as TextBox;

            if (lastEmailNameTextBox.Text != lastEmailNameTextBox.Tag.ToString() && lastEmailTextBox.Text != lastEmailTextBox.Tag.ToString())
            {
                TextBox emailNameTextBox = new TextBox();
                emailNameTextBox.Size = EmailNameTextBox0.Size;
                emailNameTextBox.Location = new Point(0, EmailsCount * 27);
                emailNameTextBox.Name = $"EmailNameTextBox{EmailsCount}";
                EmailNamesPanel.Controls.Add(emailNameTextBox);

                TextBox emailTextBox = new TextBox();
                emailTextBox.Size = EmailTextBox0.Size;
                emailTextBox.Location = new Point(0, EmailsCount * 27);
                emailTextBox.Name = $"EmailTextBox{EmailsCount}";
                EmailsPanel.Controls.Add(emailTextBox);

                Functions.SetWaterMarkTextBox(emailNameTextBox, "Имя электронной почты");
                Functions.SetWaterMarkTextBox(emailTextBox, "Электронная почта заказчика");

                EmailNamesErrorProvider.SetError(emailNameTextBox, "* - обязательное поле");
                EmailsErrorProvider.SetError(emailTextBox, "* - обязательное поле");

                emailNameTextBox.Leave += new EventHandler(EmailNameTextBox_Leave);
                emailTextBox.Leave += new EventHandler(EmailTextBox_Leave);

                EmailsCount++;
            }
        }
    }
}