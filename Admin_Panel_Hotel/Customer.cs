using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel_Hotel
{
    class Customer
    {
        public static long Id { get; set; }
        public static string Name { get; set; }

        public static DataTable GetAllDivisions()
        {
            return Functions.ExecuteSql("SELECT * FROM division WHERE parent_id is null");
        }
    }
}
