namespace Admin_Panel_Hotel
{
    /// <summary>
    /// Текущий пользователь.
    /// </summary>
    class User
    {
        /// <summary>
        /// Уникальный номер.
        /// </summary>
        public static long Id { get; set; }
        /// <summary>
        /// ФИО.
        /// </summary>
        public static string Name { get; set; }
        /// <summary>
        /// Роль.
        /// </summary>
        public static string Role { get; set; }
    }
}
