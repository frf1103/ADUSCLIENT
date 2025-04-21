using ADUSClient.Transacao;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class TransacaoControllerClient
    {
        private readonly HttpClient _httpClient;

        public TransacaoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TransacaoViewModel>> Listar(string? filtro)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync("api/Transacao/listar?filtro=" + filtro);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<TransacaoViewModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
        }

        public async Task<TransacaoViewModel> ListaById(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"api/Transacao/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TransacaoViewModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }

        public async Task<HttpResponseMessage> Adicionar(TransacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/transacao", content);
        }

        public async Task<HttpResponseMessage> Editar(int id, TransacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PutAsync($"api/Transacao/{id}", content);
        }

        public async Task<HttpResponseMessage> Excluir(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            return await _httpClient.DeleteAsync($"api/Transacao/{id}");
        }
    }
}