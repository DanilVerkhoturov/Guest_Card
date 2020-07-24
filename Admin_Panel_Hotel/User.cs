namespace Admin_Panel_Hotel
{
    /// <summary>
    /// Текущий пользователь.
    /// </summary>
    class User
    {
        private long id;
        private string name;
        private string role;

        /// <summary>
        /// Получить уникальный номер пользователя.
        /// </summary>
        public long GetId()
        {
            return id;
        }
        /// <summary>
        /// Получить ФИО пользователя.
        /// </summary>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Получить роль пользователя.
        /// </summary>
        /// <returns></returns>
        public string GetRole()
        {
            return role;
        }
    }
}
