using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class ShowApplicationHistory : Form
    {
        /// <summary>
        /// Название заказчика.
        /// </summary>
        public static string CustomerName;
        /// <summary>
        /// Дата создания заявки.
        /// </summary>
        public static string ApplicationDate;
        /// <summary>
        /// Уникальный номер заявки.
        /// </summary>
        public static long ApplicationId;

        public ShowApplicationHistory()
        {
            InitializeComponent();
            Functions.LoadApplicationUsers(UsersDataGridView, ApplicationId);

            ApplicationNameLabel.Text = $"История заявок > {CustomerName} - {ApplicationDate}";
        }

        private void NewApplicationsLabel_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new HistoryApplications(), MainForm.ContP);
        }
    }
}
