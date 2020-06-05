using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    class Functions
    {
        static System.Windows.Forms.Form ActiveForm = null;

        /// <summary>
        /// Открыть дочернюю форму на форме.
        /// </summary>
        /// <param name="childForm">Дочерняя форма.</param>
        /// <param name="contentPanel">Панель на которой требуется отобразить форму.</param>
        public static void OpenChildForm(System.Windows.Forms.Form childForm, Panel contentPanel)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
