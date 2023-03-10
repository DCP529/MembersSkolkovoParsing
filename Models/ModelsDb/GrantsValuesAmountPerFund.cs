using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelsDb
{
    [Table("grants_values_amount_per_fund")]
    public class GrantsValuesAmountPerFund
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("fund_name")]
        public Name? fund_name { get; set; }
        [Column("amount")]
        public string? amount { get; set; }
    }
}
