using AngleSharp.Html.Parser;
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

var dbContext = new EngineeringAndPrototypingCentersDbContext();
var list = new List<Company>();

companies.ForEach(x =>
{
    if (dbContext.Companies.Any(z => z.id == x.id))
    {
        list.Add(new Company()
        {
            id = x.id,
            name = x.name,
            full_name = x.full_name,
            foundation_year = x.foundation_year,
            founders = x.founders,
            description = x.description,
            short_description = x.short_description,
            revenue = x.revenue,
            average_number_of_employees = x.average_number_of_employees,
            company_type = x.company_type,
            okveds = x.okveds,
            projects = x.projects
        });
    }
});

dbContext.Companies.AddRange(list);
dbContext.SaveChanges();