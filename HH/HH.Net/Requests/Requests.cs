using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.Add("User-agent", "PostmanRuntime/7.29.0");

            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                Debug.WriteLine(text);
                throw new Exception("400");
            }
            else
            {
                return text;
            }
        }
    }
}
