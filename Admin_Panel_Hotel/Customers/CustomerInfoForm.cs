using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class CustomerInfoForm : Form
    {
        /// <summary>
        /// Название выбранного заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Уникальный номер выбранного заказчика.
        /// </summary>
        public static long CustomerId;

        public CustomerInfoForm()
        {
            InitializeComponent();

            // Установка подсказки для текстового поля.
            Functions.SetPlaceholderTextBox(FindTextBox, "Поиск");

            CustomerNameLabel.Text = $"Мои заказчики > {CustomerName.Trim()}"; // Установка названия выбранного заказчика.

            LoadCustomerLocations(LocationsDataGridView);
        }

        private static void LoadCustomerLocations(DataGridView dgv)
        {
            MySqlCommand select = new MySqlCommand($"SELECT name, location_id FROM customer_location WHERE customer_id = {CustomerId}", Functions.Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(reader[0].ToString(), null, reader[1].ToString());
            }
            reader.Close();
        }

        private void LocationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                LocationInfoForm.LocationName= LocationsDataGridView[0, e.RowIndex].Value.ToString();
                LocationInfoForm.LocationId = Convert.ToInt64(LocationsDataGridView[2, e.RowIndex].Value.ToString());
                LocationInfoForm.CustomerName = CustomerName;
                LocationInfoForm.CustomerId = CustomerId;
                Functions.OpenChildForm(new LocationInfoForm(), MainForm.ContP);
            }
        }

        private void LocationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                LocationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                LocationsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
