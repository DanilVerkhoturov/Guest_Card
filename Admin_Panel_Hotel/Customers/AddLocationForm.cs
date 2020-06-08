using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class AddLocationFrom : Form
    {
        public static string NotificationText = null;

        public AddLocationFrom()
        {
            InitializeComponent();

            //Functions.SetWaterMark(RegionComboBox, "Регион");
            //Functions.SetWaterMark(StateComboBox, "Область");
            //Functions.SetWaterMark(CityComboBox, "Город");
            //Functions.SetWaterMark(StreetTypeComboBox, "Тип улицы");
            //Functions.SetWaterMark(StreetNameComboBox, "Улица");
            //Functions.SetWaterMark(HouseTextBox, "Дом");
            //Functions.SetWaterMark(CorpsTextBox, "Корпус");
            //Functions.SetWaterMark(BuildTextBox, "Строение");

            //using (MySqlConnection connection = new MySqlConnection($"server=localhost;userid=u78479;password=hmAsKtPcTHsrK1w;database=u78479_hotel"))
            //{
            //    MySqlCommand select = new MySqlCommand("Select * FROM region", connection);
            //    MySqlDataReader reader = select.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        RegionComboBox.Items.Add(reader[1].ToString());
            //    }
            //}
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
