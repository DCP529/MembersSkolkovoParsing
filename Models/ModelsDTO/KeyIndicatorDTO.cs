using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDTO
{
    public class KeyIndicatorDTO
    {
        public string code { get; set; }
        public string value { get; set; }
        public int year { get; set; }
        public bool is_validated { get; set; }
    }
}
