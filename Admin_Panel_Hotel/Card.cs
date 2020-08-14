using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Card
    {
        /// <summary>
        /// Добавить карту в БД.
        /// </summary>
        /// <param name="serialNum">Серийный номер карты.</param>
        /// <param name="shortName">Короткий номер карты написанный на карте.</param>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <param name="statusId">Уникальный номер (Id) статуса.</param>
        /// <param name="cardId">Уникальный номер (Id) созданной карты. -1 - если возникла ошибка.</param>
        /// <returns>Возвращает результат добавления.</returns>
        public static bool Add(string serialNum, string shortName, long locationId, long statusId, out long cardId)
        {
            long currentUnixTime = Functions.ToUnixTime(DateTime.Now);
            cardId = Functions.SqlInsert($"INSERT INTO card(serial_num, short_name, who_create, location_id, status_id, created_at, updated_at)" +
                                       $" VALUES(\"{serialNum}\", \"{shortName}\", {User.Id}, {locationId}, {statusId}, {currentUnixTime}, {currentUnixTime})");
            return cardId >= 0;
        }

        /// <summary>
        /// Обновить статус карты.
        /// </summary>
        /// <param name="cardId">Уникальный номер (Id) карты.</param>
        /// <param name="statusId">Уникальный номер (Id) статуса.</param>
        /// <returns>Возвращает результат обновления.</returns>
        public static bool UpdateStatus(long cardId, long statusId)
        {
            return Functions.SqlUpdate($"UPDATE card SET status_id = {statusId} WHERE id = {cardId}") >= 0;
        }

        /// <summary>
        /// Обновить местоположение карты.
        /// </summary>
        /// <param name="cardId">Уникальный номер (Id) карты.</param>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <returns>Возвращает результат обновления.</returns>
        public static bool UpdateLocation(long cardId, long locationId)
        {
            return Functions.SqlUpdate($"UPDATE card SET location_id = {locationId} WHERE id = {cardId}") >= 0;
        }

        /// <summary>
        /// Получить список всех карт.
        /// </summary>
        /// <returns>Возвращает список всех карт.</returns>
        public static DataTable GetAll()
        {
            // TODO: Сделать проверку роли.
            if (true)
            {
                return Functions.ExecuteSql("SELECT card_id, serial_num, short_name, status_id, place_name FROM card_list");
            }
        }

        /// <summary>
        /// Получить список всех карт в локации.
        /// </summary>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <returns>Возвращает список всех карт в локации.</returns>
        public static DataTable GetAll(long locationId)
        {
            // TODO: Сделать проверку роли.
            if (true)
            {
                return Functions.ExecuteSql($"SELECT card_id, serial_num, short_name, status_id, place_name FROM card_list WHERE location_id = {locationId}");
            }
        }

        /// <summary>
        /// Получить список всех карт.
        /// </summary>
        /// <returns>Возвращает список всех карт.</returns>
        public static DataTable GetAllWithLocation()
        {
            // TODO: Сделать проверку роли.
            if (true)
            {
                return Functions.ExecuteSql("SELECT id as card_id, serial_num, short_name, status_id, location_id FROM card");
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
        /// Найти карту по серийному номеру и короткому номеру.
        /// </summary>
        /// <param name="serialNum">Серийный номер.</param>
        /// <param name="shortName">Короткий номер.</param>
        /// <param name="cardId">Уникальный номер (Id) карты. -1 - если возникла ошибка.</param>
        /// <returns>Возвращает результат поиска.</returns>
        public static bool Find(string serialNum, string shortName, out long cardId)
        {
            return Functions.GetId($"SELECT id FROM card WHERE serial_num = \"{serialNum}\" AND short_name = \"{shortName}\"", out cardId);
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
