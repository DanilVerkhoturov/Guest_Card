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
