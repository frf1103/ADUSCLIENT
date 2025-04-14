using ADUSClient.Banco;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class ContaCorrenteControllerClient
    {
        private readonly HttpClient _httpClient;

        public ContaCorrenteControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ContaCorrenteViewModel>> Listar(string? filtro, int? bancoId)
        {
            var response = await _httpClient.GetAsync($"api/contacorrente/listar?filtro={filtro}&bancoId={bancoId}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ContaCorrenteViewModel>>(content);
        }

        public async Task<ContaCorrenteViewModel> GetById(string id)
        {
            var response = await _httpClient.GetAsync("api/contacorrente/" + id);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ContaCorrenteViewModel>(content);
        }

        public async Task<HttpResponseMessage> Adicionar(ContaCorrenteViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/contacorrente", content);
            return response;
        }

        public async Task<HttpResponseMessage> Salvar(string id, ContaCorrenteViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync("api/contacorrente/" + id, content);
        }

        public async Task<HttpResponseMessage> Excluir(string id)
        {
            return await _httpClient.DeleteAsync("api/contacorrente/" + id);
        }
    }
}