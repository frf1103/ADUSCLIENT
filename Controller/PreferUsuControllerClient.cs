using FarmPlannerClient.PreferUsu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Controller
{
    public class PreferUsuControllerClient
    {
        private readonly HttpClient _httpClient;

        public PreferUsuControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PreferUsuViewModel> Lista(string uid)
        {
            PreferUsuViewModel reg = new PreferUsuViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/PreferUsu/?uid=" + uid);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<PreferUsuViewModel>(jsonResponse);
                if (c != null)
                {
                    return c;
                }
                else
                {
                    return null;
                }
            }
            else return null;
        }

        public async Task<HttpResponseMessage> Salvar(string id, PreferUsuViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/PreferUsu/" + id.ToString(), content);
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(PreferUsuViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PreferUsu", content);
            return response;
        }
    }
}