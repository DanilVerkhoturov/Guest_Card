using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class SubDivisionInfo : Form
    {
        public SubDivisionInfo()
        {
            InitializeComponent();

            Customer.SubDivision.FillInfo();

            NameTextBox.Text = Customer.SubDivision.Name;
            EmailNameTextBox.Text = Customer.SubDivision.EmailName;
            EmailTextBox.Text = Customer.SubDivision.Email;

            CustomerSubDivisionNameLabel.Text = $"Мои заказчики > {Customer.Name} > {Customer.SubDivision.Name}";
        }

        private void CustomerSubDivisionNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
        }

        /// <summary>
        /// Отображение панели с изменением данных локации.
        /// </summary>
        private void OpenSubDuvisionInfoPanel()
        {
            SubDivisionInfoPanel.Visible = true;
            CardPropertiesPanel.Visible = false;
            AllCardPropertiesPanel.Visible = false;

            SubDivisionDataLabel.ForeColor = MyColors._00A0E3();

            CardPropertiesLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// Отображение панели с изменением свойств карт локации.
        /// </summary>
        private void OpenCardPropertiesPanel()
        {
            SubDivisionInfoPanel.Visible = false;
            CardPropertiesPanel.Visible = true;
            AllCardPropertiesPanel.Visible = true;

            SubDivisionDataLabel.ForeColor = Color.Black;

            CardPropertiesLabel.ForeColor = MyColors._00A0E3();
        }

        private void EditCardPropertiesButton_Click(object sender, EventArgs e)
        {
            SaveCardPropertiesButton.Visible = true;
            EditCardPropertiesButton.Visible = false;
        }

        private void CardPropertiesLabel_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void SubDivisionDataLabel_Click(object sender, EventArgs e)
        {
            OpenSubDuvisionInfoPanel();
        }

        private void EditNameButton_Click(object sender, EventArgs e)
        {
            EditNameButton.Visible = false;
            EditNameTipLabel.Visible = true;
            SaveSubDivisionInfoButton.Visible = true;
            NameTextBox.ReadOnly = false;
        }

        private void EditEmailNameButton_Click(object sender, EventArgs e)
        {
            EditEmailNameButton.Visible = false;
            EditEmailTipLabel.Visible = true;
            SaveSubDivisionInfoButton.Visible = true;
            EmailNameTextBox.ReadOnly = false;
        }

        private void EditEmailButton_Click(object sender, EventArgs e)
        {
            EditEmailButton.Visible = false;
            EditEmailTipLabel.Visible = true;
            SaveSubDivisionInfoButton.Visible = true;
            EmailTextBox.ReadOnly = false;
        }

        private void SaveSubDivisionInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку заполнения всех полей.
            if (true)
            {
                // TODO: Сделать обновление данных в БД.
            }
        }

        private void SaveCardPropertiesButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать добавление пакета свойств.
        }
    }
}
