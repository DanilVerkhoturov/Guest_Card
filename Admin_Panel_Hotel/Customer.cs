using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Customer
    {
        /// <summary>
        /// Уникальный номер.
        /// </summary>
        public static long Id { get; set; }
        /// <summary>
        /// Уникальный номер организации.
        /// </summary>
        public static long DivisionId { get; set; }
        /// <summary>
        /// Уникальный номер подрядной организации.
        /// </summary>
        public static long SubdivisionId { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public static string Name { get; set; }
        
        /// <summary>
        /// Получить список всех организаций.
        /// </summary>
        /// <returns>Возвращает список всех организаций.</returns>
        public static DataTable GetAllDivisions()
        {
            return Functions.ExecuteSql("SELECT * FROM division WHERE parent_id is null");
        }

        /// <summary>
        /// Получить список всех подрядных организаций заказчика.
        /// </summary>
        /// <returns>Возвращает список всех подрядных организаций заказчика.</returns>
        public static DataTable GetAllSubdivisions()
        {
            return Functions.ExecuteSql($"SELECT division_id as subdivision_id, division_name as subdivision_name WHERE parent_id = {DivisionId}");
        }

        /// <summary>
        /// Получить список всех заказчиков.
        /// </summary>
        /// <returns>Возвращает таблицу со списком всех заказчиков.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql("SELECT customer_id as id, name FROM customer_list");
        }

        /// <summary>
        /// Добавить заказчика в БД.
        /// </summary>
        /// <param name="divisionName">Название заказчика.</param>
        /// <param name="contractNumber">Номер договора.</param>
        /// <param name="fromContractTime">Начало срока действия договора.</param>
        /// <param name="toContractTime">Конец срока действия договора.</param>
        /// <returns>Возвращает уникальный номер (Id) добавленного заказчика.</returns>
        public static long Add(string divisionName, string contractNumber, DateTime fromContractTime, DateTime toContractTime)
        {
            // Добавление организации в БД. 
            DivisionId = Functions.SqlInsert($"INSERT INTO division(name) VALUES('{divisionName.Trim()}')");
            // Добавление сроков договора заказчика.
            long eventId = Functions.SqlInsert($"INSERT INTO event(start_at, end_at, ev_type) VALUES ({Functions.ToUnixTime(fromContractTime)}, {Functions.ToUnixTime(toContractTime)}, 9)");
            // Добавление информации о заказчике в БД.
            Id = Functions.SqlInsert($"INSERT INTO customer_legal_info(division_id, dogovor, event_id) VALUES({DivisionId}, '{contractNumber.Trim()}', {eventId})");
            Name = divisionName;
            return Id;
        }

        /// <summary>
        /// Добавить подрядную организацию заказчика.
        /// </summary>
        /// <param name="subDivisionName">Название подрядной организации.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной подрядной организации.</returns>
        public static long AddSubDivision(string subDivisionName)
        {
            SubdivisionId = Functions.SqlInsert($"INSERT INTO division(parent_id, name) VALUES({Id}, '{subDivisionName.Trim()}')");
            return SubdivisionId;
        }

        /// <summary>
        /// Добавить электронную почту заказчика.
        /// </summary>
        /// <param name="name">Имя электронной почты.</param>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной электронной почты.</returns>
        public static long AddEmail(string name, string email)
        {
            return Functions.SqlInsert($"INSERT INTO division_email(division_id, name, email) VALUES({Id}, '{name.Trim()}', '{email.Trim()}')");
        }

        /// <summary>
        /// Редактировать существующую электронную почту заказчика.
        /// </summary>
        /// <param name="emailId">Уникальный номер электронной почты.</param>
        /// <param name="emailName">Имя электронной почты.</param>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает уникальный номер (Id) обновлённой электронной почты.</returns>
        public static long EditEmail(long emailId, string emailName, string email)
        {
            return Functions.SqlUpdate($"UPDATE division_email SET name = '{emailName}', email = '{email}' WHERE id = {emailId}");
        }

        /// <summary>
        /// Добавить электронную почту подрядной организации заказчика.
        /// </summary>
        /// <param name="subDivisionId">Уникальный номер подрядной организации заказчика.</param>
        /// <param name="name">Имя электронной почты.</param>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной электронной почты.</returns>
        public static long AddEmail(long subDivisionId, string name, string email)
        {
            return Functions.SqlInsert($"INSERT INTO division_email(division_id, name, email) VALUES({subDivisionId}, '{name.Trim()}', '{email.Trim()}')");
        }

        /// <summary>
        /// Найти подрядную организацию по названию.
        /// </summary>
        /// <param name="name">Название подрядной организации.</param>
        /// <param name="subDivisionId">Уникальный номер (Id) найденной подрядной организации. -1 - если подрядная организация не найдена. -2 - если возникла непредвиденная ошибка.</param>
        /// <returns>Возвращает результат поиска подрядной организации.</returns>
        public static bool FindSubDivision(string name, out long subDivisionId)
        {
            try
            {
                subDivisionId = -1;

                MySqlCommand select = new MySqlCommand($"SELECT id FROM division WHERE name = '{name.Trim()}' AND parent_id is not null", Functions.Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    subDivisionId = Convert.ToInt64(reader[0].ToString());
                }

                if (subDivisionId == -1) // Если подрядная организация не найдена.
                {
                    return false;
                }
                else // Если подрядная организация найдена.
                {
                    return true;
                }
            }
            catch (Exception)
            {
                subDivisionId = -2;
                return false;
            }
        }

        /// <summary>
        /// Найти заказчика по названию.
        /// </summary>
        /// <param name="name">Название заказчика.</param>
        /// <param name="divisionId">Уникальный номер (Id) найденного заказчика. -1 - если заказчик не найден. -2 - если возникла непредвиденная ошибка.</param>
        /// <returns>Возвращает результат поиска.</returns>
        public static bool FindDivision(string name, out long divisionId)
        {
            try
            {
                divisionId = -1;

                MySqlCommand select = new MySqlCommand($"SELECT id FROM division WHERE name = '{name.Trim()}' AND parent_id is null", Functions.Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    divisionId = Convert.ToInt64(reader[0].ToString());
                }
                reader.Close();

                if (divisionId == -1) // Если заказчик не найден.
                {
                    return false;
                }
                else // Если заказчик найден.
                {
                    return true;
                }
            }
            catch (Exception)
            {
                divisionId = -2;
                return false;
            }
        }

        /// <summary>
        /// Найти электронную почту заказчика.
        /// </summary>
        /// <param name="email">Электронная почта.</param>
        /// <param name="emailId">Уникальный номер (Id) электронной почты. -1 - если эл.почта не найдена. -2 - если возникла непредвиденная ошибка.</param>
        /// <returns>Возвращает результат поиска.</returns>
        public static bool FindEmail(string email, out long emailId)
        {
            try
            {
                emailId = -1;

                MySqlCommand select = new MySqlCommand($"SELECT id FROM division_email WHERE division_id = {DivisionId} AND email = '{email}'", Functions.Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    emailId = Convert.ToInt64(reader[0].ToString());
                    break;
                }
                reader.Close();

                if (emailId == -1) // Если эл.почта не найдена.
                {
                    return false;
                }
                else // Если эл.почта найдена.
                {
                    return true;
                }
            }
            catch (Exception)
            {
                emailId = -2;
                return false;
            }
        }
    }
}
