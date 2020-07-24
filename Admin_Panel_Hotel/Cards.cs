using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Cards
    {
        /// <summary>
        /// Получить список всех карт.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAll()
        {
            // TODO: Сделать проверку роли.
            if (true)
            {
                return Functions.ExecuteSql("SELECT * FROM cards_info");
            }
        }

        /// <summary>
        /// Количество всех карт.
        /// </summary>
        /// <returns>Количество карт. -1 если у пользователя нет прав для получения количества карт. -2 если возникла непредвиденная ошибка.</returns>
        public static int Count()
        {
            try
            {
                // TODO: Сделать проверку роли.
                if (true)
                {
                    MySqlCommand getCount = new MySqlCommand("SELECT COUNT(*) FROM cards_info", Functions.Connection);
                    MySqlDataReader reader = getCount.ExecuteReader();
                    int cardsCount = 0;

                    while (reader.Read())
                    {
                        cardsCount = (int)reader[0];
                    }
                    return cardsCount;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -2;
            }
        }
    }
}
