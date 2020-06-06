using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public static Panel ContP = null;
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            ContP = ContentPanel;
            
        }
        //При открытии программы под меню скрыто
        private void customizeDesign()
        {
            CustomersSubMenu.Visible = false;
            ApplicationsSubMenu.Visible = false;
        } 
        private void hideSubMenu()
        {
            if (CustomersSubMenu.Visible == true)
                CustomersSubMenu.Visible = false;
            if (ApplicationsSubMenu.Visible == true)
                ApplicationsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
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
            showSubMenu(CustomersSubMenu);
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            showSubMenu(ApplicationsSubMenu);
        }
    }
}
