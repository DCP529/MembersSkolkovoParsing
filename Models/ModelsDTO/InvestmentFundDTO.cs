using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDTO
{
    public class InvestmentFundDTO
    {
        public int id { get; set; }
        public DateTime started_at { get; set; }
        public object ended_at { get; set; }
        public object entity_status { get; set; }
    }
}
