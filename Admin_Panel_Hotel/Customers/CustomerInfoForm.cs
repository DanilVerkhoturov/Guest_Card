using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class CustomerInfoForm : Form
    {
        /// <summary>
        /// Название выбранного заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Уникальный номер выбранного заказчика.
        /// </summary>
        public static long CustomerId;

        public CustomerInfoForm()
        {
            InitializeComponent();

            // Установка подсказки для текстового поля.
            Functions.SetPlaceholderTextBox(FindTextBox, "Поиск");

            CustomerNameLabel.Text = $"Мои заказчики > {CustomerName.Trim()}"; // Установка названия выбранного заказчика.

            FilterComboBox.SelectedIndex = 0;
            LoadCustomerLocations();
        }

        private static void LoadCustomerLocations()
        {
            // TODO: Сделать подгрузку всех локаций выбранного заказчика.
        }
    }
}
