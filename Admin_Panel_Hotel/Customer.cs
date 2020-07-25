using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel_Hotel
{
    class Customer
    {
        private long id;
        private string name;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
