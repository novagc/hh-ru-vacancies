using System.Text;
using HH.Net.Models;
using HH.Net.Models.VacancyModel;
using HH.Tools;
using Newtonsoft.Json;

namespace HH.Net.Requests
{
    public class VacancyRequest
    {
        public string? Name { get; }
        public int MinSalary { get; }
        public int MaxSalary { get; }

        private string _url;

        private List<VacancyItem> _vacancies;

        public VacancyRequest(string? name=null, int? minSalary=null, int? maxSalary=null)
        {
            _vacancies = new List<VacancyItem>();

            Name = name;
            MinSalary = minSalary ?? Int32.MinValue;
            MaxSalary = maxSalary ?? Int32.MaxValue;

            var temp = new StringBuilder();
            temp.Append("http://api.hh.ru/vacancies?order_by=salary_asc&only_with_salary=true&per_page=100");

            if (name != null)
            {
                temp.Append($"&text={Name}");
            }

            if (minSalary != null)
            {
                temp.Append($"&salary={MinSalary}");
            }

            temp.Append("&page=");

            _url = temp.ToString();
        }

        public async Task<List<VacancyItem>> Send()
        {
            _vacancies.Clear();

            var res = await LoadPage(0);
            var pages = res.Pages;
            var less = AddVacancies(res);

            for (int i = 1; less && i < pages; i++)
            {
                res = await LoadPage(i);
                less = AddVacancies(res);
            }

            return _vacancies;
        }

        private async Task<VacancyResponse> LoadPage(int page)
        {
            var url = _url + page;
            var response = await Requests.SendGet(url);
            return JsonConvert.DeserializeObject<VacancyResponse>(response) ?? new VacancyResponse();
        }

        private bool AddVacancies(VacancyResponse vr)
        {
            var toAdd = vr.Items
                .Where(x => x.Salary!.Currency == "RUR" && x.Salary.From.InRangeOrNull(MinSalary, MaxSalary));
            
            _vacancies.AddRange(toAdd);

            return vr.Items.Any(x => x.Salary!.From?.InRange(MinSalary, MaxSalary) ?? x.Salary!.To!.Value.InRange(MinSalary, MaxSalary));
        } }
}
