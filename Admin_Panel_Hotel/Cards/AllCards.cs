using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Cards
{
    public partial class AllCards : Form
    {
        public AllCards()
        {
            InitializeComponent();

            Functions.SetPlaceholderTextBox(SearchTextBox, "Поиск");
            Functions.NewlineProcessing(CardsDataGridView);

            FilterCardsComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;

            StatusComboBox.DataSource = Functions.ExecuteSql("SELECT * FROM card_status");
            CardsDataGridView.DataSource = Card.GetAll();
        }

        private void AllCards_Load(object sender, EventArgs e)
        {
            // TODO: Сделать подгрузку количества всех карт и отображение в CardsCountLabel.
            CardsCountLabel.Text = $"1-50 из {Card.Count()} карт";
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            CardsDataGridView.Columns["checkBoxColumn"].Visible = true;
            StatusComboBox.Visible = true;
        }
    }
}
