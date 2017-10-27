using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APHHC_TiTo
{
    public class User
    {
        public User() { }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int employeeNumber { get; set; }
        public int iD { get; set; }
        public int dailyLogId { get; set; }
        public int breakId { get; set; }
    }
}
