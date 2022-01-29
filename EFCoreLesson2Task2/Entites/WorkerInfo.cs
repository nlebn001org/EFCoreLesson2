using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task2.Entites
{
    internal class WorkerInfo
    {
        public int WorkerInfoID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int WorkerID { get; set; }
        public virtual Worker? Worker { get; set; }
    }
}
