using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class LocationInfoForm : Form
    {
        /// <summary>
        /// Название локации.
        /// </summary>
        public static string LocationName;
        /// <summary>
        /// Уникальный идентификатор локации.
        /// </summary>
        public static long LocationId;
        /// <summary>
        /// Название выбранного заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Уникальный номер выбранного заказчика.
        /// </summary>
        public static long CustomerId;

        public LocationInfoForm()
        {
            InitializeComponent();

            CustomerLocationNameLabel.Text = $"Мои заказчики > {CustomerName} > {LocationName}";
        }

        private void EditNameButton_Click(object sender, System.EventArgs e)
        {
            EditNameButton.Visible = false;
            NameTextBox.Enabled = true;
            SaveButton.Visible = true;
            NameHelpLabel.Visible = true;
        }

        private void EditRegionButton_Click(object sender, System.EventArgs e)
        {
            EditRegionButton.Visible = false;
            RegionComboBox.Enabled = true;
            SaveButton.Visible = true;
            RegionHelpLabel.Visible = true;
            RegionComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }
}
