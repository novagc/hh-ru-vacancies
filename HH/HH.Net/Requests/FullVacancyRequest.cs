using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Net.Models;
using Newtonsoft.Json;

namespace HH.Net.Requests
{
    public class FullVacancyRequest
    {
        public async Task<FullVacancyResponse> Send(int id)
        {
            var response = await Requests.SendGet($"http://api.hh.ru/vacancies/{id}");
            return JsonConvert.DeserializeObject<FullVacancyResponse>(response) ?? new FullVacancyResponse();
        }
    }
}
