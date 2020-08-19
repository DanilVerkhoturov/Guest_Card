using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddCustomer : Form
    {
        private static long LocationId = 0;
        private static int EmailsCount = 1;

        public AddCustomer()
        {
            InitializeComponent();

            OpenCustomerInfoPanel();

            // Установка подсказок в текстовых полях.
            Functions.SetPlaceholderTextBox(NameTextBox, "Наименование организации");
            Functions.SetPlaceholderTextBox(ContractNumberTextBox, "Номер договора");
            Functions.SetPlaceholderTextBox(LocationNameTextBox, "Название локации");
            Functions.SetPlaceholderTextBox(RoomCountTextBox, "Количество комнат");
            Functions.SetPlaceholderTextBox(BedsCountTextBox, "Количество мест");
            Functions.SetPlaceholderTextBox(EmailNameTextBox0, "Имя заказчика");
            Functions.SetPlaceholderTextBox(EmailTextBox0, "Электронная почта заказчика");
            Functions.SetPlaceholderTextBox(SubDivisionNameTextBox, "Наименование организации");
            Functions.SetPlaceholderTextBox(SubDivisionEmailNameTextBox0, "Имя заказчика");
            Functions.SetPlaceholderTextBox(SubDivisionEmailTextBox0, "Электронная почта");

            // Установка подсказки для полей с датами.
            Functions.SetPlaceholderDateTimePicker(FromContractTimeDateTimePicker, "Введите дату");
            Functions.SetPlaceholderDateTimePicker(ToContractTimeDateTimePicker, "Введите дату");

            //Functions.NewlineProcessing(RoomsDataGridView, new string[] { "1", "Номер комнаты", "Количество спальных мест", null });

            // Установка ограничений для текстовых полей.
            Functions.OnlyNumbersInTextBox(CardCountTextBox);
            Functions.OnlyNumbersInTextBox(RoomCountTextBox);
            Functions.OnlyNumbersInTextBox(BedsCountTextBox);

            // Установка подсказок обязательных полей.
            //NameErrorProvider.SetError(NameTextBox, "* - обязательное поле");
            //NameErrorProvider.SetIconPadding(NameTextBox, 10);
            //ContractNumberErrorProvider.SetError(ContractNumberTextBox, "* - обязательное поле");
            //ContractNumberErrorProvider.SetIconPadding(ContractNumberTextBox, 10);
            //ToContractTimeErrorProvider.SetError(ToContractTimeDateTimePicker, "* - обязательное поле");
            //ToContractTimeErrorProvider.SetIconPadding(ToContractTimeDateTimePicker, 10);
            //FromContractTimeErrorProvider.SetError(FromContractTimeDateTimePicker, "* - обязательное поле");
            //FromContractTimeErrorProvider.SetIconPadding(FromContractTimeDateTimePicker, 10);
            //LocationNameErrorProvider.SetError(LocationNameTextBox, "* - обязательное поле");
            //LocationNameErrorProvider.SetIconPadding(LocationNameTextBox, 10);
            //RoomCountErrorProvider.SetError(RoomCountTextBox, "* - обязательное поле");
            //RoomCountErrorProvider.SetIconPadding(RoomCountTextBox, 10);
            //BedsCountErrorProvider.SetError(BedsCountTextBox, "* - обязательное поле");
            //BedsCountErrorProvider.SetIconPadding(BedsCountTextBox, 10);
            //EmailNamesErrorProvider.SetError(EmailNameTextBox0, "* - обязательное поле");
            //EmailNamesErrorProvider.SetIconPadding(EmailNameTextBox0, 10);
            //EmailsErrorProvider.SetError(EmailTextBox0, "* - обязательное поле");
            //EmailsErrorProvider.SetIconPadding(EmailTextBox0, 10);
            //SubDivisionNameErrorProvider.SetError(SubDivisionNameTextBox, "* - обязательное поле");
            //SubDivisionNameErrorProvider.SetIconPadding(SubDivisionNameTextBox, 10);
            //SubDivisionEmailNameErrorProvider.SetError(SubDivisionEmailNameTextBox0, "* - обязательное поле");
            //SubDivisionEmailNameErrorProvider.SetIconPadding(SubDivisionEmailNameTextBox0, 10);
            //SubDivisionEmailErrorProvider.SetError(SubDivisionEmailTextBox0, "* - обязательное поле");
            //SubDivisionEmailErrorProvider.SetIconPadding(SubDivisionEmailTextBox0, 10);
        }

        #region Данные заказчика

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным полем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim().Length > 0 && NameTextBox.Text != NameTextBox.Tag.ToString()) // Если в текстовом поле есть текст, который не является подсказкой.
            {
                NameErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                NameErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным полем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (ContractNumberTextBox.Text.Trim().Length > 0 && ContractNumberTextBox.Text != ContractNumberTextBox.Tag.ToString()) // Если в текстовом поле есть текст, который не является подсказкой.
            {
                ContractNumberErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                ContractNumberErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным полем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromContractTimeDateTimePicker_Leave(object sender, EventArgs e)
        {
            if (FromContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && FromContractTimeDateTimePicker.Value != FromContractTimeDateTimePicker.MinDate
                && FromContractTimeDateTimePicker.Value < ToContractTimeDateTimePicker.Value) // Если в поле введена корректная дата, то удаляем обозначение заполнения.
            {
                FromContractTimeErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else if(FromContractTimeDateTimePicker.Value >= ToContractTimeDateTimePicker.Value)
            {
                FromContractTimeErrorProvider.Icon = Properties.Resources.exclamation_mark;
                MessageBox.Show("Дата начала срока договора должна быть меньше окончания срока договора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FromContractTimeErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }

            if (ToContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && ToContractTimeDateTimePicker.Value != ToContractTimeDateTimePicker.MinDate
                && FromContractTimeDateTimePicker.Value < ToContractTimeDateTimePicker.Value) // Если в поле введена корректная дата, то удаляем обозначение заполнения.
            {
                ToContractTimeErrorProvider.Icon = Properties.Resources.check_mark;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным полем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToContractTimeDateTimePicker_Leave(object sender, EventArgs e)
        {
            if (ToContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && ToContractTimeDateTimePicker.Value != ToContractTimeDateTimePicker.MinDate
                && FromContractTimeDateTimePicker.Value < ToContractTimeDateTimePicker.Value) // Если в поле введена корректная дата, то удаляем обозначение заполнения.
            {
                ToContractTimeErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else if(FromContractTimeDateTimePicker.Value >= ToContractTimeDateTimePicker.Value)
            {
                ToContractTimeErrorProvider.Icon = Properties.Resources.exclamation_mark;
                MessageBox.Show("Дата начала срока договора должна быть меньше окончания срока договора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ToContractTimeErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }

            if (FromContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && FromContractTimeDateTimePicker.Value != FromContractTimeDateTimePicker.MinDate
                && FromContractTimeDateTimePicker.Value < ToContractTimeDateTimePicker.Value) // Если в поле введена корректная дата, то удаляем обозначение заполнения.
            {
                FromContractTimeErrorProvider.Icon = Properties.Resources.check_mark;
            }
        }

        /// <summary>
        /// Обработка окончания редактирования поля с эл.почтой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength > 0 && textBox.Text != textBox.Tag.ToString() && RegexUtilities.IsValidEmail(textBox.Text.Trim()))
            {
                EmailsErrorProvider.Clear();
            }
            else if (textBox.TextLength > 0 && textBox.Text != textBox.Tag.ToString())
            {
                MessageBox.Show($"Электронная почта \"{textBox.Text}\" введена некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailsErrorProvider.SetError(textBox, "* - обязательное поле");
                EmailsErrorProvider.SetIconPadding(textBox, 10);
                textBox.Focus();
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

            if (textBox.Text.Trim().Length > 0 && textBox.Text != textBox.Tag.ToString()) // Если введёно имя эл.почты в последнее поле.
            {
                EmailNamesErrorProvider.Clear();
            }
            else
            {
                EmailNamesErrorProvider.SetError(textBox, "* - обязательное поле");
                EmailNamesErrorProvider.SetIconPadding(textBox, 10);
            }
        }

        /// <summary>
        /// Обработка события нажатия на ссылочную надпись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEmailsFields(EmailsPanel, AddEmailLinkLabel);
        }

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerInfoNextButton_Click(object sender, EventArgs e)
        {
            CheckAndAddCustomerInfo();
        }

        private void CheckAndAddCustomerInfo()
        {
            TextBox lastEmailNameTextBox = EmailsPanel.Controls[EmailsPanel.Controls.Count - 2] as TextBox;
            TextBox lastEmailTextBox = EmailsPanel.Controls[EmailsPanel.Controls.Count - 1] as TextBox;

            if (NameTextBox.TextLength > 0 && NameTextBox.Text.Trim() != NameTextBox.Tag.ToString()
                && ContractNumberTextBox.TextLength > 0 && ContractNumberTextBox.Text.Trim() != ContractNumberTextBox.Tag.ToString()
                && FromContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && ToContractTimeDateTimePicker.Format == DateTimePickerFormat.Short
                && FromContractTimeDateTimePicker.Value < ToContractTimeDateTimePicker.Value
                && lastEmailNameTextBox.TextLength > 0 && lastEmailNameTextBox.Text.Trim() != lastEmailNameTextBox.Tag.ToString()
                && RegexUtilities.IsValidEmail(lastEmailTextBox.Text.Trim())) // Проверка заполнения всех обязательных полей на первом шаге.
            {
                if (Customer.Add(NameTextBox.Text, ContractNumberTextBox.Text, FromContractTimeDateTimePicker.Value, ToContractTimeDateTimePicker.Value) >= 0)
                {
                    for (int i = 1; i <= EmailsPanel.Controls.Count - 2; i += 2)
                    {
                        string emailName = EmailsPanel.Controls[i].Text;
                        string email = EmailsPanel.Controls[i + 1].Text;

                        Customer.AddEmail(emailName, email);
                    }

                    OpenSubDivisionsPanel();
                    SubDivisionsButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerInfoButton_Click(object sender, EventArgs e)
        {
            OpenCustomerInfoPanel();
        }

        /// <summary>
        /// Отображение панели с данными заказчика.
        /// </summary>
        private void OpenCustomerInfoPanel()
        {
            CustomerInfoPanel.Visible = true;
            SubDivisionsPanel.Visible = false;
            AddCustomerLocationPanel.Visible = false;

            CustomerInfoButton.BackgroundImage = Properties.Resources.BlueCircle;
            CustomerInfoButton.ForeColor = Color.White;

            SubDivisionsButton.BackgroundImage = Properties.Resources.GrayCircle;
            SubDivisionsButton.ForeColor = Color.Black;

            AddLocationsButton.BackgroundImage = Properties.Resources.GrayCircle;
            AddLocationsButton.ForeColor = Color.Black;
        }

        #endregion

        #region Данные подрядных организаций заказчика

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionsNextButton_Click(object sender, EventArgs e)
        {
            if (CheckSubDivisionInfo())
            {
                AddSubDivision();
            }

            if (SubDivisionsDataGridView.Rows.Count > 0)
            {
                OpenAddCustomerLocationPanel();
            }
            else
            {
                MessageBox.Show("Вы должны добавить хотя бы одну подрядную организацию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionsButton_Click(object sender, EventArgs e)
        {
            OpenSubDivisionsPanel();
        }

        /// <summary>
        /// Отображение панели с добавлением подрядных организаций заказчика.
        /// </summary>
        private void OpenSubDivisionsPanel()
        {
            CustomerInfoPanel.Visible = false;
            SubDivisionsPanel.Visible = true;
            AddCustomerLocationPanel.Visible = false;

            CustomerInfoButton.BackgroundImage = Properties.Resources.GrayCircle;
            CustomerInfoButton.ForeColor = Color.Black;

            SubDivisionsButton.BackgroundImage = Properties.Resources.BlueCircle;
            SubDivisionsButton.ForeColor = Color.White;

            AddLocationsButton.BackgroundImage = Properties.Resources.GrayCircle;
            AddLocationsButton.ForeColor = Color.Black;
        }

        /// <summary>
        /// Обработка события нажатия на ссылочную надпись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubDivisionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckSubDivisionInfo())
            {
                AddSubDivision();
            }
        }

        /// <summary>
        /// Проверить заполнение информации подрядной организации.
        /// </summary>
        /// <returns>Возвращает результат проверки заполнения информации.</returns>
        private bool CheckSubDivisionInfo()
        {
            if (SubDivisionNameTextBox.TextLength > 0 && SubDivisionNameTextBox.Text != SubDivisionNameTextBox.Tag.ToString()
                            && SubDivisionEmailNameTextBox0.TextLength > 0 && SubDivisionEmailNameTextBox0.Text != SubDivisionEmailNameTextBox0.Tag.ToString()
                            && SubDivisionEmailTextBox0.TextLength > 0 && SubDivisionEmailTextBox0.Text != SubDivisionEmailTextBox0.Tag.ToString()
                            && RegexUtilities.IsValidEmail(SubDivisionEmailTextBox0.Text.Trim())) // Если заполнены все обязательные поля и эл.почта введена корректно.
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Добавить подрядную организацию.
        /// </summary>
        private void AddSubDivision()
        {
            if (Customer.FindSubDivision(SubDivisionNameTextBox.Text, out long subDivisionId)) // Если такая подрядная организация уже есть в базе.
            {
                // TODO: Сделать обновление данных подрядной организации.
                MessageBox.Show("Такая подрядная организация уже создана. Функционал обновления данных скоро будет реализован.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Если подрядной организации нет в БД.
            {
                subDivisionId = Customer.AddSubDivision(SubDivisionNameTextBox.Text);
                Customer.AddEmail(subDivisionId, SubDivisionEmailNameTextBox0.Text, SubDivisionEmailTextBox0.Text);

                SubDivisionsDataGridView.DataSource = Customer.GetAllSubdivisions();

                SubDivisionNameTextBox.Text = SubDivisionNameTextBox.Tag.ToString();
                SubDivisionNameTextBox.ForeColor = Color.Silver;

                SubDivisionEmailNameTextBox0.Text = SubDivisionEmailNameTextBox0.Tag.ToString();
                SubDivisionEmailNameTextBox0.ForeColor = Color.Silver;
                SubDivisionEmailNameErrorProvider.Icon = Properties.Resources.exclamation_mark;

                SubDivisionEmailTextBox0.Text = SubDivisionEmailTextBox0.Tag.ToString();
                SubDivisionEmailTextBox0.ForeColor = Color.Silver;
                SubDivisionEmailErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события изменения текста в текстовом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SubDivisionNameTextBox.TextLength > 0 && SubDivisionNameTextBox.Text != SubDivisionNameTextBox.Tag.ToString())
            {
                SubDivisionNameErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                SubDivisionNameErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionEmailNameTextBox0_Leave(object sender, EventArgs e)
        {
            if (SubDivisionEmailNameTextBox0.Text.Trim().Length > 0 && SubDivisionEmailNameTextBox0.Text != SubDivisionEmailNameTextBox0.Tag.ToString()) // Если введёно имя эл.почты.
            {
                SubDivisionEmailNameErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                SubDivisionEmailNameErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionEmailTextBox0_Leave(object sender, EventArgs e)
        {
            if (SubDivisionEmailTextBox0.TextLength > 0 && SubDivisionEmailTextBox0.Text != SubDivisionEmailTextBox0.Tag.ToString() && RegexUtilities.IsValidEmail(SubDivisionEmailTextBox0.Text.Trim()))
            {
                SubDivisionEmailErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else if (SubDivisionEmailTextBox0.TextLength > 0 && SubDivisionEmailTextBox0.Text != SubDivisionEmailTextBox0.Tag.ToString())
            {
                MessageBox.Show($"Электронная почта \"{SubDivisionEmailTextBox0.Text}\" введена некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubDivisionEmailErrorProvider.Icon = Properties.Resources.exclamation_mark;
                SubDivisionEmailTextBox0.Focus();
            }
        }

        /// <summary>
        /// Обработка движения мыши в ячейке таблицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDivisionsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 4)
            {
                SubDivisionsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                SubDivisionsDataGridView.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Добавить локацию

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLocationsButton_Click(object sender, EventArgs e)
        {
            OpenAddCustomerLocationPanel();
        }

        /// <summary>
        /// Отображение панели с добавлением локаций заказчика.
        /// </summary>
        private void OpenAddCustomerLocationPanel()
        {
            CustomerInfoPanel.Visible = false;
            SubDivisionsPanel.Visible = false;
            AddCustomerLocationPanel.Visible = true;

            CustomerInfoButton.BackgroundImage = Properties.Resources.GrayCircle;
            CustomerInfoButton.ForeColor = Color.Black;

            SubDivisionsButton.BackgroundImage = Properties.Resources.GrayCircle;
            SubDivisionsButton.ForeColor = Color.Black;

            AddLocationsButton.BackgroundImage = Properties.Resources.BlueCircle;
            AddLocationsButton.ForeColor = Color.White;
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
                                Hotels.EditRoom(roomId, roomName, bedsCount);
                            }
                            else
                            {
                                Hotels.AddRoom(hotelId, roomName, bedsCount);
                            }
                        }

                        LocationsDataGridView.DataSource = Hotels.GetAll();

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

        /// <summary>
        /// Проверка заполнения данных в добавленных комнатах.
        /// </summary>
        /// <returns>True - если все данные заполнены. False - если есть незаполненные области.</returns>
        private bool CheckRoomsData()
        {
            // Проверка заполнения всех видимых ячеек.
            for (int i = 0; i < RoomsDataGridView.Rows.Count; i++)
            {
                try
                {
                    // Если в ячейке нет данных или написан текст подсказки.
                    if (RoomsDataGridView[1, i].Value == null
                        || RoomsDataGridView[1, i].Value.ToString().Trim().ToLower() == RoomsDataGridView.Columns[1].ToolTipText.ToLower()
                        || RoomsDataGridView[2, i].Value == null
                        || RoomsDataGridView[2, i].Value.ToString().Trim().ToLower() == RoomsDataGridView.Columns[2].ToolTipText.ToLower()
                        || !int.TryParse(RoomsDataGridView[2, i].Value.ToString().Trim().ToLower(), out int bedsCount))
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
        /// Обработка события изменения текста в текстовом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocationNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LocationNameTextBox.TextLength > 0 && LocationNameTextBox.Text != LocationNameTextBox.Tag.ToString())
            {
                LocationNameErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                LocationNameErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события изменения текста в текстовом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RoomCountTextBox.TextLength > 0 && RoomCountTextBox.Text != RoomCountTextBox.Tag.ToString())
            {
                RoomCountErrorProvider.Icon = Properties.Resources.check_mark;
            }
            else
            {
                RoomCountErrorProvider.Icon = Properties.Resources.exclamation_mark;
            }
        }

        /// <summary>
        /// Обработка события изменения текста в текстовом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BedsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BedsCountTextBox.TextLength > 0 && BedsCountTextBox.Text != BedsCountTextBox.Tag.ToString() && int.TryParse(BedsCountTextBox.Text, out int bedsCount))
            {
                BedsCountErrorProvider.Icon = Properties.Resources.check_mark;

                CardCountTextBox.Text = (((bedsCount * 10) / 100) + bedsCount).ToString(); // Расчёт количества карт по формуле: количество мест + 10%.
            }
            else
            {
                BedsCountErrorProvider.Icon = Properties.Resources.exclamation_mark;
                CardCountTextBox.Text = "0";
            }
        }

        /// <summary>
        /// Обработка нажатия на ссылочную надпись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Отобразить панель с добавлением комнат.
        /// </summary>
        private void VisibleAddRooms()
        {
            AddCustomerLocationPanel.Focus();
            if (RoomsDataGridView.DataSource == null)
            {
                RoomsDataGridView.Rows.Clear();
            }
            else
            {
                RoomsDataGridView.DataSource = null;
            }

            if (LocationNameTextBox.TextLength > 0 && LocationNameTextBox.Text != LocationNameTextBox.Tag.ToString()
                && RoomCountTextBox.TextLength > 0 && RoomCountTextBox.Text != RoomCountTextBox.Tag.ToString()
                && BedsCountTextBox.TextLength > 0 && BedsCountTextBox.Text != BedsCountTextBox.Tag.ToString()) // Если заполнены все обязательные поля.
            {
                for (int i = 0; i < Convert.ToInt32(RoomCountTextBox.Text); i++)
                {
                    int row = RoomsDataGridView.Rows.Add();
                    RoomsDataGridView[1, row].ErrorText = "* - обязательное поле";
                    RoomsDataGridView[2, row].ErrorText = "* - обязательное поле";
                    RoomsDataGridView[3, row].Value = LocationId;
                }

                AddRoomsLabel.Visible = true;
                RoomsDataGridView.Visible = true;
            }
        }

        /// <summary>
        /// Обработка окончания редактирования ячейки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Если закончилось редактирование не первого столбца (номер строки) и в ячейке нет текста, или есть текст, который является подсказкой.
            if (e.ColumnIndex != 0 && (RoomsDataGridView[e.ColumnIndex, e.RowIndex].Value == null || (RoomsDataGridView[e.ColumnIndex, e.RowIndex].Value != null
                && (RoomsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString().Trim() == RoomsDataGridView.Columns[e.ColumnIndex].ToolTipText || !int.TryParse(RoomsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out int count)))))
            {
                RoomsDataGridView[e.ColumnIndex, e.RowIndex].ErrorText = "* - обязательное поле";
            }
            else
            {
                RoomsDataGridView[e.ColumnIndex, e.RowIndex].ErrorText = null;
            }
        }

        /// <summary>
        /// Обработка события, когда текстовое поле перестаёт быть активным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocationNameTextBox_Leave(object sender, EventArgs e)
        {
            VisibleAddRooms();
        }

        /// <summary>
        /// Обработка движения мыши в ячейке таблицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (LocationsDataGridView.Columns[e.ColumnIndex].Name == "LocationName" || LocationsDataGridView.Columns[e.ColumnIndex].Name == "DeleteLocation")
            {
                LocationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                LocationsDataGridView.Cursor = Cursors.Default;
            }
        }

        private void LocationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Если была нажата ссылка с именем локации.
            if (LocationsDataGridView.Columns[e.ColumnIndex].Name == "LocationName")
            {
                // Получение информации о локации.
                Hotels.Id = Convert.ToInt64(LocationsDataGridView["hotel_id", e.RowIndex].Value);
                Hotels.FillInfo();

                //RoomsDataGridView.Rows.Clear();

                // Заполнение полей информацией о локации.
                LocationName.Text = Locations.Name;
                RoomCountTextBox.Text = Hotels.RoomCount.ToString();
                BedsCountTextBox.Text = Hotels.BedsCount.ToString();
                CardCountTextBox.Text = Hotels.CardsCount.ToString();
                RoomsDataGridView.DataSource = Hotels.GetRooms();
                RoomsDataGridView.Columns["RoomNumber"].ValueType = Type.GetType("System.String");
                RoomsDataGridView.Columns["roomid"].ValueType = Type.GetType("System.String");
                RoomsDataGridView.Columns["BedsCount"].ValueType = Type.GetType("System.String");
            }
        }

        #endregion

        /// <summary>
        /// Добавить поля электронных почт.
        /// </summary>
        /// <param name="emailsPanel">Панель, на которой находятся поля электронной почты.</param>
        /// <param name="activateButton">Кнопка, которой активировали создание полей.</param>
        private void AddEmailsFields(Panel emailsPanel, LinkLabel activateButton)
        {
            TextBox lastEmailTextBox = emailsPanel.Controls[emailsPanel.Controls.Count - 1] as TextBox;
            TextBox lastEmailNameTextBox = emailsPanel.Controls[emailsPanel.Controls.Count - 2] as TextBox;

            if (lastEmailNameTextBox.Text != lastEmailNameTextBox.Tag.ToString() && lastEmailTextBox.Text != lastEmailTextBox.Tag.ToString())
            {
                TextBox emailNameTextBox = new TextBox();
                emailNameTextBox.Size = lastEmailNameTextBox.Size;
                emailNameTextBox.Margin = lastEmailNameTextBox.Margin;
                emailNameTextBox.Location = new Point(0, lastEmailNameTextBox.Location.Y + lastEmailNameTextBox.Size.Height + lastEmailNameTextBox.Margin.Top);
                emailNameTextBox.Name = $"EmailNameTextBox{EmailsCount}";
                emailsPanel.Controls.Add(emailNameTextBox);

                TextBox emailTextBox = new TextBox();
                emailTextBox.Size = lastEmailTextBox.Size;
                emailTextBox.Margin = lastEmailTextBox.Margin;
                emailTextBox.Location = new Point(lastEmailTextBox.Location.X, lastEmailTextBox.Location.Y + lastEmailTextBox.Size.Height + lastEmailTextBox.Margin.Top);
                emailTextBox.Name = $"EmailTextBox{EmailsCount}";
                emailsPanel.Controls.Add(emailTextBox);

                Functions.SetPlaceholderTextBox(emailNameTextBox, lastEmailNameTextBox.Tag.ToString());
                Functions.SetPlaceholderTextBox(emailTextBox, lastEmailTextBox.Tag.ToString());

                EmailNamesErrorProvider.SetError(emailNameTextBox, "* - обязательное поле");
                EmailNamesErrorProvider.SetIconPadding(emailNameTextBox, 10);
                EmailsErrorProvider.SetError(emailTextBox, "* - обязательное поле");
                EmailsErrorProvider.SetIconPadding(emailTextBox, 10);

                emailNameTextBox.Leave += new EventHandler(EmailNameTextBox_Leave);
                emailTextBox.Leave += new EventHandler(EmailTextBox_Leave);

                activateButton.Location = new Point(activateButton.Location.X, activateButton.Location.Y + lastEmailNameTextBox.Margin.Top + lastEmailNameTextBox.Size.Height);

                EmailsCount++;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
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
                    DialogResult dialogResult = MessageBox.Show("Заполнены не все поля, введённые данные будут утеряны! Завершить добавление заказчика?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes) // Если добавление заказчика завершено.
                    {
                        MainForm.SubMenuProcessing(MainForm.MyCustomersBtn, MainForm.CustomersBtn, MainForm.CustomersP);
                        Functions.OpenChildForm(new CustomersForm(), MainForm.ContP);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}