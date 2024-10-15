using HomeLandCost._01.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLandCost._03.Model
{
    public class CostWorkerModel:Base
    {
        public string Employeer { get; set; }
        public string Price { get; set; }
        public int DeletedId { get; set; } = 0;
        public DateTime AddTime { get; set; } = DateTime.Now;
    }
}
