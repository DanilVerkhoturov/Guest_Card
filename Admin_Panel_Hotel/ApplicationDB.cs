using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class ApplicationDB
    {
        /// <summary>
        /// Дата заявки.
        /// </summary>
        public static string Date { get; set; }
        /// <summary>
        /// Уникальный номер заявки.
        /// </summary>
        public static long Id { get; set; }

        /// <summary>
        /// Получить количество черновиков.
        /// </summary>
        /// <returns>Количество черновиков.</returns>
        public static int GetDraftCount()
        {
            int draftApplicationsCount = 0;

            MySqlCommand select = new MySqlCommand("SELECT COUNT(*) as 'count' FROM applications WHERE applications.status_id = 3", Functions.Connection)
            {
                CommandTimeout = 86400
            };

            using (MySqlDataReader reader = select.ExecuteReader())
            {
                while (reader.Read())
                {
                    draftApplicationsCount = Convert.ToInt32(reader[0].ToString());
                }
            }
            return draftApplicationsCount;
        }

        /// <summary>
        /// Получить количество новых заявок.
        /// </summary>
        /// <returns>Количество новых заявок.</returns>
        public static int GetNewCount()
        {
            int newApplicationsCount = 0;

            MySqlCommand select = new MySqlCommand("SELECT COUNT(*) as 'count' FROM applications WHERE applications.status_id = 1", Functions.Connection)
            {
                CommandTimeout = 86400
            };

            using (MySqlDataReader reader = select.ExecuteReader())
            {
                while (reader.Read())
                {
                    newApplicationsCount = Convert.ToInt32(reader[0].ToString());
                }
            }
            return newApplicationsCount;
        }

        /// <summary>
        /// Получить список новых заявок.
        /// </summary>
        /// <returns>Возвращает таблицу с новыми заявками.</returns>
        public static DataTable GetNew()
        {
            // TODO: Написать запрос на получение новых заявок.
            return null /*Functions.ExecuteSql("")*/;
        }

        /// <summary>
        /// Получить список текущих заявок.
        /// </summary>
        /// <returns>Возвращает таблицу с текущими заявками.</returns>
        public static DataTable GetCurrent()
        {
            // TODO: Написать запрос на получение текущих заявок.
            return null /*Functions.ExecuteSql("")*/;
        }

        /// <summary>
        /// Получить список черновиков.
        /// </summary>
        /// <returns>Возвращает таблицу с черновиками заявок.</returns>
        public static DataTable GetDrafts()
        {
            // TODO: Написать запрос на получение списка черновиков.
            return null /*Functions.ExecuteSql("")*/;
        }

        /// <summary>
        /// Получить список заявок из истории.
        /// </summary>
        /// <returns>Возвращает таблицу с заявками из истории.</returns>
        public static DataTable GetHistory()
        {
            // TODO: Написать запрос на получение заявок из истории.
            return null /*Functions.ExecuteSql("")*/;
        }

        /// <summary>
        /// Получить список людей из заявки
        /// </summary>
        /// <returns>Возвращает таблицу с пользователями из заявки.</returns>
        public static DataTable GetUsers()
        {
            // TODO: Написать запрос на получение данных о пользователях в заявке.
            return null /*Functions.ExecuteSql("")*/;
        }
    }
}
