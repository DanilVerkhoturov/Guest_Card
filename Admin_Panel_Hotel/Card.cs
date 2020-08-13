using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Card
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
                return Functions.ExecuteSql("SELECT * FROM card_list");
            }
        }

        /// <summary>
        /// Получить список всех возможных статусов карт.
        /// </summary>
        /// <returns>Возвращает список статусов.</returns>
        public static DataTable GetStatuses()
        {
            return Functions.ExecuteSql($"SELECT id as status_id, name as status_name FROM card_status");
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
                    MySqlCommand getCount = new MySqlCommand("SELECT COUNT(*) FROM card_list", Functions.Connection);
                    MySqlDataReader reader = getCount.ExecuteReader();
                    int cardsCount = 0;

                    while (reader.Read())
                    {
                        cardsCount = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    return cardsCount;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                return -2;
            }
        }
    }
}
