using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MauiHybridFetchSave.Models;

namespace MauiHybridFetchSave.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _http;

        public ApiService(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<List<Post>> FetchPostsAsync()
        {
            var resp = await _http.GetAsync("https://jsonplaceholder.typicode.com/posts");
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var posts = JsonSerializer.Deserialize<List<Post>>(json, options);
            return posts ?? new List<Post>();
        }
    }
}
