using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models.ModelsDb
{
    [Table("Company")]
    public class Company
    {
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public Name? name { get; set; }
        [Column("full_name")]
        public FullName? full_name { get; set; }
        [Column("description")]
        public Description? description { get; set; }
        [Column("short_description")]
        public ShortDescription? short_description { get; set; }
        [Column("foundation_year")]
        public int? foundation_year { get; set; }
        [Column("revenue")]
        public long? revenue { get; set; }
        [Column("average_number_of_employees")]
        public double? average_number_of_employees { get; set; }
        
        [Column("company_type")]
        public string? company_type { get; set; }
        
        [Column("founders")]
        public List<string>? founders { get; set; }
       
        [Column("okveds")]
        public List<Okved>? okveds { get; set; }
        
        [Column("projects")]
        public List<Project>? projects { get; set; }         
    }

}
