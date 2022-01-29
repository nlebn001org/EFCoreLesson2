using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task1.Entities
{
    internal class UserInfo
    {
        public int UserInfoID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int UserID { get; set; } 
        public virtual User? User { get; set; }

    }
}
