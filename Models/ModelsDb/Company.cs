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
        public Guid id { get; set; }
        [Column("orn")]
        public int? orn { get; set; }
        [Column("inn")]
        public string? inn { get; set; }
        [Column("kpp")]
        public string? kpp { get; set; }
        [Column("ogrn")]
        public string? ogrn { get; set; }
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
        [Column("status")]
        public string? status { get; set; }
        [Column("status_add_date")]
        public DateTime? status_add_date { get; set; }
        [Column("status_del_date")]
        public string? status_del_date { get; set; }
        [Column("sk_member")]
        public bool? sk_member { get; set; }
        [Column("sk_tp_member")]
        public bool? sk_tp_member { get; set; }
        [Column("sk_tech_member")]
        public bool? sk_tech_member { get; set; }
        [Column("can_sign_nda")]
        public bool? can_sign_nda { get; set; }
        [Column("is_validated")]
        public bool? is_validated { get; set; }
        [Column("need_investment")]
        public bool? need_investment { get; set; }
        [Column("need_services")]
        public bool? need_services { get; set; }
        [Column("stage")]
        public string? stage { get; set; }
        [Column("business_model")]
        public string? business_model { get; set; }
        [Column("investment_size")]
        public string? investment_size { get; set; }
        [Column("staff_number")]
        public string? staff_number { get; set; }
        [Column("staff_number_val")]
        public string? staff_number_val { get; set; }
        [Column("interests")]
        public string? interests { get; set; }
        [Column("external_financing_value")]
        public double? external_financing_value { get; set; }
        [Column("international_revenue")]
        public string? international_revenue { get; set; }
        [Column("revenue")]
        public long? revenue { get; set; }
        [Column("average_number_of_employees")]
        public double? average_number_of_employees { get; set; }
        [Column("investment_round")]
        public string? investment_round { get; set; }
        [Column("approved_patents_count")]
        public string? approved_patents_count { get; set; }
        [Column("has_plan")]
        public bool? has_plan { get; set; }
        [Column("key_indicators")]
        public List<KeyIndicator>? key_indicators { get; set; }
        [Column("cluster")]
        public int? cluster { get; set; }
        [Column("company_type")]
        public string? company_type { get; set; }
        [Column("logo")]
        public string? logo { get; set; }
        [Column("authorized_capital")]
        public double? authorized_capital { get; set; }
        [Column("organisation_status")]
        public string? organisation_status { get; set; }
        [Column("founders")]
        public List<string>? founders { get; set; }
        [Column("investment_funds")]
        public List<InvestmentFund>? investment_funds { get; set; }
        [Column("tech_parks")]
        public List<TechPark>? tech_parks { get; set; }
        [Column("grants_values_amount_per_fund")]
        public List<GrantsValuesAmountPerFund>? grants_values_amount_per_fund { get; set; }
        [Column("has_large_contracts")]
        public bool? has_large_contracts { get; set; }
        [Column("international_markets")]
        public bool? international_markets { get; set; }
        [Column("msp_type")]
        public string? msp_type { get; set; }
        [Column("similar_companies")]
        public List<string>? similar_companies { get; set; }
        [Column("is_fast_growing")]
        public bool? is_fast_growing { get; set; }
        [Column("cities_of_presence")]
        public List<Name>? cities_of_presence { get; set; }
        [Column("okveds")]
        public List<Okved>? okveds { get; set; }
        [Column("accredited_it")]
        public bool? accredited_it { get; set; }
        [Column("domestic_software")]
        public bool? domestic_software { get; set; }
        [Column("know_how_counts")]
        public string? know_how_counts { get; set; }
        [Column("has_knowhow")]
        public bool? has_knowhow { get; set; }
        [Column("has_ip")]
        public bool? has_ip { get; set; }
        [Column("tags")]
        public List<string>? tags { get; set; }
        [Column("projects")]
        public List<Project>? projects { get; set; }
        [Column("rank")]
        public string? rank { get; set; }
        [Column("company_has_patents")]
        public bool? company_has_patents { get; set; }
        [Column("company_has_competition_win")]
        public bool? company_has_competition_win { get; set; }
    }

}
