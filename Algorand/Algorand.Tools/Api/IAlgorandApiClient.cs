using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorand.Tools.Api
{
    public interface IAlgorandApiClient
    {
        Task<T> GetAsync<T>(string requestUri);
        Task<T> PostAsync<T>(string requestUri, string json);
        void SetApiKey(string headerName, string headerValue);
    }

    public class AlgorandApiClient : IAlgorandApiClient, IDisposable
    {
        private readonly HttpClient _client;
        private readonly Uri _hostAddress;

        public AlgorandApiClient(string hostAddress)
        {
            _hostAddress = new Uri(hostAddress);
            _client = new HttpClient() { BaseAddress = _hostAddress };
        }

        public void SetApiKey(string headerName, string headerValue)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.TryAddWithoutValidation(headerName, headerValue);
        }

        public async Task<T> GetAsync<T>(string requestUri)
        {
            var uri = new Uri(_hostAddress, $"{requestUri}");

            var response = await _client.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                throw new AlgorandApiException(response.StatusCode);
            }

            var result = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(result);
        }

        public async Task<T> PostAsync<T>(string requestUri, string json)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}