﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class NewApplications : Form
    {
        public NewApplications()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            MySqlCommand select = new MySqlCommand("SELECT id, (SELECT name as 'name' FROM customer_legal_info WHERE id = contract.customer_id), created_at as 'date' FROM contract WHERE status_id = 1", Functions.Connection);
            select.CommandTimeout = 86400;
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                ApplicationsDataGridView.Rows.Add(reader[1].ToString(), DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader[2].ToString())).DateTime.Date.ToString().Replace("00:00:00", "").Trim(), null, reader[0].ToString());
            }
            reader.Close();
        }

        private void ApplicationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ShowApplicationNew.CustomerName = ApplicationsDataGridView[0, e.RowIndex].Value.ToString();
                ShowApplicationNew.ApplicationDate = ApplicationsDataGridView[1, e.RowIndex].Value.ToString();
                ShowApplicationNew.ApplicationId = Convert.ToInt64(ApplicationsDataGridView[3, e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new ShowApplicationNew(), MainForm.ContP);
            }
        }

        private void ApplicationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
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
