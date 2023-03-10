using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDTO
{
    public class TechParkDTO
    {
        public int id { get; set; }
        public object started_at { get; set; }
        public object ended_at { get; set; }
        public string entity_status { get; set; }
    }
}
