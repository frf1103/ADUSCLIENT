using FarmPlannerClient.CustosIndiretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerClient.Controller
{
    public class CustoIndiretoControllerClient
    {
        private readonly HttpClient _httpClient;

        public CustoIndiretoControllerClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GrupoContaViewModel>> ListaGrupo(int idclasse, int idorganizacao, string idconta, string? filtro)
        {
            GrupoContaViewModel reg = new GrupoContaViewModel();
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/grupoconta/listar/" + idclasse.ToString() + "/" + idorganizacao.ToString() + "/" + idconta + "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<GrupoContaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<GrupoContaViewModel> ListaGrupoById(int id, string idconta)
        {
            GrupoContaViewModel reg = new GrupoContaViewModel();

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/grupoconta/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<GrupoContaViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> SalvarGrupo(int id, string idconta, GrupoContaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/grupoconta/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirGrupo(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/grupoconta/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarGrupo(GrupoContaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/grupoconta", content);
            return response;
        }

        // contas

        public async Task<List<CadastroContaViewModel>> ListaConta(int idgrupo, int idorganizacao, string idconta, string? filtro)
        {
            //  _httpClient.BaseAddress = new Uri("http://localhost:5001");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string x = "api/cadastroconta/listar/" + idorganizacao.ToString() + "/0/" + idgrupo.ToString() + "/" + idconta + "?filtro=" + filtro;
            var response = await _httpClient.GetAsync(x);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<List<CadastroContaViewModel>>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<CadastroContaViewModel> ListaContaById(int id, string idconta)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.GetAsync("api/cadastroconta/" + id.ToString() + "/" + idconta);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var c = System.Text.Json.JsonSerializer.Deserialize<CadastroContaViewModel>(jsonResponse);
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> SalvarConta(int id, string idconta, CadastroContaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/cadastroconta/" + id.ToString() + "/" + idconta, content);
            return response;
        }

        public async Task<HttpResponseMessage> ExcluirConta(int id, string idconta, string uid)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //var json = System.Text.Json.JsonSerializer.Serialize(dados);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.DeleteAsync("api/cadastroconta/" + id.ToString() + "/" + idconta + "/" + uid);
            return response;
        }

        public async Task<HttpResponseMessage> AdicionarConta(CadastroContaViewModel dados)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var json = System.Text.Json.JsonSerializer.Serialize(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/cadastroconta", content);
            return response;
        }
    }
}