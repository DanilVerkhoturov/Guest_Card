using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Shown(object sender, EventArgs e)
        {
            if (Functions.Connection.State == ConnectionState.Open) // Подгрузка всех заказчиков, если соединение с БД открыто.
            {
                MySqlCommand select = new MySqlCommand("SELECT name FROM customer_legal_info", Functions.Connection);
                MySqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    CustomersDataGridView.Rows.Add(reader[0].ToString());
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
    }
}
