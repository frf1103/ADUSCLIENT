using ADUSClient.MovimentoCaixa;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ADUSClient.Controller
{
    public class MovimentoCaixaControllerClient
    {
        private readonly HttpClient _httpClient;

        public MovimentoCaixaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MovimentoCaixaViewModel>> ListarAsync(
            DateTime? ini = null,
            DateTime? fim = null,
            int? idtransacao = null,
            int? idcentrocusto = null,
            string? idparceiro = null,
            string? idcontacorrente = null,
            int? idcategoria = null,
            string? filtro = null,
            string? idmovbanco = null)
        {
            var query = new Dictionary<string, string>();

            if (ini.HasValue)
                query.Add("dataInicio", ini.Value.ToString("yyyy-MM-dd"));
            if (fim.HasValue)
                query.Add("dataFim", fim.Value.ToString("yyyy-MM-dd"));
            if (idtransacao.HasValue)
                query.Add("idtransacao", idtransacao.Value.ToString());
            if (idcentrocusto.HasValue)
                query.Add("idcentrocusto", idcentrocusto.Value.ToString());
            if (!string.IsNullOrEmpty(idparceiro))
                query.Add("idparceiro", idparceiro);
            if (!string.IsNullOrEmpty(idcontacorrente))
                query.Add("idContaCorrente", idcontacorrente);
            if (idcategoria.HasValue)
                query.Add("idcategoria", idcategoria.Value.ToString());
            if (!string.IsNullOrEmpty(filtro))
                query.Add("descricao", filtro);
            if (!string.IsNullOrEmpty(idmovbanco))
                query.Add("idmovbanco", idmovbanco);

            var queryString = string.Join("&", query.Select(kv => $"{kv.Key}={Uri.EscapeDataString(kv.Value)}"));

            var response = await _httpClient.GetAsync("api/MovimentoCaixa/listar?" + queryString);
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<MovimentoCaixaViewModel>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<MovimentoCaixaViewModel>();
        }

        public async Task<List<ExtratoConta>> Extrato(
         DateTime ini,
         DateTime fim,
         string? idcontacorrente = null)
        {
            string url = "api/MovimentoCaixa/extrato/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd") + "/" + idcontacorrente;

            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<ExtratoConta>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<ExtratoConta>();
        }

        public async Task<MovimentoCaixaViewModel?> ObterPorIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/MovimentoCaixa/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<MovimentoCaixaViewModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> AdicionarAsync(MovimentoCaixaViewModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync("api/MovimentoCaixa", content);
        }

        public async Task<HttpResponseMessage> AtualizarAsync(int id, MovimentoCaixaViewModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync($"api/MovimentoCaixa/{id}", content);
        }

        public async Task<HttpResponseMessage> RemoverAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/MovimentoCaixa/{id}");
        }
    }
}