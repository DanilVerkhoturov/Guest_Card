namespace Admin_Panel_Hotel
{
    public class Guest
    {
        /// <summary>
        /// Уникальный номер гостя.
        /// </summary>
        public static long Id { get; set; }
        /// <summary>
        /// ФИО гостя.
        /// </summary>
        public static string Name { get; set; }

        /// <summary>
        /// Карта гостя.
        /// </summary>
        public class Card
        {
            /// <summary>
            /// Уникальный номер карты.
            /// </summary>
            public static long Id { get; set; }
            /// <summary>
            /// Серийный номер карты.
            /// </summary>
            public static string SerialNum { get; set; }
            /// <summary>
            /// Короткий номер карты (написан на карте).
            /// </summary>
            public static string ShortName { get; set; }
        }
    }
}
