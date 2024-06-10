using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Whatsapp.Http.Service
{
    public class BaseService<T> where T : class
    {
        protected readonly HttpClient _httpClient;

        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<T> GetFromJsonAsync(string endpoint)
        {
            return await _httpClient.GetFromJsonAsync<T>(endpoint);
        }

        public async Task<HttpResponseMessage> PostAsJsonAsync<TContent>(string endpoint, TContent content)
        {
            return await _httpClient.PostAsJsonAsync(endpoint, content);
        }

        public async Task<HttpResponseMessage> PutAsJsonAsync<TContent>(string endpoint, TContent content)
        {
            return await _httpClient.PutAsJsonAsync(endpoint, content);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            return await _httpClient.DeleteAsync(endpoint);
        }
    }
}
