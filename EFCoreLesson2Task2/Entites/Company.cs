using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson2Task2.Entites
{
    internal class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public List<Worker>? Workers { get; set; } = new List<Worker>();
    }
}
