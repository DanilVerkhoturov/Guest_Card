using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Cards
{
    public partial class MovingCards : Form
    {
        private int CardSelectedCount = 0;
        public MovingCards()
        {
            InitializeComponent();

            Functions.SetPlaceholderTextBox(SearchTextBox, "Поиск");

            Functions.OnlyNumbersInTextBox(FromTextBox);
            Functions.OnlyNumbersInTextBox(ToTextBox);

            Functions.NewlineProcessing(CardsDataGridView);

            Functions.FillLocationsInDataGridViewComboBox(CardsDataGridView);
            Functions.FillCardStatusesInDataGridView(CardsDataGridView);

            FilterLocationComboBox.DataSource = Locations.GetAll();
            LocationComboBox.DataSource = Locations.GetAll();

            CardsDataGridView.DataSource = Card.GetAllWithLocation();
        }

        private void FromToTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FromTextBox.TextLength > 0 && ToTextBox.TextLength > 0)
            {
                // TODO: Сделать подгрузку карт по диапазону.
            }
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменение локации у выбранных карт.
            for (int i = 0; i < CardsDataGridView.Rows.Count; i++)
                if (Convert.ToBoolean(Convert.ToInt32(CardsDataGridView["checkBoxColumn", i].Value)))
                    CardsDataGridView["location_id", i].Value = LocationComboBox.SelectedValue;
        }

        private void CardsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CardsDataGridView.ColumnCount > 0 && e.RowIndex != -1)
                if (e.ColumnIndex == CardsDataGridView.Columns["checkBoxColumn"].Index)
                {
                    if (Convert.ToBoolean(CardsDataGridView[e.ColumnIndex, e.RowIndex].Value))
                    {
                        CardSelectedCount++;
                    }
                    else
                    {
                        CardSelectedCount--;
                    }
                    CardCountLabel.Text = $"Выбрано карт: {CardSelectedCount}";
                }
        }

        private void CardsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CardsDataGridView.ColumnCount > 0 && e.RowIndex != -1)
                if (e.ColumnIndex == CardsDataGridView.Columns["checkBoxColumn"].Index)
                    CardsDataGridView.EndEdit();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CardsDataGridView.RowCount; i++)
            {
                if (!Card.UpdateLocation(Convert.ToInt64(CardsDataGridView["card_id", i].Value), Convert.ToInt64(CardsDataGridView["location_id", i].Value)))
                {
                    MessageBox.Show("Возникла ошибка при обновлении местоположения карты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Обновление успешно завершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FilterLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
