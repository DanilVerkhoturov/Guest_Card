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
            Functions.SetWaterMark(Location_Customer_TextBox, "Локация");
            Functions.SetWaterMark(Email_Customer_TextBox, "Электронная почта заказчика");
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
                            && Location_Customer_TextBox.TextLength > 0 && Location_Customer_TextBox.Text != "Локация"
                            && Email_Customer_TextBox.TextLength > 0 && Email_Customer_TextBox.Text != "Электронная почта заказчика") // Если все обязательные поля заполнены корректно.
            {
                // TODO: Проверка корректности эл.почты и срока договора.
                return true;
            }
            else // Если какое-либо или все обязательные поля незаполнены.
            {
                return false;
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // Установка подсказки для первого комплекта белья.
            ToolTip set1Help = new ToolTip();
            set1Help.SetToolTip(Set1Help_Customer_Button, "В \"Комплект-1\" входит:\nНаволочка, подушка, одеяло, пододеяльник.");

            // Установка подсказки для второго комплекта белья.
            ToolTip set2Help = new ToolTip();
            set2Help.SetToolTip(Set2Help_Customer_Button, "В \"Комплект-2\" входит:\nПростыня, подушка, одеяло.");
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            // Открытие формы добавления локации
            var addLocation = new AddLocationFrom();
            addLocation.Owner = this;
            addLocation.StartPosition = FormStartPosition.CenterParent;
            addLocation.ShowDialog();
        }
    }
}
