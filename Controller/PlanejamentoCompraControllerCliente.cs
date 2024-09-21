using FarmPlannerClient.PlanejamentoCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Controller
{
    public class PlanejamentoCompraControllerClient
    {
        private readonly HttpClient _httpClient;

        public PlanejamentoCompraControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListPlanejamentoCompraViewModel>> Lista(int idorganizacao, string idconta, int idano, int idprincipio, int idfazenda, int idsafra)
        {
            //{ idconta}/{ idano},{ idorganizacao}/{ idsafra}/{ idproduto}/{ idfazenda}
            PlanejamentoCompraViewModel reg = new PlanejamentoCompraViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/PlanejamentoCompra/listar/" + idconta + "/" + idano.ToString() + "/" + idorganizacao.ToString() + "/" + idsafra.ToString() + "/" + idprincipio.ToString() + "/" + idfazenda.ToString();
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListPlanejamentoCompraViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<PlanejamentoCompraViewModel> ListaById(int id, string idconta)
        {
            PlanejamentoCompraViewModel reg = new PlanejamentoCompraViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/PlanejamentoCompra/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<PlanejamentoCompraViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(int id, string idconta, PlanejamentoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/PlanejamentoCompra/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/PlanejamentoCompra/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(PlanejamentoCompraViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PlanejamentoCompra", content);
            return response;
        }
    }
}