using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.Net.Requests
{
    public static class Requests
    {
        public static async Task<string> SendGet(string url, Dictionary<string, object> queryParams)
        {
            return await SendGet($"{url}?{String.Join("&", queryParams.Select(x => $"{x.Key}={x.Value}"))}");
        }

        public static async Task<string> SendGet(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }
    }
}
