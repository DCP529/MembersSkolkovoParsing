using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("Description")]

    public class Description
    {
        [Column("id")]
        public int id { get; set; }
        [Column("ru")]
        public string? ru { get; set; }
        [Column("en")]
        public string? en { get; set; }
    }
}
