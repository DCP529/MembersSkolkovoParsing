using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("KeyIndicator")]

    public class KeyIndicator
    {
        [Column("id")]
        public int id { get; set; }
        [Column("code")]
        public string? code { get; set; }
        [Column("value")]
        public string? value { get; set; }
        [Column("year")]
        public int? year { get; set; }
        [Column("is_validated")]
        public bool? is_validated { get; set; }
    }
}
