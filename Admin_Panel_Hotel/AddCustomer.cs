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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AllPropertiesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GiveOutLinenCheckBox.Checked = AllPropertiesCheckBox.Checked;
            Set1CheckBox.Checked = AllPropertiesCheckBox.Checked;
            Set2checkBox.Checked = AllPropertiesCheckBox.Checked;
            InstructedCheckBox.Checked = AllPropertiesCheckBox.Checked;
            ResidenceRulesCheckBox.Checked = AllPropertiesCheckBox.Checked;
            FireSafetyCheckBox.Checked = AllPropertiesCheckBox.Checked;
        }

        private void CustomerNameTextBox_Enter(object sender, EventArgs e)
        {
            CustomerNameTextBox.Text = null;
        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            AddressTextBox.Text = null;
        }

        private void INNTextBox_Enter(object sender, EventArgs e)
        {
            INNTextBox.Text = null;
        }

        private void OGRNTextBox_Enter(object sender, EventArgs e)
        {
            OGRNTextBox.Text = null;
        }

        private void ContractNumberTextBox_Enter(object sender, EventArgs e)
        {
            ContractNumberTextBox.Text = null;
        }

        private void LocationTextBox_Enter(object sender, EventArgs e)
        {
            LocationTextBox.Text = null;
        }

        private void ContractTimetextBox_Enter(object sender, EventArgs e)
        {
            ContractTimetextBox.Text = null;
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            EmailTextBox.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
