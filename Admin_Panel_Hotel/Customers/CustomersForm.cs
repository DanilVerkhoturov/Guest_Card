﻿using Admin_Panel_Hotel.Customers;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class CustomersForm : Form
    {
        DataTable AllCustomers = Customer.GetAll();
        public CustomersForm()
        {
            InitializeComponent();

            Functions.SetPlaceholderTextBox(SearchTextBox, "Поиск");

            CustomersDataGridView.DataSource = AllCustomers;
        }

        private void CustomersDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
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
            if (e.ColumnIndex == 0)
            {
                Customer.Name = CustomersDataGridView["name", e.RowIndex].Value.ToString();
                Customer.Id = Convert.ToInt64(CustomersDataGridView["id", e.RowIndex].Value.ToString());
                Customer.GetDivisionIdFromCustomerId(Customer.Id, out long divisionId);
                Customer.DivisionId = divisionId;
                Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != SearchTextBox.Tag.ToString())
            {
                DataView dataView = new DataView(AllCustomers);
                dataView.RowFilter = $"name LIKE '%{SearchTextBox.Text}%'";

                CustomersDataGridView.DataSource = dataView;
            }
        }
    }
}
