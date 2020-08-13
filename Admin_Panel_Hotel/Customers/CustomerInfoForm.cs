using System;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class CustomerInfoForm : Form
    {
        public CustomerInfoForm()
        {
            InitializeComponent();

            // Установка подсказки для текстового поля.
            Functions.SetPlaceholderTextBox(LocationSearchTextBox, "Поиск");
            Functions.SetPlaceholderTextBox(SubDivisionSearchTextBox, "Поиск");

            CustomerNameLabel.Text = $"Мои заказчики > {Customer.Name}"; // Установка названия выбранного заказчика.

            LocationsDataGridView.DataSource = Locations.GetAll(Customer.Id);
        }

        private void LocationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Locations.Name = LocationsDataGridView["name", e.RowIndex].Value.ToString();
                Hotels.Id = Convert.ToInt64(LocationsDataGridView["id", e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new LocationInfo(), MainForm.ContP);
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

        private void SubDivisionsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Customer.SubDivision.Id = Convert.ToInt64(SubDivisionsDataGridView["subdivision_id", e.RowIndex].Value.ToString());
                Functions.OpenChildForm(new SubDivisionInfo(), MainForm.ContP);
            }
        }

        private void SubDivisionsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SubDivisionsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                SubDivisionsDataGridView.Cursor = Cursors.Default;
            }
        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomersForm(), MainForm.ContP);
        }

        private void SubDivisionsLabel_Click(object sender, EventArgs e)
        {
            LocationsLabel.Font = new Font(LocationsLabel.Font, FontStyle.Regular);
            LocationsLabel.ForeColor = Color.Black;
            SubDivisionsLabel.Font = new Font(SubDivisionsLabel.Font, FontStyle.Underline);
            SubDivisionsLabel.ForeColor = MyColors._00A0E3();

            LocationsPanel.Visible = false;
            SubDivisionsPanel.Visible = true;

            SubDivisionsDataGridView.DataSource = Customer.GetAllSubdivisions();
        }

        private void LocationsLabel_Click(object sender, EventArgs e)
        {
            LocationsLabel.Font = new Font(LocationsLabel.Font, FontStyle.Underline);
            LocationsLabel.ForeColor = MyColors._00A0E3();
            SubDivisionsLabel.Font = new Font(SubDivisionsLabel.Font, FontStyle.Regular);
            SubDivisionsLabel.ForeColor = Color.Black;

            LocationsPanel.Visible = true;
            SubDivisionsPanel.Visible = false;

            LocationsDataGridView.DataSource = Locations.GetAll(Customer.Id);
        }
    }
}
