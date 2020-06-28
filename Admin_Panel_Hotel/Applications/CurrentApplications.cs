using System;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class CurrentApplications : Form
    {
        public CurrentApplications()
        {
            InitializeComponent();
            this.CurrentApplicationsDataGridView.Rows.Add("1", "Иванов Иван Иванович", "ННГ/Цех 136/112", "06.06.2020", "06.06.2020");
            this.CurrentApplicationsDataGridView.Rows.Add("2", "Петров Петр Петрович", "ННГ/Цех 136/113", "06.06.2020", "06.06.2020");
        }

        /// private void ShowApplicationButton1_Click(object sender, EventArgs e)
        ///   {
        ///   Functions.OpenChildForm(new ShowApplication(), MainForm.ContP);
        ///  }

        ///   private void ShowApplicationsButton2_Click(object sender, EventArgs e)
        ///  {
        ///   Functions.OpenChildForm(new ShowApplication(), MainForm.ContP);
        ///
        ///  }
    }
}
