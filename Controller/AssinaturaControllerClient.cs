using ADUSClient.Assinatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class AssinaturaControllerClient
    {
        private readonly HttpClient _httpClient;

        public AssinaturaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListAssinaturaViewModel>> Lista(DateTime ini, DateTime fim, string idparceiro, string status, int forma, string? filtro)
        {
            ListAssinaturaViewModel reg = new ListAssinaturaViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Assinatura/listar/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd") + "/" + status.ToString() + "/" + idparceiro.ToString() + "/" + forma.ToString() + "?filtro=" + filtro);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListAssinaturaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<AssinaturaViewModel> ListaById(string id)
        {
            AssinaturaViewModel reg = new AssinaturaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Assinatura/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<AssinaturaViewModel>(jsonResponse);
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

        public async Task<HttpResponseMessage> Salvar(string id, AssinaturaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/Assinatura/" + id.ToString(), content);
            return response;
        }

        public async Task<AssinaturaViewModel> Cancelar(string id,string motivo)
        {
            AssinaturaViewModel reg = new AssinaturaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Assinatura/cancelar/" + id.ToString()+"?motivo="+motivo);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<AssinaturaViewModel>(jsonResponse);
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

        public async Task<HttpResponseMessage> Excluir(string id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/Assinatura/" + id.ToString());
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(AssinaturaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Assinatura", content);
            return response;
        }
    }
}