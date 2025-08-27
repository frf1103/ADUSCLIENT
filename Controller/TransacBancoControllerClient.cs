using ADUSClient.Banco;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class TransacBancoControllerClient
    {
        private readonly HttpClient _httpClient;

        public TransacBancoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TransacBancoViewModel>> ListarTodos()
        {
            var response = await _httpClient.GetAsync("api/transacbanco");
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<TransacBancoViewModel>>(json) ?? new List<TransacBancoViewModel>();
        }

        public async Task<TransacBancoViewModel?> ObterPorId(string id, int bancoid)
        {
            var response = await _httpClient.GetAsync($"api/transacbanco/{id}/{bancoid.ToString()}");
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TransacBancoViewModel>(json);
        }

        public async Task<HttpResponseMessage> Adicionar(TransacBancoViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/transacbanco", content);
        }

        public async Task<HttpResponseMessage> Editar(TransacBancoViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PutAsync("api/transacbanco", content);
        }

        public async Task<HttpResponseMessage> Excluir(string idTransacBanco, int idBanco)
        {
            return await _httpClient.DeleteAsync($"api/transacbanco/{idTransacBanco}/{idBanco}");
        }
    }
}