using ADUSClient.Parcela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.Controller
{
    public class ParcelaControllerClient
    {
        private readonly HttpClient _httpClient;

        public ParcelaControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListParcelaViewModel>> ListarParcela(DateTime ini, DateTime fim, int tipodata, int status = 0, string idparceiro = "0", int forma = 3, string idassinatura = "0", string? filtro = "")
        {
            ListParcelaViewModel reg = new ListParcelaViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/Parcela/listar/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd") + "/" + status.ToString() + "/" + idparceiro.ToString() + "/" + forma.ToString() + "/" + tipodata.ToString() + "/" + idassinatura + "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListParcelaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<ParcelaViewModel> ListaById(string id)
        {
            ParcelaViewModel reg = new ParcelaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Parcela/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<ParcelaViewModel>(jsonResponse);
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

        public async Task<ParcelaViewModel> ListaByIdCheckout(string id)
        {
            ParcelaViewModel reg = new ParcelaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Parcela/checkout/" + id.ToString());
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse != "")
            {
                var c = System.Text.Json.JsonSerializer.Deserialize<ParcelaViewModel>(jsonResponse);
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

        public async Task<HttpResponseMessage> Salvar(string id, ParcelaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/Parcela/" + id.ToString(), content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(string id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/Parcela/" + id.ToString());
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(ParcelaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Parcela", content);
            return response;
        }
    }
}