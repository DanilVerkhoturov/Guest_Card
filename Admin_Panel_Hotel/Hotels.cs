﻿using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
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
        public static long AddRoom(long hotelId, string name, int bedsCount)
        {
            long type = 1; // "Стандарт".
            long statusId = 3; // "Свободно".
            long roomId = Functions.SqlInsert($"INSERT INTO room(name, count_beds, hotel_id, room_type, status_id) VALUES(\"{name}\", {bedsCount}, {hotelId}, {type}, {statusId})");
            return roomId >= 0 ? roomId : 0;
        }

        /// <summary>
        /// Обновить информацию о гостинице.
        /// </summary>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <param name="hotelId">Уникальный номер (Id) гостиницы.</param>
        /// <param name="name">Имя.</param>
        /// <param name="roomCount">Количество комнат.</param>
        /// <param name="bedsCount">Количество спальных мест.</param>
        /// <param name="cardsCount">Количество карт.</param>
        /// <returns>Возвращает результат обновления данных.</returns>
        public static bool Update(long locationId, long hotelId, string name, int roomCount, int bedsCount, int cardsCount)
        {
            return Functions.SqlUpdate($"UPDATE location SET name = \"{name}\" WHERE id = {locationId}") >= 0
                ? Functions.SqlUpdate($"UPDATE hotel SET count_rooms = {roomCount}, beds_count = {bedsCount}, cards_count = {cardsCount} WHERE id = {hotelId}") >= 0
                : false;
        }

        /// <summary>
        /// Изменить информацию о комнате.
        /// </summary>
        /// <param name="roomId">Уникальный номер (Id) комнаты.</param>
        /// <param name="name">Номер комнаты.</param>
        /// <param name="bedsCount">Количество спальных мест в комнате.</param>
        /// <returns>Возвращает уникальный номер (Id) изменённой комнаты.</returns>
        public static bool EditRoom(long roomId, string name, long bedsCount)
        {
            return Functions.SqlUpdate($"UPDATE room SET name = \"{name}\", count_beds = {bedsCount} WHERE id = {roomId}") >= 0;
        }

        /// <summary>
        /// Изменить статус комнаты.
        /// </summary>
        /// <param name="roomId">Уникальный номер (Id) комнаты.</param>
        /// <param name="statusId">Уникальный номер (Id) статуса.</param>
        /// <returns>Возвращает результат изменения.</returns>
        public static bool EditRoomStatus(long roomId, long statusId)
        {
            return Functions.SqlUpdate($"UPDATE room SET status_id = {statusId} WHERE id = {roomId}") >= 0;
        }

        /// <summary>
        /// Заполнить основную информацию о гостинице.
        /// </summary>
        public static void FillInfo()
        {
            MySqlCommand select = new MySqlCommand($"SELECT count_rooms, beds_count, cards_count, location_id FROM hotel WHERE id = {Id}", Functions.Connection);
            select.CommandTimeout = 999999;

            select.ExecuteNonQuery();

            MySqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                RoomCount = Convert.ToInt32(reader[0]);
                BedsCount = Convert.ToInt32(reader[1]);
                CardsCount = Convert.ToInt32(reader[2]);
                Locations.Id = Convert.ToInt32(reader[3]);
                break;
            }
            reader.Close();
        }

        /// <summary>
        /// Получить список всех гостиниц заказчика.
        /// </summary>
        /// <param name="customerId">Уникальный номер (Id) заказчика.</param>
        /// <returns>Возвращает таблицу со всеми гостиницами заказчика.</returns>
        public static DataTable GetAll(long customerId)
        {
            return Functions.ExecuteSql($"SELECT hotel_id, location_name FROM customer_locations_list WHERE customer_id = {customerId}");
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
        /// Получить список комнат гостиницы.
        /// </summary>
        /// <param name="locationId">Уникальный номер (Id) локации.</param>
        /// <returns>Возвращает список всех комнат гостиницы.</returns>
        public static DataTable GetRooms(long locationId)
        {
            return Functions.ExecuteSql($"SELECT room_id, type_id, status_id, room_name, description FROM room_list WHERE location_id = {locationId}");
        }

        /// <summary>
        /// Получить список типов комнат гостиницы.
        /// </summary>
        /// <returns>Возвращает список всех типов комнат гостиницы.</returns>
        public static DataTable GetRoomTypes()
        {
            return Functions.ExecuteSql("SELECT id as type_id, name as type_name FROM room_type");
        }

        /// <summary>
        /// Получить список статусов комнат гостиницы.
        /// </summary>
        /// <returns>Возвращает список всех статусов комнат гостиницы.</returns>
        public static DataTable GetRoomStatuses()
        {
            return Functions.ExecuteSql("SELECT id as status_id, name as status_name FROM room_status");
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
            return Functions.GetId($"SELECT id FROM room WHERE hotel_id = {hotelId} AND name = \"{name}\"", out roomId);
        }
    }
}
