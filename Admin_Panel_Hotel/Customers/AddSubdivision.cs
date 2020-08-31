using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class AddSubDivision : Form
    {
        public AddSubDivision()
        {
            InitializeComponent();

            Hotels.FillInfo();

            NameTextBox.Text = Locations.Name;
            RoomsCountTextBox.Text = Hotels.RoomCount.ToString();
            BedsCountTextBox.Text = Hotels.BedsCount.ToString();
           

            CustomerLocationNameLabel.Text = $"Мои заказчики > {Customer.Name} > {Locations.Name}";
        }

        private void CustomerLocationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
        }

        /// <summary>
        /// Отображение панели с изменением данных локации.
        /// </summary>
        private void OpenLocationInfoPanel()
        {
            LocationInfoPanel.Visible = true;
           

            LocationDataLabel.ForeColor = MyColors._00A0E3();

          
        }

        /// <summary>
        /// Отображение панели с изменением свойств карт локации.
        /// </summary>
        private void OpenCardPropertiesPanel()
        {
            LocationInfoPanel.Visible = false;
           

            LocationDataLabel.ForeColor = Color.Black;

            
        }

        private void EditCardPropertiesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CardPropertiesLabel_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void LocationDataLabel_Click(object sender, EventArgs e)
        {
            OpenLocationInfoPanel();
        }

        private void EditNameButton_Click_1(object sender, EventArgs e)
        {
            EditNameButton.Visible = false;
           
            SaveLocationInfoButton.Visible = true;
            NameTextBox.ReadOnly = false;
        }

        private void EditRoomsButton_Click_1(object sender, EventArgs e)
        {
            
            AddRoomLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void SaveLocationInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать проверку заполнения всех полей.
            if (true)
            {
                // TODO: Сделать обновление данных в БД.
            }
        }

        private void SaveCardPropertiesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddRoomLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
