using Admin_Panel_Hotel.Customers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            CustomersComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            if (Functions.Connection.State == ConnectionState.Open) // Подгрузка всех заказчиков, если соединение с БД открыто.
            {
                MySqlCommand select = new MySqlCommand("SELECT id, name FROM customer_legal_info", Functions.Connection);
                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    CustomersDataGridView.Rows.Add(reader[1].ToString(), null, reader[0].ToString());
                }
                reader.Close();
            }
        }

        private void CustomersDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                CustomersDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                CustomersDataGridView.Cursor = Cursors.Default;
            }
        }

        private void CustomersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                CustomerInfoForm.CustomerName = CustomersDataGridView[0, e.RowIndex].Value.ToString();
                CustomerInfoForm.CustomerId = Convert.ToInt64(CustomersDataGridView[2, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
            }
        }
    }
}
