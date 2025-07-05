using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class LogCheckoutControllerClient
    {
        private readonly HttpClient _httpClient;

        public LogCheckoutControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagedResult<LogCheckoutViewModel>> Listar(DateTime ini, DateTime fim, string? filtro, int pageindex, int pagesize)
        {
            var url = $"api/logcheckout/listar/{ini:yyyy-MM-dd}/{fim:yyyy-MM-dd}/{pageindex}/{pagesize}";

            var response = await _httpClient.GetAsync(url + "?filtro=" + filtro);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var pagedResult = JsonSerializer.Deserialize<PagedResult<LogCheckoutViewModel>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return pagedResult;
        }

        public async Task<LogCheckoutViewModel> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/logcheckout/{id}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<LogCheckoutViewModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> Adicionar(LogCheckoutViewModel model)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/logcheckout", content);
        }

        public async Task<HttpResponseMessage> Excluir(int id)
        {
            return await _httpClient.DeleteAsync($"api/logcheckout/{id}");
        }

        public class PagedResult<T>
        {
            public int TotalCount { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public List<T> Data { get; set; }
        }
    }
}