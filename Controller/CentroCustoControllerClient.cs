using ADUSClient.CentroCusto;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class CentroCustoControllerClient
    {
        private readonly HttpClient _httpClient;

        public CentroCustoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CentroCustoViewModel>> Listar(string? filtro)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"api/centrocusto?filtro={Uri.EscapeDataString(filtro ?? "")}");
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<CentroCustoViewModel>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }

        public async Task<CentroCustoViewModel?> ObterPorId(int id)
        {
            var response = await _httpClient.GetAsync($"api/centrocusto/{id}");
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<CentroCustoViewModel>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> Adicionar(CentroCustoViewModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync("api/centrocusto", content);
        }

        public async Task<HttpResponseMessage> Editar(int id, CentroCustoViewModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync($"api/centrocusto/{id}", content);
        }

        public async Task<HttpResponseMessage> Excluir(int id)
        {
            return await _httpClient.DeleteAsync($"api/centrocusto/{id}");
        }
    }
}