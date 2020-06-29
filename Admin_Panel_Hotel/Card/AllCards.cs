using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Card
{
    public partial class AllCards : Form
    {
        public AllCards()
        {
            InitializeComponent();

            FilterCardsComboBox.SelectedIndex = 0;
            CardsStatusComboBox.SelectedIndex = 0;
        }

        private void AllCards_Load(object sender, EventArgs e)
        {
            // TODO: Сделать подгрузку количество всех карт и отображение в CardsCountLabel.
            // CardsCountLabel.Text = $"1-50 из {cardsCount} карт";
        }
    }
}
