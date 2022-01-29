using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task2.Entites
{
    internal class Worker
    {
        public int WorkerID { get; set; }
        public string Position { get; set; }
        public int CompanyID { get; set; }
        public virtual Company? Company { get; set; }
        public virtual WorkerInfo? WorkerInfo { get; set; }
    }
}
