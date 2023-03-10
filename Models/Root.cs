using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersSkolkovoParsing
{
    public class Root
    {
        public string Key { get; set; }
        public string Sort { get; set; }
        public int Page { get; set; }
        public Filters Filters { get; set; }
        public int Limit { get; set; }
    }
}
