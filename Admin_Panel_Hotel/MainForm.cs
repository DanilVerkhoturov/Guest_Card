using Admin_Panel_Hotel.Applications;
using Admin_Panel_Hotel.Cards;
using Admin_Panel_Hotel.Guests;
using Admin_Panel_Hotel.Registry;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    public partial class MainForm : Form
    {
        public static Panel ContP = null;
        private static Button CurrentSubButton = null;
        private static Button CurrentMainButton = null;
        private static Panel CurrentSubMenu = null;

        public MainForm()
        {
            InitializeComponent();

            ContP = ContentPanel;

            Functions.Connection.StateChange += Functions.MySQLConnectionStateChange;
            Functions.Connection.Open();

            NewApplicationsButton.Text = $"Новые   {ApplicationDB.GetNewCount()}";
            DraftsButton.Text = $"Черновики   {ApplicationDB.GetDraftCount()}";
        }

        #region Заказчики

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(MyCustomersButton, CustomersButton, CustomersPanel);
            Functions.OpenChildForm(new CustomersForm(), ContentPanel);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddCustomerButton, CustomersButton);
            Functions.OpenChildForm(new AddCustomer(), ContentPanel);
        }

        private void MyCustomersButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(MyCustomersButton, CustomersButton);
            Functions.OpenChildForm(new CustomersForm(), ContentPanel);
        }

        #endregion

        #region Заявки

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(NewApplicationsButton, ApplicationsButton, ApplicationsPanel);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void NewApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(NewApplicationsButton, ApplicationsButton);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }

        private void CurrentApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(CurrentApplicationsButton, ApplicationsButton);
            Functions.OpenChildForm(new CurrentApplications(), ContentPanel);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddApplicationButton, ApplicationsButton);
            Functions.OpenChildForm(new AddApplication(), ContentPanel);
        }

        private void HistoryApplicationsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(HistoryApplicationsButton, ApplicationsButton);
            Functions.OpenChildForm(new HistoryApplications(), ContentPanel);
        }

        private void DraftsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(DraftsButton, ApplicationsButton);
            Functions.OpenChildForm(new DraftApplications(), ContentPanel);
        }

        #endregion

        #region Карты

        private void CardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AllCardsButton, CardsButton, CardsPanel);
            Functions.OpenChildForm(new AllCards(), ContentPanel);
        }

        private void AllCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AllCardsButton, CardsButton);
            Functions.OpenChildForm(new AllCards(), ContentPanel);
        }

        private void AddCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddCardsButton, CardsButton);
            Functions.OpenChildForm(new AddCards(), ContentPanel);
        }

        private void MovingCardsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(MovingCardsButton, CardsButton);
            Functions.OpenChildForm(new MovingCards(), ContentPanel);
        }

        #endregion

        #region Реестр

        private void RegistryButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(RegistryListButton, RegistryButton, RegistryPanel);
            Functions.OpenChildForm(new RegistryForm(), ContentPanel);
        }

        private void RegistryListButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(RegistryListButton, RegistryButton);
            Functions.OpenChildForm(new RegistryForm(), ContentPanel);
        }

        private void AddRegistryButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(AddRegistryButton, RegistryButton);
            Functions.OpenChildForm(new AddRegistry(), ContentPanel);
        }

        #endregion

        #region Гости

        private void GuestsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(NewGuestsButton, GuestsButton, GuestsPanel);
            Functions.OpenChildForm(new NewGuest(), ContentPanel);
        }

        private void NewGuestsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(NewGuestsButton, GuestsButton);
            Functions.OpenChildForm(new NewGuest(), ContentPanel);
        }

        private void EvictionGuestsButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(EvictionGuestsButton, GuestsButton);
            Functions.OpenChildForm(new EvictionGuest(), ContentPanel);
        }

        private void GuestsCalendarButton_Click(object sender, EventArgs e)
        {
            SubMenuProcessing(GuestsCalendarButton, GuestsButton);
            Functions.OpenChildForm(new CalendarGuest(), ContentPanel);
        }

        #endregion

        /// <summary>
        /// Обработка открытия страниц из подменю.
        /// </summary>
        /// <param name="newButton">Объект нажатой кнопки.</param>
        /// <param name="newSubMenu">Объект подменю. Указывать только если была нажата кнопка, отвечающая за разворачивание подменю! По умолчанию - null.</param>
        private void SubMenuProcessing(Button newButton, Button newMainButton, Panel newSubMenu = null)
        {
            // Обработка нажатия главной кнопки меню.
            if (CurrentMainButton == null)
            {
                newMainButton.ForeColor = MyColors._00A0E3();
                CurrentMainButton = newMainButton;
            }
            else
            {
                if (newMainButton != CurrentMainButton)
                {
                    CurrentMainButton.ForeColor = MyColors._FFFFFF();
                    newMainButton.ForeColor = MyColors._00A0E3();
                    CurrentMainButton = newMainButton;
                }
            }

            // Обработка нажатия кнопки в подменю.
            if (CurrentSubButton == null)
            {
                newButton.ForeColor = MyColors._00A0E3();
                CurrentSubButton = newButton;
            }
            else
            {
                if (newButton != CurrentSubButton)
                {
                    CurrentSubButton.ForeColor = MyColors._FFFFFF();
                    newButton.ForeColor = MyColors._00A0E3();
                    CurrentSubButton = newButton;
                }
            }

            // Обработка отображения подменю.
            if (newSubMenu != null)
            {
                if (CurrentSubMenu == null)
                {
                    newSubMenu.Visible = !newSubMenu.Visible;

                    CurrentSubMenu = newSubMenu;
                }
                else
                {
                    if (CurrentSubMenu == newSubMenu)
                    {
                        newSubMenu.Visible = !newSubMenu.Visible;
                    }
                    else
                    {
                        CurrentSubMenu.Visible = false;
                        newSubMenu.Visible = true;
                        CurrentSubMenu = newSubMenu;
                    }
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
            SubMenuProcessing(NewApplicationsButton, ApplicationsButton, ApplicationsPanel);
            Functions.OpenChildForm(new NewApplications(), ContentPanel);
        }
    }
}
