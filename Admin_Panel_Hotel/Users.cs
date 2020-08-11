using System.Data;

namespace Admin_Panel_Hotel
{
    class Users
    {
        /// <summary>
        /// Получить список всех пользователей из организации.
        /// </summary>
        /// <param name="divisionId">Уникальный номер (Id) организации.</param>
        /// <returns>Возвращает список пользователей.</returns>
        public static DataTable GetAll(long divisionId)
        {
            return Functions.ExecuteSql($"SELECT user_id, fio FROM user_list WHERE division_id = {divisionId}");
        }
    }
}
