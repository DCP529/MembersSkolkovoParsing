using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ModelsDb;

namespace Models.ModelsDTO
{
    public class CompanyDTO
    {
        public int id { get; set; }
        public int? orn { get; set; }
        public string? inn { get; set; }
        public string? kpp { get; set; }
        public string? ogrn { get; set; }
        public Name? name { get; set; }
        public FullName? full_name { get; set; }
        public Description? description { get; set; }
        public ShortDescription? short_description { get; set; }
        public int? foundation_year { get; set; }
        public string? status { get; set; }
        public DateTime? status_add_date { get; set; }
        public object? status_del_date { get; set; }
        public bool? sk_member { get; set; }
        public bool? sk_tp_member { get; set; }
        public bool? sk_tech_member { get; set; }
        public bool? can_sign_nda { get; set; }
        public bool? is_validated { get; set; }
        public bool? need_investment { get; set; }
        public bool? need_services { get; set; }
        public object? stage { get; set; }
        public object? business_model { get; set; }
        public object? investment_size { get; set; }
        public object? staff_number { get; set; }
        public object? staff_number_val { get; set; }
        public object? interests { get; set; }
        public double? external_financing_value { get; set; }
        public object? international_revenue { get; set; }
        public long? revenue { get; set; }
        public double? average_number_of_employees { get; set; }
        public object? investment_round { get; set; }
        public object? approved_patents_count { get; set; }
        public bool? has_plan { get; set; }
        public List<KeyIndicator>? key_indicators { get; set; }
        public int? cluster { get; set; }
        public string? company_type { get; set; }
        public string? logo { get; set; }
        public double? authorized_capital { get; set; }
        public string? organisation_status { get; set; }
        public List<string>? founders { get; set; }
        public List<InvestmentFund>? investment_funds { get; set; }
        public List<TechPark>? tech_parks { get; set; }
        public List<object>? grants_values_amount_per_fund { get; set; }
        public bool? has_large_contracts { get; set; }
        public bool? international_markets { get; set; }
        public string? msp_type { get; set; }
        public List<object>? similar_companies { get; set; }
        public bool? is_fast_growing { get; set; }
        public List<object>? cities_of_presence { get; set; }
        public List<Okved>? okveds { get; set; }
        public bool? accredited_it { get; set; }
        public bool? domestic_software { get; set; }
        public object? know_how_counts { get; set; }
        public bool? has_knowhow { get; set; }
        public bool? has_ip { get; set; }
        public List<object>? tags { get; set; }
        public List<Project>? projects { get; set; }
        public object? rank { get; set; }
        public bool? company_has_patents { get; set; }
        public bool? company_has_competition_win { get; set; }
    }
}
