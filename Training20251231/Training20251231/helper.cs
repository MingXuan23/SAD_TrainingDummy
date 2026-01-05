using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Training20251231
{
    public static class helper
    {
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("http://10.0.2.2/api/") };
        // public static HttpClient client = new HttpClient() { BaseAddress = new Uri("http://ipv4address/api/") };

        public static void addBearerToken(string token)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

        }


        public static async Task<T> get<T>(string url)
        {
            try
            {
                var req = await client.GetStringAsync(url);
                return JsonSerializer.Deserialize<T>(req);
            }
            catch (Exception)
            {

                return default;
            }
        }
        public static async Task<T> post<T>(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                return JsonSerializer.Deserialize<T>(await req.Content.ReadAsStringAsync());
            }
            catch (Exception)
            {

                return default;
            }
        }
        public static async Task<int> post(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                return (int)req.StatusCode;
            }
            catch (Exception)
            {

                return default;
            }
        }
        public static async Task<int> put(string url, object data)
        {
            try
            {
                var req = await client.PutAsJsonAsync(url, data);
                return (int)req.StatusCode;
            }
            catch (Exception)
            {

                return default;
            }
        }
        public static async Task<int> delete(string url)
        {
            try
            {
                var req = await client.DeleteAsync(url);
                return (int)req.StatusCode;
            }
            catch (Exception)
            {

                return default;
            }
        }
    }
}
