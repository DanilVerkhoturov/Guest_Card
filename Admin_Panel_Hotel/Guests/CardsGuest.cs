using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class CardsGuest : Form
    {
        public CardsGuest()
        {
            InitializeComponent();

            Functions.NewlineProcessing(CardsDataGridView);
            Functions.FillCardStatusesInDataGridView(CardsDataGridView);

            CardsDataGridView.AutoGenerateColumns = false;
            CardsDataGridView.DataSource = Card.GetAll(User.LocationId);
        }
    }
}
