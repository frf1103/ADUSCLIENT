using ADUSClient.Convite;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class ConviteControllerClient
    {
        private readonly HttpClient _httpClient;

        public ConviteControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ConviteViewModel>> Listar(string? idafiliado, string? idcoprodutor, int? status, int? expirados, string? titular = null)
        {
            var url = $"api/convite/listar/{idcoprodutor}/{idafiliado}/{status}/{expirados}/{titular ?? "null"}";
            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ConviteViewModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<ConviteViewModel> GetById(string id)
        {
            var response = await _httpClient.GetAsync("api/convite/" + id);
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ConviteViewModel>(content);
        }

        public async Task<HttpResponseMessage> Adicionar(ConviteViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/convite", content);
        }

        public async Task<HttpResponseMessage> Salvar(string id, ConviteViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync("api/convite/" + id, content);
        }

        public async Task<HttpResponseMessage> Excluir(string id)
        {
            return await _httpClient.DeleteAsync("api/convite/" + id);
        }
    }
}