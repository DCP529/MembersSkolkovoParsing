using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("Okved")]

    public class Okved
    {
        [Column("id")]
        public int id { get; set; }
        [Column("unidata_id")]
        public string? unidata_id { get; set; }
        [Column("is_main")]
        public bool? is_main { get; set; }
        [Column("type")]
        public string? type { get; set; }
        [Column("code")]
        public string? code { get; set; }
        [Column("name")]
        public string? name { get; set; }
    }
}
