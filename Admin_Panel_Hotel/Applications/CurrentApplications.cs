using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel_Hotel.Applications
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();
           
            this.CurrentDataGridView.Rows.Add("ННГ","06.06.2020");
            this.CurrentDataGridView.Rows.Add("ГПН", "06.06.2020");
        }

        private void CurrentDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                
                Functions.OpenChildForm(new ShowApplication(), MainForm.ContP);
            }
        }
    }
}
    