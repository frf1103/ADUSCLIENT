using ADUSClient.Banco;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class BancoControllerClient
    {
        private readonly HttpClient _httpClient;

        public BancoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BancoViewModel>> ListarBanco(string? filtro)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"api/banco/?filtro={filtro}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<BancoViewModel>>(json) ?? new List<BancoViewModel>();
        }

        public async Task<BancoViewModel?> ListarBancoById(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"api/banco/{id}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BancoViewModel>(json);
        }

        public async Task<HttpResponseMessage> AdicionarBanco(BancoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/banco", content);
        }

        public async Task<HttpResponseMessage> EditarBanco(int id, BancoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PutAsync($"api/banco/{id}", content);
        }

        public async Task<HttpResponseMessage> ExcluirBanco(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return await _httpClient.DeleteAsync($"api/banco/{id}");
        }
    }
}