using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("Project")]

    public class Project
    {
        [Column("id")]
        public int? id { get; set; }
        [Column("name")]
        public Name? name { get; set; }
    }
}
