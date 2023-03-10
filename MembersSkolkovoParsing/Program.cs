using MembersSkolkovoParsing;
using System;
using System.Net;
using System.Text;

var baseUrl = "https://navigator.sk.ru/?q=N4IgZiBcoC4IYHMDOB9GBPADgUyiA9gE4gC%2BANCEngLQC22tARtoSkgJYB2AxrhZlACsJIA";
var urlMembers = "https://navigator.sk.ru/navigator/api/search/only_companies/";

using (var client = new HttpClient())
{
    var root = new Root();

    root.key = "707c4beebeed60264ba0684c01dd334a";
    root.sort = "-member_since";
    root.page = 1;
    root.filters = new Filters() { tags_type = "or" };
    root.limit = 48;

    string? json = null;

    StringContent? data = null;

    for (int i = 0; i < length; i++)
    {
        root.page = 1;

        json = Newtonsoft.Json.JsonConvert.SerializeObject(root);
        data = new StringContent(json, Encoding.UTF8, "application/json");

        var result = await client.PostAsync(urlMembers, data);
        string resultContent = await result.Content.ReadAsStringAsync();
    }
}

Console.ReadLine();