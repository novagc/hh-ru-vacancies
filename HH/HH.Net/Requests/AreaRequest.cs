using HH.Net.Models;
using HH.Net.Models.AreaModel;
using Newtonsoft.Json;

namespace HH.Net.Requests
{
    public class AreaRequest
    {
        private readonly List<AreaItem> _areas;

        public AreaRequest()
        {
            _areas = new List<AreaItem>();
        }

        public async Task<List<AreaItem>> Send()
        {
            _areas.Clear();

            var response = await Requests.SendGet("http://api.hh.ru/areas");
            var areas = JsonConvert.DeserializeObject<List<AreaResponse>>(response) ?? new List<AreaResponse>();

            foreach (var area in areas)
            {
                AddArea(area);
            }

            return _areas;
        }

        private void AddArea(AreaResponse res)
        {
            _areas.Add(new AreaItem(res));

            if (res.Areas != null)
            {
                foreach (var area in res.Areas)
                {
                    AddArea(area);
                }
            }
        }
    }
}