using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Applications
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();

            CustomerComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
            LoadApplications();
        }

        /// <summary>
        /// Загрузить текущие заявки из базы данных.
        /// </summary>
        private void LoadApplications()
        {
            MySqlCommand select = new MySqlCommand("SELECT id" +
                ", (SELECT name FROM customer_legal_info WHERE id = contract.customer_id) as 'name'" +
                ", created_at as 'date'" +
                " FROM contract" +
                " WHERE status_id = 2", Functions.Connection);
            select.CommandTimeout = 86400;
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                CurrentApplicationsDataGridView.Rows.Add(reader[1].ToString(), DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[2].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim(), null, reader[0].ToString());
            }
            reader.Close();
        }

        private void CurrentApplicationsDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowCurrentApplication.CustomerName = CurrentApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowCurrentApplication.ApplicationDate = CurrentApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowCurrentApplication.ApplicationId = Convert.ToInt64(CurrentApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowCurrentApplication(), MainForm.ContP);
            }
        }

        private void CurrentApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                CurrentApplicationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                CurrentApplicationsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
    