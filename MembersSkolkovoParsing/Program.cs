using MembersSkolkovoParsing;
using System;
using System.Net;
using System.Text;

var baseUrl = "https://navigator.sk.ru/?q=N4IgZiBcoC4IYHMDOB9GBPADgUyiA9gE4gC%2BANCEngLQC22tARtoSkgJYB2AxrhZlACsJIA";
var urlMembers = "https://navigator.sk.ru/navigator/api/search/only_companies/";

using (var client = new HttpClient())
{
    var root = new Root();

    root.Key = "707c4beebeed60264ba0684c01dd334a";
    root.Sort = "-member_since";
    root.Page = 1;
    root.Filters = new Filters() { TagsType = "or" };
    root.Limit = 48;

    string? json;
    StringContent? data;

    for (int i = 0; i < length; i++)
    {
        root.Page = 1;

        json = Newtonsoft.Json.JsonConvert.SerializeObject(root);
        data = new StringContent(json, Encoding.UTF8, "application/json");

        var result = await client.PostAsync(urlMembers, data);
        string resultContent = await result.Content.ReadAsStringAsync();
    }
}

Console.ReadLine();