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
    public partial class MainForm : Form
    {
        Form ActiveForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(childForm);
            this.ContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCustomer());
        }

        private void AddApplicationsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEditApplication());
        }

        private void NewApplicationsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewApplications());
        }
    }
}
