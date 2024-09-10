using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FarmPlannerClient.PlanejOperacao;

namespace FarmPlannerClient.Controller
{
    public class PlanejOperacaoControllerClient
    {
        private readonly HttpClient _httpClient;

        public PlanejOperacaoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListPlanejamentoOperacaoViewModel>> Lista(int idorganizacao, int idano, int idfazenda, int idtalhao, int idvariedade, int idsafra, string idconta, int idoperacao, DateTime ini, DateTime fim, int idprincipio, int idproduto)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string x = "api/planejamentooperacao/listar/" + idorganizacao.ToString() + "/" + idfazenda.ToString() + "/" + idano.ToString() + "/" + idsafra.ToString() + "/" + idtalhao.ToString() + "/" + idoperacao.ToString() + "/" + idconta + "/" + idvariedade.ToString() + "/" + idprincipio.ToString() + "/" + idproduto.ToString() + "/" + ini.ToString("yyyy-MM-dd") + "/" + fim.ToString("yyyy-MM-dd");
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListPlanejamentoOperacaoViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<PlanejamentoOperacaoViewModel> ListaById(int id, string idconta)
        {
            PlanejamentoOperacaoViewModel reg = new PlanejamentoOperacaoViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/PlanejamentoOperacao/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<PlanejamentoOperacaoViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Salvar(int id, string idconta, PlanejamentoOperacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/PlanejamentoOperacao/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> Excluir(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/PlanejamentoOperacao/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> Adicionar(PlanejamentoOperacaoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PlanejamentoOperacao", content);
            return response;
        }

        public async Task<HttpResponseMessage> GravarAssistente(string idconta, string uid, List<AssistentePlanejOperViewModel> dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PlanejamentoOperacao/assistente/" + idconta + "/" + uid, content);
            return response;
            /*         if (!(response.StatusCode.ToString() == "NotFound"))
                     {
                         return response;
                     }
                     else return null; */
        }

        public async Task<List<ListProdutoPlanejadoViewModel>> ListaProdPlanej(int idplanejamento, string idconta)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string x = "api/ProdutoPlanejado/listar/" + idplanejamento.ToString() + "/" + idconta;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListProdutoPlanejadoViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProdutoPlanejadoViewModel> ListaProdPlanejById(int id, string idconta)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string x = "api/ProdutoPlanejado/" + id.ToString() + "/" + idconta;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<ProdutoPlanejadoViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> AdicionarProdutoPlanejado(ProdutoPlanejadoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/ProdutoPlanejado", content);
            return response;
        }

        public async Task<HttpResponseMessage> SalvarProdutoPlanejado(int id, string idconta, ProdutoPlanejadoViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/ProdutoPlanejado/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirProdutoPlanejado(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/ProdutoPlanejado/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<List<ListMaquinaPlanejadaViewModel>> ListaMaquinaPlanej(int idplanejamento, string idconta)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string x = "api/MaquinaPlanejada/listar/" + idplanejamento.ToString() + "/" + idconta;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<ListMaquinaPlanejadaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<MaquinaPlanejadaViewModel> ListaMaquinaPlanejById(int id, string idconta)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string x = "api/MaquinaPlanejada/" + id.ToString() + "/" + idconta;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<MaquinaPlanejadaViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> AdicionarMaquinaPlanejada(MaquinaPlanejadaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/MaquinaPlanejada", content);
            return response;
        }

        public async Task<HttpResponseMessage> SalvarMaquinaPlanejada(int id, string idconta, MaquinaPlanejadaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/MaquinaPlanejada/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirMaquinaPlanejada(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/MaquinaPlanejada/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<parametrooperacaoviewmodel> BuscaParametroOperacao(string idconta, int idmodelo, int idmaquina, int idconfigarea, int idoperacao, int idcultura)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");
            string xx = "api/planejamentooperacao/parametrooperacao/" + idconta + "/" + idmodelo.ToString() + "/" + idmaquina.ToString() + "/" + idoperacao.ToString() + "/" + idconfigarea.ToString() + "/" + idcultura.ToString();
            var response = await _httpClient.GetAsync(xx);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var c = System.Text.Json.JsonSerializer.Deserialize<parametrooperacaoviewmodel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }
    }
}