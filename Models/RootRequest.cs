using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersSkolkovoParsing
{
    public class RootRequest
    {
        public string key { get; set; }
        public string sort { get; set; }
        public int page { get; set; }
        public filters filters { get; set; }
        public int limit { get; set; }
    }
}
