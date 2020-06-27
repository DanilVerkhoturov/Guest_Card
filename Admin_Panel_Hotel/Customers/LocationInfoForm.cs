using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class LocationInfoForm : Form
    {
        public LocationInfoForm()
        {
            InitializeComponent();
        }

        private void EditNameButton_Click(object sender, System.EventArgs e)
        {
            EditNameButton.Visible = false;
            ToolTip.Show("Редактируйте поле и\nнажмите Сохранить", LocationInfoPanel, NameTextBox.Location.X + NameTextBox.Width + 32, NameTextBox.Location.Y);
        }

        private void EditRegionButton_Click(object sender, System.EventArgs e)
        {
            EditRegionButton.Visible = false;
            ToolTip.Show("Редактируйте поле и\nнажмите Сохранить", LocationInfoPanel, RegionComboBox.Location.X + RegionComboBox.Width + 32, RegionComboBox.Location.Y);
            RegionComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }
}
