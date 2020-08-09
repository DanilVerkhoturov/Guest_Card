using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class CustomerInfoForm : Form
    {
        public CustomerInfoForm()
        {
            InitializeComponent();

            // Установка подсказки для текстового поля.
            Functions.SetPlaceholderTextBox(FindTextBox, "Поиск");

            CustomerNameLabel.Text = $"Мои заказчики > {Customer.Name}"; // Установка названия выбранного заказчика.

            LocationsDataGridView.DataSource = Locations.GetAll();
        }

        private void LocationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Locations.Name = LocationsDataGridView["name", e.RowIndex].Value.ToString();
                Hotels.Id = Convert.ToInt64(LocationsDataGridView["id", e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new SubDivisionInfo(), MainForm.ContP);
            }
        }

        private void LocationsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                LocationsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                LocationsDataGridView.Cursor = Cursors.Default;
            }
        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomersForm(), MainForm.ContP);
        }
    }
}
