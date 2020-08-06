using System.Windows.Forms;

namespace Admin_Panel_Hotel.Registry
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();

            DivisionsComboBox.DataSource = Customer.GetAllDivisions();
            // TODO: Сделать получение всех организаций и заполнение в столбец "Организация".
            // TODO: Сделать получение всех пользователей.
        }
    }
}
