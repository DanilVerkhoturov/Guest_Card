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
            this.CurrentApplicationsDataGridView.Rows.Add("1", "Иванов Иван Иванович", "ННГ/Цех 136/112", "06.06.2020", "06.06.2020");
            this.CurrentApplicationsDataGridView.Rows.Add("2", "Петров Петр Петрович", "ННГ/Цех 136/113", "06.06.2020", "06.06.2020");
        }
    }
}
