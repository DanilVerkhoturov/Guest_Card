using Admin_Panel_Hotel.Customers;
using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddEditApplication());
            Application.Run(new LocationInfoForm());
        }
    }
}
