using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Locations
    {
        /// <summary>
        /// Уникальный номер.
        /// </summary>
        public static long Id { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public static string Name { get; set; }

        /// <summary>
        /// Добавить локацию.
        /// </summary>
        /// <param name="name">Название локации.</param>
        /// <returns>Возвращает уникальный номер (Id) добавленной локации. -1 - если возникла непредвиденная ошибка.</returns>
        public static long Add(string name)
        {
            Id = Functions.SqlInsert($"INSERT INTO location(name) VALUES(\"{name}\")");
            return Id >= 0 ? Id : -1;
        }

        /// <summary>
        /// Получить список всех локаций заказчика.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми локациями заказчика.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql($"SELECT location_id, location_name FROM customer_locations_list WHERE customer_id = {Customer.Id}");
        }

        /// <summary>
        /// Заполнить основную информацию о локации и гостинице.
        /// </summary>
        public static void GetInfo()
        {
            MySqlCommand select = new MySqlCommand($"SELECT count_rooms, beds_count, cards_count FROM hotel WHERE id = {Hotels.Id}", Functions.Connection);
            select.CommandTimeout = 999999;

            select.ExecuteNonQuery();

            MySqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                Hotels.RoomCount = Convert.ToInt32(reader[0].ToString());
                Hotels.BedsCount = Convert.ToInt32(reader[1].ToString());
                Hotels.CardsCount = Convert.ToInt32(reader[2].ToString());
                break;
            }
            reader.Close();
        }
    }

    public class Hotels
    {
        /// <summary>
        /// Уникальный номер гостиницы.
        /// </summary>
        public static long Id { get; set; }
        /// <summary>
        /// Количество комнат в гостинице.
        /// </summary>
        public static int RoomCount { get; set; }
        /// <summary>
        /// Количество мест в гостинице.
        /// </summary>
        public static int BedsCount { get; set; }
        /// <summary>
        /// Количество карт для гостиницы.
        /// </summary>
        public static int CardsCount { get; set; }

        /// <summary>
        /// Добавить гостиницу заказчика.
        /// </summary>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <param name="customerId">Уникальный номер (Id) заказчика.</param>
        /// <param name="roomCount">Количество комнат в гостинице.</param>
        /// <param name="bedsCount">Количество спальных мест в гостинице.</param>
        /// <param name="cardsCount">Количество карт в гостинице.</param>
        /// <returns>Возвращает уникальный номер (Id) добавленной гостиницы. -1 - если возникла непредвиденная ошибка.</returns>
        public static long Add(long locationId, long customerId, int roomCount, int bedsCount, int cardsCount)
        {
            // Добавление гостиницы в БД.
            Id = Functions.SqlInsert($"INSERT INTO hotel(count_rooms, beds_count, cards_count, location_id) VALUES({roomCount}, {bedsCount}, {cardsCount}, {locationId})");
            if (Id >= 0)
            {
                // Связывание созданной гостиницы с заказчиком.
                Functions.SqlInsert($"INSERT INTO customer_location(customer_id, hotel_id) VALUES({customerId}, {Id})");
                return Id;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Добавить комнату в БД.
        /// </summary>
        /// <param name="hotelId">Уникальный номер (Id) гостиницы.</param>
        /// <param name="name">Номер комнаты.</param>
        /// <param name="bedsCount">Количество спальных мест в комнате.</param>
        /// <returns>Возвращает уникальный номер (Id) добавленной комнаты.</returns>
        public static long AddRoom(long hotelId, string name, string bedsCount)
        {
            long type = 1; // "Стандарт".
            long statusId = 3; // "Свободно".
            long roomId = Functions.SqlInsert($"INSERT INTO room(name, count_beds, hotel_id, room_type, status_id) VALUES(\"{name}\", {bedsCount}, {hotelId}, {type}, {statusId})");
            return roomId >= 0 ? roomId : 0;
        }

        /// <summary>
        /// Изменить информацию о комнате.
        /// </summary>
        /// <param name="roomId">Уникальный номер (Id) комнаты.</param>
        /// <param name="name">Номер комнаты.</param>
        /// <param name="bedsCount">Количество спальных мест в комнате.</param>
        /// <returns>Возвращает уникальный номер (Id) изменённой комнаты.</returns>
        public static long EditRoom(long roomId, string name, string bedsCount)
        {
            return Functions.SqlUpdate($"UPDATE room SET name = \"{name}\", count_beds = {bedsCount} WHERE id = {roomId}");
        }

        /// <summary>
        /// Получить список всех гостиниц заказчика.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми гостиницами заказчика.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql($"SELECT hotel_id, location_name FROM customer_locations_list WHERE customer_id = {Customer.Id}");
        }

        /// <summary>
        /// Получить список комнат гостиницы.
        /// </summary>
        /// <returns>Возвращает список всех комнат гостиницы.</returns>
        public static DataTable GetRooms()
        {
            return Functions.ExecuteSql($"SELECT id as room_id, name as room_name, count_beds as beds_count FROM room WHERE hotel_id = {Id}");
        }

        /// <summary>
        /// Получить количество занятых спальных мест в комнате.
        /// </summary>
        /// <param name="roomId">Уникальный номер (Id) комнаты.</param>
        /// <returns>Возвращает количество занятых спальных мест в комнате.</returns>
        public static int GetOccupiedBedsCount(long roomId)
        {
            int occupiedBedsCount = 0;

            MySqlCommand select = new MySqlCommand($"SELECT COUNT(*) FROM room_user WHERE room_id = {roomId}", Functions.Connection);
            select.CommandTimeout = 999999;

            select.ExecuteNonQuery();

            MySqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                occupiedBedsCount = Convert.ToInt32(reader[0].ToString());
                break;
            }
            reader.Close();

            return occupiedBedsCount;
        }

        /// <summary>
        /// Найти комнату.
        /// </summary>
        /// <param name="name">Номер комнаты.</param>
        /// <param name="hotelId">Уникальный номер гостиницы.</param>
        /// <param name="roomId">Уникальный номер комнаты. -1 - если комната не найдена. -2 - если возникла непредвиденная ошибка.</param>
        /// <returns>Возвращает результат поиска.</returns>
        public static bool FindRoom(string name, long hotelId, out long roomId)
        {
            try
            {
                roomId = -1;

                MySqlCommand select = new MySqlCommand($"SELECT id FROM room WHERE hotel_id = {hotelId} AND name = \"{name}\"", Functions.Connection);
                select.CommandTimeout = 999999;

                select.ExecuteNonQuery();

                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    roomId = Convert.ToInt64(reader[0].ToString());
                    break;
                }
                reader.Close();

                if (roomId < 0) // Если комната не найдена.
                {
                    return false;
                }
                else // Если комната найдена.
                {
                    return true;
                }
            }
            catch (Exception)
            {
                roomId = -2;
                return false;
            }
        }
    }
}
