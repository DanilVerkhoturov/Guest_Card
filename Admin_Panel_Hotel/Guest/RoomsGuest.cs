using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guest
{
    public partial class RoomsGuest : Form
    {
        public RoomsGuest()
        {
            InitializeComponent();

            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "112", "Жилое");
            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "112", "Жилое");

            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "113", "Ремонт", "Ремонт до 30.02.2020");
            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "113", "Ремонт", "Ремонт до 30.02.2020");

            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "114", "Жилое");
            RoomsDataGridView.Rows.Add("Стандарт 2-х местный", "114", "Жилое");

            RoomsDataGridView.Rows.Add("Стандарт 4-х местный", "112", "Жилое");
            RoomsDataGridView.Rows.Add("Стандарт 4-х местный", "112", "Жилое");
            RoomsDataGridView.Rows.Add("Стандарт 4-х местный", "112", "Нет койко-место", "Сломана спинка");
            RoomsDataGridView.Rows.Add("Стандарт 4-х местный", "112", "Жилое");
        }
    }
}
