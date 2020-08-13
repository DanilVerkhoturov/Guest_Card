using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Panel_Hotel
{
    class Applications
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
        /// Добавить заявку.
        /// </summary>
        /// <param name="applicationId">Возвращает уникальный номер (Id) созданной заявки. -1 - если возникла ошибка.</param>
        /// <param name="customerId">Уникальный номер (Id) заказчика.</param>
        /// <param name="type">Тип заявки: 1 - заявка на питание; 2 - заявка на проживание.</param>
        /// <returns>Возвращает результат добавления.</returns>
        public static bool Add(out long applicationId, long customerId, int type)
        {
            applicationId = Functions.SqlInsert($"INSERT INTO applications(customer_id, status_id, type, created_at)" +
                $" VALUES({customerId}, {1}, {type}, {Functions.ToUnixTime(DateTime.Now)})");
            if (applicationId >= 0)
            {
                Id = applicationId;
                return true;
            }
            else
            {
                return false;
            }
        }

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
            return Functions.ExecuteSql("SELECT application_id, customer_id, name, created_at as 'date' FROM application_list WHERE status_id = 1");
        }

        /// <summary>
        /// Получить список текущих заявок.
        /// </summary>
        /// <returns>Возвращает таблицу с текущими заявками.</returns>
        public static DataTable GetCurrent()
        {
            return Functions.ExecuteSql("SELECT application_id, customer_id, name, created_at as 'date' FROM application_list WHERE status_id = 2");
        }

        /// <summary>
        /// Получить список черновиков.
        /// </summary>
        /// <returns>Возвращает таблицу с черновиками заявок.</returns>
        public static DataTable GetDrafts()
        {
            return Functions.ExecuteSql("SELECT application_id, customer_id, name, created_at as 'date' FROM application_list WHERE status_id = 3");
        }

        /// <summary>
        /// Получить список заявок из истории.
        /// </summary>
        /// <returns>Возвращает таблицу с заявками из истории.</returns>
        public static DataTable GetHistory()
        {
            return Functions.ExecuteSql("SELECT application_id, customer_id, name, created_at as 'date' FROM application_list WHERE status_id = 4");
        }

        /// <summary>
        /// Клиенты указанные в заявке.
        /// </summary>
        public class Users
        {
            /// <summary>
            /// Добавить клиента в текущую заявку.
            /// </summary>
            /// <param name="userId">Уникальный номер (Id) клиента.</param>
            /// <param name="from">Дата от.</param>
            /// <param name="to">Дата до.</param>
            /// <param name="locationId">Уникальный номер (Id) локации.</param>
            /// <param name="sum">Сумма начисления.</param>
            /// <returns>Возвращает результат добавления.</returns>
            public static bool Add(long userId, DateTime from, DateTime to, long locationId, float sum)
            {
                long eventId = Functions.SqlInsert($"INSERT INTO event(start_at, end_at, ev_type) VALUES({Functions.ToUnixTime(from)}, {Functions.ToUnixTime(to)}, {10})");
                if (eventId >= 0)
                {
                    long id = Functions.SqlInsert($"INSERT INTO applications_user(user_id, application_id, event_id, location_id, application_sum)" +
                    $" VALUES({userId}, {Applications.Id}, {eventId}, {locationId}, {sum})");
                    if (id >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// Получить список людей из заявки.
            /// </summary>
            /// <returns>Возвращает таблицу с пользователями из заявки.</returns>
            public static DataTable Get()
            {
                return Functions.ExecuteSql($"SELECT user_id, fio, tab_number, start_at, end_at, location_id FROM application_user_list WHERE application_id = {Id}");
            }
        }
    }
}
