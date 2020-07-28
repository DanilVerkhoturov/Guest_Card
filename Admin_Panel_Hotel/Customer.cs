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

        public static DataTable GetAll()
        {
            return Functions.ExecuteSql("SELECT customer_id as id, name FROM customer_list");
        }

        public static long Add(string divisionName, string contractNumber, DateTime fromContractTime, DateTime toContractTime)
        {
            // Добавление организации в бд.
            long divisionId = Functions.SqlInsert($"INSERT INTO division(name) VALUES('{divisionName}')");
            long eventId = Functions.SqlInsert($"INSERT INTO event(start_at, end_at, ev_type) VALUES ({Functions.ToUnixTime(fromContractTime)}, {Functions.ToUnixTime(toContractTime)}, 9)");
            Id = Functions.SqlInsert($"INSERT INTO customer_legal_info(division_id, dogovor, event_id) VALUES({divisionId}, '{contractNumber}', {eventId})");
            Name = divisionName;
            return Id;
        }

        public static long AddEmails(string name, string email)
        {
            return Functions.SqlInsert($"INSERT INTO customer_email(name, customer_id, email) VALUES('{name}', {Id}, '{email}')");
        }

        //public static long AddSubdivisions()
        //{
        //    Functions.SqlInsert($"INSERT INTO division(name) VALUES('{divisionName}')");
        //}
    }
}
