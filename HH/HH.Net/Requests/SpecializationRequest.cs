using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Net.Models;
using HH.Net.Models.SpecializationModel;
using Newtonsoft.Json;

namespace HH.Net.Requests
{
    public class SpecializationRequest
    {
        private readonly List<SpecializationItem> _specializations;

        public SpecializationRequest()
        {
            _specializations = new List<SpecializationItem>();
        }

        public async Task<List<SpecializationItem>> Send()
        {
            _specializations.Clear();

            var response = await Requests.SendGet("http://api.hh.ru/specializations");
            var specializations = JsonConvert.DeserializeObject<List<SpecializationResponse>>(response);

            foreach (var specialization in specializations!)
            {
                _specializations.Add(new SpecializationItem
                {
                    Id = specialization.Id,
                    Name = specialization.Name
                });

                _specializations.AddRange(specialization.Specializations);
            }

            return _specializations;
        }
    }
}
