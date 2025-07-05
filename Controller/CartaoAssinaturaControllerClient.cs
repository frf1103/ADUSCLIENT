using ADUSClient.Assinatura;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class CartaoAssinaturaControllerClient
    {
        private readonly HttpClient _httpClient;

        public CartaoAssinaturaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CartaoAssinaturaViewModel>> ListarPorAssinatura(string idAssinatura)
        {
            var response = await _httpClient.GetAsync($"api/ccassina/assinatura/{idAssinatura}");
            var content = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<List<CartaoAssinaturaViewModel>>(content, options);
        }

        public async Task<CartaoAssinaturaViewModel> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/ccassina/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CartaoAssinaturaViewModel>(content);
        }

        public async Task<CartaoAssinaturaViewModel> GetByToken(string id)
        {
            var response = await _httpClient.GetAsync($"api/ccassina/token/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CartaoAssinaturaViewModel>(content);
        }

        public async Task<HttpResponseMessage> Adicionar(CartaoAssinaturaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync("api/ccassina", content);
        }

        public async Task<HttpResponseMessage> Atualizar(int id, CartaoAssinaturaViewModel dados)
        {
            var json = JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PutAsync($"api/ccassina/{id}", content);
        }

        public async Task<HttpResponseMessage> Excluir(int id)
        {
            return await _httpClient.DeleteAsync($"api/ccassina/{id}");
        }

        public async Task<HttpResponseMessage> Ativar(int id)
        {
            return await _httpClient.PostAsync($"api/ccassina/{id}/ativar", null);
        }

        public async Task<HttpResponseMessage> Inativar(int id)
        {
            return await _httpClient.PostAsync($"api/ccassina/{id}/inativar", null);
        }
    }
}