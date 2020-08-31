using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Customers
{
    public partial class LocationInfo : Form
    {
        public LocationInfo()
        {
            InitializeComponent();

            Hotels.FillInfo();

            NameTextBox.Text = Locations.Name;
            RoomsCountTextBox.Text = Hotels.RoomCount.ToString();
            BedsCountTextBox.Text = Hotels.BedsCount.ToString();
            CardsCountTextBox.Text = Hotels.CardsCount.ToString();
            DataTable rooms = Hotels.GetRooms();
            for (int i = 0; i < rooms.Rows.Count; i++)
                RoomsDataGridView.Rows.Add(rooms.Rows[i].ItemArray);

            CustomerLocationNameLabel.Text = $"Мои заказчики > {Customer.Name} > {Locations.Name}";
        }

        private void CustomerLocationNameLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CustomerInfoForm(), MainForm.ContP);
        }

        /// <summary>
        /// Отображение панели с изменением данных локации.
        /// </summary>
        private void OpenLocationInfoPanel()
        {
            LocationInfoPanel.Visible = true;
            CardPropertiesPanel.Visible = false;
            AllCardPropertiesPanel.Visible = false;

            LocationDataLabel.ForeColor = MyColors._00A0E3();

            CardPropertiesLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// Отображение панели с изменением свойств карт локации.
        /// </summary>
        private void OpenCardPropertiesPanel()
        {
            LocationInfoPanel.Visible = false;
            CardPropertiesPanel.Visible = true;
            AllCardPropertiesPanel.Visible = true;

            LocationDataLabel.ForeColor = Color.Black;

            CardPropertiesLabel.ForeColor = MyColors._00A0E3();
        }

        private void EditCardPropertiesButton_Click(object sender, EventArgs e)
        {
            SaveCardPropertiesButton.Visible = true;
            EditCardPropertiesButton.Visible = false;
        }

        private void CardPropertiesLabel_Click(object sender, EventArgs e)
        {
            OpenCardPropertiesPanel();
        }

        private void LocationDataLabel_Click(object sender, EventArgs e)
        {
            OpenLocationInfoPanel();
        }

        private void EditNameButton_Click_1(object sender, EventArgs e)
        {
            EditNameButton.Visible = false;
            EditNameTipLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
            NameTextBox.ReadOnly = false;
        }

        private void EditRoomsButton_Click_1(object sender, EventArgs e)
        {
            EditRoomsButton.Visible = false;
            RoomsDataGridView.ReadOnly = false;
            RoomsDataGridView.Columns["delete"].Visible = true;
            CardsCountTextBox.ReadOnly = false;
            AddRoomLabel.Visible = true;
            SaveLocationInfoButton.Visible = true;
        }

        private void SaveLocationInfoButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength > 0)
            {
                if (Hotels.Update(Locations.Id, Hotels.Id, NameTextBox.Text, Convert.ToInt32(RoomsCountTextBox.Text), Convert.ToInt32(BedsCountTextBox.Text), Convert.ToInt32(CardsCountTextBox.Text)))
                {
                    // Обновление данных о комнатах.
                    for (int i = 0; i < RoomsDataGridView.RowCount; i++)
                    {
                        if (Hotels.FindRoom(RoomsDataGridView["roomNumber", i].Value.ToString(), Hotels.Id, out long roomId))
                        {
                            // Обновление данных комнаты.
                            if (!Hotels.EditRoom(Convert.ToInt32(RoomsDataGridView["room_id", i].Value), RoomsDataGridView["roomNumber", i].Value.ToString(), Convert.ToInt32(RoomsDataGridView["bedsCount", i].Value)))
                            {
                                MessageBox.Show("Возникла непредвиденная ошибка с обновлением данных гостиницы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Добавление новой комнаты.
                            if (Hotels.AddRoom(Hotels.Id, RoomsDataGridView["roomNumber", i].Value.ToString(), Convert.ToInt32(RoomsDataGridView["bedsCount", i].Value)) < 0)
                            {
                                MessageBox.Show("Возникла непредвиденная ошибка с обновлением данных гостиницы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Возникла непредвиденная ошибка с обновлением данных гостиницы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveCardPropertiesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddRoomLabel_Click(object sender, EventArgs e)
        {
            RoomsDataGridView.Rows.Add();
            RoomsCountTextBox.Text = Convert.ToString(Convert.ToInt32(RoomsCountTextBox.Text) + 1);
        }

        private void RoomsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (RoomsDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show($"Вы действительно хотите удалить комнату \"{RoomsDataGridView["roomNumber", e.RowIndex].Value}\"?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // TODO: Сделать удаление / архивирование комнаты.
                    RoomsCountTextBox.Text = Convert.ToString(Convert.ToInt32(RoomsCountTextBox.Text) - 1);
                    BedsCountTextBox.Text = Convert.ToString(Convert.ToInt32(BedsCountTextBox.Text) - Convert.ToInt32(RoomsDataGridView["bedsCount", e.RowIndex].Value));
                    RoomsDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void RoomsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (RoomsDataGridView.Columns[e.ColumnIndex].Name == "bedsCount")
            {
                int bedsCount = 0;
                for (int i = 0; i < RoomsDataGridView.RowCount; i++)
                    bedsCount += Convert.ToInt32(RoomsDataGridView["bedsCount", i].Value);
                BedsCountTextBox.Text = bedsCount.ToString();
            }
        }

        private void RoomsDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (RoomsDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                RoomsDataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                RoomsDataGridView.Cursor = Cursors.Default;
            }
        }
    }
}
