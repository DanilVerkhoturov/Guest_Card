using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class InfoUserForm : Form
    {
        int UserId = -1;

        public InfoUserForm()
        {
            InitializeComponent();

            // TODO: Реализовать получение данных по UserId и заполнять их в поля.
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
