using System;
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
    }
}
