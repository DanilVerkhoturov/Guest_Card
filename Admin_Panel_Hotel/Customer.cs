using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    internal class Customer
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
            return Functions.ExecuteSql($"SELECT id as subdivision_id, name as subdivision_name FROM division WHERE parent_id = {DivisionId}");
        }

        /// <summary>
        /// Получить список всех организаций и подрядных организаций.
        /// </summary>
        /// <returns>Возвращает список всех организаций и подрядных организаций.</returns>
        public static DataTable GetAllDivisionsAndSubdivisions()
        {
            return Functions.ExecuteSql("SELECT * FROM division");
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
        /// Получить уникальный номер (Id) организации подрядной организации.
        /// </summary>
        /// <param name="subdivisionId">Уникальный номер подрядной организации.</param>
        /// <param name="divisionId">Уникальный номер (Id) организации. -1 - если возникла ошибка.</param>
        /// <returns>Возвращает результат получения уникального номера.</returns>
        public static bool GetDivisionId(long subdivisionId, string subdivisionName, out long divisionId)
        {
            try
            {
                if (IsSubDivision(subdivisionId, subdivisionName))
                {
                    MySqlCommand select = new MySqlCommand($"SELECT parent_id FROM division WHERE id = {subdivisionId}", Functions.Connection);
                    object result = select.ExecuteScalar();
                    if (result != null && !string.IsNullOrEmpty(result.ToString()))
                    {
                        return long.TryParse(result.ToString(), out divisionId);
                    }
                    else
                    {
                        divisionId = -1;
                        return false;
                    }
                }
                else if (IsDivision(subdivisionId, subdivisionName))
                {
                    divisionId = subdivisionId;
                    return true;
                }
                else
                {
                    divisionId = -1;
                    return false;
                }
            }
            catch (Exception e)
            {
                divisionId = -1;
                return false;
            }
        }

        /// <summary>
        /// Получить уникальный номер (Id) организации заказчика.
        /// </summary>
        /// <param name="customerId">Уникальный номер заказчика.</param>
        /// <param name="divisionId">Уникальный номер (Id) организации. -1 - если возникла ошибка.</param>
        /// <returns>Возвращает результат получения уникального номера.</returns>
        public static bool GetDivisionIdFromCustomerId(long customerId, out long divisionId)
        {
            try
            {
                MySqlCommand select = new MySqlCommand($"SELECT division_id FROM customer_legal_info WHERE id = {customerId}", Functions.Connection);
                object result = select.ExecuteScalar();
                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    return long.TryParse(result.ToString(), out divisionId);
                }
                else
                {
                    divisionId = -1;
                    return false;
                }
            }
            catch (Exception e)
            {
                divisionId = -1;
                return false;
            }
        }

        /// <summary>
        /// Получить уникальный номер (Id) заказчика.
        /// </summary>
        /// <param name="divisionId">Уникальный номер организации.</param>
        /// <param name="customerId">Уникальный номер (Id) заказчика. -1 - если возникла ошибка.</param>
        /// <returns>Возвращает результат получения уникального номера.</returns>
        public static bool GetCustomerId(long divisionId, out long customerId)
        {
            try
            {
                MySqlCommand select = new MySqlCommand($"SELECT id FROM customer_legal_info WHERE division_id = {divisionId}", Functions.Connection);
                object result = select.ExecuteScalar();
                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    return long.TryParse(result.ToString(), out customerId);
                }
                else
                {
                    customerId = -1;
                    return false;
                }
            }
            catch (Exception e)
            {
                customerId = -1;
                return false;
            }
        }

        /// <summary>
        /// Добавить заказчика в БД.
        /// </summary>
        /// <param name="divisionName">Название заказчика.</param>
        /// <param name="contractNumber">Номер договора.</param>
        /// <param name="fromContractTime">Начало срока действия договора.</param>
        /// <param name="toContractTime">Конец срока действия договора.</param>
        /// <returns>Возвращает уникальный номер (Id) добавленного заказчика. -1 - если возникла непредвиденная ошибка.</returns>
        public static long Add(string divisionName, string contractNumber, DateTime fromContractTime, DateTime toContractTime)
        {
            // Добавление организации в БД. 
            DivisionId = Functions.SqlInsert($"INSERT INTO division(name) VALUES('{divisionName.Trim()}')");
            if (DivisionId >= 0)
            {
                // Добавление сроков договора заказчика.
                long eventId = Functions.SqlInsert($"INSERT INTO event(start_at, end_at, ev_type) VALUES ({Functions.ToUnixTime(fromContractTime)}, {Functions.ToUnixTime(toContractTime)}, 9)");
                // Добавление информации о заказчике в БД.
                Id = Functions.SqlInsert($"INSERT INTO customer_legal_info(division_id, dogovor, event_id) VALUES({DivisionId}, '{contractNumber.Trim()}', {eventId})");
                Name = divisionName;
                return Id;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Добавить подрядную организацию заказчика.
        /// </summary>
        /// <param name="subDivisionName">Название подрядной организации.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной подрядной организации. -1 - если возникла непредвиденная ошибка.</returns>
        public static long AddSubDivision(string subDivisionName)
        {
            SubDivision.Id = Functions.SqlInsert($"INSERT INTO division(parent_id, name) VALUES({DivisionId}, '{subDivisionName.Trim()}')");
            return SubDivision.Id >= 0 ? SubDivision.Id : -1;
        }

        /// <summary>
        /// Добавить электронную почту заказчика.
        /// </summary>
        /// <param name="name">Имя электронной почты.</param>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной электронной почты. -1 - если возникла непредвиденная ошибка.</returns>
        public static long AddEmail(string name, string email)
        {
            long emailId = Functions.SqlInsert($"INSERT INTO division_email(division_id, name, email) VALUES({DivisionId}, '{name.Trim()}', '{email.Trim()}')");
            return emailId >= 0 ? emailId : -1;
        }

        /// <summary>
        /// Добавить электронную почту подрядной организации заказчика.
        /// </summary>
        /// <param name="subDivisionId">Уникальный номер подрядной организации заказчика.</param>
        /// <param name="name">Имя электронной почты.</param>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает уникальный номер (Id) созданной электронной почты. -1 - если возникла непредвиденная ошибка.</returns>
        public static long AddEmail(long subDivisionId, string name, string email)
        {
            long emailId = Functions.SqlInsert($"INSERT INTO division_email(division_id, name, email) VALUES({subDivisionId}, '{name.Trim()}', '{email.Trim()}')");
            return emailId >= 0 ? emailId : -1;
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

                MySqlCommand select = new MySqlCommand($"SELECT id FROM division WHERE name = '{name.Trim()}' AND parent_id = {DivisionId}", Functions.Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    subDivisionId = Convert.ToInt64(reader[0].ToString());
                }
                reader.Close();

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

        /// <summary>
        /// Проверить является ли заказчиком отправленный уникальный номер (Id).
        /// </summary>
        /// <param name="id">Уникальный номер.</param>
        /// <returns>Возвращает результат проверки.</returns>
        public static bool IsCustomer(long id, long divisionId)
        {
            try
            {
                MySqlCommand select = new MySqlCommand($"SELECT id FROM customer_legal_info WHERE id = {id} AND division_id = {divisionId}", Functions.Connection);
                object result = select.ExecuteScalar();
                return result != null && long.TryParse(result.ToString(), out long customerId);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Проверить является ли подразделением отправленный уникальный номер (Id).
        /// </summary>
        /// <param name="id">Уникальный номер.</param>
        /// <returns>Возвращает результат проверки.</returns>
        public static bool IsSubDivision(long id, string name)
        {
            try
            {
                MySqlCommand select = new MySqlCommand($"SELECT id FROM division WHERE id = {id} AND name = \"{name}\" AND parent_id is not null", Functions.Connection);
                object result = select.ExecuteScalar();
                return result != null && long.TryParse(result.ToString(), out long divisionId);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Проверить является ли организацией отправленный уникальный номер (Id).
        /// </summary>
        /// <param name="id">Уникальный номер.</param>
        /// <returns>Возвращает результат проверки.</returns>
        public static bool IsDivision(long id, string name)
        {
            try
            {
                MySqlCommand select = new MySqlCommand($"SELECT id FROM division WHERE id = {id} AND name = \"{name}\" AND parent_id is null", Functions.Connection);
                object result = select.ExecuteScalar();
                return result != null && long.TryParse(result.ToString(), out long customerId);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Локация заказчика.
        /// </summary>
        public class Location
        {
            /// <summary>
            /// Уникальный номер.
            /// </summary>
            public static long Id { get; set; }
            /// <summary>
            /// Название.
            /// </summary>
            public static string Name { get; set; }
        }

        /// <summary>
        /// Подрядная организация заказчика.
        /// </summary>
        public class SubDivision
        {
            /// <summary>
            /// Уникальный номер.
            /// </summary>
            public static long Id { get; set; }
            /// <summary>
            /// Название.
            /// </summary>
            public static string Name { get; set; }
            /// <summary>
            /// Название электронной почты.
            /// </summary>
            public static string EmailName { get; set; }
            /// <summary>
            /// Электронная почта.
            /// </summary>
            public static string Email { get; set; }

            /// <summary>
            /// Заполнить основную информацию о подрядной организации заказчика.
            /// </summary>
            public static void FillInfo()
            {
                try
                {
                    MySqlCommand select = new MySqlCommand($"SELECT subdivision_name, email_name, email FROM subdivision_email_list WHERE subdivision_id = {Id}", Functions.Connection);
                    select.CommandTimeout = 999999;

                    select.ExecuteNonQuery();

                    MySqlDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        Name = reader[0].ToString();
                        EmailName = reader[1].ToString();
                        Email = reader[2].ToString();
                        break;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    FillInfo();
                }
            }
        }
    }
}
