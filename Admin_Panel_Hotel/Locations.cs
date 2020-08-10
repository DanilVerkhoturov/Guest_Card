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
    }
}
