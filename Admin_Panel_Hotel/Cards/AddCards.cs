using ExcelDataReader;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Cards
{
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();

            LocationComboBox.DataSource = Locations.GetAll();

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

                // TODO: Сделать загрузку данных из файла в таблицу.

                CardsPanel.Visible = true;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
