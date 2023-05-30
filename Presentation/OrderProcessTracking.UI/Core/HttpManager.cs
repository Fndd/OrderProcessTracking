using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OrderProcessTracking.UI.Core
{
    public static class HttpManager
    {

        private static HttpClient _client = new HttpClient();
        public static async Task<T> GetAs<T>(string path)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.AddJsonFile("appsettings.json");
            string rootPath = configurationManager.GetSection("API_URL").Value;//.GetConnectionString("API_URL");
            var response = await _client.GetStringAsync(rootPath + path);
            return JsonConvert.DeserializeObject<T>(response);
        }

        public static async Task<string> Post(string path, object content)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.AddJsonFile("appsettings.json");
            string rootPath = configurationManager.GetConnectionString("API_URL");
            StringContent postContent = new StringContent(JsonConvert.SerializeObject(content));
            var response = await _client.PostAsync(rootPath + path, postContent);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
    }
}
