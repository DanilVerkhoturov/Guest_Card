using Admin_Panel_Hotel.Applications;
using Admin_Panel_Hotel.Card;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class MainForm : Form
    {
        public static Panel ContP = null;
        private static Button CurrentSubButton = null;

        public MainForm()
        {
            InitializeComponent();

            CustomizeDesign();
            ContP = ContentPanel;
            Functions.Connection.StateChange += Functions.MySQLConnectionStateChange;
            Functions.Connection.Open();

            NewApplicationsButton.Text = $"Новые   {GetNewApplicationsCount()}";
            DraftsButton.Text = $"Черновики   {GetDraftApplicationsCount()}";
        }

        #region Заказчики

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersButton.ForeColor = MyColors._00A0E3();
            ApplicationsButton.ForeColor = MyColors._FFFFFF();
            CardsButton.ForeColor = MyColors._FFFFFF();
            SubMenuProcessing(CustomersButton, CustomersPanel);

            SubMenuProcessing(MyCustomersButton);
            Functions.OpenChildForm(new CustomersForm(), ContentPanel);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddCustomerButton);
            Functions.OpenChildForm(new AddCustomer(), ContentPanel);
        }

        private void MyCustomersButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(MyCustomersButton);
            Functions.OpenChildForm(new CustomersForm(), ContentPanel);
        }

        #endregion

        #region Заявки

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(ApplicationsButton, ApplicationsPanel);

            SubMenuProcessing(NewApplicationsButton);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void NewApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(NewApplicationsButton);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void CurrentApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(CurrentApplicationsButton);
            Functions.OpenChildForm(new CurrentApplications(), ContentPanel);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddApplicationButton);
            Functions.OpenChildForm(new AddApplication(), ContentPanel);
        }

        private void HistoryApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(HistoryApplicationsButton);
            Functions.OpenChildForm(new HistoryApplications(), ContentPanel);
        }

        private void DraftsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(DraftsButton);
            Functions.OpenChildForm(new DraftApplications(), ContentPanel);
        }

        #endregion

        #region Карты

        private void CardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(CardsButton, CardsPanel);

            SubMenuProcessing(AllCardsButton);
            Functions.OpenChildForm(new AllCards(), ContentPanel);
        }

        private void AllCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AllCardsButton);
            Functions.OpenChildForm(new AllCards(), ContentPanel);
        }

        private void AddCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddCardsButton);
            Functions.OpenChildForm(new AddCards(), ContentPanel);
        }

        private void MovingCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(MovingCardsButton);
            Functions.OpenChildForm(new MovingCards(), ContentPanel);
        }

        #endregion

        /// <summary>
        /// При открытии программы подменю скрыто.
        /// </summary>
        private void CustomizeDesign()
        {
            CustomersPanel.Visible = false;
            ApplicationsPanel.Visible = false;
            CardsPanel.Visible = false;
        }

        /// <summary>
        /// Обработка открытия страниц из подменю.
        /// </summary>
        /// <param name="button">Объект нажатой кнопки.</param>
        /// <param name="subMenu">Объект подменю. Указывать только если была нажата кнопка, отвечающая за разворачивание подменю! По умолчанию - null.</param>
        private void SubMenuProcessing(Button button, Panel subMenu = null)
        {
            if (CurrentSubButton == null)
            {
                button.ForeColor = MyColors._00A0E3();
                CurrentSubButton = button;
            }
            else
            {
                if (button != CurrentSubButton)
                {
                    CurrentSubButton.ForeColor = MyColors._FFFFFF();
                    button.ForeColor = MyColors._00A0E3();
                    CurrentSubButton = button;
                }
            }

            if (subMenu != null)
            {
                if (subMenu.Visible)
                {
                    subMenu.Visible = false;
                }
                else
                {
                    if (CustomersPanel.Visible)
                    {
                        CustomersPanel.Visible = false;
                        CustomersButton.ForeColor = MyColors._FFFFFF();
                        MyCustomersButton.ForeColor = MyColors._FFFFFF();
                        AddCustomerButton.ForeColor = MyColors._FFFFFF();
                    }

                    if (ApplicationsPanel.Visible)
                    {
                        ApplicationsPanel.Visible = false;
                        ApplicationsButton.ForeColor = MyColors._FFFFFF();
                        NewApplicationsButton.ForeColor = MyColors._FFFFFF();
                        CurrentApplicationsButton.ForeColor = MyColors._FFFFFF();
                        AddApplicationButton.ForeColor = MyColors._FFFFFF();
                        HistoryApplicationsButton.ForeColor = MyColors._FFFFFF();
                        DraftsButton.ForeColor = MyColors._FFFFFF();
                    }

                    if (CardsPanel.Visible)
                    {
                        CardsPanel.Visible = false;
                        AllCardsButton.ForeColor = MyColors._FFFFFF();
                    }

                    subMenu.Visible = true;
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Если соединение с БД закрыто, то подключаемся ещё раз.
            if (Functions.Connection.State == ConnectionState.Closed)
                Functions.Connection.Open();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если подключение к БД открыто, тогда закрываем его.
            if (Functions.Connection.State == ConnectionState.Open)
                Functions.Connection.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SubMenuProcessing(NewApplicationsButton, ApplicationsPanel);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        /// <summary>
        /// Получить количество черновиков.
        /// </summary>
        /// <returns>Количество черновиков.</returns>
        private static long GetDraftApplicationsCount()
        {
            long draftApplicationsCount = 0;

            MySqlCommand select = new MySqlCommand("SELECT COUNT(*) as 'count' FROM applications WHERE applications.status_id = 3", Functions.Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                draftApplicationsCount = (long)reader[0];
                break;
            }
            reader.Close();
            return draftApplicationsCount;
        }

        /// <summary>
        /// Получить количество новых заявок.
        /// </summary>
        /// <returns>Количество новых заявок.</returns>
        private static long GetNewApplicationsCount()
        {
            long newApplicationsCount = 0;

            MySqlCommand select = new MySqlCommand("SELECT COUNT(*) as 'count' FROM applications WHERE applications.status_id = 1", Functions.Connection);
            MySqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                newApplicationsCount = (long)reader[0];
                break;
            }
            reader.Close();

            return newApplicationsCount;
        }
    }
}
