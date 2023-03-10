using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ModelsDb;
using Models.ModelsDTO;

namespace Models
{
    public class RootResponse
    {
        public string key { get; set; }
        public List<CompanyDTO> companies { get; set; }
        public int page { get; set; }
        public int total_pages { get; set; }
        public int total_companies { get; set; }
        public List<string> sort { get; set; }
    }
}
