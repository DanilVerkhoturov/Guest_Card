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

            Functions.SetWaterMark(RegionComboBox, "Регион");
            Functions.SetWaterMark(StateComboBox, "Область");
            Functions.SetWaterMark(CityComboBox, "Город");
            Functions.SetWaterMark(StreetTypeComboBox, "Тип улицы");
            Functions.SetWaterMark(StreetNameComboBox, "Улица");
            Functions.SetWaterMark(HouseTextBox, "Дом");
            Functions.SetWaterMark(CorpsTextBox, "Корпус");
            Functions.SetWaterMark(BuildTextBox, "Строение");

            //using (MySqlConnection connection = new MySqlConnection($"server=u78479.netangels.ru;userid=u78479@10.19.0.80;pass=hmAsKtPcTHsrK1w;database=u78479_hotel"))
            //{
            //    MySqlCommand select = new MySqlCommand("Select * FROM region", connection);
            //}
        }

        private void CurrentApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CurrentApplications(), MainForm.ContP);
        }

        private void AddApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddApplication(), MainForm.ContP);
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
