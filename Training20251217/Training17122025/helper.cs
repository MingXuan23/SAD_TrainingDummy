using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Training17122025
{
    public class helper
    {
        //localhost change to 10.0.2.2
        //localhost ->ipconfig ->get ipv4  10.131.78.21 (ip v4 address)
        public static HttpClient client =
            new HttpClient() { BaseAddress = new Uri("http://10.0.2.2:5000/api/") };

        public static async Task<T> get<T>(string url)
        {
            try
            {
                var req = await client.GetStringAsync(url);
                return JsonSerializer.Deserialize<T>(req);
            }
            catch (Exception ex)
            {
                //for list, object ->null
                //int,long -> 0
                //bool -> false
                return default;
            }
        }

        public static async Task<T> post<T>(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                return JsonSerializer.Deserialize<T>(await req.Content.ReadAsStringAsync());

                //var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
                //var req = await client.PostAsync(url, content);
            }
            catch (Exception)
            {
                //for list, object ->null
                //int,long -> 0
                //bool -> false
                return default;
            }
        }
        public static async Task<int> postres(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                return (int)req.StatusCode;
                //var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
                //var req = await client.PostAsync(url, content);
            }
            catch (Exception)
            {
                //for list, object ->null
                //int,long -> 0
                //bool -> false
                return default;
            }
        }


    }
}
