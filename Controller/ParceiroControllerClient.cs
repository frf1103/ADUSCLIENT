using ADUSClient.Parceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class ParceiroControllerClient
    {
        private readonly HttpClient _httpClient;

        public ParceiroControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListParceiroViewModel>> Lista(string? filtro)
        {
            ListParceiroViewModel reg = new ListParceiroViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Parceiro?filtro=" + filtro);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListParceiroViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<ParceiroViewModel> ListaById(string id)
        {
            ParceiroViewModel reg = new ParceiroViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Parceiro/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<ParceiroViewModel>(jsonResponse);
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

        public async Task<HttpResponseMessage> Salvar(string id, ParceiroViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/Parceiro/" + id.ToString(), content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(string id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/Parceiro/" + id.ToString());
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(ParceiroViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Parceiro", content);
            return response;
        }

        public async Task<ViaCep> BuscarEnderecoAsync(string cep)
        {
            var _httpClient = new HttpClient();
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            var response = await _httpClient.GetFromJsonAsync<ViaCep>(url);
            return response;
        }
    }
}