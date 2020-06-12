using Admin_Panel_Hotel.Card;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class MainForm : Form
    {
        public static Panel ContP = null;

        public MainForm()
        {
            InitializeComponent();

            CustomizeDesign();
            ContP = ContentPanel;
        }

        /// <summary>
        /// При открытии программы подменю скрыто.
        /// </summary>
        private void CustomizeDesign()
        {
            CustomersSubMenu.Visible = false;
            ApplicationsSubMenu.Visible = false;
            CardSubMenu.Visible = false;
        } 

        /// <summary>
        /// Скрыть подменю.
        /// </summary>
        private void HideSubMenu()
        {
            if (CustomersSubMenu.Visible == true)
                CustomersSubMenu.Visible = false;
            if (ApplicationsSubMenu.Visible == true)
                ApplicationsSubMenu.Visible = false;
            if (CardSubMenu.Visible == true)
                CardSubMenu.Visible = false;
        }

        /// <summary>
        /// Отобразить подменю.
        /// </summary>
        /// <param name="subMenu">Объект подменю.</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddCustomer(), ContentPanel);
        }

        private void NewApplicationsButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddApplication(), ContentPanel);
        }

        private void CurrentApplicationsButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new CurrentApplications(), ContentPanel);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(CustomersSubMenu);
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ApplicationsSubMenu);
        }

        private void DraftButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new DraftApplications(), ContentPanel);
        }

        private void HistoryApplicationsButton_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new HistoryApplications(), ContentPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AllCard(), ContentPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new MovingGards(), ContentPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new AddApplication(), ContentPanel);
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(CardSubMenu);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Если соединение с БД закрыто, то подключаемся ещё раз.
            if (Functions.Connection.State == ConnectionState.Closed)
            {
                Functions.Connection.Open();
                Functions.Connection.StateChange += MySQLConnectionStateChange;
            }
        }

        /// <summary>
        /// Обработка изменения статуса подключения к БД.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySQLConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            // Если подключение к БД стало закрытым, то открываем его.
            if (e.CurrentState == ConnectionState.Closed)
            {
                Functions.Connection.Open();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если подключение к БД открыто, тогда закрываем его.
            if (Functions.Connection.State == ConnectionState.Open)
            {
                Functions.Connection.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }
    }
}
