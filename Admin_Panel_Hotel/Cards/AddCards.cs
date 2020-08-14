using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Admin_Panel_Hotel.Cards
{
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();

            LocationComboBox.DataSource = Locations.GetAll();
            LocationComboBox.SelectedIndex = 0;

            DataGridViewComboBoxColumn statusesComboBox = (DataGridViewComboBoxColumn)CardsDataGridView.Columns["status_id"];
            statusesComboBox.DataSource = Card.GetStatuses();
            statusesComboBox.ValueMember = "status_id";
            statusesComboBox.DisplayMember = "status_name";

            DataGridViewComboBoxColumn locationsComboBox = (DataGridViewComboBoxColumn)CardsDataGridView.Columns["location_id"];
            locationsComboBox.DataSource = LocationComboBox.DataSource;
            locationsComboBox.ValueMember = "location_id";
            locationsComboBox.DisplayMember = "location_name";
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл Excel";
            openFileDialog.Filter = "Файлы Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (!(openFileDialog.ShowDialog() == DialogResult.Cancel))
            {
                string fileExcel = openFileDialog.FileName;

                Excel.Application excel = new Excel.Application();
                Workbooks workbooks = excel.Workbooks;
                Workbook workbook = workbooks.Open(fileExcel);
                Worksheet worksheet = workbook.Worksheets.get_Item(1);
                Range range = worksheet.UsedRange;

                for (int i = 2; i <= range.Rows.Count; i++)
                    if (range.Cells[i, 1].Value != null && range.Cells[i, 2].Value != null && range.Cells[i, 3].Value != null)
                        CardsDataGridView.Rows.Add(range.Cells[i, 1].Value.ToString(), range.Cells[i, 2].Value.ToString(), range.Cells[i, 3].Value.ToString(), 4, LocationComboBox.SelectedValue);

                workbooks.Close();
                excel.Quit();

                CardsPanel.Visible = true;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CardsDataGridView.RowCount; i++)
            {
                string serialNum = CardsDataGridView["serial_num", i].Value.ToString();
                string shortName = CardsDataGridView["short_name", i].Value.ToString();
                long statusId = Convert.ToInt64(CardsDataGridView["status_id", i].Value);
                long locationId = Convert.ToInt64(CardsDataGridView["location_id", i].Value);

                if (!Card.Find(serialNum, shortName, out long cardId)) // Если карты нет в БД.
                    if (!Card.Add(serialNum, shortName, locationId, statusId, out cardId))
                        MessageBox.Show("Возникла ошибка при добавлении карты в БД!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Карты успешно добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm.SubMenuProcessing(MainForm.AllCardsBtn, MainForm.CardsBtn, MainForm.CardsP);
            Functions.OpenChildForm(new AllCards(), MainForm.ContP);
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CardsDataGridView.Rows.Count; i++)
                CardsDataGridView["location_id", i].Value = LocationComboBox.SelectedValue;
        }
    }
}
