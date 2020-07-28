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
            return Functions.ExecuteSql("SELECT id, name, created_at as 'date' FROM application_list WHERE status_id = 1");
        }

        /// <summary>
        /// Получить список текущих заявок.
        /// </summary>
        /// <returns>Возвращает таблицу с текущими заявками.</returns>
        public static DataTable GetCurrent()
        {
            return Functions.ExecuteSql("SELECT id, name, created_at as 'date' FROM application_list WHERE status_id = 2");
        }

        /// <summary>
        /// Получить список черновиков.
        /// </summary>
        /// <returns>Возвращает таблицу с черновиками заявок.</returns>
        public static DataTable GetDrafts()
        {
            return Functions.ExecuteSql("SELECT id, name, created_at as 'date' FROM application_list WHERE status_id = 3");
        }

        /// <summary>
        /// Получить список заявок из истории.
        /// </summary>
        /// <returns>Возвращает таблицу с заявками из истории.</returns>
        public static DataTable GetHistory()
        {
            return Functions.ExecuteSql("SELECT id, name, created_at as 'date' FROM application_list WHERE status_id = 4");
        }

        /// <summary>
        /// Получить список людей из заявки
        /// </summary>
        /// <returns>Возвращает таблицу с пользователями из заявки.</returns>
        public static DataTable GetUsers()
        {
            return Functions.ExecuteSql($"SELECT id as user_id, fio, tab_number, start_at, end_at, location FROM user_list WHERE application_id = {Id}");
        }
    }
}
