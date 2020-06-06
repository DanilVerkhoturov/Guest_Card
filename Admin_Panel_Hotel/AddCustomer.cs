using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddCustomer : System.Windows.Forms.Form
    {
        public AddCustomer()
        {
            InitializeComponent();
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

        private void Name_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            Name_Customer_TextBox.Text = null;
        }

        private void Address_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            Address_Customer_TextBox.Text = null;
        }

        private void INN_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            INN_Customer_TextBox.Text = null;
        }

        private void OGRN_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            OGRN_Customer_TextBox.Text = null;
        }

        private void ContractNumber_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            ContractNumber_Customer_TextBox.Text = null;
        }

        private void Location_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            Location_Customer_TextBox.Text = null;
        }

        private void Email_Customer_TextBox_Enter(object sender, EventArgs e)
        {
            Email_Customer_TextBox.Text = null;
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
    }
}
