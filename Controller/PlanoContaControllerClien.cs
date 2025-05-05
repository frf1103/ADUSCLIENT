using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ADUSClient.PlanoConta;

namespace ADUSClient.Controller
{
    public class PlanoContaControllerClient
    {
        private readonly HttpClient _httpClient;

        public PlanoContaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PlanoContaViewModel>> ListarAsync(string? filtro)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync("api/PlanoConta?filtro=" + filtro);
            var json = await response.Content.ReadAsStringAsync();
            /*
            return JsonSerializer.Deserialize<List<PlanoContaViewModel>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });*/

            try
            {
                return JsonSerializer.Deserialize<List<PlanoContaViewModel>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de desserialização: " + ex.Message);
                Console.WriteLine("JSON retornado: " + json);
                throw;
            }
        }

        public async Task<PlanoContaViewModel> BuscarPorIdAsync(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"api/PlanoConta/{id}");
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<PlanoContaViewModel>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<HttpResponseMessage> AdicionarAsync(PlanoContaViewModel model)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/planoconta", content);
        }

        public async Task<HttpResponseMessage> AtualizarAsync(int id, PlanoContaViewModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PutAsync($"api/PlanoConta/{id}", content);
        }

        public async Task<HttpResponseMessage> RemoverAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/PlanoConta/{id}");
        }
    }
}