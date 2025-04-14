using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class ParametroGuruControllerClient
    {
        private readonly HttpClient _httpClient;

        public ParametroGuruControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ParametrosGuruViewModel> ListaById(int id)
        {
            ParametrosGuruViewModel reg = new ParametrosGuruViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/ParametroGuru/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<ParametrosGuruViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(string id, ParametrosGuruViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/ParametroGuru/" + id.ToString(), content);
            return response;
        }
    }
}