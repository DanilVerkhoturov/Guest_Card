using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Guests
{
    public partial class RoomsGuest : Form
    {
        public RoomsGuest()
        {
            InitializeComponent();

            Functions.FillRoomTypesInDataGridView(RoomsDataGridView);
            Functions.FillRoomStatusesInDataGridView(RoomsDataGridView);

            RoomsDataGridView.AutoGenerateColumns = false;
            RoomsDataGridView.DataSource = Hotels.GetRooms(User.LocationId);
        }

        private void RoomsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            YesNoNotification yesNo = new YesNoNotification($"Изменить статус комнаты {RoomsDataGridView["room_name", e.RowIndex].Value}: \"{RoomsDataGridView["status_id", e.RowIndex].FormattedValue}\"");
            yesNo.Owner = this;
            if (yesNo.ShowDialog() == DialogResult.Yes)
            {
                Hotels.EditRoomStatus(Convert.ToInt64(RoomsDataGridView["room_id", e.RowIndex].Value), Convert.ToInt64(RoomsDataGridView["status_id", e.RowIndex].Value));
            }
        }
    }
}
