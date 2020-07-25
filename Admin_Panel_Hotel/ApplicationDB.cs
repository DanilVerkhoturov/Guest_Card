using MySql.Data.MySqlClient;

namespace Admin_Panel_Hotel
{
    class ApplicationDB
    {
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
                    draftApplicationsCount = (int)reader[0];
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
                    newApplicationsCount = (int)reader[0];
                }
            }
            return newApplicationsCount;
        }
    }
}
