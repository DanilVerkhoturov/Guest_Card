using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Card
{
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            // TODO: Сделать выбор файла Excel;
            // TODO: Сделать проверку данных из выбранного файла Excel;
            // TODO: Сделать выгрузку данных из выбранного файла Excel;

            CardsPanel.Visible = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
