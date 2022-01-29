using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task1.Entities
{
    internal class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string PassNo { get; set; }
        public virtual UserInfo? UserInfo { get; set; }

    }
}
