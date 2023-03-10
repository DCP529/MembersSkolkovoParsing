using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersSkolkovoParsing
{
    public class Root
    {
        public string key { get; set; }
        public string sort { get; set; }
        public int page { get; set; }
        public Filters filters { get; set; }
        public int limit { get; set; }
    }
}
