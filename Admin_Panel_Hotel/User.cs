using System.Data;

namespace Admin_Panel_Hotel
{
    /// <summary>
    /// Текущий пользователь.
    /// </summary>
    class User
    {
        private static long id;
        private static string name;
        private static string role;

        /// <summary>
        /// Получить уникальный номер пользователя.
        /// </summary>
        public static long GetId()
        {
            return id;
        }
        /// <summary>
        /// Получить ФИО пользователя.
        /// </summary>
        public static string GetName()
        {
            return name;
        }
        /// <summary>
        /// Получить роль пользователя.
        /// </summary>
        /// <returns></returns>
        public static string GetRole()
        {
            return role;
        }

        //public static DataTable GetAll()
        //{
        //    return Functions.ExecuteSql("SELECT ");
        //}
    }
}
