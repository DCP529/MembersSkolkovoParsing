using AngleSharp.Html.Parser;
using AutoMapper;
using MembersSkolkovoParsing;
using Models;
using Models.ModelsDb;
using Models.ModelsDTO;
using Newtonsoft.Json;
using System.Text;

var baseUrl = "https://navigator.sk.ru/?q=N4IgZiBcoC4IYHMDOB9GBPADgUyiA9gE4gC%2BANCEngLQC22tARtoSkgJYB2AxrhZlACsJIA";
var urlMembers = "https://navigator.sk.ru/navigator/api/search/only_companies/";

RootResponse resultContent = new();
List<CompanyDTO> companies = new();
Random rnd = new();

var configuration = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<CompanyDTO, Company>().ReverseMap()
    .ForMember(x => x.id, f => rnd.Next())
    .ForMember(x => x.status_del_date, x => x = null)
    .ForMember(x => x.stage, x => x = null)
    .ForMember(x => x.business_model, x => x = null)
    .ForMember(x => x.investment_size, x => x = null)
    .ForMember(x => x.staff_number, x => x = null)
    .ForMember(x => x.staff_number_val, x => x = null)
    .ForMember(x => x.interests, x => x = null)
    .ForMember(x => x.international_revenue, x => x = null)
    .ForMember(x => x.investment_round, x => x = null)
    .ForMember(x => x.approved_patents_count, x => x = null)
    .ForMember(x => x.grants_values_amount_per_fund, x => x = null)
    .ForMember(x => x.similar_companies, x => x = null)
    .ForMember(x => x.cities_of_presence, x => x = null)
    .ForMember(x => x.know_how_counts, x => x = null)
    .ForMember(x => x.tags, x => x = null)
    .ForMember(x => x.rank, x => x = null)
    .ForMember(x => x.investment_funds, f => f = null);

    cfg.CreateMap<Company, CompanyDTO>()
    .ForMember(x => x.id, f => Guid.NewGuid());
});

var mapper = new Mapper(configuration);

double count = 0;

using (var client = new HttpClient())
{
    HtmlParser _htmlDocument = new();

    var document = await client.GetAsync(baseUrl);

    string resultReadContent = await document.Content.ReadAsStringAsync();
    var resultDocument = _htmlDocument.ParseDocument(resultReadContent);

    var menuItems = resultDocument.QuerySelectorAll("div.number-of-companies-text");
    count = Convert.ToDouble(menuItems[0].TextContent.Replace("Всего ", "").Replace("компаний", ""));

    var root = new RootRequest();

    root.key = "707c4beebeed60264ba0684c01dd334a";
    root.sort = "-member_since";
    root.page = 1;
    root.filters = new filters() { tags_type = "or" };
    root.limit = 48;

    string? json;
    StringContent? data;

    for (int i = 1; i <= Math.Ceiling(count / root.limit); i++)
    {
        root.page = i;

        json = JsonConvert.SerializeObject(root);
        data = new StringContent(json, Encoding.Default, "application/json");

        var result = await client.PostAsync(urlMembers, data);
        resultContent = JsonConvert.DeserializeObject<RootResponse>(await result.Content.ReadAsStringAsync()) ?? new RootResponse();

        companies.AddRange(resultContent.companies);

        Console.WriteLine(i);
    }
}

companies.ForEach(x =>
{
    x.id = rnd.Next();
    x.investment_funds?.ForEach(x => x.id = rnd.Next());
    x.tech_parks?.ForEach(x => x.id = rnd.Next());
    x.key_indicators?.ForEach(x => x.id = rnd.Next());
    x.okveds?.ForEach(x => x.id = rnd.Next());
    x.projects?.ForEach(x => x.id = rnd.Next());
});

var dbContext = new EngineeringAndPrototypingCentersDbContext();

dbContext.Companies.AddRange(mapper.Map<List<Company>>(companies));
dbContext.SaveChanges();

Console.ReadLine();

