using System;
using System.Diagnostics;
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
            Functions.FillCardStatusesInDataGridView(CardsDataGridView);

            CardsDataGridView.DataSource = Card.GetAll();

            // Подгрузка данных в выпадающие списки.
            LocationComboBox.DataSource = Locations.GetAll();
            StatusComboBox.DataSource = Card.GetStatuses();
            StatusComboBox.SelectedIndex = 0;
        }

        

        private void AllCards_Load(object sender, EventArgs e)
        {
            // Сделать динамичную подгрузку карт и изменение количества карт.
            CardsCountLabel.Text = $"1-50 из {Card.Count()} карт";
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            ChangeStatusButton.Visible = false;
            CardsDataGridView.ReadOnly = false;
            CardsDataGridView.Columns["checkBoxColumn"].Visible = true;
            StatusComboBox.Visible = true;
            AcceptButton.Visible = true;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменение статуса у выбранных карт.
            for (int i = 0; i < CardsDataGridView.Rows.Count; i++)
                if (Convert.ToBoolean(Convert.ToInt32(CardsDataGridView["checkBoxColumn", i].Value)))
                    CardsDataGridView["status_id", i].Value = StatusComboBox.SelectedValue;
        }

        private void CardsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int rowIndex = e.RowIndex;

            for (int i = 0; i < e.RowCount; i++)
            {
                // Заполнение значения False в столбец чекбокса.
                dgv["checkBoxColumn", rowIndex].Value = 0;
                rowIndex++;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CardsDataGridView.RowCount; i++)
            {
                if (!Card.UpdateStatus(Convert.ToInt64(CardsDataGridView["card_id", i].Value), Convert.ToInt64(CardsDataGridView["status_id", i].Value)))
                {
                    MessageBox.Show("Возникла ошибка при обновлении статуса карты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ChangeStatusButton.Visible = true;
            CardsDataGridView.ReadOnly = true;
            CardsDataGridView.Columns["checkBoxColumn"].Visible = false;
            StatusComboBox.Visible = false;
            AcceptButton.Visible = false;

            MessageBox.Show("Обновление успешно завершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardsDataGridView.DataSource = Card.GetAll(Convert.ToInt64(LocationComboBox.SelectedValue));
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string fileExcel = Functions.DataGridViewToExcel(CardsDataGridView, $"Все карты {DateTime.Now.ToShortDateString()}", out string filePath);
            Process.Start(filePath);
        }
    }
}
