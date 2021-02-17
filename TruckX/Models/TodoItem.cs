using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckX.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string surname { get; set; }


        public string type { get; set; }
        public string imei { get; set; }
        public string alarmType { get; set; }
        public DateTime alarmTime { get; set; }
        public double latitude { get; set; }
        public string fileList { get; set; }
        public DateTime locationTime { get; set; }
        public string fileName { get; set; }
        public string data { get; set; }

    }
}
