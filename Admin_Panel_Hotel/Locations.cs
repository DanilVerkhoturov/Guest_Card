using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel_Hotel
{
    class Locations
    {
        /// <summary>
        /// Получить список всех локаций.
        /// </summary>
        /// <returns>Возвращает таблицу со всеми локациями.</returns>
        public static DataTable GetAll()
        {
            return Functions.ExecuteSql("SELECT id as location_id, name as location_name FROM location");
        }
    }
}
