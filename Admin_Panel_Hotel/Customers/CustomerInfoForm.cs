using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class CustomerInfoForm : Form
    {
        private DataTable AllLocations = Hotels.GetAll(Customer.Id);
        private DataTable AllSubDivisions = Customer.GetAllSubdivisions();
        public CustomerInfoForm()
        {
            InitializeComponent();

            // Установка подсказки для текстового поля.
            Functions.SetPlaceholderTextBox(LocationSearchTextBox, "Поиск");
            Functions.SetPlaceholderTextBox(SubDivisionSearchTextBox, "Поиск");

            CustomerNameLabel.Text = $"Мои заказчики > {Customer.Name}"; // Установка названия выбранного заказчика.

            LocationsDataGridView.DataSource = AllLocations;
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

            AddLocationButton.Visible = false;
            AddSubDivisionButton.Visible = true;

            LocationsPanel.Visible = false;
            SubDivisionsPanel.Visible = true;

            SubDivisionsDataGridView.DataSource = AllSubDivisions;
        }

        private void LocationsLabel_Click(object sender, EventArgs e)
        {
            LocationsLabel.Font = new Font(LocationsLabel.Font, FontStyle.Underline);
            LocationsLabel.ForeColor = MyColors._00A0E3();
            SubDivisionsLabel.Font = new Font(SubDivisionsLabel.Font, FontStyle.Regular);
            SubDivisionsLabel.ForeColor = Color.Black;

            AddLocationButton.Visible = true;
            AddSubDivisionButton.Visible = false;

            LocationsPanel.Visible = true;
            SubDivisionsPanel.Visible = false;

            LocationsDataGridView.DataSource = AllLocations;
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddLocationInfo(), MainForm.ContP);
        }

        private void LocationSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LocationSearchTextBox.Text != LocationSearchTextBox.Tag.ToString())
            {
                DataView dataView = new DataView(AllLocations);
                dataView.RowFilter = $"location_name LIKE '%{LocationSearchTextBox.Text}%'";

                LocationsDataGridView.DataSource = dataView;
            }
        }

        private void SubDivisionSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SubDivisionSearchTextBox.Text != SubDivisionSearchTextBox.Tag.ToString())
            {
                DataView dataView = new DataView(AllSubDivisions);
                dataView.RowFilter = $"subdivision_name LIKE '%{SubDivisionSearchTextBox.Text}%'";

                SubDivisionsDataGridView.DataSource = dataView;
            }
        }
    }
}
