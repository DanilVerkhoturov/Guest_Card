using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Admin_Panel_Hotel
{
    class Locations
    {
        public static long Id { get; set; }
        public static string Name { get; set; }
        public static int RoomsCount { get; set; }
        public static int BedsCount { get; set; }
        public static int CardsCount { get; set; }

        /// <summary>
        /// Получить список всех локаций.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми локациями.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql($"SELECT location_id, location_name FROM customer_locations_list WHERE customer_id = {Customer.Id}");
        }

        public static DataTable GetRooms()
        {
            return Functions.ExecuteSql($"SELECT id, name, count_beds FROM room WHERE hotel_id = {Id}");
        }

        public static void GetInfo()
        {
            MySqlCommand select = new MySqlCommand($"SELECT count_rooms, beds_count, cards_count FROM hotel WHERE id = {Id}", Functions.Connection);
            select.CommandTimeout = 999999;

            select.ExecuteNonQuery();

            MySqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                RoomsCount = Convert.ToInt32(reader[0].ToString());
                BedsCount = Convert.ToInt32(reader[1].ToString());
                CardsCount = Convert.ToInt32(reader[2].ToString());
                break;
            }
            reader.Close();
        }
    }
}
