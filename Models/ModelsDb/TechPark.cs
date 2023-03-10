using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("TechPark")]

    public class TechPark
    {
        [Column("id")]
        public int? id { get; set; }
        [Column("started_at")]
        public string? started_at { get; set; }
        [Column("ended_at")]
        public string? ended_at { get; set; }
        [Column("entity_status")]
        public string? entity_status { get; set; }
    }
}
