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

        public async Task<List<LogCheckoutViewModel>> Listar(DateTime ini, DateTime fim, string? filtro)
        {
            var response = await _httpClient.GetAsync("api/logcheckout/listar/" + ini.ToString("yyyy-MM-dd") +
                "/" + fim.ToString("yyyy-MM-dd") + "/" + filtro);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<LogCheckoutViewModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
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
    }
}