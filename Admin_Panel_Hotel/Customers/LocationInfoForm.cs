using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class LocationInfoForm : Form
    {
        /// <summary>
        /// Название локации.
        /// </summary>
        public static string LocationName;
        /// <summary>
        /// Уникальный идентификатор локации.
        /// </summary>
        public static long LocationId;
        /// <summary>
        /// Название выбранного заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Уникальный номер выбранного заказчика.
        /// </summary>
        public static long CustomerId;

        public LocationInfoForm()
        {
            InitializeComponent();

            CustomerLocationNameLabel.Text = $"Мои заказчики > {CustomerName} > {LocationName}";
        }

        private void EditNameButton_Click(object sender, System.EventArgs e)
        {
            EditNameButton.Visible = false;
            NameTextBox.Enabled = true;
            NameHelpLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void CustomerLocationNameLabel_Click(object sender, System.EventArgs e)
        {
            CustomerInfoForm.CustomerName = CustomerName;
            CustomerInfoForm.CustomerId = CustomerId;
            Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
        }

        private void EditRoomBedsCountButton_Click(object sender, System.EventArgs e)
        {
            EditRoomBedsCountButton.Visible = false;
            RoomCountTextBox.Enabled = true;
            BedsCountTextBox.Enabled = true;
            RoomBedsCountHelpLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void EditCardsCountButton_Click(object sender, System.EventArgs e)
        {
            EditCardsCountButton.Visible = false;
            CardsCountTextBox.Enabled = true;
            CardsCountHelpLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void EditRoomsButton_Click(object sender, System.EventArgs e)
        {
            EditRoomsButton.Visible = false;
            RoomsDataGridView.Enabled = true;
            RoomsHelpLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            // TODO: Сделать проверку заполнения всех полей.
            if (true)
            {
                // TODO: Сделать обновление данных в БД.
            }
        }

        private void AllPropertiesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GiveOutLinenCheckBox.Checked = AllPropertiesCheckBox.Checked;
            Set1CheckBox.Checked = AllPropertiesCheckBox.Checked;
            Set2CheckBox.Checked = AllPropertiesCheckBox.Checked;
            InstructedCheckBox.Checked = AllPropertiesCheckBox.Checked;
            ResidenceRulesCheckBox.Checked = AllPropertiesCheckBox.Checked;
            FireSafetyCheckBox.Checked = AllPropertiesCheckBox.Checked;
        }

        /// <summary>
        /// Отображение панели с изменением данных локации.
        /// </summary>
        private void OpenLocationInfoPanel()
        {
            LocationInfoPanel.Visible = true;
            CardPropertiesPanel.Visible = false;

            LocationDataLabel.ForeColor = MyColors._00A0E3();

            CardPropertiesLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// Отображение панели с изменением свойств карт локации.
        /// </summary>
        private void OpenCardPropertiesPanel()
        {
            LocationInfoPanel.Visible = false;
            CardPropertiesPanel.Visible = true;

            LocationDataLabel.ForeColor = Color.Black;

            CardPropertiesLabel.ForeColor = MyColors._00A0E3();
        }

        private void Set1HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В \"Комплект-1\" входит:\nНаволочка, подушка, одеяло, пододеяльник.", "Комплект-1", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Set2HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В \"Комплект-2\" входит:\nПростыня, подушка, одеяло.", "Комплект-2", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void EditCardPropertiesButton_Click(object sender, EventArgs e)
        {
            GiveOutLinenCheckBox.Enabled = true;
            Set1CheckBox.Enabled = true;
            Set2CheckBox.Enabled = true;
            InstructedCheckBox.Enabled = true;
            ResidenceRulesCheckBox.Enabled = true;
            FireSafetyCheckBox.Enabled = true;

            SaveCardPropertiesButton.Visible = true;
            EditCardPropertiesButton.Visible = false;
        }

        private void CardPropertiesLabel_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void LocationDataLabel_Click(object sender, EventArgs e)
        {
            OpenLocationInfoPanel();
        }
    }
}
