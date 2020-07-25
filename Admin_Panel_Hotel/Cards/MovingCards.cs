using System.Windows.Forms;

namespace Admin_Panel_Hotel.Cards
{
    public partial class MovingCards : Form
    {
        public MovingCards()
        {
            InitializeComponent();

            FilterComboBox.SelectedIndex = 0;
            SearchComboBox.SelectedIndex = 0;
            LocationComboBox.SelectedIndex = 0;
        }
    }
}
