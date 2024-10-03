using FarmPlannerClient.Comercializacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Controller
{
    public class ComercializacaoControllerClient
    {
        private readonly HttpClient _httpClient;

        public ComercializacaoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListComercializacaoViewModel>> Lista(int idorganizacao, int idano, int idfazenda, int idsafra, string idconta, int idparceiro, int idmoeda, DateTime ini, DateTime fim, string? filtro)
        {
            //{idconta}/{idorganizacao}/{idano}/{idfazenda}/{idsafra}/{idparceiro}/{idmoeda}/{ini}/{fim}
            ComercializacaoViewModel reg = new ComercializacaoViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/Comercializacao/listar/" + idconta + "/" + idorganizacao.ToString() + "/" + idano.ToString() + "/" + idfazenda.ToString() + "/" + idsafra.ToString() + "/" + idparceiro.ToString() + "/" + idmoeda.ToString() + "/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd") +
                "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListComercializacaoViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<ComercializacaoViewModel> ListaById(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/Comercializacao/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<ComercializacaoViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(int id, string idconta, ComercializacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/Comercializacao/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/Comercializacao/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(ComercializacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Comercializacao", content);
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarEntrega(EntregaContratoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/entregacontrato", content);
            return response;
        }

        public async Task<List<ItemEntregaContratoViewModel>> ListaItensEntrega(int idpedido, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/comercializacao/entregas/" + idpedido.ToString() + "/" + idconta + "/0");
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ItemEntregaContratoViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<EntregaContratoViewModel>> ListaEntregaByComercializacao(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/entregacontrato/ListaByCom/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<EntregaContratoViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> ExcluirEntregaById(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/entregacontrato/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }
    }
}