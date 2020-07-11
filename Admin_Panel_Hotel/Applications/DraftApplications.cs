using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class DraftApplications : Form
    {
        public DraftApplications()
        {
            InitializeComponent();

            LoadApplications();
        }

        /// <summary>
        /// Загрузка черновиков из базы данных.
        /// </summary>
        private void LoadApplications()
        {
            MySqlCommand select = new MySqlCommand("SELECT id" +
                ", (SELECT name FROM customer_legal_info WHERE id = contract.customer_id) as 'name'" +
                ", created_at as 'date'" +
                " FROM contract" +
                " WHERE status_id = 3", Functions.Connection);
            select.CommandTimeout = 86400;
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                ApplicationsDataGridView.Rows.Add(reader[1].ToString(), DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[2].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim(), null, reader[0].ToString());
            }
            reader.Close();
        }

        private void DraftDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowApplicationDraft.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowApplicationDraft.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowApplicationDraft.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationDraft(), MainForm.ContP);
            }
        }

        private void DraftDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ApplicationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                ApplicationsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
