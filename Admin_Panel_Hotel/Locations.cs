﻿using MySql.Data.MySqlClient;
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
        /// Уникальный номер гостиницы.
        /// </summary>
        public static long HotelId { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public static string Name { get; set; }
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
        /// Получить список всех локаций заказчика.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми локациями заказчика.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql($"SELECT location_id, location_name FROM customer_locations_list WHERE customer_id = {Customer.Id}");
        }

        /// <summary>
        /// Получить список всех гостиниц заказчика.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми гостиницами заказчика.</returns>
        public static DataTable GetAllHotels()
        {
            return Functions.ExecuteSql($"SELECT hotel_id, location_name FROM customer_locations_list WHERE customer_id = {Customer.Id}");
        }

        /// <summary>
        /// Получить список комнат гостиницы.
        /// </summary>
        /// <returns>Возвращает список всех комнат гостиницы.</returns>
        public static DataTable GetRooms()
        {
            return Functions.ExecuteSql($"SELECT id, name, count_beds FROM room WHERE hotel_id = {HotelId}");
        }

        /// <summary>
        /// Заполнить основную информацию о локации и гостинице.
        /// </summary>
        public static void GetInfo()
        {
            MySqlCommand select = new MySqlCommand($"SELECT count_rooms, beds_count, cards_count FROM hotel WHERE id = {HotelId}", Functions.Connection);
            select.CommandTimeout = 999999;

            select.ExecuteNonQuery();

            MySqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                RoomCount = Convert.ToInt32(reader[0].ToString());
                BedsCount = Convert.ToInt32(reader[1].ToString());
                CardsCount = Convert.ToInt32(reader[2].ToString());
                break;
            }
            reader.Close();
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

                MySqlCommand select = new MySqlCommand($"SELECT id FROM room WHERE hotel_id = {hotelId} AND name = '{name}'", Functions.Connection);
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
            return Functions.SqlInsert($"INSERT INTO room(name, count_beds, hotel_id, room_type, status_id) VALUES('{name}', {bedsCount}, {hotelId}, {type}, {statusId})");
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
            return Functions.SqlUpdate($"UPDATE room SET name = '{name}', count_beds = {bedsCount} WHERE id = {roomId}");
        }
    }
}
