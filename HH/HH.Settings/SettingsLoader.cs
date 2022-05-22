using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Settings
{
    public static class SettingsLoader<T> where T : class, new()
    {
        public static T? Load(string? path=null)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path ?? BasicSettings.DefaultFileName));
        }
    }
}
