using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Card
{
    public partial class AddCard : Form
    {
        public AddCard()
        {
            InitializeComponent();

            Functions.NewlineProcessing(CardsDataGridView, new string[] { "1", "Введите номер карты", null, null });
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            CardsDataGridView.Rows.Add();
        }
    }
}
